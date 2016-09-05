namespace bit_reversal
{
    partial class HideForm
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
            this.openContainerButton = new System.Windows.Forms.Button();
            this.originalPictureBox = new System.Windows.Forms.PictureBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.hideButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openContainerButton
            // 
            this.openContainerButton.Location = new System.Drawing.Point(12, 12);
            this.openContainerButton.Name = "openContainerButton";
            this.openContainerButton.Size = new System.Drawing.Size(256, 23);
            this.openContainerButton.TabIndex = 5;
            this.openContainerButton.Text = "Open Container";
            this.openContainerButton.UseVisualStyleBackColor = true;
            this.openContainerButton.Click += new System.EventHandler(this.openContainerButton_Click);
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.originalPictureBox.Location = new System.Drawing.Point(12, 41);
            this.originalPictureBox.Name = "originalPictureBox";
            this.originalPictureBox.Size = new System.Drawing.Size(512, 512);
            this.originalPictureBox.TabIndex = 6;
            this.originalPictureBox.TabStop = false;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.imagePictureBox.Location = new System.Drawing.Point(530, 41);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(256, 256);
            this.imagePictureBox.TabIndex = 7;
            this.imagePictureBox.TabStop = false;
            // 
            // hideButton
            // 
            this.hideButton.Enabled = false;
            this.hideButton.Location = new System.Drawing.Point(530, 303);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(79, 28);
            this.hideButton.TabIndex = 8;
            this.hideButton.Text = "Hide Image";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(530, 337);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(79, 41);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save Container\r\n";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openImageButton
            // 
            this.openImageButton.Location = new System.Drawing.Point(530, 12);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(79, 23);
            this.openImageButton.TabIndex = 10;
            this.openImageButton.Text = "Open Image";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.openImageButton_Click);
            // 
            // HideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 555);
            this.Controls.Add(this.openImageButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.originalPictureBox);
            this.Controls.Add(this.openContainerButton);
            this.Name = "HideForm";
            this.Text = "Hide";
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openContainerButton;
        private System.Windows.Forms.PictureBox originalPictureBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openImageButton;
    }
}