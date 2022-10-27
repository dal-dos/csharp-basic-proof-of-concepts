using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparing_and_Converting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word1 = textBox1.Text.Trim();
            string word2 = textBox2.Text.Trim();

            listBox1.Items.Add(string.CompareOrdinal(word1, word2));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string word1 = textBox1.Text.Trim();
            string word2 = textBox2.Text.Trim();

            listBox1.Items.Add(string.Compare(word1, word2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string word1 = textBox1.Text.Trim();
                string word2 = textBox2.Text.Trim();
                int ans;
                listBox1.Items.Add(int.Parse(word1) * int.Parse(word2));
            }
            catch
            {
                listBox1.Items.Add("enter numbers");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string word1 = textBox1.Text.Trim();
            string word2 = textBox2.Text.Trim();

            if(int.TryParse(word1, out int result1) && int.TryParse(word2, out int result2))
            {
                listBox1.Items.Add(result1 + " " + result2);
            }
            else
            {
                listBox1.Items.Add("enter numbers");
            }
        }
    }
}
