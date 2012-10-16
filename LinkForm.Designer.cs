namespace YT_Uploader
{
    partial class LinkForm
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
            this.videoLinks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // videoLinks
            // 
            this.videoLinks.Location = new System.Drawing.Point(12, 12);
            this.videoLinks.Multiline = true;
            this.videoLinks.Name = "videoLinks";
            this.videoLinks.ReadOnly = true;
            this.videoLinks.Size = new System.Drawing.Size(384, 205);
            this.videoLinks.TabIndex = 0;
            // 
            // LinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 229);
            this.Controls.Add(this.videoLinks);
            this.Name = "LinkForm";
            this.Text = "Video Links";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox videoLinks;
    }
}