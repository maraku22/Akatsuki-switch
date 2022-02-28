using System;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;
/*
 * Osu! Private Server : https://akatsuki.pw/
 * 
 * 2022/02/19 18:26 (Japan Time)
 * 
 * 言語 : C#(.NET)
 * Credit By. Darkne$$$carlet
 * Github:https://github.com/zzScarletzz
 * Twitter:https://twitter.com/Private_Scarlet
 * Akatsuki User:https://akatsuki.pw/u/89913
 * 非公式のswitchツールです。
 */
namespace AkatsukiServer
{
    public partial class SwitchMain : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        public SwitchMain()
        {
            InitializeComponent();
        }


        private Point mousePoint;
        private void SwitchMain_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {

                mousePoint = new Point(e.X, e.Y);//位置
            }
        }


        private void SwitchMain_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Left += e.X - mousePoint.X;
                Top += e.Y - mousePoint.Y;
            }
        }



        static private string ProcessExecutablePath(Process process)
        {
            try
            {
                return process.MainModule.FileName;
            }
            catch
            {
                string query = "SELECT ExecutablePath, ProcessID FROM Win32_Process";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

                foreach (ManagementObject item in searcher.Get())
                {
                    object id = item["ProcessID"];
                    object path = item["ExecutablePath"];

                    if (path != null && id.ToString() == process.Id.ToString())
                    {
                        return path.ToString();
                    }
                }
            }

            return "";
        }

        public static Process Process;
        private void SwitchMain_Load(object sender, EventArgs e)
        {
            FileBox.Enabled = false;
            MouseDown += new MouseEventHandler(SwitchMain_MouseDown);
            MouseMove += new MouseEventHandler(SwitchMain_MouseMove);
            var osu = Process.GetProcessesByName("osu!");

            if (osu.Length != 0)
            {
                Process = osu[0];
                StatusText.ForeColor = Color.Green; 
                StatusText.Text = "Found";
            }
            else
            {
                MessageBox.Show("Please start osu Running", "Error", MessageBoxButtons.OK);
                StatusText.ForeColor = Color.Maroon;
                StatusText.Text = "Not Found";
            }

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = FindWindow(null, "osu!");

            if (hWnd != IntPtr.Zero)
            {
                int processId;
                GetWindowThreadProcessId(hWnd, out processId);
                Process p = Process.GetProcessById(processId);
                string path = ProcessExecutablePath(p);
                FileBox.Text = path;
                p.Kill();
                ProcessStartInfo processStartInfo = new ProcessStartInfo(FileBox.Text, " -devserver akatsuki.pw");
                Process.Start(processStartInfo);
                StatusText.ForeColor= Color.White;
                StatusText.Text = "Done!";
            }
            else
            {
                MessageBox.Show("Please start osu");//Error
                return;
            }
        }

        private void Exitlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
