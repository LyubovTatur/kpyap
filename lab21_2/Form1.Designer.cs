
namespace lab21_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "команда2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "команда1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ready!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(277, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "команда1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 71);
            this.button2.TabIndex = 3;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 71);
            this.button3.TabIndex = 4;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(536, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "команда2";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 66);
            this.button5.TabIndex = 6;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(125, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 66);
            this.button4.TabIndex = 5;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 185);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Имя Фамилия";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

