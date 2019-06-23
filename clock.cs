using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace WindowsFormsApplication2
{
    public partial class clock : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow([MarshalAs(UnmanagedType.LPTStr)] string lpClassName, [MarshalAs(UnmanagedType.LPTStr)] string lpWindowName);

        [DllImport("user32")]
        private static extern IntPtr FindWindowEx(IntPtr hWnd1, IntPtr hWnd2, string lpsz1, string lpsz2);

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public clock()
        {

            InitializeComponent();
            /* 
            //无边框
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //不出现在任务栏
            this.ShowInTaskbar = false;
            timer1.Start();
            //置顶
            //this.TopMost = true;
            */
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToShortTimeString();
            this.label3.Text = DateTime.Now.DayOfWeek.ToString();

            string month = " ";
            switch(DateTime.Now.Month.ToString())
            {
                case "1":month = "January";break;
                case "2": month = "February"; break;
                case "3": month = "March"; break;
                case "4": month = " April"; break;
                case "5": month = "May"; break;
                case "6": month = "June"; break;
                case "7": month = "July"; break;
                case "8": month = "August "; break;
                case "9": month = "September"; break;
                case "10": month = "October"; break;
                case "11": month = "November"; break;
                case "12": month = "December"; break;
                default:
                    break;
            }

            string day = DateTime.Now.Day.ToString();
            string a = " ";
            string b = string.Format("{0} {1} {2}", month, a, day);
            this.label4.Text = b;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void clock_Load(object sender, EventArgs e)
        {
            /*
            IntPtr pWnd = FindWindow("Progman", null);
            pWnd = FindWindowEx(pWnd, IntPtr.Zero, "SHELLDLL_DefVIew", null);
            pWnd = FindWindowEx(pWnd, IntPtr.Zero, "SysListView32", null);
            //IntPtr tWnd = new System.Windows.Interop.WindowInteropHelper(this).Handle;

            SetParent(this.Handle, pWnd);
            */
        }
        public void Close()
        {
            this.Dispose();
        }
    }
}
