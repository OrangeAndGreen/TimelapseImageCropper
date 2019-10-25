namespace Image_Cropper
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.InputStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.OutputStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StartImage = new System.Windows.Forms.PictureBox();
            this.ImageInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageSkip = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.VideoSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StartXOffset = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VideoFrameRate = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.StartYOffset = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.StartZoom = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.EndImage = new System.Windows.Forms.PictureBox();
            this.EndXOffset = new System.Windows.Forms.NumericUpDown();
            this.EndYOffset = new System.Windows.Forms.NumericUpDown();
            this.EndZoom = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartXOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoFrameRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartYOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndXOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndYOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InputStatus,
            this.OutputStatus,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1611, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // InputStatus
            // 
            this.InputStatus.AutoSize = false;
            this.InputStatus.Name = "InputStatus";
            this.InputStatus.Size = new System.Drawing.Size(500, 17);
            this.InputStatus.Text = "input status";
            this.InputStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutputStatus
            // 
            this.OutputStatus.AutoSize = false;
            this.OutputStatus.Name = "OutputStatus";
            this.OutputStatus.Size = new System.Drawing.Size(500, 17);
            this.OutputStatus.Text = "output status";
            this.OutputStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 16);
            // 
            // StartImage
            // 
            this.StartImage.Location = new System.Drawing.Point(15, 51);
            this.StartImage.Name = "StartImage";
            this.StartImage.Size = new System.Drawing.Size(720, 540);
            this.StartImage.TabIndex = 1;
            this.StartImage.TabStop = false;
            // 
            // ImageInterval
            // 
            this.ImageInterval.DecimalPlaces = 1;
            this.ImageInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ImageInterval.Location = new System.Drawing.Point(747, 186);
            this.ImageInterval.Name = "ImageInterval";
            this.ImageInterval.Size = new System.Drawing.Size(123, 20);
            this.ImageInterval.TabIndex = 2;
            this.ImageInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ImageInterval.ValueChanged += new System.EventHandler(this.Output_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Interval (s)";
            // 
            // ImageSkip
            // 
            this.ImageSkip.Location = new System.Drawing.Point(747, 124);
            this.ImageSkip.Name = "ImageSkip";
            this.ImageSkip.Size = new System.Drawing.Size(123, 20);
            this.ImageSkip.TabIndex = 4;
            this.ImageSkip.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ImageSkip.ValueChanged += new System.EventHandler(this.Output_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Use every nth Frame";
            // 
            // VideoSize
            // 
            this.VideoSize.FormattingEnabled = true;
            this.VideoSize.Location = new System.Drawing.Point(747, 79);
            this.VideoSize.Name = "VideoSize";
            this.VideoSize.Size = new System.Drawing.Size(123, 21);
            this.VideoSize.TabIndex = 6;
            this.VideoSize.SelectedIndexChanged += new System.EventHandler(this.VideoSize_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Video Size";
            // 
            // StartXOffset
            // 
            this.StartXOffset.Location = new System.Drawing.Point(15, 25);
            this.StartXOffset.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.StartXOffset.Name = "StartXOffset";
            this.StartXOffset.Size = new System.Drawing.Size(66, 20);
            this.StartXOffset.TabIndex = 2;
            this.StartXOffset.ValueChanged += new System.EventHandler(this.StartInput_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "X Offset";
            // 
            // OutputLabel
            // 
            this.OutputLabel.Location = new System.Drawing.Point(747, 25);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(123, 20);
            this.OutputLabel.TabIndex = 8;
            this.OutputLabel.Text = "Output";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Label";
            // 
            // VideoFrameRate
            // 
            this.VideoFrameRate.Location = new System.Drawing.Point(747, 230);
            this.VideoFrameRate.Name = "VideoFrameRate";
            this.VideoFrameRate.Size = new System.Drawing.Size(123, 20);
            this.VideoFrameRate.TabIndex = 2;
            this.VideoFrameRate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.VideoFrameRate.ValueChanged += new System.EventHandler(this.Output_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(744, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Video Frame Rate (fps)";
            // 
            // StartYOffset
            // 
            this.StartYOffset.Location = new System.Drawing.Point(87, 25);
            this.StartYOffset.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.StartYOffset.Name = "StartYOffset";
            this.StartYOffset.Size = new System.Drawing.Size(66, 20);
            this.StartYOffset.TabIndex = 2;
            this.StartYOffset.ValueChanged += new System.EventHandler(this.StartInput_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Y Offset";
            // 
            // StartZoom
            // 
            this.StartZoom.DecimalPlaces = 2;
            this.StartZoom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.StartZoom.Location = new System.Drawing.Point(200, 25);
            this.StartZoom.Name = "StartZoom";
            this.StartZoom.Size = new System.Drawing.Size(66, 20);
            this.StartZoom.TabIndex = 2;
            this.StartZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartZoom.ValueChanged += new System.EventHandler(this.StartInput_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Zoom";
            // 
            // EndImage
            // 
            this.EndImage.Location = new System.Drawing.Point(879, 51);
            this.EndImage.Name = "EndImage";
            this.EndImage.Size = new System.Drawing.Size(720, 540);
            this.EndImage.TabIndex = 1;
            this.EndImage.TabStop = false;
            // 
            // EndXOffset
            // 
            this.EndXOffset.Location = new System.Drawing.Point(879, 25);
            this.EndXOffset.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EndXOffset.Name = "EndXOffset";
            this.EndXOffset.Size = new System.Drawing.Size(66, 20);
            this.EndXOffset.TabIndex = 2;
            this.EndXOffset.ValueChanged += new System.EventHandler(this.EndInput_ValueChanged);
            // 
            // EndYOffset
            // 
            this.EndYOffset.Location = new System.Drawing.Point(951, 25);
            this.EndYOffset.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EndYOffset.Name = "EndYOffset";
            this.EndYOffset.Size = new System.Drawing.Size(66, 20);
            this.EndYOffset.TabIndex = 2;
            this.EndYOffset.ValueChanged += new System.EventHandler(this.EndInput_ValueChanged);
            // 
            // EndZoom
            // 
            this.EndZoom.DecimalPlaces = 2;
            this.EndZoom.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.EndZoom.Location = new System.Drawing.Point(1064, 25);
            this.EndZoom.Name = "EndZoom";
            this.EndZoom.Size = new System.Drawing.Size(66, 20);
            this.EndZoom.TabIndex = 2;
            this.EndZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndZoom.ValueChanged += new System.EventHandler(this.EndInput_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(876, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "X Offset";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(948, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Y Offset";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1061, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Zoom";
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(747, 318);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(123, 23);
            this.ProcessButton.TabIndex = 9;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 638);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VideoSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImageSkip);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndZoom);
            this.Controls.Add(this.StartZoom);
            this.Controls.Add(this.EndYOffset);
            this.Controls.Add(this.StartYOffset);
            this.Controls.Add(this.EndXOffset);
            this.Controls.Add(this.StartXOffset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VideoFrameRate);
            this.Controls.Add(this.EndImage);
            this.Controls.Add(this.ImageInterval);
            this.Controls.Add(this.StartImage);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Image Cropper";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartXOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoFrameRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartYOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndXOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndYOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox StartImage;
        private System.Windows.Forms.NumericUpDown ImageInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ImageSkip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VideoSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown StartXOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OutputLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown VideoFrameRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown StartYOffset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown StartZoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox EndImage;
        private System.Windows.Forms.NumericUpDown EndXOffset;
        private System.Windows.Forms.NumericUpDown EndYOffset;
        private System.Windows.Forms.NumericUpDown EndZoom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripStatusLabel InputStatus;
        private System.Windows.Forms.ToolStripStatusLabel OutputStatus;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Button ProcessButton;
    }
}

