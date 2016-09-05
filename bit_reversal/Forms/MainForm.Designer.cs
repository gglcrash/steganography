namespace bit_reversal
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
            this.buttonRev = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonAutent = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonNoise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRev
            // 
            this.buttonRev.Location = new System.Drawing.Point(12, 12);
            this.buttonRev.Name = "buttonRev";
            this.buttonRev.Size = new System.Drawing.Size(100, 23);
            this.buttonRev.TabIndex = 0;
            this.buttonRev.Text = "Reverse";
            this.buttonRev.UseVisualStyleBackColor = true;
            this.buttonRev.Click += new System.EventHandler(this.buttonRev_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(12, 41);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(100, 23);
            this.buttonHide.TabIndex = 1;
            this.buttonHide.Text = "Hide";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(12, 70);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(100, 23);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // buttonAutent
            // 
            this.buttonAutent.Location = new System.Drawing.Point(12, 128);
            this.buttonAutent.Name = "buttonAutent";
            this.buttonAutent.Size = new System.Drawing.Size(100, 23);
            this.buttonAutent.TabIndex = 3;
            this.buttonAutent.Text = "Autentificate";
            this.buttonAutent.UseVisualStyleBackColor = true;
            this.buttonAutent.Click += new System.EventHandler(this.buttonAutent_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 157);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonNoise
            // 
            this.buttonNoise.Location = new System.Drawing.Point(12, 99);
            this.buttonNoise.Name = "buttonNoise";
            this.buttonNoise.Size = new System.Drawing.Size(100, 23);
            this.buttonNoise.TabIndex = 5;
            this.buttonNoise.Text = "Remove Noise";
            this.buttonNoise.UseVisualStyleBackColor = true;
            this.buttonNoise.Click += new System.EventHandler(this.buttonNoise_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 184);
            this.Controls.Add(this.buttonNoise);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAutent);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonRev);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRev;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonAutent;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonNoise;
    }
}