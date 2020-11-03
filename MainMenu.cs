using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QSM
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string userfolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            string sidequest = userfolder + "/AppData/Local/Programs/SideQuest/sidequest.exe";
            Process.Start(sidequest);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);

            string bmbfweb = appPath + "/bmbf.exe";
            Process.Start(bmbfweb);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);

            string bmbfupdate = appPath + "/bmbfupdate.exe";
            Process.Start(bmbfupdate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new QuestAssetsPage1();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
