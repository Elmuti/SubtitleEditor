namespace SubtitleEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetSelectedLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.startHours = new System.Windows.Forms.NumericUpDown();
            this.startMinutes = new System.Windows.Forms.NumericUpDown();
            this.startSeconds = new System.Windows.Forms.NumericUpDown();
            this.startMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.endSeconds = new System.Windows.Forms.NumericUpDown();
            this.endMinutes = new System.Windows.Forms.NumericUpDown();
            this.endHours = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.indexSelector = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMilliseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMilliseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(433, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.offsetSelectedLinesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // offsetSelectedLinesToolStripMenuItem
            // 
            this.offsetSelectedLinesToolStripMenuItem.Name = "offsetSelectedLinesToolStripMenuItem";
            this.offsetSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.offsetSelectedLinesToolStripMenuItem.Text = "Offset Subtitles";
            this.offsetSelectedLinesToolStripMenuItem.Click += new System.EventHandler(this.Offset_Click);
            // 
            // treeView
            // 
            this.treeView.HideSelection = false;
            this.treeView.Location = new System.Drawing.Point(12, 27);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(77, 396);
            this.treeView.TabIndex = 3;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeNodeSelected);
            // 
            // startHours
            // 
            this.startHours.Location = new System.Drawing.Point(143, 84);
            this.startHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.startHours.Name = "startHours";
            this.startHours.Size = new System.Drawing.Size(52, 20);
            this.startHours.TabIndex = 5;
            this.startHours.Leave += new System.EventHandler(this.numeric_Changed);
            // 
            // startMinutes
            // 
            this.startMinutes.Location = new System.Drawing.Point(201, 84);
            this.startMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startMinutes.Name = "startMinutes";
            this.startMinutes.Size = new System.Drawing.Size(52, 20);
            this.startMinutes.TabIndex = 6;
            this.startMinutes.Leave += new System.EventHandler(this.numeric_Changed);
            // 
            // startSeconds
            // 
            this.startSeconds.Location = new System.Drawing.Point(259, 84);
            this.startSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startSeconds.Name = "startSeconds";
            this.startSeconds.Size = new System.Drawing.Size(52, 20);
            this.startSeconds.TabIndex = 7;
            this.startSeconds.Leave += new System.EventHandler(this.numeric_Changed);
            // 
            // startMilliseconds
            // 
            this.startMilliseconds.Location = new System.Drawing.Point(317, 84);
            this.startMilliseconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.startMilliseconds.Name = "startMilliseconds";
            this.startMilliseconds.Size = new System.Drawing.Size(52, 20);
            this.startMilliseconds.TabIndex = 8;
            this.startMilliseconds.Leave += new System.EventHandler(this.numeric_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Start time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "End time:";
            // 
            // endMilliseconds
            // 
            this.endMilliseconds.Location = new System.Drawing.Point(317, 136);
            this.endMilliseconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.endMilliseconds.Name = "endMilliseconds";
            this.endMilliseconds.Size = new System.Drawing.Size(52, 20);
            this.endMilliseconds.TabIndex = 13;
            this.endMilliseconds.Leave += new System.EventHandler(this.numeric_Changed);
            // 
            // endSeconds
            // 
            this.endSeconds.Location = new System.Drawing.Point(259, 136);
            this.endSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.endSeconds.Name = "endSeconds";
            this.endSeconds.Size = new System.Drawing.Size(52, 20);
            this.endSeconds.TabIndex = 12;
            this.endSeconds.Leave += new System.EventHandler(this.numeric_Changed);
            // 
            // endMinutes
            // 
            this.endMinutes.Location = new System.Drawing.Point(201, 136);
            this.endMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.endMinutes.Name = "endMinutes";
            this.endMinutes.Size = new System.Drawing.Size(52, 20);
            this.endMinutes.TabIndex = 11;
            this.endMinutes.Leave += new System.EventHandler(this.numeric_Changed);
            // 
            // endHours
            // 
            this.endHours.Location = new System.Drawing.Point(143, 136);
            this.endHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.endHours.Name = "endHours";
            this.endHours.Size = new System.Drawing.Size(52, 20);
            this.endHours.TabIndex = 10;
            this.endHours.Leave += new System.EventHandler(this.numeric_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Timestamps are in the following format:\r\nHours, Minutes, Seconds, Milliseconds";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(143, 227);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(226, 96);
            this.textBox.TabIndex = 16;
            this.textBox.Leave += new System.EventHandler(this.textbox_Changed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Text:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(143, 400);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(226, 23);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Remove this subtitle";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.Remove_Click);
            // 
            // indexSelector
            // 
            this.indexSelector.Location = new System.Drawing.Point(185, 351);
            this.indexSelector.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.indexSelector.Name = "indexSelector";
            this.indexSelector.Size = new System.Drawing.Size(62, 20);
            this.indexSelector.TabIndex = 20;
            this.indexSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.indexSelector.Leave += new System.EventHandler(this.indexSelector_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Index:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 429);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(77, 23);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add New";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.New_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(433, 459);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.indexSelector);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endMilliseconds);
            this.Controls.Add(this.endSeconds);
            this.Controls.Add(this.endMinutes);
            this.Controls.Add(this.endHours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startMilliseconds);
            this.Controls.Add(this.startSeconds);
            this.Controls.Add(this.startMinutes);
            this.Controls.Add(this.startHours);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Subtitle Editor";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMilliseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMilliseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.NumericUpDown startHours;
        private System.Windows.Forms.NumericUpDown startMinutes;
        private System.Windows.Forms.NumericUpDown startSeconds;
        private System.Windows.Forms.NumericUpDown startMilliseconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown endMilliseconds;
        private System.Windows.Forms.NumericUpDown endSeconds;
        private System.Windows.Forms.NumericUpDown endMinutes;
        private System.Windows.Forms.NumericUpDown endHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.NumericUpDown indexSelector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offsetSelectedLinesToolStripMenuItem;
    }
}

