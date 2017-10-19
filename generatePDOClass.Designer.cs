namespace WebToolHelper
{
    partial class generatePDOClass
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
            this.pdoClassTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.previewBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.hostnameTxtBox = new System.Windows.Forms.TextBox();
            this.dbNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dbUserTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dbPassTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editCodeBtn = new System.Windows.Forms.Button();
            this.guideBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pdoClassTextBox
            // 
            this.pdoClassTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pdoClassTextBox.Location = new System.Drawing.Point(173, 12);
            this.pdoClassTextBox.Multiline = true;
            this.pdoClassTextBox.Name = "pdoClassTextBox";
            this.pdoClassTextBox.ReadOnly = true;
            this.pdoClassTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pdoClassTextBox.Size = new System.Drawing.Size(604, 450);
            this.pdoClassTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hostname";
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(12, 381);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(151, 23);
            this.previewBtn.TabIndex = 4;
            this.previewBtn.Text = "Preview Code";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Enabled = false;
            this.generateBtn.Location = new System.Drawing.Point(12, 439);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(151, 23);
            this.generateBtn.TabIndex = 5;
            this.generateBtn.Text = "Generate Code";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // hostnameTxtBox
            // 
            this.hostnameTxtBox.Location = new System.Drawing.Point(12, 41);
            this.hostnameTxtBox.Name = "hostnameTxtBox";
            this.hostnameTxtBox.Size = new System.Drawing.Size(151, 20);
            this.hostnameTxtBox.TabIndex = 6;
            // 
            // dbNameTxtBox
            // 
            this.dbNameTxtBox.Location = new System.Drawing.Point(12, 95);
            this.dbNameTxtBox.Name = "dbNameTxtBox";
            this.dbNameTxtBox.Size = new System.Drawing.Size(151, 20);
            this.dbNameTxtBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "DataBase Name";
            // 
            // dbUserTxtBox
            // 
            this.dbUserTxtBox.Location = new System.Drawing.Point(12, 147);
            this.dbUserTxtBox.Name = "dbUserTxtBox";
            this.dbUserTxtBox.Size = new System.Drawing.Size(151, 20);
            this.dbUserTxtBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DataBase User";
            // 
            // dbPassTxtBox
            // 
            this.dbPassTxtBox.Location = new System.Drawing.Point(12, 197);
            this.dbPassTxtBox.Name = "dbPassTxtBox";
            this.dbPassTxtBox.Size = new System.Drawing.Size(151, 20);
            this.dbPassTxtBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "DataBase Password";
            // 
            // editCodeBtn
            // 
            this.editCodeBtn.Enabled = false;
            this.editCodeBtn.Location = new System.Drawing.Point(12, 410);
            this.editCodeBtn.Name = "editCodeBtn";
            this.editCodeBtn.Size = new System.Drawing.Size(151, 23);
            this.editCodeBtn.TabIndex = 13;
            this.editCodeBtn.Text = "Edit Code";
            this.editCodeBtn.UseVisualStyleBackColor = true;
            this.editCodeBtn.Click += new System.EventHandler(this.editCodeBtn_Click);
            // 
            // guideBtn
            // 
            this.guideBtn.Location = new System.Drawing.Point(15, 268);
            this.guideBtn.Name = "guideBtn";
            this.guideBtn.Size = new System.Drawing.Size(148, 20);
            this.guideBtn.TabIndex = 14;
            this.guideBtn.Text = "Guide";
            this.guideBtn.UseVisualStyleBackColor = true;
            this.guideBtn.Click += new System.EventHandler(this.guideBtn_Click);
            // 
            // generatePDOClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(789, 474);
            this.Controls.Add(this.guideBtn);
            this.Controls.Add(this.editCodeBtn);
            this.Controls.Add(this.dbPassTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dbUserTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dbNameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hostnameTxtBox);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pdoClassTextBox);
            this.Name = "generatePDOClass";
            this.Text = "generatePDOClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pdoClassTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox hostnameTxtBox;
        private System.Windows.Forms.TextBox dbNameTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dbUserTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dbPassTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editCodeBtn;
        private System.Windows.Forms.Button guideBtn;
    }
}