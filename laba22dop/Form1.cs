using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba22dop
{
    public partial class Form1 : Form
    {
        int step;
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                step =  100/(int.Parse(textBox2.Text) - int.Parse(textBox1.Text));
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private void StartCompile()
        {

            for (int i = 2; i < 10000; i++)
            {
                if (IsSimple(i))
                {
                    listBox1.Items.Add(i);
                }
            }
        }
        private bool IsSimple(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num%i ==0)
                {
                    return false;
                }
            }
            return true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = int.Parse(textBox1.Text); i < int.Parse(textBox2.Text); i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    if (IsSimple(i))
                    {
                        worker.ReportProgress(i);
                    }
                    System.Threading.Thread.Sleep(1);

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            
                progressBar1.Value = 100;
            

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            listBox1.Items.Add(e.ProgressPercentage);
            progressBar1.Value = e.ProgressPercentage;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
