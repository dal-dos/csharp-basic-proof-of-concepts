using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Return(int num)
        {
            num = num + 1;
            return num;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 1;
            listBox1.Items.Add(num1);
            Return(num1);
            listBox1.Items.Add(num1);
        }

        private void Default(int num, int num1 = 1)
        {
            listBox1.Items.Add(num);
            listBox1.Items.Add(num1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Default(1);

            Default(1, 2);

        }

        private void Reference(ref int num)
        {
            num = num + 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = 5;
            Reference(ref num1);
            listBox1.Items.Add(num1);
        }

        private void Value(int num)
        {
            num = num + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            Value(num1);
            //the original stays the same in passbyval
        }
    }
}
