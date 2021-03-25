
namespace lab23
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filledToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withBackgroundToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.picToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewiitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closwToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // closwToolStripMenuItem
            // 
            this.closwToolStripMenuItem.Name = "closwToolStripMenuItem";
            this.closwToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.closwToolStripMenuItem.Text = "Close";
            this.closwToolStripMenuItem.Click += new System.EventHandler(this.closwToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.textToolStripMenuItem,
            this.copyToolStripMenuItem1,
            this.picToolStripMenuItem,
            this.pasteToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cutToolStripMenuItem.Text = "Line";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filledToolStripMenuItem,
            this.emptyToolStripMenuItem});
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pasteToolStripMenuItem.Text = "Circle";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // filledToolStripMenuItem
            // 
            this.filledToolStripMenuItem.Name = "filledToolStripMenuItem";
            this.filledToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.filledToolStripMenuItem.Text = "Filled";
            this.filledToolStripMenuItem.Click += new System.EventHandler(this.filledToolStripMenuItem_Click);
            // 
            // emptyToolStripMenuItem
            // 
            this.emptyToolStripMenuItem.Name = "emptyToolStripMenuItem";
            this.emptyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.emptyToolStripMenuItem.Text = "Empty";
            this.emptyToolStripMenuItem.Click += new System.EventHandler(this.emptyToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filledToolStripMenuItem1,
            this.emptyToolStripMenuItem1});
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            // 
            // filledToolStripMenuItem1
            // 
            this.filledToolStripMenuItem1.Name = "filledToolStripMenuItem1";
            this.filledToolStripMenuItem1.Size = new System.Drawing.Size(134, 26);
            this.filledToolStripMenuItem1.Text = "Filled";
            this.filledToolStripMenuItem1.Click += new System.EventHandler(this.filledToolStripMenuItem1_Click);
            // 
            // emptyToolStripMenuItem1
            // 
            this.emptyToolStripMenuItem1.Name = "emptyToolStripMenuItem1";
            this.emptyToolStripMenuItem1.Size = new System.Drawing.Size(134, 26);
            this.emptyToolStripMenuItem1.Text = "Empty";
            this.emptyToolStripMenuItem1.Click += new System.EventHandler(this.emptyToolStripMenuItem1_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withBackgroundToolStripMenuItem,
            this.withBackgroundToolStripMenuItem1});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // withBackgroundToolStripMenuItem
            // 
            this.withBackgroundToolStripMenuItem.Name = "withBackgroundToolStripMenuItem";
            this.withBackgroundToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.withBackgroundToolStripMenuItem.Text = "Without background";
            this.withBackgroundToolStripMenuItem.Click += new System.EventHandler(this.withBackgroundToolStripMenuItem_Click);
            // 
            // withBackgroundToolStripMenuItem1
            // 
            this.withBackgroundToolStripMenuItem1.Name = "withBackgroundToolStripMenuItem1";
            this.withBackgroundToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.withBackgroundToolStripMenuItem1.Text = "With background";
            this.withBackgroundToolStripMenuItem1.Click += new System.EventHandler(this.withBackgroundToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // picToolStripMenuItem
            // 
            this.picToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brushToolStripMenuItem,
            this.additionalToolStripMenuItem});
            this.picToolStripMenuItem.Name = "picToolStripMenuItem";
            this.picToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.picToolStripMenuItem.Text = "Pick color";
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.brushToolStripMenuItem.Text = "Brush";
            this.brushToolStripMenuItem.Click += new System.EventHandler(this.brushToolStripMenuItem_Click);
            // 
            // additionalToolStripMenuItem
            // 
            this.additionalToolStripMenuItem.Name = "additionalToolStripMenuItem";
            this.additionalToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.additionalToolStripMenuItem.Text = "Additional";
            this.additionalToolStripMenuItem.Click += new System.EventHandler(this.additionalToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.pasteToolStripMenuItem1.Text = "Paste";
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.pasteToolStripMenuItem1_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.copyToolStripMenuItem.Text = "Poly Line";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prewiitToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // prewiitToolStripMenuItem
            // 
            this.prewiitToolStripMenuItem.Name = "prewiitToolStripMenuItem";
            this.prewiitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.prewiitToolStripMenuItem.Text = "Prewitt";
            this.prewiitToolStripMenuItem.Click += new System.EventHandler(this.prewiitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filledToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emptyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withBackgroundToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem picToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewiitToolStripMenuItem;
    }
}

