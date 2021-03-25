using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Visible = true;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Visible = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Green;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Blue;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Ура?");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            changecolorofbutton(Color.Red);
        }
        private void changecolorofbutton(Color color)
        {
            switch (comboBox1.SelectedIndex)
            {
                case -1:
                    button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = color;
                    break;
                case 0:
                    button1.BackColor = color;

                    break;
                case 1:
                    button2.BackColor = color;

                    break;
                case 2:
                    button3.BackColor = color;

                    break;
                case 3:
                    button4.BackColor = color;
                    break;
                default:
                    break;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            changecolorofbutton(Color.Yellow);

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            changecolorofbutton(Color.Green);

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            changecolorofbutton(Color.Blue);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showbutton(button1);
                }

        private void button2_Click(object sender, EventArgs e)
        {
            showbutton(button2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            showbutton(button3);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            showbutton(button4);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void showbutton(Button button)
        {

            if (button.BackColor == Color.Red)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (button.BackColor == Color.Yellow)
            {
                MessageBox.Show("Warning", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (button.BackColor == Color.Green)
            {
                MessageBox.Show("Info", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (button.BackColor == Color.Blue)
            {
                MessageBox.Show("Ques", "Ques", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }

        }

        private void button5_Click(object sender, EventArgs e)
        { 
            button1.BackColor = Color.White; button2.BackColor = Color.White; button3.BackColor = Color.White; button4.BackColor  = Color.White;
            radioButton1.Checked = false; radioButton2.Checked = false; radioButton3.Checked = false; radioButton4.Checked = false; radioButton5.Checked = false; radioButton6.Checked = false; radioButton7.Checked = false; radioButton8.Checked = false;
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Выберите кнопку";
            checkBox1.Checked = false;
            checkBox2.Visible = false; checkBox2.Checked = false; checkBox3.Visible = false; checkBox3.Checked = false; checkBox4.Visible = false; checkBox4.Checked = false;


            this.BackColor = Color.White ;
          





        }
    }
}
