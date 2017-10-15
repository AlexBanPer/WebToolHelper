using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebToolHelper.Properties;

namespace WebToolHelper
{
    public partial class advancedHTML : Form
    {
        String metaTxt = Resources.defaultMeta;
        String navbarTxt = Resources.defaultNavbar;

        public advancedHTML()
        {
            InitializeComponent();
        }

        private void advancedHTML_Shown(object sender, EventArgs e)
        {
            selectPageTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectPageTypeBox.SelectedIndex = 0;

            checkBoxesPanel.Enabled = false;

            //Mostrar textos por defecto:
            metaTextBox.Text = metaTxt;
            navbarTextBox.Text = navbarTxt;
        }

        private void selectPageTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (selectPageTypeBox.SelectedIndex)
            {
                case 0: //Nothing
                    checkBoxesPanel.Enabled = false;
                    break;
                case 1: //Index - Main Page
                    checkBoxesPanel.Enabled = true;
                    break;
                case 2: //Login
                    checkBoxesPanel.Enabled = true;
                    break;
                case 3: //Register
                    checkBoxesPanel.Enabled = true;
                    break;
                case 4: //Custom code
                    customCode cC = new customCode();
                    cC.Show();
                    break;
            }
        }

        //get defaults

        private void getDefaultMeta_Click(object sender, EventArgs e)
        {
            metaTextBox.Text = metaTxt;
        }

        private void getDefaultNavbar_Click(object sender, EventArgs e)
        {
            navbarTextBox.Text = navbarTxt;
        }

        /////////////////////////////////

        private void editOnTabBTN_Click(object sender, EventArgs e)
        {
            
        }

        public void openNewTab()
        {
            editCodeFullTab openNewTab = new editCodeFullTab(this);
            openNewTab.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (checkBoxMeta.Checked)
            {
                customMetaPanel.Enabled = true;
            }
            else
            {
                customMetaPanel.Enabled = false;
            }

            if (checkBoxNavBar.Checked)
            {
                customNavbarPanel.Enabled = true;
            }
            else
            {
                customNavbarPanel.Enabled = false;
            }
        }

        private void editOnTabBTN_Click_1(object sender, EventArgs e)
        {
            String textToEdit = metaTextBox.Text;
            globalVariables.textToEdit = textToEdit;
            globalVariables.tabToSet = "Meta";
            openNewTab();
        }

        private void editOnTabBTN2_Click(object sender, EventArgs e)
        {
            String textToEdit = navbarTextBox.Text;
            globalVariables.textToEdit = textToEdit;
            globalVariables.tabToSet = "NavBar";
            openNewTab();
        }

        public string setMetaTextBox { set { metaTextBox.Text = value; } }
        public string setNavBarTextBox { set { navbarTextBox.Text = value; } }
    }
}
