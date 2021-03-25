using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab21_2
{
    public partial class Form1 : Form
    {
        Form2 form2;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalTrash.num1 = int.Parse(textBox1.Text);
            GlobalTrash.num2 = int.Parse(textBox2.Text);
            form2.label3.Text = GlobalTrash.num1.ToString();
            form2.label4.Text = GlobalTrash.num2.ToString();

            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalTrash.num1 += 1;
            form2.label3.Text = GlobalTrash.num1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalTrash.num1 -= 1;
            form2.label3.Text = GlobalTrash.num1.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GlobalTrash.num2 += 1;
            form2.label4.Text = GlobalTrash.num2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GlobalTrash.num2 -= 1;
            form2.label4.Text = GlobalTrash.num2.ToString();
        }
    }
}
