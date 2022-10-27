using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_and_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            if(num == 1 || num > 1 || num < 1 || num >= 1)
            {
                listBox1.Items.Add(num);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 0;
            if(num == 1)
            {
                listBox1.Items.Add(num);
            }
            else
            {
                listBox1.Items.Add(num + " else");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = 1;

            switch (num)
            {
                case 1:
                    listBox1.Items.Add(num);
                    break;

                default:
                    break;
            }
        }
    }
}
