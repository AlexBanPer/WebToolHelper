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
                    tabControl.Enabled = false;
                    break;
                case 1: //Full HTML Site
                    checkBoxesPanel.Enabled = true;
                    tabControl.Enabled = true;
                    setTrueOrFalse(new List<int> { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19, 20, 21, 22 }, true);
                    break;
                case 2: //Custom code
                    setTrueOrFalse(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 }, false);
                    customCode cC = new customCode();
                    cC.Show();
                    break;
            }
        }

        //set true or false
        private void setTrueOrFalse(List<int> value, bool toSet, bool checkedmark=false)
        {
           
            if (value.Contains(1))
            {
                checkBoxMeta.Enabled = toSet;
                checkBoxMeta.Checked = checkedmark;
            }
            if (value.Contains(2))
            {
                checkBoxNavBar.Enabled = toSet;
                checkBoxNavBar.Checked = checkedmark;
            }
            if (value.Contains(3))
            {
                checkBoxBlog.Enabled = toSet;
                checkBoxBlog.Checked = checkedmark;
            }
            if (value.Contains(4)) 
            {
                checkBoxTBest.Enabled = toSet;
                checkBoxTBest.Checked = checkedmark;
            }
            if (value.Contains(5))
            {
                checkBoxInfoPanel.Enabled = toSet;
                checkBoxInfoPanel.Checked = checkedmark;
            }
            if (value.Contains(6))
            {
                checkBox3Row.Enabled = toSet;
                checkBox3Row.Checked = checkedmark;
            }
            if (value.Contains(7))
            {
                checkBoxSearch.Enabled = toSet;
                checkBoxSearch.Checked = checkedmark;
            }
            if (value.Contains(8))
            {
                checkBoxPortfolio.Enabled = toSet;
                checkBoxPortfolio.Checked = checkedmark;
            }
            if (value.Contains(9))
            {
                checkBoxComment.Enabled = toSet;
                checkBoxComment.Checked = checkedmark;
            }
            if (value.Contains(10))
            {
                checkBoxPictures.Enabled = toSet;
                checkBoxPictures.Checked = checkedmark;
            }
            if (value.Contains(11))
            {
                checkBoxContact.Enabled = toSet;
                checkBoxContact.Checked = checkedmark;
            }
            if (value.Contains(12))
            {
                checkBoxCTable.Enabled = toSet;
                checkBoxCTable.Checked = checkedmark;
            }
            if (value.Contains(13))
            {
                checkBoxCarousel.Enabled = toSet;
                checkBoxCarousel.Checked = checkedmark;
            }
            if (value.Contains(14))
            {
                checkBoxCards.Enabled = toSet;
                checkBoxCards.Checked = checkedmark;
            }
            if (value.Contains(15))
            {
                checkBoxProgressBar.Enabled = toSet;
                checkBoxProgressBar.Checked = checkedmark;
            }
            if (value.Contains(16))
            {
                checkBoxNavs.Enabled = toSet;
                checkBoxNavs.Checked = checkedmark;
            }
            if (value.Contains(17))
            {
                checkBoxMaintenance.Enabled = toSet;
                checkBoxMaintenance.Checked = checkedmark;
            }
            if (value.Contains(18))
            {
                checkBoxPoll.Enabled = toSet;
                checkBoxPoll.Checked = checkedmark;
            }
            if (value.Contains(19))
            {
                checkBoxSubs.Enabled = toSet;
                checkBoxSubs.Checked = checkedmark;
            }
            if (value.Contains(20))
            {
                checkBoxRegister.Enabled = toSet;
                checkBoxRegister.Checked = checkedmark;
            }
            if (value.Contains(21))
            {
                checkBoxLogin.Enabled = toSet;
                checkBoxLogin.Checked = checkedmark;
            }
            if (value.Contains(22))
            {
                checkBoxFooter.Enabled = toSet;
                checkBoxFooter.Checked = checkedmark;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            setTrueOrFalse(new List<int> {1,2,3}, false);
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
        private void getDefaultBlog_Click(object sender, EventArgs e)
        {
            blogEntryTxt.Text = "";
        }

        /////////////////////////////////

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

        public string setMetaTextBox { set { metaTextBox.Text = value; } }
        public string setNavBarTextBox { set { navbarTextBox.Text = value; } }

        private void editOnTabBTN_Click(object sender, EventArgs e)
        {
            String textToEdit = metaTextBox.Text;
            globalFunctions.textToEdit = textToEdit;
            globalFunctions.tabToSet = "Meta";
            openNewTab();
        }

        private void editOnTabBTN2_Click_2(object sender, EventArgs e)
        {
            String textToEdit = navbarTextBox.Text;
            globalFunctions.textToEdit = textToEdit;
            globalFunctions.tabToSet = "NavBar";
            openNewTab();
        }

        private void savevars_btn(object sender, EventArgs e)
        {
            string title = siteTitleTxt.Text;
            string version = siteVersionTxt.Text;
            string copy = siteCopyTxt.Text;
            string domain = siteDomainTxt.Text;

            if(title == "")
            {
                MessageBox.Show("Title is empty, has been replaced by default text");
                title = "My Site Title";
                siteTitleTxt.Text = title;
            }
            if(version == "")
            {
                MessageBox.Show("Version is empty, has been replaced by default text");
                title = "1.0.0";
                siteVersionTxt.Text = title;
            }
            if(copy == "")
            {
                MessageBox.Show("Copyright is empty, has been replaced by default text");
                copy = "MyName 2017 - All rigts reserved.";
                siteCopyTxt.Text = copy;
            }
            if(domain == "")
            {
                MessageBox.Show("Domain is empty, has been replaced by default text");
                domain = "mydomain.com";
                siteDomainTxt.Text = domain;
            }
            MessageBox.Show(title + version + copy + domain);
        }
    }
}
