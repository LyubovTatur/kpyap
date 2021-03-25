using System;
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
    public partial class Form1 : Form
    {
        
        Point startPoint =  new Point(-1,-1);
        // Point endPoint = new Point(-1, -1);
        string state = "none";
        Pen pen = new Pen(Color.Black, 5);
        SolidBrush brush = new SolidBrush(Color.Pink);
        string text = "";
        Bitmap bitmap = null;
        Bitmap tempLayer;
        Bitmap copyBitmap;
        public void  SetText(string user_text)
        {
            text = user_text;

        }

        public Form1()
        {
            InitializeComponent();
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            bitmap = new Bitmap(1980,1080);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.MdiParent = this;
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.MouseDown+=pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            f.Controls.Add(pictureBox);
            f.Show();
            
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {

            if (sender is PictureBox pictureBox)
            {

                Graphics graphics = Graphics.FromImage(bitmap);
                switch (state)
                {
                    case "draw":
                        startPoint = new Point(-1, -1);
                        break;
                    case "line":
                        graphics.DrawLine(pen, startPoint, e.Location);
                        break;
                    case "polyline":
                        break;
                    case "empty circle":
                        graphics.DrawEllipse(pen, startPoint.X,startPoint.Y, Math.Abs(startPoint.X-e.X), Math.Abs(startPoint.Y-e.Y));
                        break;
                    case "filled circle":
                        graphics.FillEllipse(brush, startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                        graphics.DrawEllipse(pen, startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                        break;
                    case "filled rectangle":
                        graphics.FillRectangle(brush, startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                        graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                        break;
                    case "empty rectangle":
                        graphics.DrawRectangle(pen, startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                        break;
                    case "bg text":
                        break;
                    case "empty text":
                        graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        //graphics.MeasureString();


                        break;
                    case "copy":
                        Bitmap bmp = new Bitmap(pictureBox.Image);
                        //bitmap = new Bitmap(bmp.Clone(new Rectangle(startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y)), System.Drawing.Imaging.PixelFormat.Format32bppArgb));
                        copyBitmap = bmp.Clone(new Rectangle(startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y)),System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                        break;

                    case "paste":
                        break;
                    case "none":
                        break;
                    default:
                        MessageBox.Show("Ошибка.");
                        break;
                }
                state = "none";
                //  Bitmap booba = new Bitmap(pictureBox.Width, pictureBox.Height,  graphics);
                //  pictureBox.Image = booba;
                pictureBox.Image = bitmap;

            }


        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                switch (state)
                {
                    case "draw":
                        graphics.DrawLine(pen, startPoint, e.Location);
                        pictureBox.Image = bitmap;
                        startPoint = e.Location;
                        break;
                    case "line":
                        if (e.Button == MouseButtons.Left)
                        {
                            tempLayer = new Bitmap(pictureBox.Width, pictureBox.Height);
                            Graphics tempGraphics = Graphics.FromImage(tempLayer);
                            tempGraphics.Clear(Color.Empty);
                            tempGraphics.DrawLine(pen, startPoint, e.Location);
                            tempGraphics.DrawImage(bitmap,0,0);
                            pictureBox.Image = tempLayer;

                        }
                        break;
                    case "polyline":
                        break;
                    case "empty circle":
                        if (e.Button == MouseButtons.Left)
                        {
                            tempLayer = new Bitmap(pictureBox.Width, pictureBox.Height);
                            Graphics tempGraphics = Graphics.FromImage(tempLayer);
                            tempGraphics.Clear(Color.Empty);
                            tempGraphics.DrawEllipse(pen, startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                            tempGraphics.DrawImage(bitmap, 0, 0);
                            pictureBox.Image = tempLayer;

                        }
                        break;
                    case "filled circle":
                        if (e.Button == MouseButtons.Left)
                        {
                            tempLayer = new Bitmap(pictureBox.Width, pictureBox.Height);
                            Graphics tempGraphics = Graphics.FromImage(tempLayer);
                            tempGraphics.Clear(Color.Empty);
                            tempGraphics.DrawImage(bitmap, 0, 0);
                            tempGraphics.FillEllipse(brush, startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                            tempGraphics.DrawEllipse(pen, startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                            pictureBox.Image = tempLayer;
                        }
                        break;
                    case "filled rectangle":
                        if (e.Button == MouseButtons.Left)
                        {
                            tempLayer = new Bitmap(pictureBox.Width, pictureBox.Height);
                            Graphics tempGraphics = Graphics.FromImage(tempLayer);
                            tempGraphics.Clear(Color.Empty);
                            tempGraphics.DrawImage(bitmap, 0, 0);
                            tempGraphics.FillRectangle(brush, startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                            tempGraphics.DrawRectangle(pen, startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                            pictureBox.Image = tempLayer;
                        }
                        break;
                    case "empty rectangle":
                        if (e.Button == MouseButtons.Left)
                        {
                            tempLayer = new Bitmap(pictureBox.Width, pictureBox.Height);
                            Graphics tempGraphics = Graphics.FromImage(tempLayer);
                            tempGraphics.Clear(Color.Empty);
                            tempGraphics.DrawImage(bitmap, 0, 0);
                            //tempGraphics.DrawRectangle(pen, startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                            tempGraphics.DrawRectangle(pen, startPoint.X, startPoint.Y, e.X - startPoint.X , e.Y - startPoint.Y  );
                            pictureBox.Image = tempLayer;
                        }
                        break;
                    case "bg text":
                        break;
                    case "empty text":
                        break;

                    case "copy":
                        if (e.Button == MouseButtons.Left)
                        {
                            tempLayer = new Bitmap(pictureBox.Width, pictureBox.Height);
                            Graphics tempGraphics = Graphics.FromImage(tempLayer);
                            tempGraphics.Clear(Color.Empty);
                            tempGraphics.DrawImage(bitmap, 0, 0);
                            //tempGraphics.DrawRectangle(pen, startPoint.X, startPoint.Y, Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                            tempGraphics.DrawRectangle(new Pen(Color.Black, 0.5f), startPoint.X-1, startPoint.Y-1, e.X - startPoint.X + 1, e.Y - startPoint.Y+1);
                            pictureBox.Image = tempLayer;
                        }
                        break;

                    case "paste":
                        break;
                    case "none":

                        break;
                    default:
                        MessageBox.Show("Ошибка.");
                        break;
                }






            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                startPoint = e.Location;
                if (pictureBox.Image == null)
                {
                    bitmap = new Bitmap(1920, 1080);
                }
                else
                {
                    bitmap = new Bitmap(pictureBox.Image);

                }
                Graphics graphics = Graphics.FromImage(bitmap);
                switch (state)
                {
                    case "draw":
                        break;
                    case "line":

                        break;
                    case "polyline":
                        break;
                    case "empty circle":

                        break;
                    case "filled circle":
                        break;
                    case "filled rectangle":
                        break;
                    case "empty rectangle":
                        break;
                    case "bg text":
                        graphics.FillRectangle(brush,new RectangleF( new PointF( startPoint.X, startPoint.Y), graphics.MeasureString(text, new Font("Arial", 14))));
                        graphics.DrawString(text, new Font("Arial", 14), pen.Brush, e.Location);

                        break;
                    case "empty text":
                        //Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                        //for (int i = pictureBox.Controls.Count-1; i >= 0; i--)
                        //{
                        //    Control control = pictureBox.Controls[i];
                        //    control.DrawToBitmap(bmp, new Rectangle(control.Location.X, control.Location.Y, control.Width, control.Height));
                        //}

                        graphics.DrawString(text,new Font("Arial", 14),pen.Brush, e.Location);
                        break;

                    case "copy":

                        break;
                    case "paste":
                        graphics.DrawImage(copyBitmap,e.Location);
                        break;
                    case "none":
                        state = "draw";
                        break;
                    default:
                        MessageBox.Show("Ошибка.");
                        break;
                }

                pictureBox.Image = bitmap;




            }

        }

        private void closwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            } 
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in MdiChildren)
            {
                item.Close();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = "line";            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = "polyline";

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void brushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pen.Color = colorDialog1.Color;
            
        }

        private void filledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = "filled circle";
        }

        private void emptyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = "empty circle";
        }

        private void additionalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            colorDialog1.ShowDialog();
            brush.Color = colorDialog1.Color;
        }

        private void filledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            state = "filled rectangle";
        }

        private void emptyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            state = "empty rectangle";
        }

        private void withBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            state = "empty text";
            TextHandler th = new TextHandler(this);
            th.Show();
        }

        private void withBackgroundToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            state = "bg text";

            TextHandler th = new TextHandler(this);
            th.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            state = "copy";
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            state = "paste";

        }

        private void prewiitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (ActiveMdiChild.Controls[0] is PictureBox pictureBox)
                {
                    Graphics g = pictureBox.CreateGraphics();
                }
                    
            }
        }
    }
}
