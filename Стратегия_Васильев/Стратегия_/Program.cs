using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{



    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter line length: ");
            int length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("1.Nothing");
            Console.WriteLine("2.Arrow");
            Console.WriteLine("3.Rhombus");
            Console.Write("Enter number of left figure: ");
            int firstfigure = Int32.Parse(Console.ReadLine());
            Console.Write("Enter number of right figure: ");
            int secondfigure = Int32.Parse(Console.ReadLine());
            LineEnd first, second;
            switch(firstfigure)
            {
                case 1:
                    first = new JustLine();
                    break;
                case 2:
                    first = new LineArrow();
                    break;
                case 3:
                    first = new LineRomb();
                    break;
                default: first = new JustLine(); break;

            }
            switch (secondfigure)
            {
                case 1:
                    second = new JustLine();
                    break;
                case 2:
                    second = new LineArrow();
                    break;
                case 3:
                    second = new LineRomb();
                    break;
                default: second = new JustLine(); break;

            }
            Line LINE = new Line(first, second,length);
            Console.Write (LINE.OutPutLine());
            Console.WriteLine();
            
            }
        }
    }

