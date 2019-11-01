using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Line : Coord
    {
        public override int X1 { get; set; }
        public override int X2 { get; set; }
        public override int Y1 { get; set; }
        public override int Y2 { get; set; }
        public Figure FirstFigure =new Figure(new None());
        public Figure LastFigure = new Figure(new None());
        public Line(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
        public Line(int x1, int y1, int x2, int y2, Figure FirstFigure, Figure LastFigure)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            this.FirstFigure = FirstFigure;
            this.LastFigure = LastFigure;
        }
        public override string GetCap()
        {
            return $"X1 = {X1}; Y1 = {Y1}\tX2 = {X2}; Y2 = {Y2}";
        }
        public override string ToString()
        {
            return $"{GetCap()}\t {{{FirstFigure.WhatIsIt()}; {LastFigure.WhatIsIt()}}}";
        }
    }
}
