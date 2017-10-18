using System;
using System.Windows.Forms;

namespace WebToolHelper
{
    public partial class editCodeFullTab : Form
    {
        private advancedHTML advancedHTMLSetString;
        private ProgramConfigMenu programConfigMenuSetString;

        public editCodeFullTab()
        {
            InitializeComponent();
        }

        public editCodeFullTab(advancedHTML other)
        {
            this.advancedHTMLSetString = other;
            InitializeComponent();
        }

        private void editCodeFullTab_Load(object sender, EventArgs e)
        {
            textBox1.Text = globalFunctions.textToEdit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
              switch (globalFunctions.tabToSet)
              {
                    case "Meta":
                        advancedHTMLSetString.setMetaTextBox = textBox1.Text;
                        break;
                    case "NavBar":
                        advancedHTMLSetString.setNavBarTextBox = textBox1.Text;
                        break;
                    default:
                        MessageBox.Show("Nombre de TAB para el editor no encontrado!");
                        break;
                }
            this.Close();
        }

        public string setTextBox { set { textBox1.Text = value; } }
    }
}
