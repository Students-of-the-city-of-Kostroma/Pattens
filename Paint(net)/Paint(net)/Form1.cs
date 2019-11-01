using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;


namespace Paint_net_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ps = panel1.CreateGraphics();
            ResizeRedraw = true;
        }

        static Color ActiveColor = Color.Black;
        Graphics ps;
        bool Pressed = false;
        Point temp;
        delegate void Drow(Graphics ps, Color ActiveColor, Point LastPoint, Point NextPoint);
        Drow DrowPls = Line.Draw;
        List<Figura> figurs = new List<Figura>();

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(Form1.ActiveForm.Size.Width - 145, Form1.ActiveForm.Size.Height - 63);
            ps = panel1.CreateGraphics();
            //foreach (Figura x in figurs)
            //{
            //    if (x.LastPoint.X <= panel1.Size.Width || x.LastPoint.Y <= panel1.Size.Height || x.NextPoint.X <= panel1.Size.Width || x.NextPoint.Y <= panel1.Size.Height)
            //        x.Draw(ps);
            //}
        }
        
        private void BtColor_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == DialogResult.OK)
            {
                ActiveColor = colorDialog1.Color;
                panel2.BackColor = colorDialog1.Color;
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Pressed = true;
                temp = e.Location;
            }
            if (radioButton2.Checked == true || radioButton3.Checked == true)
            {
                temp = e.Location;
            }
            panel1.MouseUp += new MouseEventHandler(Panel1_MouseUp);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (Pressed)
                {
                    DrowPls(ps, ActiveColor, temp, e.Location);
                    figurs.Add(new Line(ActiveColor, temp, e.Location));
                    temp = e.Location;
                }
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Pressed = false;
            }
            if (radioButton2.Checked == true)
            {
                DrowPls(ps, ActiveColor, temp, e.Location);
                figurs.Add(new Rect(ActiveColor, temp, e.Location));
            }
            if (radioButton3.Checked == true)
            {
                DrowPls(ps, ActiveColor, temp, e.Location);
                figurs.Add(new Circle(ActiveColor, temp, e.Location));
            }
            panel1.MouseUp -= new MouseEventHandler(Panel1_MouseUp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.MouseDown -= new MouseEventHandler(Panel1_MouseDown);
            SaveFileDialog ofd = new SaveFileDialog() { Filter = "xml(*.xml)|*.xml" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                NetDataContractSerializer serializer = new NetDataContractSerializer();
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                {
                    serializer.Serialize(fs, figurs);
                }
            }
            panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.MouseDown -= new MouseEventHandler(Panel1_MouseDown);
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "xml(*.xml)|*.xml" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate))
                {
                    NetDataContractSerializer serializer = new NetDataContractSerializer();
                    figurs.Clear();
                    figurs = (List<Figura>)serializer.Deserialize(fs);
                }
                ps.Clear(SystemColors.Control);
                foreach (Figura x in figurs)
                    x.Draw(ps);
            }
            panel1.MouseDown += new MouseEventHandler(Panel1_MouseDown);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ps.Clear(SystemColors.Control);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                DrowPls = Line.Draw;
                panel1.MouseMove += new MouseEventHandler(Panel1_MouseMove);
            }
            if (radioButton2.Checked == true)
            {
                DrowPls = Rect.Draw;
                panel1.MouseMove -= new MouseEventHandler(Panel1_MouseMove);
            }
            if (radioButton3.Checked == true)
            {
                DrowPls = Circle.Draw;
                panel1.MouseMove -= new MouseEventHandler(Panel1_MouseMove);
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura x in figurs)
                x.Draw(ps);
        }
    }
}
