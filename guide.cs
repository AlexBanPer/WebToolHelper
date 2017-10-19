using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebToolHelper
{
    public partial class guide : Form
    {
        public guide()
        {
            InitializeComponent();
        }

        public void showGuide(string type, string url = "home")
        {
            try
            {
                var myUri = new UriBuilder(".../guide.php?index=" + url).Uri;

                switch (type)
                {
                    case "PDOClass":
                        webGuide.Url = myUri;
                        break;
                    default:
                        webGuide.Url = myUri;
                        break;
                }
            }
            catch(UriFormatException e)
            {
                MessageBox.Show("Error: " + e.Message);
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                this.Close();
            }
        }

        private void guide_Shown(object sender, EventArgs e)
        {
            showGuide(globalFunctions.tabguide);
        }
    }
}
