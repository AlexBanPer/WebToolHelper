namespace WebToolHelper
{
    partial class customCode
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
            this.customCodeTextBox = new System.Windows.Forms.TextBox();
            this.readCodeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(182, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSERT CUSTOM CODE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customCodeTextBox
            // 
            this.customCodeTextBox.Location = new System.Drawing.Point(12, 49);
            this.customCodeTextBox.Name = "customCodeTextBox";
            this.customCodeTextBox.Size = new System.Drawing.Size(458, 20);
            this.customCodeTextBox.TabIndex = 1;
            // 
            // readCodeBtn
            // 
            this.readCodeBtn.Location = new System.Drawing.Point(12, 75);
            this.readCodeBtn.Name = "readCodeBtn";
            this.readCodeBtn.Size = new System.Drawing.Size(458, 23);
            this.readCodeBtn.TabIndex = 2;
            this.readCodeBtn.Text = "READ CODE";
            this.readCodeBtn.UseVisualStyleBackColor = true;
            this.readCodeBtn.Click += new System.EventHandler(this.readCodeBtn_Click);
            // 
            // customCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 107);
            this.Controls.Add(this.readCodeBtn);
            this.Controls.Add(this.customCodeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "customCode";
            this.Text = "customCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customCodeTextBox;
        private System.Windows.Forms.Button readCodeBtn;
    }
}