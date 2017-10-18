using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class customCode : Form
    {
        public customCode()
        {
            InitializeComponent();
        }



    private void readCodeBtn_Click(object sender, EventArgs e)
        {
            string fullcode = customCodeTextBox.Text;
            if (validateJson(fullcode))
            {
                RootObject r = JsonConvert.DeserializeObject<RootObject>(fullcode);
                MessageBox.Show(r.@string);
            }
            else
            {
                MessageBox.Show("JSON Code not valid!");
            }
        }

        private static bool validateJson(string jsonToValidate)
        {
            jsonToValidate = jsonToValidate.Trim();
            if((jsonToValidate.StartsWith("{") && jsonToValidate.EndsWith("}")) || (jsonToValidate.StartsWith("[") && jsonToValidate.EndsWith("]")))
            {
                try
                {
                    var obj = JToken.Parse(jsonToValidate);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    MessageBox.Show(jex.Message);
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public class Object
        {
            public string a { get; set; }
            public string c { get; set; }
            public string e { get; set; }
        }

        public class RootObject
        {
            public List<string> htmlsite { get; set; }
            public bool useCustomNav { get; set; }
            public object @null { get; set; }
            public int number { get; set; }
            public Object @object { get; set; }
            public string @string { get; set; }
        }
    }
}
