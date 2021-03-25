using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeValue(button2, label5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeValue(button8, label7);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeValue(button7, label6);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeValue(button6, label5);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeValue(button5, label8);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeValue(button4, label7);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeValue(button3, label6);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeValue(button9, label8);

        }
        private void ChangeValue(Button button, Label label)
        {
            if (button.Text == "+")
            {
                label.Text = (int.Parse(label.Text)+1).ToString();
            }
            else
            {
                if (label.Text!="0")
                {
                    label.Text = (int.Parse(label.Text) - 1).ToString();
                }

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {


                if (label5.Text == "0" && label6.Text == "0" && label7.Text == "0" && label8.Text == "0")
                {
                    MessageBox.Show("Выберите товары.");
                }
                else
                {
                    double Sum = 0;
                    richTextBox1.Text = $"Здравствуйте!\n 'Зоомагазин'\n ваши товары:\n ";
                    if (label5.Text != "0")
                    {
                        AddRich(label1.Text, label5.Text, label12.Text);
                        Sum += int.Parse(label5.Text) * int.Parse(label12.Text);
                    }
                    if (label6.Text != "0")
                    {
                        AddRich(label2.Text, label6.Text, label13.Text);
                        Sum += int.Parse(label6.Text) * int.Parse(label13.Text);

                    }
                    if (label7.Text != "0")
                    {
                        AddRich(label3.Text, label7.Text, label14.Text);
                        Sum += int.Parse(label7.Text) * int.Parse(label14.Text);

                    }
                    if (label8.Text != "0")
                    {
                        AddRich(label4.Text, label8.Text, label15.Text);
                        Sum += int.Parse(label8.Text) * int.Parse(label15.Text);

                    }
                    richTextBox1.Text += $"Сумма = {Sum} руб\n";
                    if (DateTime.Today.Hour > 9 && DateTime.Today.Hour < 15)
                    {
                        richTextBox1.Text += $"Скидка 3%\n";
                        Sum *= 0.97;
                    }
                    if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday || DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
                    {
                        richTextBox1.Text += $"Скидка 2%\n";
                        Sum *= 0.98;
                    }
                    Math.Round(Sum, 2);
                    richTextBox1.Text += $"Итого: {Sum} руб\n {DateTime.Today}\n Спасибо за покупку\n";
                }
            }

        }
        private void AddRich(string name, string amount, string price)
        {
            richTextBox1.Text += $"{name} {price} руб x{amount} шт ;\n";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text !="")
            {

                textBox1.Visible = true;
                label16.Visible = true;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "1111")
            {
                textBox1.Text = "";
                textBox1.Visible = false;
                label16.Visible = false;
                richTextBox1.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            button11.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            button10.Visible = false;
            button11.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
            saveFileDialog1.ShowDialog();
            System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            MessageBox.Show($"Ваш чек сохранен. \nПуть: {saveFileDialog1.FileName}");
        }
    }
}
