
namespace lab21
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "красный";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(39, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "жёлтый";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(39, 125);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "зеленый";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(39, 164);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "синий";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(52, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 208);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "цвет фона";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Location = new System.Drawing.Point(52, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 215);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "цвет кнопки";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(269, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "я милая";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(269, 110);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 21);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "или нет";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(269, 137);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 21);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "или да";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(269, 164);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(112, 21);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "для кого как";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(414, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Выбери кнопку";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(535, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(57, 118);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(86, 21);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "зеленый";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(57, 36);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(85, 21);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "красный";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(57, 75);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(79, 21);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "жёлтый";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(57, 157);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(68, 21);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "синий";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "секреты";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(424, 358);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 488);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Имя Фамилия";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}

