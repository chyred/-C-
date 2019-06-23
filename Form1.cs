using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SetTime1
{
    public partial class Form1 : Form
    {
        public void Close()
        {
            this.Dispose();
        }
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                //显示当前时间
                lblNow.Text = DateTime.Now.ToString("yyyy年MM月dd日hh时mm分ss秒");
                Timer timer = new Timer();
                timer.Tick += new EventHandler(this.timer_Tick);
                timer.Enabled = true;

                //不断捕获鼠标位置
                Timer timer1 = new Timer();
                timer1.Tick += new EventHandler(this.timer1_Tick);
                timer1.Enabled = true;

                //初始化关机
                InitialModel1();

                //初始化重启模式
                InitialRset();

                //初始化注销
                InitialModel2();
            }
            catch { }

        }

        private void timer_Tick(object sender, EventArgs e)//当前时间
        {
            try
            {
                //在标签上实时显示当前时间
                lblNow.Text = DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒");
            }
            catch{}
        }

        private void timer1_Tick(object sender, EventArgs e)//窗体贴边
        {
            try
            {
                int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;  //获取屏幕宽度 
                int ScreenRight = Screen.PrimaryScreen.WorkingArea.Right; //获取屏幕高度 
                System.Drawing.Point mouse_pos = new Point(Cursor.Position.X, Cursor.Position.Y);//获取鼠标在屏幕的坐标点
                Rectangle Rects = new Rectangle(this.Left, this.Top, this.Left + this.Width, this.Top + this.Height);//存储当前窗体在屏幕的所在区域
                
                if ((this.Top < 0) && Win32API.PtInRect(ref Rects, mouse_pos))//当鼠标在当前窗体内，并且窗体的Top属性小于0
                {//如果窗体已经上贴边了并且鼠标在窗体内部，上贴边展开
                    this.Top = 0;//设置窗体的Top属性为0
                }
                else if (this.Top > -5 && this.Top < 5 && !(Win32API.PtInRect(ref Rects, mouse_pos)))
                {//当窗体的上边框与屏幕的顶端的距离小于5,并且鼠标不在窗体内部时
                         this.Top = 5 - this.Height;//将窗体隐藏到屏幕的顶端，即上贴边
                }
                
                if ((this.Left >= ScreenWidth - 5) && Win32API.PtInRect(ref Rects, mouse_pos))//当鼠标在当前窗体内，并且窗体的Left属性小于ScreenWidth
                {//如果窗体已经右贴边了并且鼠标在窗体内部，右贴边展开
                    this.Left = ScreenWidth - this.Width;//设置窗体的Left属性为ScreenWidth
                }
                else if (this.Right >= ScreenWidth && !(Win32API.PtInRect(ref Rects, mouse_pos)))
                {//当窗体的右边框与屏幕的右端的距离小于+5时，并且鼠标不在窗体内部，右贴边
                    this.Left = ScreenWidth - 5;//将窗体隐藏到屏幕的右端
                }
            }
            catch { }
        }

        Point mouseOff;//鼠标移动位置变量  
        bool leftFlag;//标志左键是否按下
 
        //鼠标按下
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouseOff = new Point(-e.X, -e.Y); //记下鼠标移动的偏移量
                    leftFlag = true;                  //点击左键按下时标注为true;  
                }
            }
            catch { }
        }
        //鼠标移动
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (leftFlag)
                {
                    Point mouseSet = Control.MousePosition;//获取鼠标的位置
                    mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置  
                    this.Location = mouseSet;//设置当前窗体的位置
                }
            }
            catch { }
        }
        //释放鼠标
        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;  
            }
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            try
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            }
            catch { }
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMin_Click(object sender, EventArgs e)//最小化
        {
            //将窗体最小化
            this.WindowState = FormWindowState.Minimized;
        }
       
        void InitialModel1()//初始化关机
        {
            try
            {
                int item = 0;
                //在小时下拉框添加(0~12)选项
                while (item <= 12)
                {
                    cbbHours1.Items.Add(item);
                    cbbHours1.SelectedIndex = 0;
                    item++;
                }
                //在分钟下拉框添加(0~59)选项
                for (item = 0; item <= 0x3b; item++)
                {
                    cbbMins1.Items.Add(item);
                    cbbMins1.SelectedIndex = 0;
                }
                //在秒下拉框添加(0~59)选项
                for (item = 0; item <= 0x3b; item++)
                {
                    cbbSeconds1.Items.Add(item);
                    cbbSeconds1.SelectedIndex = 0;
                }
            }
            catch { }

        }
        
        private void Cmd(string str)//命令函数
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";//调用cmd.exe程序
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardInput = true;//重定向标准输入
                    process.StartInfo.RedirectStandardOutput = true;//重定向标准输出
                    process.StartInfo.RedirectStandardError = true;//重定向标准出错
                    process.StartInfo.CreateNoWindow = true;//不显示黑窗口
                    process.Start();//开始调用执行
                    process.StandardInput.WriteLine(str + "&exit");//标准输入str + "&exit"，相等于在cmd黑窗口输入str + "&exit"
                    process.StandardInput.AutoFlush = true;//刷新缓冲流，执行缓冲区的命令，相当于输入命令之后回车执行
                    process.WaitForExit();//等待退出
                    process.Close();//关闭进程
                }
            }
            catch
            {
            }
        }
       
        private void btnSure1_Click(object sender, EventArgs e)//关机确定
        {
            try
            {
                string strHour = cbbHours1.Items[cbbHours1.SelectedIndex].ToString();//小时
                string strMin = cbbMins1.Items[cbbMins1.SelectedIndex].ToString();//分钟
                string strSec = cbbSeconds1.Items[cbbSeconds1.SelectedIndex].ToString();//秒数
                if (((cbbHours1.SelectedIndex != 0) || (cbbMins1.SelectedIndex != 0)) || (cbbSeconds1.SelectedIndex != 0))
                {
                    this.Cmd("shutdown -a");//取消之前的关机任务
                    //组织关机命令
                    string strCmd = "shutdown -s -t " + (((((Convert.ToInt32(strHour) * 60) * 60) + (Convert.ToInt32(strMin) * 60)) + Convert.ToInt32(strSec))).ToString();
                    this.Cmd(strCmd);//调用cmd执行命令
                    //弹出消息框告知用户
                    MessageBox.Show("计算机将在" + strHour + "小时" + strMin + "分" + strSec + "秒后关机");
                }
                else
                {
                    MessageBox.Show("选择无效！");
                }
            }
            catch { }

        }
       
        private void btnCancel1_Click(object sender, EventArgs e)//取消关机
        {
            this.Cmd("shutdown -a");//调用cmd执行取消关机命令
        }

        void InitialRset()//初始化重启模式
        {
            try
            {
                int item = 0;
                //在小时下拉框添加(0~12)选项
                while (item <= 12)
                {
                    cbbHoursRset.Items.Add(item);
                    cbbHoursRset.SelectedIndex = 0;
                    item++;
                }
                //在分钟下拉框添加(0~59)选项
                for (item = 0; item <= 0x3b; item++)
                {
                    cbbMinsRset.Items.Add(item);
                    cbbMinsRset.SelectedIndex = 0;
                }
                //在秒下拉框添加(0~59)选项
                for (item = 0; item <= 0x3b; item++)
                {
                    cbbSecondsRset.Items.Add(item);
                    cbbSecondsRset.SelectedIndex = 0;
                }
            }
            catch { }

        }

        private void btnSureRset_Click(object sender, EventArgs e)//确认重启
        {
            try
            {
                //获取用户选择的时间
                string strHour = cbbHoursRset.Items[cbbHoursRset.SelectedIndex].ToString();//小时
                string strMin = cbbMinsRset.Items[cbbMinsRset.SelectedIndex].ToString();//分钟
                string strSec = cbbSecondsRset.Items[cbbSecondsRset.SelectedIndex].ToString();//秒

                this.Cmd("shutdown -a");//取消之前的关机任务
                //根据用户的选择组织关机命令
                string strCmd = "shutdown -r -t " + (((((Convert.ToInt32(strHour) * 60) * 60) + (Convert.ToInt32(strMin) * 60)) + Convert.ToInt32(strSec))).ToString();
                this.Cmd(strCmd);//调用cmd执行重启命令
                //弹出消息框告知用户
                MessageBox.Show("计算机将在" + strHour + "小时" + strMin + "分" + strSec + "秒后重启");
            }
            catch { }

        }

        private void BtnCancelRset_Click(object sender, EventArgs e)//取消重启
        {
            this.Cmd("shutdown -a");//取消关机任务
        }


        void InitialModel2()//初始化固定时间关机
        {
            try
            {
                int num;
                this.cbbMonths.Items.Clear();//清空月份下拉框
                //在月份下拉框添加1~12
                for (num = 1; num <= 12; num++)
                {
                    cbbMonths.Items.Add(num);

                }
                //默认选择当前月
                cbbMonths.SelectedIndex = DateTime.Now.Month - 1;

                this.cbbHours2.Items.Clear();//清空小时下拉框
                //在小时下拉框添加0~23
                for (num = 0; num <= 0x17; num++)
                {
                    this.cbbHours2.Items.Add(num);

                }

                //默认选择当前小时
                cbbHours2.SelectedIndex = DateTime.Now.Hour;

                this.cbbMins2.Items.Clear();//清空分钟下拉框、
                //在月份下拉框添加0~59
                for (num = 0; num <= 0x3b; num++)
                {
                    this.cbbMins2.Items.Add(num);

                }
                //默认选择当前秒
                cbbMins2.SelectedIndex = DateTime.Now.Minute;
                SetDay();//根据用户选择的月份选择天数(月份的天数有差异，有润平年之分)
            }
            catch { }

        }


        void SetDay()//设置关机天数
        {
            try
            {
                int num;
                this.cbbDays.Items.Clear();//清空天数下拉框
                switch ((cbbMonths.SelectedIndex + 1))
                {
                    case 1://1 3 5 7 8 10 12 月有31天
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12: for (num = 1; num <= 31; num++)
                        {
                            cbbDays.Items.Add(num);

                        }
                        break;
                    case 4://4 6 9 11月有30天
                    case 6:
                    case 9:
                    case 11: for (num = 1; num <= 30; num++)
                        {
                            cbbDays.Items.Add(num);

                        }
                        break;
                    case 2: for (num = 1; num <= 28; num++)//2月至少有28天
                        {
                            cbbDays.Items.Add(num);

                        }

                        //闰年 2月 有29天
                        if (((Convert.ToInt32(DateTime.Now.Year) % 400) == 0) || (((Convert.ToInt32(DateTime.Now.Year) % 4) == 0) && ((Convert.ToInt32(DateTime.Now.Year) % 100) != 0)))
                        {
                            cbbDays.Items.Add(0x1d);//再加1天
                        }
                        break;
                    default: break;
                }

                if (Convert.ToInt32(DateTime.Now.Day) > cbbDays.Items.Count)
                {//当前天数大于可选天数，设置为27
                    cbbDays.SelectedIndex = 27;
                }
                else
                {
                    //默认选为当前天数
                    cbbDays.SelectedIndex = Convert.ToInt32(DateTime.Now.Day) - 1;
                }
            }
            catch { }
        }

        private void cbbMonths_SelectedIndexChanged(object sender, EventArgs e)//当月数改变天数随之改变
        {
            SetDay();
        }

        private DateTime GetDTime()//获取设置固定关机时间
        {
            try
            {
                string strYear = Convert.ToString(DateTime.Now.Year);
                string strMouth = this.cbbMonths.Items[this.cbbMonths.SelectedIndex].ToString();
                string strDay = this.cbbDays.Items[this.cbbDays.SelectedIndex].ToString();
                string strHour = this.cbbHours2.Items[this.cbbHours2.SelectedIndex].ToString();
                string strMin = this.cbbMins2.Items[this.cbbMins2.SelectedIndex].ToString();
                //跨年处理
                if ((DateTime.Now.Month == 12) && (this.cbbMonths.SelectedIndex == 0))
                {
                    strYear = (DateTime.Now.Year + 1).ToString();
                }
                //返回设置的时间
                return Convert.ToDateTime(strYear + "-" + strMouth + "-" + strDay + " " + strHour + ":" + strMin + ":00");
            }
            catch
            {
                return DateTime.Now;//返回当前时间
            }

        }

        private double DateDiff(DateTime DateTime1, DateTime DateTime2)//计算关机秒数
        {
            try
            {
                if (DateTime1 <= DateTime2)//关机时间必须是大于当前时间
                {
                    return 0.0;
                }
                //返回记录关机的秒数
                return DateTime1.Subtract(DateTime2).Duration().TotalSeconds;
            }
            catch
            {
                return -1.0;
            }
        }

        private void btnSure2_Click(object sender, EventArgs e)//固定时间关机确定
        {
            try
            {
                this.Cmd("shutdown -a");//取消之前的关机任务
                DateTime dTime = this.GetDTime();//获取关机时间
                double sec = this.DateDiff(dTime, DateTime.Now);//获取离关机还有多少秒
                //关机时间分为2秒~3天
                if ((sec > 2.0) && (sec < 259200.0))
                {
                    this.Cmd("shutdown -a");//取消之前的关机任务
                    //执行关机命令
                    this.Cmd("shutdown -s -t " + Convert.ToInt32(sec.ToString().Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries)[0]).ToString());
                    //弹出消息框提示用户
                    MessageBox.Show("计算机将于" + this.GetDTime().ToString() + "关机");
                }
                else
                {
                    MessageBox.Show("选择无效！！！");
                }

            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)// 固定时间关机取消
        {
            Cmd("shutdown -a");//取消关机任务
        }
        /// <summary>
        /// 当选项卡为模式2时，重置时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)//当选项卡为模式2时，重置时间
        {
            if (tabControl1.SelectedIndex == 1)
            {
                InitialModel2();
            }
        }

        private void cbbSeconds1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    class Win32API //拖动接口
    {
        [DllImport("User32.dll")]
        public static extern bool PtInRect(ref Rectangle r, Point p);
    
    }

}
