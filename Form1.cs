using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebToolHelper.Properties;

namespace WebToolHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveBasicHTML = new SaveFileDialog();
            saveBasicHTML.Filter = "HTML Files|*.html";
            saveBasicHTML.FilterIndex = 2;
            saveBasicHTML.Title = "Save a Basic HTML file.";
            saveBasicHTML.RestoreDirectory = true;
            String saveBasicPath = saveBasicHTML.FileName;

            if(saveBasicHTML.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.FileStream fs = (System.IO.FileStream)saveBasicHTML.OpenFile())
                {
                    String contents = generateHtml();
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                    {
                        sw.Write(contents);
                        MessageBox.Show("Created Successfully!");
                    }
                }
            }
        }

        private string generateHtml()
        {
            return Resources.default_basic;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            advancedHTML aHTML = new advancedHTML();
            aHTML.Show();
        }
    }
}
