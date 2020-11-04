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
    public partial class QuestAssetsPage1 : Form
    {
        public QuestAssetsPage1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainMenu();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
