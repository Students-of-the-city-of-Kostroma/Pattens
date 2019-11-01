using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Xml.Serialization;

namespace pnt
{
    public partial class Form1 : Form
    {
        delegate void Rendering(Panel obj);

        Rendering rnd;
        List<Square> listSquare = new List<Square>();//Список хранящий в себе все Square.
        List<Ellipse> listEllipse = new List<Ellipse>();//Cписок хранящий в себе все Ellipse.
        List<Pencil> listPencil = new List<Pencil>();//Список хранящий в сеье все точки для Pen.

        private int Key = 1; //Ключ для действия
        private bool check = false; // true если ветется действие
        // 1-Карандаш
        // 2-Квадрат
        // 3-Эллипс
        // 4-Стерка
        // 5-
        //Graphics p;
        Graphics g;
        Point prev;  //предыдущая координата
        Point cur;  //Текущая координата
        Color clr = Color.Black;  //Цвет по умолчанию черный
        //private int x = 0;  //Переменные для отрисовки
        //private int y = 0;

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            //p = panel1.CreateGraphics();
            rnd = DrawPencilFromArray;
            rnd += DrawEllipseFromArray;
            rnd += DrawRectangleFromArray;
        }

        //-----------------------------
        private void drawPanelPen(float width = 1)
        {

            Pen pen = new Pen(clr, trackBar1.Value);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            pen.LineJoin = LineJoin.Round;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawLine(pen, cur, prev);
            listPencil.Add(new Pencil(cur, prev, clr, trackBar1.Value));
        }

        private void drawPanelRectangle(float width = 1)
        {
            Pen pen = new Pen(clr, width);
            float wd = Math.Abs(cur.X - prev.X);
            float hd = Math.Abs(cur.Y - prev.Y);
            int x = cur.X > prev.X ? prev.X : cur.X;
            int y = cur.Y > prev.Y ? prev.Y : cur.Y;
            g.DrawRectangle(pen, x, y, wd, hd);
            listSquare.Add(new Square(new Point(x, y), wd, hd, clr, trackBar1.Value));
            //Pen pen = new Pen(clr, trackBar1.Value);
            //float wd = Math.Abs(cur.X - prev.X);
            //float hd = Math.Abs(cur.Y - prev.Y);
            //int x = cur.X > prev.X ? prev.X : cur.X;
            //int y = cur.Y > prev.Y ? prev.Y : cur.Y;
            //g.DrawRectangle(pen, x, y, wd, hd);
            ////g.DrawRectangle(new Pen(clr, trackBar1.Value), e.X < cur.X ? e.X : cur.X, e.Y < cur.Y ? e.Y : cur.Y, Math.Abs(cur.X - e.X), Math.Abs(cur.Y - e.Y));

            //listSquare.Add(new Square(new Point(x, y), wd, hd, clr, trackBar1.Value));
        }

        private void drawPanelErase()
        {
            Pen pen = new Pen(Color.White, 50);
            g.DrawLine(pen, cur, prev);
        }

