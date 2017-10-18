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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveNewFile("HTML", generateHtml());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            advancedHTML aHTML = new advancedHTML();
            aHTML.Show();
        }

        private void generatePDOBtn_Click(object sender, EventArgs e)
        {
            generatePDOClass gPDOc = new generatePDOClass();
            gPDOc.Show();
        }

        public static void saveNewFile(string type, string fileContent, string fileTitle = "")
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            globalVariables.content = fileContent;
            saveFile.FileName = fileTitle;
            switch (type)
            {
                case "HTML":
                    saveFile.Filter = "HTML Files|*.html";
                    
                    break;
                case "PHP":
                    saveFile.Filter = "PHP Files|*.php";
                    break;
                default:
                    saveFile.Filter = "Text Files|*.txt";
                    break;
            }
            saveFile.FilterIndex = 2;
            saveFile.Title = "Save a Generated File...";
            saveFile.RestoreDirectory = true;
            String saveBasicPath = saveFile.FileName;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.FileStream fs = (System.IO.FileStream)saveFile.OpenFile())
                {
                    
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                    {
                        sw.Write(globalVariables.content);
                        MessageBox.Show("Created Successfully!");
                    }
                }
            }
        }

        private static string generateHtml()
        {
            return Resources.default_basic;
        }
    }
}
