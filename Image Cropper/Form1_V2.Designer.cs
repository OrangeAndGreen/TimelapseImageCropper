namespace Image_Cropper
{
    partial class Form1_V2
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
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageDisplay = new System.Windows.Forms.PictureBox();
            this.ImageInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageSkip = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.VideoSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StartXOffset = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.VideoFrameRate = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.StartYOffset = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.StartZoom = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.inputsLabel = new System.Windows.Forms.Label();
            this.outputsLabel = new System.Windows.Forms.Label();
            this.calculatorLabel = new System.Windows.Forms.Label();
            this.frameSlider = new System.Windows.Forms.TrackBar();
            this.frameIndex = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.keyFramesListBox = new System.Windows.Forms.ListBox();
            this.keyButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.NumericUpDown();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartXOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoFrameRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartYOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 702);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 16);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = false;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(500, 17);
            this.statusLabel.Text = "Status";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageDisplay
            // 
            this.imageDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageDisplay.Location = new System.Drawing.Point(215, 108);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(781, 583);
            this.imageDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageDisplay.TabIndex = 1;
            this.imageDisplay.TabStop = false;
            // 
            // ImageInterval
            // 
            this.ImageInterval.DecimalPlaces = 1;
            this.ImageInterval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ImageInterval.Location = new System.Drawing.Point(12, 537);
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
            this.label1.Location = new System.Drawing.Point(9, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Interval (s)";
            // 
            // ImageSkip
            // 
            this.ImageSkip.Location = new System.Drawing.Point(12, 166);
            this.ImageSkip.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ImageSkip.Name = "ImageSkip";
            this.ImageSkip.Size = new System.Drawing.Size(85, 20);
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
            this.label2.Location = new System.Drawing.Point(9, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Frame Out Interval";
            // 
            // VideoSize
            // 
            this.VideoSize.FormattingEnabled = true;
            this.VideoSize.Location = new System.Drawing.Point(12, 74);
            this.VideoSize.Name = "VideoSize";
            this.VideoSize.Size = new System.Drawing.Size(123, 21);
            this.VideoSize.TabIndex = 6;
            this.VideoSize.SelectedIndexChanged += new System.EventHandler(this.VideoSize_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Video Size";
            // 
            // StartXOffset
            // 
            this.StartXOffset.Location = new System.Drawing.Point(329, 82);
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
            this.label4.Location = new System.Drawing.Point(326, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "X Offset";
            // 
            // VideoFrameRate
            // 
            this.VideoFrameRate.Location = new System.Drawing.Point(12, 581);
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
            this.label6.Location = new System.Drawing.Point(9, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Video Frame Rate (fps)";
            // 
            // StartYOffset
            // 
            this.StartYOffset.Location = new System.Drawing.Point(401, 82);
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
            this.label7.Location = new System.Drawing.Point(398, 66);
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
            this.StartZoom.Location = new System.Drawing.Point(514, 82);
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
            this.label8.Location = new System.Drawing.Point(511, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Zoom";
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(12, 22);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(123, 23);
            this.ProcessButton.TabIndex = 9;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // inputsLabel
            // 
            this.inputsLabel.AutoSize = true;
            this.inputsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputsLabel.Location = new System.Drawing.Point(12, 199);
            this.inputsLabel.Name = "inputsLabel";
            this.inputsLabel.Size = new System.Drawing.Size(62, 60);
            this.inputsLabel.TabIndex = 10;
            this.inputsLabel.Text = "(inputs)\r\n1...\r\n2...";
            // 
            // outputsLabel
            // 
            this.outputsLabel.AutoSize = true;
            this.outputsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputsLabel.Location = new System.Drawing.Point(12, 271);
            this.outputsLabel.Name = "outputsLabel";
            this.outputsLabel.Size = new System.Drawing.Size(73, 60);
            this.outputsLabel.TabIndex = 11;
            this.outputsLabel.Text = "(outputs)\r\n1...\r\n2...";
            // 
            // calculatorLabel
            // 
            this.calculatorLabel.AutoSize = true;
            this.calculatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorLabel.Location = new System.Drawing.Point(12, 615);
            this.calculatorLabel.Name = "calculatorLabel";
            this.calculatorLabel.Size = new System.Drawing.Size(55, 80);
            this.calculatorLabel.TabIndex = 12;
            this.calculatorLabel.Text = "(calcs)\r\n1...\r\n2...\r\n3...";
            // 
            // frameSlider
            // 
            this.frameSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameSlider.Location = new System.Drawing.Point(313, 22);
            this.frameSlider.Name = "frameSlider";
            this.frameSlider.Size = new System.Drawing.Size(683, 45);
            this.frameSlider.TabIndex = 13;
            this.frameSlider.Scroll += new System.EventHandler(this.frameSlider_Scroll);
            // 
            // frameIndex
            // 
            this.frameIndex.Location = new System.Drawing.Point(215, 22);
            this.frameIndex.Name = "frameIndex";
            this.frameIndex.Size = new System.Drawing.Size(92, 20);
            this.frameIndex.TabIndex = 14;
            this.frameIndex.ValueChanged += new System.EventHandler(this.frameIndex_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Key Frames";
            // 
            // keyFramesListBox
            // 
            this.keyFramesListBox.FormattingEnabled = true;
            this.keyFramesListBox.Location = new System.Drawing.Point(12, 372);
            this.keyFramesListBox.Name = "keyFramesListBox";
            this.keyFramesListBox.Size = new System.Drawing.Size(190, 134);
            this.keyFramesListBox.TabIndex = 16;
            this.keyFramesListBox.SelectedIndexChanged += new System.EventHandler(this.keyFramesListBox_SelectedIndexChanged);
            // 
            // keyButton
            // 
            this.keyButton.Location = new System.Drawing.Point(215, 79);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(92, 23);
            this.keyButton.TabIndex = 17;
            this.keyButton.Text = "Make Key";
            this.keyButton.UseVisualStyleBackColor = true;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(2, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 2);
            this.label10.TabIndex = 18;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(2, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 2);
            this.label11.TabIndex = 19;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.WindowText;
            this.label12.Location = new System.Drawing.Point(2, 509);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 2);
            this.label12.TabIndex = 20;
            this.label12.Text = "label12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Frame Selector";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(101, 99);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 24;
            this.heightLabel.Text = "Height";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(29, 99);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 25;
            this.widthLabel.Text = "Width";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(104, 115);
            this.heightInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(66, 20);
            this.heightInput.TabIndex = 22;
            this.heightInput.ValueChanged += new System.EventHandler(this.heightInput_ValueChanged);
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(32, 115);
            this.widthInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(66, 20);
            this.widthInput.TabIndex = 23;
            this.widthInput.ValueChanged += new System.EventHandler(this.widthInput_ValueChanged);
            // 
            // Form1_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 724);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.keyFramesListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.frameIndex);
            this.Controls.Add(this.frameSlider);
            this.Controls.Add(this.calculatorLabel);
            this.Controls.Add(this.outputsLabel);
            this.Controls.Add(this.inputsLabel);
            this.Controls.Add(this.ProcessButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VideoSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImageSkip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartZoom);
            this.Controls.Add(this.StartYOffset);
            this.Controls.Add(this.StartXOffset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VideoFrameRate);
            this.Controls.Add(this.ImageInterval);
            this.Controls.Add(this.imageDisplay);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1_V2";
            this.Text = "Image Cropper";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartXOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoFrameRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartYOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frameIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox imageDisplay;
        private System.Windows.Forms.NumericUpDown ImageInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ImageSkip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox VideoSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown StartXOffset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown VideoFrameRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown StartYOffset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown StartZoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Label inputsLabel;
        private System.Windows.Forms.Label outputsLabel;
        private System.Windows.Forms.Label calculatorLabel;
        private System.Windows.Forms.TrackBar frameSlider;
        private System.Windows.Forms.NumericUpDown frameIndex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox keyFramesListBox;
        private System.Windows.Forms.Button keyButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown heightInput;
        private System.Windows.Forms.NumericUpDown widthInput;
    }
}

