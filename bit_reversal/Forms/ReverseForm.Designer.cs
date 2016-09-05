namespace bit_reversal
{
    partial class ReverseForm
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
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            this.reversedPictureBox = new System.Windows.Forms.PictureBox();
            this.imageRevButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reversedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.originalPictureBox.Location = new System.Drawing.Point(6, 34);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(256, 256);
            this.originalPictureBox.TabIndex = 3;
            this.originalPictureBox.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(6, 5);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(64, 23);
            this.openButton.TabIndex = 4;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // reversedPictureBox
            // 
            this.reversedPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reversedPictureBox.Location = new System.Drawing.Point(342, 34);
            this.reversedPictureBox.Name = "reversedPictureBox";
            this.reversedPictureBox.Size = new System.Drawing.Size(256, 256);
            this.reversedPictureBox.TabIndex = 5;
            this.reversedPictureBox.TabStop = false;
            // 
            // imageRevButton
            // 
            this.imageRevButton.Enabled = false;
            this.imageRevButton.Location = new System.Drawing.Point(268, 112);
            this.imageRevButton.Name = "imageRevButton";
            this.imageRevButton.Size = new System.Drawing.Size(68, 64);
            this.imageRevButton.TabIndex = 6;
            this.imageRevButton.Text = "Reverse Image";
            this.imageRevButton.UseVisualStyleBackColor = true;
            this.imageRevButton.Click += new System.EventHandler(this.imageRevButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(342, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ReverseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 293);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.imageRevButton);
            this.Controls.Add(this.reversedPictureBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.originalPictureBox);
            this.Name = "ReverseForm";
            this.Text = "Reverse";
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reversedPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.PictureBox reversedPictureBox;
        private System.Windows.Forms.Button imageRevButton;
        private System.Windows.Forms.Button saveButton;
    }
}

