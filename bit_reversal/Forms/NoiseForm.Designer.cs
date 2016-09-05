namespace bit_reversal
{
    partial class NoiseForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.remNoiseButton = new System.Windows.Forms.Button();
            this.noislessPictureBox = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.noiseComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.noislessPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(338, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // remNoiseButton
            // 
            this.remNoiseButton.Enabled = false;
            this.remNoiseButton.Location = new System.Drawing.Point(264, 110);
            this.remNoiseButton.Name = "remNoiseButton";
            this.remNoiseButton.Size = new System.Drawing.Size(68, 64);
            this.remNoiseButton.TabIndex = 11;
            this.remNoiseButton.Text = "Remove Noise";
            this.remNoiseButton.UseVisualStyleBackColor = true;
            this.remNoiseButton.Click += new System.EventHandler(this.remNoiseButton_Click);
            // 
            // noislessPictureBox
            // 
            this.noislessPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.noislessPictureBox.Location = new System.Drawing.Point(338, 32);
            this.noislessPictureBox.Name = "noislessPictureBox";
            this.noislessPictureBox.Size = new System.Drawing.Size(256, 256);
            this.noislessPictureBox.TabIndex = 10;
            this.noislessPictureBox.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(2, 3);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(64, 23);
            this.openButton.TabIndex = 9;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.originalPictureBox.Location = new System.Drawing.Point(2, 32);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(256, 256);
            this.originalPictureBox.TabIndex = 8;
            this.originalPictureBox.TabStop = false;
            // 
            // noiseComboBox
            // 
            this.noiseComboBox.FormattingEnabled = true;
            this.noiseComboBox.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.noiseComboBox.Location = new System.Drawing.Point(264, 32);
            this.noiseComboBox.Name = "noiseComboBox";
            this.noiseComboBox.Size = new System.Drawing.Size(67, 21);
            this.noiseComboBox.TabIndex = 13;
            this.noiseComboBox.Text = "2";
            // 
            // NoiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 295);
            this.Controls.Add(this.noiseComboBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.remNoiseButton);
            this.Controls.Add(this.noislessPictureBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.originalPictureBox);
            this.Name = "NoiseForm";
            this.Text = "NoiseForm";
            ((System.ComponentModel.ISupportInitialize)(this.noislessPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button remNoiseButton;
        private System.Windows.Forms.PictureBox noislessPictureBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.ComboBox noiseComboBox;
    }
}