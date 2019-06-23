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
    public partial class basic_setting : Form
    {
        public event Changeform settingshow;
        public basic_setting()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            settingshow(true);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true && this.checkBox2.Checked == true)
            {
                MessageBox.Show("请选择开机启动与否!");
            }
            else if(this.checkBox1.Checked == false && this.checkBox2.Checked == false)
            {
                MessageBox.Show("请选择开机启动与否!");
            }
            else if(this.checkBox1.Checked == true && this.checkBox2.Checked == false)
            {
                set.open = 0;
            }
            else if (this.checkBox1.Checked == false && this.checkBox2.Checked == true)
            {
                set.open = 1;
            }

            if (radioButton1.Checked == true)
            {
                set.active = 0;
            }
            else if (radioButton2.Checked == true)
            {
                set.active = 1;
            }
            else if (radioButton3.Checked == true)
            {
                set.active = 2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            checkBox1.Checked = true;
            checkBox2.Checked = false;
        }
        public void Close()
        {
            this.Dispose();
        }
        private void basic_setting_Load(object sender, EventArgs e)
        {

        }
    }
}
