using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SubtitlesParser;
using System.IO;

namespace SubtitleEditor
{
    public struct Timestamp
    {
        public int Hours;
        public int Minutes;
        public int Seconds;
        public int Milliseconds;

        public Timestamp(int h, int m, int s, int ms)
        {
            Hours = h; Minutes = m; Seconds = s; Milliseconds = ms;
        }
        public Timestamp(decimal h, decimal m, decimal s, decimal ms)
        {
            Hours = (int)h; Minutes = (int)m; Seconds = (int)s; Milliseconds = (int)ms;
        }
    }


    public partial class MainForm : Form
    {
        public List<SubtitlesParser.Classes.SubtitleItem> List = new List<SubtitlesParser.Classes.SubtitleItem>();
        private SubtitlesParser.Classes.Parsers.SrtParser Parser = new SubtitlesParser.Classes.Parsers.SrtParser();
        private string SaveLocation = "";
        private int CurrentNode = 1;

        //Please do not look at this method
        public static string MillisecondsFormat(int x)
        {
            string hs = ""; string ms = ""; string ss = ""; string mis = "";
            int y = 60 * 60 * 1000;
            int h = x / y;
            int m = (x - (h * y)) / (y / 60);
            int s = (x - (h * y) - (m * (y / 60))) / 1000;
            int mi = x - (h * y) - (m * (y / 60)) - (s * 1000);
            if (h < 10) { hs = hs + "0"; }
            if (m < 10) { ms = ms + "0"; }
            if (s < 10) { ss = ss + "0"; }
            if (mi < 10) { mis = mis + "00"; } else if (mi < 100) { mis = mis + "0"; }
            hs = hs + h; ms = ms + m; ss = ss + s; mis = mis + mi;
            return hs + ":" + ms + ":" + ss + "," + mis;
        }

        public static Timestamp MillisecondsToTimestamp(int x)
        {
            int y = 60 * 60 * 1000;
            int h = x / y;
            int m = (x - (h * y)) / (y / 60);
            int s = (x - (h * y) - (m * (y / 60))) / 1000;
            int mi = x - (h * y) - (m * (y / 60)) - (s * 1000);
            return new Timestamp(h, m, s, mi);
        }

        public static int MillisecondsFromTimestamp(Timestamp s)
        {
            return (s.Hours * 3600000) + (s.Minutes * 60000) + (s.Seconds * 1000) + s.Milliseconds;
        }

