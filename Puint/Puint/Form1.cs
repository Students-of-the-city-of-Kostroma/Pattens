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

namespace Puint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BtnColor.BackColor = Color.Black;//первоначальный цвет пера
            gr = panel1.CreateGraphics();//создаем область для работы с графикой на панели
        }
        Color color = Color.Black;//переменная цвета кисти
        bool isPressed = false; //возможность рисовать на панели
        Point NewPoint; //новая точка
        Point OldPoint; //первая точка
        Point temp;//рабочая
        Graphics gr;//создаем графический элемент
        float size;
        delegate void Druw(Graphics gr, Color color, Point OldPoint, Point NewPoint, float size);
        Druw DruwP = Line.Draw;
        List<Figures> figure = new List<Figures>();
       

        ColorDialog colorDialog = new ColorDialog();//диалоговое окно выбора цвета
        

        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog()==DialogResult.OK)//закрытие окна по кноппке ОК
            {
                color = colorDialog.Color;//наш выбранный цвет
                BtnColor.BackColor = colorDialog.Color;//присваиваем выбранный цвет фону кнопки
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            figure.Clear();
            gr.Clear(Color.Gainsboro);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isPressed = true;//разрешение на рисование
            NewPoint = e.Location;//начальная точка равна текущему положению курсора
            if (TFbrush.Checked == true)
            {
                isPressed = true;
                temp = e.Location;
            }
            if(TFcircle.Checked ==true || TFrectangle.Checked == true)
            {
                temp = e.Location;
            }
            panel1.MouseUp += new MouseEventHandler(panel1_MouseUp);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (TFbrush.Checked == true)
            {
                isPressed = false;
            }
            if (TFrectangle.Checked == true)
            {
                DruwP(gr, color, temp, e.Location, size);
                figure.Add(new Rectangli(color, temp, e.Location, size));
            }
            if (TFcircle.Checked == true)
            {
                DruwP(gr, color, temp, e.Location, size);
                figure.Add(new Circli(color, temp, e.Location, size));
            }
            panel1.MouseUp -= new MouseEventHandler(panel1_MouseUp);
            isPressed = false;//запрет на рисование
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TFbrush.Checked == true)
            {
                if (isPressed)
                {
                    size = (float)numericUpDown1.Value;
                    OldPoint = NewPoint;
                    NewPoint = e.Location;
                    DruwP(gr, color, OldPoint, NewPoint, size);
                    figure.Add(new Line(color, temp, e.Location, size));
                    temp = e.Location;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figures i in figure)
                i.Draw(gr, (float)numericUpDown1.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            size = (float)numericUpDown1.Value;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(Form1.ActiveForm.Size.Width - 180, Form1.ActiveForm.Size.Height - 78);
            gr = panel1.CreateGraphics();
        }

        private void TFbrush_CheckedChanged(object sender, EventArgs e)
        {
            if (TFbrush.Checked == true)
            {
                DruwP = Line.Draw;
                panel1.MouseMove += new MouseEventHandler(panel1_MouseMove);
            }
            if (TFrectangle.Checked == true)
            {
                DruwP = Rectangli.Draw;
                panel1.MouseMove -= new MouseEventHandler(panel1_MouseMove);
            }
            if (TFcircle.Checked == true)
            {
                DruwP = Circli.Draw;
                panel1.MouseMove -= new MouseEventHandler(panel1_MouseMove);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.MouseDown -= new MouseEventHandler(panel1_MouseDown);
            SaveFileDialog sv = new SaveFileDialog() { Filter = "xml(*.xml)|*.xml" };
            if (sv.ShowDialog() == DialogResult.OK)
            {
                NetDataContractSerializer serializer = new NetDataContractSerializer();
                using (FileStream fs = new FileStream(sv.FileName, FileMode.OpenOrCreate))
                {
                    serializer.Serialize(fs, figure);
                }
            }
            panel1.MouseDown += new MouseEventHandler(panel1_MouseDown);
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.MouseDown -= new MouseEventHandler(panel1_MouseDown);
            OpenFileDialog dnld = new OpenFileDialog() { Filter = "xml(*.xml)|*.xml" };
            if (dnld.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(dnld.FileName, FileMode.OpenOrCreate))
                {
                    NetDataContractSerializer serializer = new NetDataContractSerializer();
                    figure.Clear();
                    figure = (List<Figures>)serializer.Deserialize(fs);
                }
                gr.Clear(SystemColors.Control);
                foreach (Figures x in figure)
                    x.Draw(gr, (float)numericUpDown1.Value);
            }
            panel1.MouseDown += new MouseEventHandler(panel1_MouseDown);
        }
    }
    
}
