namespace bit_reversal
{
    partial class FindForm
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
            this.hideButton = new System.Windows.Forms.Button();
            this.reversedPictureBox = new System.Windows.Forms.PictureBox();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.openButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reversedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(530, 349);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(63, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save ";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(530, 303);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(63, 40);
            this.hideButton.TabIndex = 13;
            this.hideButton.Text = "Find Image";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // reversedPictureBox
            // 
            this.reversedPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reversedPictureBox.Location = new System.Drawing.Point(530, 41);
            this.reversedPictureBox.Name = "reversedPictureBox";
            this.reversedPictureBox.Size = new System.Drawing.Size(256, 256);
            this.reversedPictureBox.TabIndex = 12;
            this.reversedPictureBox.TabStop = false;
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.originalPictureBox.Location = new System.Drawing.Point(12, 41);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(512, 512);
            this.originalPictureBox.TabIndex = 11;
            this.originalPictureBox.TabStop = false;
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(256, 23);
            this.openButton.TabIndex = 10;
            this.openButton.Text = "Open Container";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 560);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.reversedPictureBox);
            this.Controls.Add(this.originalPictureBox);
            this.Controls.Add(this.openButton);
            this.Name = "FindForm";
            this.Text = "Find";
            ((System.ComponentModel.ISupportInitialize)(this.reversedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.PictureBox reversedPictureBox;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.Button openButton;
    }
}