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
    public partial class generatePDOClass : Form
    {
        public generatePDOClass()
        {
            InitializeComponent();
        }

        public static string generateClass(string hostname, string dbname, string dbuser, string dbpass)
        {
            string phpStart = "<?php\n";
            string structureComment = "/**\n* PDOConnect\n*/\n ";
            string startClass = "class PDOConnect\n{\npublic $dbPDO;\nprivate$tableName;\n function __construct()\n{\n$this->checkConn();\n}\n";
            string checkConn = "private function checkConn($dbhost=" + hostname + ", $dbname=" + dbname + ", $dbuser=" + dbuser + ", $dbpass=" + dbpass + ")\n{\n";
            string checkConnMiddle = "try{\n$this->dbPDO = new PDO('mysql:host='.$dbhost.';dbname='.$dbname, $dbuser, $dbpass);\n}catch(PDOException $e){\nprint 'Error!: '.$e->getMessage().'<br>';\ndie();\n}\n}\n}";
            string phpEnd = "\n?>";
            string CompleteCode = phpStart + structureComment + startClass + checkConn + checkConnMiddle + phpEnd;
            return CompleteCode;
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            pdoClassTextBox.Text = generateClass("localhost", "tesla", "user", "pasword");
        }
    }
}
