using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Патерн_Стратегия_Наблюдатель
{
    public partial class Form1 : Form
    {
        Graphics g;
        Point CurPoint;
        Point PrePoint;
        Drawing drawing = new Drawing();
        Observer obs = new Observer();

        public Form1()
        {
            InitializeComponent();

            //Выбраем элемент заранее
            cbStartCapLine.SelectedIndex = 0;
            cbEndCapLine.SelectedIndex = 0;

            drawing.AddObserver(obs);
            g = Canvas.CreateGraphics();                    
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            PrePoint = e.Location;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            g = Canvas.CreateGraphics();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            CurPoint = e.Location;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            drawing.DrawLine(g, CurPoint, PrePoint);
        }

        private void cbStartCapLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbStartCapLine.SelectedIndex)
            {
                case 0: drawing.StrategyForStartCap = new StrategyArrow(); break;
                case 1: drawing.StrategyForStartCap = new StrategyTriangle(); break;
                case 2: drawing.StrategyForStartCap = new Strategy(); break;
                default: break;
            }
        }

        private void cbEndCapLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEndCapLine.SelectedIndex)
            {
                case 0: drawing.StrategyForEndCap = new StrategyArrow(); break;
                case 1: drawing.StrategyForEndCap = new StrategyTriangle(); break;
                case 2: drawing.StrategyForEndCap = new Strategy(); break;
                default: break;
            }
        }
    }
}
