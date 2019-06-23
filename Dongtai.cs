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

    public partial class Dongtai : Form
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public event Changeform ChangenotifyIcon;
        public event Changeform loginmianshow;
        public event Changeform loginmianclose;
        // 指向 Program Manager 窗口句柄
        private IntPtr programIntPtr = IntPtr.Zero;
  
        // 桌面背景窗口
        private BgForm bgForm = null;

        public Dongtai()
        {
            InitializeComponent();
            // 设置循环播放

            axWindowsMediaPlayer1.settings.setMode("loop", true);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BringToFront();
            button2.BringToFront();
            set.op_dongtai = 1;

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Enabled = true;
            timer.Interval = 10000;//执行间隔时间,单位为毫秒    
            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer1_Elapsed);
        }
        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (Process thisproc in Process.GetProcesses())
            {
                if (thisproc.MainWindowHandle.ToInt32() != GetForegroundWindow().ToInt32())
                {
                    if(set.active == 1)
                    {
                        bgForm.pause(axWindowsMediaPlayer1);
                    }
                    if(set.active == 2)
                    {
                        this.Close();
                    }
                }
            }
        }

        public void Init()
        {
            // 通过类名查找一个窗口，返回窗口句柄。
            programIntPtr = Win32.FindWindow("Progman", null);

            // 窗口句柄有效
            if (programIntPtr != IntPtr.Zero)
            {

                IntPtr result = IntPtr.Zero;

                // 向 Program Manager 窗口发送 0x52c 的一个消息，超时设置为0x3e8（1秒）。
                Win32.SendMessageTimeout(programIntPtr, 0x52c, IntPtr.Zero, IntPtr.Zero, 0, 0x3e8, result);

                // 遍历顶级窗口
                Win32.EnumWindows((hwnd, lParam) =>
                {
                    // 找到包含 SHELLDLL_DefView 这个窗口句柄的 WorkerW
                    if (Win32.FindWindowEx(hwnd, IntPtr.Zero, "SHELLDLL_DefView", null) != IntPtr.Zero)
                    {
                        // 找到当前 WorkerW 窗口的，后一个 WorkerW 窗口。 
                        IntPtr tempHwnd = Win32.FindWindowEx(IntPtr.Zero, hwnd, "WorkerW", null);

                        // 隐藏这个窗口
                        Win32.ShowWindow(tempHwnd, 0);
                    }
                    return true;
                }, IntPtr.Zero);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // 创建对话框
            OpenFileDialog dialog = new OpenFileDialog();
            // 设置过滤器，只允许 .wmv 和 mp4 格式的视频。
            dialog.Filter = "视频(*.wmv;*.mp4)|*.wmv;*.mp4";

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // 把打开的视频路径，给播放器。
                axWindowsMediaPlayer1.URL = dialog.FileName;

                // 播放视频。
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            button2.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BringToFront();
            if (bgForm == null)
            {
                // 创建背景窗口
                bgForm = new BgForm();

                // 初始化桌面窗口
                Init();

                // 窗口置父，设置背景窗口的父窗口为 Program Manager 窗口
                Win32.SetParent(bgForm.Handle, programIntPtr);

                // 显示背景窗口
                bgForm.Show();
            }

            // 预览窗口视频暂停播放
            axWindowsMediaPlayer1.Ctlcontrols.pause();

            // 背景窗口视频播放
            bgForm.Play(axWindowsMediaPlayer1);

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否放弃设置关闭程序？", "警告",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            e.Cancel = result != DialogResult.Yes;
            set.op_dongtai = 0;
            base.OnClosing(e);
            loginmianclose(true);
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // 播放结束
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                // 无黑屏循环播放视频
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0;
            }
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginmianshow(true);
            //ChangenotifyIcon(true);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bgForm.stop(axWindowsMediaPlayer1);
        }
        public void Close()
        {
            this.Dispose();
        }
    }
}
