using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSM.QuestModsInstallers
{
    public partial class CustomFailTextinstaller : Form
    {
        public CustomFailTextinstaller()
        {
            InitializeComponent();
        }
        public static String adbS(String Argument)
        {
            String User = System.Environment.GetEnvironmentVariable("USERPROFILE");
            ProcessStartInfo s = new ProcessStartInfo();
            s.CreateNoWindow = false;
            s.UseShellExecute = false;
            s.FileName = "adb.exe";
            s.WindowStyle = ProcessWindowStyle.Minimized;
            s.RedirectStandardOutput = true;
            s.Arguments = Argument;
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(s))
                {
                    String IPS = exeProcess.StandardOutput.ReadToEnd();
                    exeProcess.WaitForExit();
                    return IPS;
                }
            }
            catch
            {

                ProcessStartInfo se = new ProcessStartInfo();
                se.CreateNoWindow = false;
                se.UseShellExecute = false;
                se.FileName = User + "\\AppData\\Roaming\\SideQuest\\platform-tools\\adb.exe";
                se.WindowStyle = ProcessWindowStyle.Minimized;
                se.RedirectStandardOutput = true;
                se.Arguments = Argument;
                try
                {
                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(se))
                    {
                        String IPS = exeProcess.StandardOutput.ReadToEnd();
                        exeProcess.WaitForExit();
                        return IPS;

                    }
                }
                catch
                {
                    // Log error.
                    return "Error";
                }
            }
        }
        public string IP { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            String IPS = adbS("shell ifconfig wlan0");
            int Index = IPS.IndexOf("inet addr:");
            Boolean space = false;
            String FIP = "";
            for (int i = 0; i < IPS.Length; i++)
            {
                if (i > (Index + 9) && i < (Index + 9 + 16))
                {
                    if (IPS.Substring(i, 1) == " ")
                    {
                        space = true;
                    }
                    if (!space)
                    {
                        FIP = FIP + IPS.Substring(i, 1);
                    }
                }
            }

            if (FIP == "")
            {
                IP = "Quest IP";
                return;
            }
            IP = FIP;

            using (WebClient client = new WebClient())
            {
                //upload file
                string filename = "custom-fail-text_v0.1.6.zip";
                client.UploadFile("http://" + IP + ":50000/host/beatsaber/upload?overwrite", filename);
                client.QueryString.Add("foo", "foo");
                client.UploadValues("http://" + IP + ":50000/host/beatsaber/commitconfig", "POST", client.QueryString);
            }
        }
      }
  }

