using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainMenu();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string qosmeticsinstall = appPath + "/install-qosmetics.cs.exe";
            string qosmeticsdownload = "https://github.com/RedBrumbler/Qosmetics/releases/latest/download/Qosmetics.zip";

            if (!File.Exists(appPath + "/qosmetics.zip"))
            {
                Process.Start(qosmeticsdownload);


                int delay = 3000;
                System.Threading.Thread.Sleep(delay);

                if (File.Exists(appPath + "/qosmetics.zip"))
                {
                    Process.Start(qosmeticsinstall);
                }
            }

            else Process.Start(qosmeticsinstall);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string CFTinstall = appPath + "/install-customfailtext.cs.exe";
            string CFTdownload = "https://cdn.discordapp.com/attachments/765630505000894484/771818619515699230/custom-fail-text_v0.1.6.zip";

            if (!File.Exists(appPath + "/custom-fail-text_v0.1.6.zip"))
            {
                Process.Start(CFTdownload);

                int delay = 3000;
                System.Threading.Thread.Sleep(delay);

                if (File.Exists(appPath + "/custom-fail-text_v0.1.6.zip"))
                {
                    Process.Start(CFTinstall);
                }
             
            }

            else Process.Start(CFTinstall);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string ADinstall = appPath + "/install-autodebris.cs.exe";
            string ADdownload = "https://cdn.discordapp.com/attachments/765630505000894484/771810848959496192/auto-debris_v0.1.1.zip";

            if (!File.Exists(appPath + "/auto-debris_v0.1.1.zip"))
            {
                Process.Start(ADdownload);

                int delay = 3000;
                System.Threading.Thread.Sleep(delay);

                if (File.Exists(appPath + "/auto-debris_v0.1.1.zip"))
                {
                    Process.Start(ADinstall);
                }

            }

            else Process.Start(ADinstall);
        }
    }
}