        private void drawPanelElipse(float width = 1)
        {
            Pen pen = new Pen(clr, trackBar1.Value);
            float wd = Math.Abs(cur.X - prev.X);
            float hd = Math.Abs(cur.Y - prev.Y);
            int x = cur.X > prev.X ? prev.X : cur.X;
            int y = cur.Y > prev.Y ? prev.Y : cur.Y;
            g.DrawEllipse(pen, x, y, wd, hd);

            listEllipse.Add(new Ellipse(new Point(x, y), wd, hd, clr, width));
        }
        //-----------------------------
        private void pencil_Click(object sender, EventArgs e)
        {
            Key = 1;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            check = true;
            prev = e.Location;
            cur = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (check)
            {
                switch (Key) 
                {
                    case 1:
                        {
                            //prev = cur;
                            //cur = e.Location;
                            //g.DrawLine(new Pen(clr,trackBar1.Value), prev, cur);
                            //listPencil.Add(new Pencil(cur, prev, clr, trackBar1.Value));
                            //return;
                            prev = cur;
                            cur = e.Location;
                            drawPanelPen(trackBar1.Value); break;
                        }
                    //case 2:
                    //    {
                    //        //p.DrawRectangle(new Pen(Color.White, trackBar1.Value), prev.X, prev.Y, x, y);
                    //        //p.DrawRectangle(new Pen(clr, trackBar1.Value), e.X < cur.X ? e.X : cur.X, e.Y < cur.Y ? e.Y : cur.Y, Math.Abs(cur.X - e.X), Math.Abs(cur.Y - e.Y));
                    //        //p.Clear(Color.White);
                    //        g.DrawRectangle(new Pen(clr, trackBar1.Value), e.X < cur.X ? e.X : cur.X, e.Y < cur.Y ? e.Y : cur.Y, Math.Abs(cur.X - e.X), Math.Abs(cur.Y - e.Y));
                    //        //prev.X = e.X < cur.X ? e.X : cur.X;
                    //        //prev.Y = e.Y < cur.Y ? e.Y : cur.Y;
                    //        //x = Math.Abs(cur.X - e.X);
                    //        //y= Math.Abs(cur.Y - e.Y);
                    //        return;
                    //    }
                    //case 3:
                    //    {
                    //        g.DrawEllipse(new Pen(Color.White, trackBar1.Value), prev.X, prev.Y, x, y);
                    //        g.DrawEllipse(new Pen(clr, trackBar1.Value), e.X < cur.X ? e.X : cur.X, e.Y < cur.Y ? e.Y : cur.Y, Math.Abs(cur.X - e.X), Math.Abs(cur.Y - e.Y));
                            
                    //        prev.X = e.X < cur.X ? e.X : cur.X;
                    //        prev.Y = e.Y < cur.Y ? e.Y : cur.Y;
                    //        x = Math.Abs(cur.X - e.X);
                    //        y = Math.Abs(cur.Y - e.Y);
                    //        return;
                    //    }
                    case 4:
                        {
                            prev = cur;
                            cur = e.Location;
                            g.DrawLine(new Pen(Color.White,20), prev, cur);
                            return;
                        }
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            //x = 0;
            check = false;
            switch (Key)
            {
                case 2:
                    {
                        drawPanelRectangle(trackBar1.Value);
                        //g.DrawRectangle(new Pen(clr, trackBar1.Value), e.X < cur.X ? e.X : cur.X, e.Y < cur.Y ? e.Y : cur.Y, Math.Abs(cur.X-e.X), Math.Abs(cur.Y - e.Y));
                        break;
                    }
                case 3:
                    {
                        g.DrawEllipse(new Pen(clr, trackBar1.Value), e.X < cur.X ? e.X : cur.X, e.Y < cur.Y ? e.Y : cur.Y, Math.Abs(cur.X - e.X), Math.Abs(cur.Y - e.Y));                    
                        break;
                    }
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            Key = 2;
            
            //g.DrawRectangle(new Pen(Color.Black),)
        }

        private void ellips_Click(object sender, EventArgs e)
        {
            Key = 3;
        }

        private void erase_Click(object sender, EventArgs e)
        {
            Key = 4;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("Уверены?", "Подтверждение", MessageBoxButtons.YesNo))
            {
                g.Clear(Color.White);
                listPencil.Clear();
                listSquare.Clear();
                listEllipse.Clear();
            }
            
        }

        //----------------------------------
        private void DrawPencilFromArray(Panel a)
        {
            foreach (Pencil el in a.pen)
            {
                Pen pen = new Pen(Color.FromArgb(el.color), el.linewidth);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                pen.LineJoin = LineJoin.Round;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawLine(pen, el.point1, el.point2);
                listPencil.Clear();
                listPencil.Add(el);
            }
        }

        private void DrawRectangleFromArray(Panel a)
        {
            foreach (Square el in a.square)
            {
                g.DrawRectangle(new Pen(Color.FromArgb(el.color)), el.point.X, el.point.Y, (float)el.width, (float)el.heigth);
                listSquare.Clear();
                listSquare.Add(el);
            }
        }

        private void DrawEllipseFromArray(Panel a)
        {
            foreach (Ellipse el in a.ellipse)
            {
                g.DrawEllipse(new Pen(Color.FromArgb(el.color)), el.point.X, el.point.Y, (float)el.width, (float)el.heigth);
                listEllipse.Clear();
                listEllipse.Add(el);
            }

        }
        //----------------------------------

        private void label1_Click(object sender, EventArgs e)
        {
            ColorDialog D = new ColorDialog();
            if (D.ShowDialog()==DialogResult.OK)
                clr = D.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel objPan = new Panel(listPencil.ToArray(), listSquare.ToArray(), listEllipse.ToArray());
            XmlSerializer xml = new XmlSerializer(typeof(Panel));

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fl = new FileStream(saveDialog.FileName + ".xml", FileMode.CreateNew))
                    {
                        xml.Serialize(fl, objPan);
                    }
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Panel));

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileAddress = fileDialog.FileName;

                    using (FileStream fl = new FileStream(fileAddress, FileMode.Open))
                    {
                        Panel a = (Panel)xml.Deserialize(fl);
                        rnd(a);
                    }
                }
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Уверены?", "Подтверждение", MessageBoxButtons.YesNo))
            {
                Application.Exit();
            }
        }

        //private void panel1_SizeChanged(object sender, EventArgs e)
        //{
        //    g = panel1.CreateGraphics();

        //    foreach (Pencil p in listPencil)
        //        g.DrawLine(new Pen(Color.FromArgb(p.color)), p.point1, p.point2);
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = panel1.CreateGraphics();

            foreach (Pencil p in listPencil)
                g.DrawLine(new Pen(Color.FromArgb(p.color),p.linewidth), p.point1, p.point2);
            foreach (Square sq in listSquare)
                g.DrawRectangle(new Pen(Color.FromArgb(sq.color)), sq.point.X, sq.point.Y, (float)sq.width, (float)sq.heigth);
            foreach (Ellipse ell in listEllipse)
                g.DrawEllipse(new Pen(Color.FromArgb(ell.color)), ell.point.X, ell.point.Y, (float)ell.width, (float)ell.heigth);

        }
    }
}
