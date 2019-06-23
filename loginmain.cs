using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class loginmain : Form
    {
        mp3 frm2 = new mp3();
        Dongtai frm = new Dongtai();
        Main frm4 = new Main();
        setting frm3 = new setting();
        public loginmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //frm2.ChangenotifyIcon += new Changeform(frm_ChangenotifyIcon);
            frm2.loginmianshow += new Changeform(frm_loginmianshow);
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //frm.ChangenotifyIcon += new Changeform(frm_ChangenotifyIcon);
            frm.loginmianshow += new Changeform(frm_loginmianshow);
            frm.loginmianclose += new Changeform(frm_loginmianclose);
            frm.Show();
            this.Hide();
        }

        //关闭时选项
        protected override void OnClosing(CancelEventArgs e)
        {
            if(radioButton1.Checked)
            {
                DialogResult result = MessageBox.Show("是否确认关闭？", "警告",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                e.Cancel = result != DialogResult.Yes;
                base.OnClosing(e);
                this.Dispose();
                this.Close();
            }
            if(radioButton2.Checked)
            {
                e.Cancel = true;
                /*this.ShowInTaskbar = false;
                this.WindowState = FormWindowState.Minimized;
                this.notifyIcon1.Visible = true;*/
                this.Hide();
            }
        }
        void frm_ChangenotifyIcon(bool topmost) //回调函数
        {
            notifyIcon1.Visible = false;
        }

        void frm_loginmianshow(bool topmost) //回调函数
        {
            this.Show();
        }
        void frm_loginmianclose(bool topmost) //回调函数
        {
            this.Close();
        }

        private void main_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = Application.StartupPath + @"\DeepCyan.ssk";
            skinEngine1.SkinFile = "DeepCyan.ssk"; //样式文件的文件名

            
        }

        //开机启动
        public static void AutoStart(bool isAuto)
        {
            try
            {
                if (isAuto == true)
                {
                    RegistryKey R_local = Registry.LocalMachine;//RegistryKey R_local = Registry.CurrentUser;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.SetValue("动态桌面壁纸处理", Application.ExecutablePath);
                    R_run.Close();
                    R_local.Close();
                }
                else
                {
                    RegistryKey R_local = Registry.LocalMachine;//RegistryKey R_local = Registry.CurrentUser;
                    RegistryKey R_run = R_local.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                    R_run.DeleteValue("动态桌面壁纸处理", false);
                    R_run.Close();
                    R_local.Close();
                }

                //GlobalVariant.Instance.UserConfig.AutoStart = isAuto;
            }
            catch (Exception)
            {
                //MessageBoxDlg dlg = new MessageBoxDlg();
                //dlg.InitialData("您需要管理员权限修改", "提示", MessageBoxButtons.OK, MessageBoxDlgIcon.Error);
                //dlg.ShowDialog();
                MessageBox.Show("您需要管理员权限修改", "提示");
            }
        }

        private void loginmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Close();
            frm2.Close();
            frm3.Close();
            frm4.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm4.loginmianshow += new Changeform(frm_loginmianshow);
            frm4.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            //frm3.ChangenotifyIcon += new Changeform(frm_ChangenotifyIcon);
            frm3.loginmianshow += new Changeform(frm_loginmianshow);
            frm3.Show();
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*
            Form frmx = new loginmain();
            notifyIcon1.Visible = false;
            frmx.Show();
            */
            this.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm5 = new clock();

            frm5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm6 = new showForm();

            frm6.Show();
            this.Hide(); 
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
