﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab23
{
    public partial class TextHandler : Form
    {
        Form1 form;
        public TextHandler(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.SetText(textBox1.Text);
            Close();
        }
    }
}
