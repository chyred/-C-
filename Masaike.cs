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
    public partial class Masaike : Form
    {
        public delegate void SendMessage1(object sender, string message1);
        public delegate void SendMessage2(object sender, string message2);
        public delegate void SendMessage3(object sender, string message3);
        public delegate void SendMessage4(object sender, string message4);
        public event SendMessage1 MessageSent1;
        public event SendMessage2 MessageSent2;
        public event SendMessage3 MessageSent3;
        public event SendMessage4 MessageSent4;
        public Masaike()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(textBox1.Text)> Convert.ToInt32(textBox2.Text)|| Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox3.Text) || Convert.ToInt32(textBox3.Text) > Convert.ToInt32(textBox4.Text))
            {
                MessageBox.Show("请输入指定范围内的数字");
            }
            else
            {
                if (this.MessageSent1 != null)
                    MessageSent1(this, textBox1.Text);
                if (this.MessageSent2 != null)
                    MessageSent2(this, textBox2.Text);
                if (this.MessageSent3 != null)
                    MessageSent3(this, textBox3.Text);
                if (this.MessageSent4 != null)
                    MessageSent4(this, textBox4.Text);
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int x;
            bool result = int.TryParse(textBox1.Text, out x);
            if (result)
            {
                if (x > 329)
                {
                    textBox1.Text = Convert.ToString(329);
                }
                else if (x < 0)
                {
                    textBox1.Text = Convert.ToString(0);
                }
            }
            else
            {
                MessageBox.Show("请不要输入非数字字符");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int x;
            bool result = int.TryParse(textBox2.Text, out x);
            if (result)
            {
                if (x > 329)
                {
                    textBox2.Text = Convert.ToString(329);
                }
                else if (x < 0)
                {
                    textBox2.Text = Convert.ToString(0);
                }
            }
            else
            {
                MessageBox.Show("请不要输入非数字字符");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int x;
            bool result = int.TryParse(textBox3.Text, out x);
            if (result)
            {
                if (x > 369)
                {
                    textBox3.Text = Convert.ToString(369);
                }
                else if (x < 0)
                {
                    textBox3.Text = Convert.ToString(0);
                }
            }
            else
            {
                MessageBox.Show("请不要输入非数字字符");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int x;
            bool result = int.TryParse(textBox4.Text, out x);
            if (result)
            {
                if (x > 369)
                {
                    textBox4.Text = Convert.ToString(369);
                }
                else if (x < 0)
                {
                    textBox4.Text = Convert.ToString(0);
                }
            }
            else
            {
                MessageBox.Show("请不要输入非数字字符");
            }
        }

        private void Masaike_Load(object sender, EventArgs e)
        {

        }
    }
}
