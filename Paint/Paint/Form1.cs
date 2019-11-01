using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Color Acolor = Color.Black;
        Graphics gr;
        bool Pressed = false;
        Point temp;
        delegate void Draw(Graphics ps, Color Acolor, Point LPoint, Point NPoint);
        Draw draw = Line.Draw;
        List<Figura> figurs = new List<Figura>();

        /// <summary>
        /// Выбор цвета для рисования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtColor_Click(object sender, EventArgs e)
        {
            DialogResult f = colorDialog1.ShowDialog();
            if (f == DialogResult.OK)
            {
                Acolor = colorDialog1.Color;
                panel2.BackColor = colorDialog1.Color;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            gr.Clear(SystemColors.Control);
        }
    }
}
