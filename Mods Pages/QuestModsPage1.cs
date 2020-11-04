
using QSM.QuestModsInstallers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
            var form1 = new qosmeticsinstall();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form1 = new CustomFailTextinstaller();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}

