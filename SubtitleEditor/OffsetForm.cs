using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SubtitleEditor
{
    public partial class OffsetForm : Form
    {
        private MainForm MainForm;


        private void ApplyOffset(bool forwards)
        {
            int start = (int)startNode.Value - 1;
            int end = (int)endNode.Value - 1;
            if ((start < end) && (start < MainForm.List.Count) && (end < MainForm.List.Count))
            {
                for (int i = start; i <= end; i++)
                {
                    if (forwards)
                    {
                        MainForm.List[i].StartTime += MainForm.MillisecondsFromTimestamp(new Timestamp(startHours.Value, startMinutes.Value, startSeconds.Value, startMilliseconds.Value));
                        MainForm.List[i].EndTime += MainForm.MillisecondsFromTimestamp(new Timestamp(startHours.Value, startMinutes.Value, startSeconds.Value, startMilliseconds.Value));
                    }
                    else
                    {
                        MainForm.List[i].StartTime -= MainForm.MillisecondsFromTimestamp(new Timestamp(startHours.Value, startMinutes.Value, startSeconds.Value, startMilliseconds.Value));
                        MainForm.List[i].EndTime -= MainForm.MillisecondsFromTimestamp(new Timestamp(startHours.Value, startMinutes.Value, startSeconds.Value, startMilliseconds.Value));
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid node selection");
            }
        }

        private void Backwards_Click(object sender, EventArgs e)
        {
            ApplyOffset(false);
        }

        private void Forwards_Click(object sender, EventArgs e)
        {
            ApplyOffset(true);
        }

        public OffsetForm(MainForm mainform)
        {
            MainForm = mainform;
            InitializeComponent();
        }
    }
}
