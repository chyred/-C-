using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class timer1 : Form
    {
        System.DateTime TimeNow = new DateTime();
        TimeSpan TimeCount = new TimeSpan();
        public timer1()
        {
            InitializeComponent();
            textBox1.Height = 60;
        }

        private void timer1_Load(object sender, EventArgs e)
        {
            MyTimer.Interval = 1000;
        }

        public void Close()
        {
            this.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MyTimer.Start();
            TimeNow = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyTimer.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeCount = DateTime.Now - TimeNow;
            textBox1.Text = string.Format("{0:00}:{1:00}:{2:00}", TimeCount.Hours, TimeCount.Minutes, TimeCount.Seconds);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == null|| textBox3.Text == null)
                MessageBox.Show("请输入您需要提醒的时间！");
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Enabled = true;
            timer.Interval = 30000;//执行间隔时间,单位为毫秒    
            timer.Start();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(Timer1_Elapsed);
            set.timeout = 1;
            MessageBox.Show("提醒事件已设立！");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {

        }
        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            int intHour = e.SignalTime.Hour;
            int intMinute = e.SignalTime.Minute;
            // System.Windows.Forms.MessageBox.Show(intSecond.ToString());
            int hour = Convert.ToInt32(textBox2.Text);
            int minutes = Convert.ToInt32(textBox3.Text);
            if (intHour == hour && intMinute == minutes&&set.timeout==1)
            {
                MessageBox.Show(textBox4.Text);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            set.timeout = 0;
            MessageBox.Show("已取消设立的提醒事件!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
