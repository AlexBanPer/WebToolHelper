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
            globalFunctions.saveNewFile("HTML", generateHtml());
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

        private static string generateHtml()
        {
            return Resources.default_basic;
        }

        private void configBtn_Click(object sender, EventArgs e)
        {
            ProgramConfigMenu PCM = new ProgramConfigMenu();
            PCM.Show();
        }
    }
}
