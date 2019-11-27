using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Калькулятор
{
	public partial class CalcForm : Form
	{
        Graphics SGraphics; //Создание графической панели.
        CDrawingLines SLines = new CDrawingLines(); //Создание пользовательской линии.
        Point FirstP; //Исходная точка текущего элемента графической панели.
        Point SecondP; //Активная точка текущего элемента графической панели.
        List<RLine> ListLines = new List<RLine>(); //Список всех линий.          |
        string LMBStatus = "NP"; //Статус ЛКМ.
        string LMBMovingStatus = "S";

        public CalcForm()
		{
			InitializeComponent();
            SGraphics = DrawPanel.CreateGraphics();
            
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LMBStatus = "P";
            FirstP = e.Location;
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (LMBStatus == "p")
            {
                LMBMovingStatus = "M";
                
            }
            SecondP = e.Location;
        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            SGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            SLines.CLine(SGraphics, SecondP, FirstP);
            ListLines.Add(new RLine(SecondP, FirstP, Color.Black, 2, StartCap.Text, EndCap.Text));
            LMBMovingStatus = "S";
            LMBStatus = "NP";
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            SGraphics = DrawPanel.CreateGraphics();
            foreach (RLine RealLine in ListLines)
            {
                SGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                switch (RealLine.StartCap)
                {
                    case ("N"):
                        SLines.StartCapCS = new CStrategy();
                        break;
                    case (">"):
                        SLines.StartCapCS = new ArrowCStrategy();
                        break;
                    case ("▶"):
                        SLines.StartCapCS = new TriangleCStrategy();
                        break;
                }
                switch (RealLine.EndCap)
                {
                    case ("N"):
                        SLines.EndCapCS = new CStrategy();
                        break;
                    case (">"):
                        SLines.EndCapCS = new ArrowCStrategy();
                        break;
                    case ("▶"):
                        SLines.EndCapCS = new TriangleCStrategy();
                        break;
                }
                SLines.CLine(SGraphics, RealLine.LPoint, RealLine.FPoint);
            }
        }

        private void StartCap_Click(object sender, EventArgs e)
        {
            switch(StartCap.Text)
            {
                case ("N"):
                    SLines.StartCapCS = new ArrowCStrategy();
                    StartCap.Text = ">";
                    break;
                case (">"):
                    SLines.StartCapCS = new TriangleCStrategy();
                    StartCap.Text = "▶";
                    break;
                case ("▶"):
                    SLines.StartCapCS = new CStrategy();
                    StartCap.Text = "N";
                    break;
            }
        }

        private void EndCap_Click(object sender, EventArgs e)
        {
            switch (EndCap.Text)
            {
                case ("N"):
                    SLines.EndCapCS = new ArrowCStrategy();
                    EndCap.Text = ">";
                    break;
                case (">"):
                    SLines.EndCapCS = new TriangleCStrategy();
                    EndCap.Text = "▶";
                    break;
                case ("▶"):
                    SLines.EndCapCS = new CStrategy();
                    EndCap.Text = "N";
                    break;
            }
        }

        private void CalcForm_SizeChanged(object sender, EventArgs e)
        {
            StartCap.Location = new Point(this.Width - 140, this.Height - 100);
            EndCap.Location = new Point(this.Width - 78, this.Height - 100);
        }
    }
}