        // Click events
        private void New_Click(object sender, EventArgs e)
        {
            SubtitlesParser.Classes.SubtitleItem node = new SubtitlesParser.Classes.SubtitleItem();
            List.Add(node);
            treeView.Nodes.Clear();
            PopulateUIFromCurrentList();
            treeView.SelectedNode = treeView.Nodes[treeView.Nodes.Count - 1];
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (treeView.Nodes.Count > 0)
            {
                int index = Int32.Parse(treeView.SelectedNode.Text) - 1;
                List.RemoveAt(index);
                treeView.Nodes.Clear();
                PopulateUIFromCurrentList();
            }
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            bool continueNew = true;
            if (List.Count > 0)
            {
                DialogResult res;// = MessageBox.Show("Save changes to " + SaveLocation + "?", "Subtitle Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (SaveLocation == "")
                {
                    res = MessageBox.Show("Save changes to current file?", "Subtitle Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }
                else
                {
                    res = MessageBox.Show("Save changes to " + SaveLocation + "?", "Subtitle Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                }

                if (res == DialogResult.Cancel)
                {
                    continueNew = false;
                }
                else if (res == DialogResult.Yes)
                {
                    if (SaveLocation == "")
                    {
                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        saveFileDialog1.Filter = "srt files (*.srt)|*.srt|All files (*.*)|*.*";
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            SaveLocation = saveFileDialog1.FileName;
                        }
                    }
                    SaveToFile(SaveLocation);
                }
            }
            if (continueNew)
            {
                ClearAllCurrent();
                treeView.Nodes.Clear();
                Parser = new SubtitlesParser.Classes.Parsers.SrtParser();
                List = new List<SubtitlesParser.Classes.SubtitleItem>();
                SaveLocation = "";
                CurrentNode = 1;
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "srt files (*.srt)|*.srt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ClearAllCurrent();
                    LoadFromFile(openFileDialog1.FileName);
                    PopulateUIFromCurrentList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file from disk.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (SaveLocation == "")
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "srt files (*.srt)|*.srt|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveLocation = saveFileDialog1.FileName;
                    SaveToFile(SaveLocation);
                }
            }
            else
            {
                SaveToFile(SaveLocation);
            }
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "srt files (*.srt)|*.srt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveLocation = saveFileDialog1.FileName;
                SaveToFile(SaveLocation);
            }
        }

        private void Offset_Click(object sender, EventArgs e)
        {
            OffsetForm f = new OffsetForm(this);
            f.Show();
        }

        private void SaveToFile(string path)
        {
            //if (File.Exists(path))
            //{
                using (StreamWriter file = new StreamWriter(path, false, Encoding.UTF8))
                {
                    int index = 1;
                    foreach (SubtitlesParser.Classes.SubtitleItem item in List)
                    {
                        string start = MillisecondsFormat(item.StartTime);
                        string end = MillisecondsFormat(item.EndTime);
                        file.WriteLine(index);
                        file.WriteLine(start + " --> " + end);
                        foreach (string s in item.Lines)
                        {
                            file.WriteLine(s);
                        }
                        file.WriteLine("");
                        index++;
                    }
                }
            //}
            //else
            //{
                //MessageBox.Show("Invalid save path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }




        // Changed events
        private void numeric_Changed(object sender, EventArgs e)
        {
            try
            {
                int index = CurrentNode - 1;
                List[index].StartTime = MillisecondsFromTimestamp(new Timestamp(startHours.Value, startMinutes.Value, startSeconds.Value, startMilliseconds.Value));
                List[index].EndTime = MillisecondsFromTimestamp(new Timestamp(endHours.Value, endMinutes.Value, endSeconds.Value, endMilliseconds.Value));
            }
            catch (Exception ex)
            {
                // do stuff
            }
        }

        private void textbox_Changed(object sender, EventArgs e)
        {
            try
            {
                int index = CurrentNode - 1;
                List[index].Lines = new List<string>();
                foreach (string s in textBox.Lines)
                {
                    List[index].Lines.Add(s);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void TreeNodeSelected(object sender, TreeViewEventArgs e)
        {
            ClearAllCurrent();
            int index = Int32.Parse(e.Node.Text) - 1;
            CurrentNode = index + 1;
            Timestamp time = MillisecondsToTimestamp(List[index].StartTime);
            Timestamp time2 = MillisecondsToTimestamp(List[index].EndTime);

            startHours.Value = time.Hours;
            startMinutes.Value = time.Minutes;
            startSeconds.Value = time.Seconds;
            startMilliseconds.Value = time.Milliseconds;
            endHours.Value = time2.Hours;
            endMinutes.Value = time2.Minutes;
            endSeconds.Value = time2.Seconds;
            endMilliseconds.Value = time2.Milliseconds;

            textBox.Text = "";
            StringBuilder str = new StringBuilder();

            foreach (string s in List[index].Lines.ToArray())
            {
                str.Append(s);
                str.Append("\n");
            }

            //textBox.Text = str.ToString();
            byte[] bytes = Encoding.Default.GetBytes(str.ToString());
            string real = Encoding.UTF8.GetString(bytes);
            textBox.Text = real;

            indexSelector.Value = index + 1;
        }

        public void ClearAllCurrent()
        {
            startHours.Value = 0;
            startMinutes.Value = 0;
            startSeconds.Value = 0;
            startMilliseconds.Value = 0;
            endHours.Value = 0;
            endMinutes.Value = 0;
            endSeconds.Value = 0;
            endMilliseconds.Value = 0;
            textBox.Text = "";
        }

        private void PopulateUIFromCurrentList()
        {
            int index = 1;
            foreach (SubtitlesParser.Classes.SubtitleItem item in List)
            {
                treeView.Nodes.Add(index.ToString());
                index++;
            }
        }


        private void LoadFromFile(string path)
        {
            Stream fs = File.OpenRead(path);
            List = Parser.ParseStream(fs, ASCIIEncoding.Default);
            fs.Close();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void indexSelector_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The index feature is still incomplete.");
        }
    }
}
