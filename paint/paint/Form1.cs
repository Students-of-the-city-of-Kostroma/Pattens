using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        //Graphics g;
        Point prev;  //предыдущая координата
        Point cur;  //Текущая координата
        IStrategy str;
        IStrategy str2;

        event EventHandler changecanvas;


        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            //g = panel1.CreateGraphics();
            str = new StrategyNone();
            str2 = new StrategyNone();
            
            changecanvas += Panel_changecanvas;
        }

        private void Panel_changecanvas(object sender, EventArgs e)
        {
            using (Graphics g = panel1.CreateGraphics())
            {
                g.DrawLine((Pen)sender, prev, cur);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: str = new StrategyNone(); break;
                case 1: str = new StrategyTriangle(); break;
                case 2: str = new StrategyArrow(); break;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0: str2 = new StrategyNone(); break;
                case 1: str2 = new StrategyTriangle(); break;
                case 2: str2 = new StrategyArrow(); break;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            prev = e.Location;
            cur = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            prev = cur;
            cur = e.Location;

            Pen pen = new Pen(Color.Black, 3);
            pen.StartCap = str.cap();
            pen.EndCap = str2.cap();

            changecanvas.Invoke(pen, null);
            //g.DrawLine(pen, prev, cur);
        }


    }
}
