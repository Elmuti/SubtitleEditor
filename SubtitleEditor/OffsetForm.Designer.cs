namespace SubtitleEditor
{
    partial class OffsetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.startMilliseconds = new System.Windows.Forms.NumericUpDown();
            this.startSeconds = new System.Windows.Forms.NumericUpDown();
            this.startMinutes = new System.Windows.Forms.NumericUpDown();
            this.startHours = new System.Windows.Forms.NumericUpDown();
            this.backwardsButton = new System.Windows.Forms.Button();
            this.forwardsButton = new System.Windows.Forms.Button();
            this.startNode = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.endNode = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startMilliseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Time to offset selected subtitles by:";
            // 
            // startMilliseconds
            // 
            this.startMilliseconds.Location = new System.Drawing.Point(209, 92);
            this.startMilliseconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.startMilliseconds.Name = "startMilliseconds";
            this.startMilliseconds.Size = new System.Drawing.Size(52, 20);
            this.startMilliseconds.TabIndex = 13;
            // 
            // startSeconds
            // 
            this.startSeconds.Location = new System.Drawing.Point(151, 92);
            this.startSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startSeconds.Name = "startSeconds";
            this.startSeconds.Size = new System.Drawing.Size(52, 20);
            this.startSeconds.TabIndex = 12;
            // 
            // startMinutes
            // 
            this.startMinutes.Location = new System.Drawing.Point(93, 92);
            this.startMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startMinutes.Name = "startMinutes";
            this.startMinutes.Size = new System.Drawing.Size(52, 20);
            this.startMinutes.TabIndex = 11;
            // 
            // startHours
            // 
            this.startHours.Location = new System.Drawing.Point(35, 92);
            this.startHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.startHours.Name = "startHours";
            this.startHours.Size = new System.Drawing.Size(52, 20);
            this.startHours.TabIndex = 10;
            // 
            // backwardsButton
            // 
            this.backwardsButton.Location = new System.Drawing.Point(11, 130);
            this.backwardsButton.Name = "backwardsButton";
            this.backwardsButton.Size = new System.Drawing.Size(126, 23);
            this.backwardsButton.TabIndex = 15;
            this.backwardsButton.Text = "Apply offset backwards";
            this.backwardsButton.UseVisualStyleBackColor = true;
            this.backwardsButton.Click += new System.EventHandler(this.Backwards_Click);
            // 
            // forwardsButton
            // 
            this.forwardsButton.Location = new System.Drawing.Point(156, 130);
            this.forwardsButton.Name = "forwardsButton";
            this.forwardsButton.Size = new System.Drawing.Size(126, 23);
            this.forwardsButton.TabIndex = 16;
            this.forwardsButton.Text = "Apply offset forwards";
            this.forwardsButton.UseVisualStyleBackColor = true;
            this.forwardsButton.Click += new System.EventHandler(this.Forwards_Click);
            // 
            // startNode
            // 
            this.startNode.Location = new System.Drawing.Point(65, 31);
            this.startNode.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.startNode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startNode.Name = "startNode";
            this.startNode.Size = new System.Drawing.Size(64, 20);
            this.startNode.TabIndex = 17;
            this.startNode.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select all subtitles between:";
            // 
            // endNode
            // 
            this.endNode.Location = new System.Drawing.Point(171, 31);
            this.endNode.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.endNode.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endNode.Name = "endNode";
            this.endNode.Size = new System.Drawing.Size(64, 20);
            this.endNode.TabIndex = 19;
            this.endNode.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "and";
            // 
            // OffsetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 165);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endNode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startNode);
            this.Controls.Add(this.forwardsButton);
            this.Controls.Add(this.backwardsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startMilliseconds);
            this.Controls.Add(this.startSeconds);
            this.Controls.Add(this.startMinutes);
            this.Controls.Add(this.startHours);
            this.Name = "OffsetForm";
            this.Text = "Offset";
            ((System.ComponentModel.ISupportInitialize)(this.startMilliseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startNode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endNode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown startMilliseconds;
        private System.Windows.Forms.NumericUpDown startSeconds;
        private System.Windows.Forms.NumericUpDown startMinutes;
        private System.Windows.Forms.NumericUpDown startHours;
        private System.Windows.Forms.Button backwardsButton;
        private System.Windows.Forms.Button forwardsButton;
        private System.Windows.Forms.NumericUpDown startNode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown endNode;
        private System.Windows.Forms.Label label3;
    }
}