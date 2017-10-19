namespace WebToolHelper
{
    partial class guide
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
            this.webGuide = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webGuide
            // 
            this.webGuide.AllowWebBrowserDrop = false;
            this.webGuide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webGuide.Location = new System.Drawing.Point(0, 0);
            this.webGuide.MinimumSize = new System.Drawing.Size(20, 20);
            this.webGuide.Name = "webGuide";
            this.webGuide.Size = new System.Drawing.Size(643, 478);
            this.webGuide.TabIndex = 0;
            // 
            // guide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 478);
            this.Controls.Add(this.webGuide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "guide";
            this.Text = "guide";
            this.Shown += new System.EventHandler(this.guide_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webGuide;
    }
}