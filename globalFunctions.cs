using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebToolHelper
{
    class globalFunctions
    {
        // set tab for guide
        public static String tabguide = "";

        // set content for X tab on advanced HTML
        public static String textToEdit = "";
        public static String tabToSet = "";

        // set content for saveNewFile
        public static String content = "";

        // set HTML content for advancedHTML
        public static String advancedHtml = "";

        public static void saveNewFile(string type, string fileContent, string fileTitle = "")
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            content = fileContent;
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
                        sw.Write(content);
                        MessageBox.Show("Created Successfully!");
                    }
                }
            }
        }
    }
}
