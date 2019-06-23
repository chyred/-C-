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
    public partial class Light : Form
    {
        public delegate void SendMessage(object sender, string message);
        public event SendMessage MessageSent;
        public Light()
        {
            InitializeComponent();
            trackBar1.Maximum = 220;
            trackBar1.Minimum = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "-")
                return;
            int x;
            bool result = int.TryParse(textBox1.Text, out x);
            if (result)
            {
                if (x > trackBar1.Maximum)
                {
                    textBox1.Text = trackBar1.Maximum.ToString();
                    trackBar1.Value = trackBar1.Maximum;
                }
                else if (x < trackBar1.Minimum)
                {
                    textBox1.Text = trackBar1.Minimum.ToString();
                    trackBar1.Value = trackBar1.Minimum;
                }
                else
                {
                    trackBar1.Value = int.Parse(textBox1.Text);
                }
            }
            else
            {
                MessageBox.Show("请不要输入非数字字符");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.MessageSent != null)
                MessageSent(this, textBox1.Text);
            this.Close();
        }

        private void Light_Load(object sender, EventArgs e)
        {

        }
    }
}
