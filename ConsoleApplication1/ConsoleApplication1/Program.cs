using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface IStrategy
    {
        void DoIt(List<int[]> points, List<string[]> end);
    }        

    class StrategyAdd : IStrategy
    {
        Random rnd = new Random();
        string[] temp = new string[2];

        public StrategyAdd()
        {            
            Console.WriteLine("1.None\n" + 
                              "2.Strelka\n" +
                              "3.Romb\n");

            for(int i = 0; i < 2; i++)
            {
                switch (Console.ReadLine())
                {
                    case "1": temp[i] = "None" ; break;
                    case "2": temp[i] = "Strelka"; break;
                    case "3": temp[i] = "Romb"; break;
                    default: temp[i] = "None"; break;
                }
            }            
        }

        public void DoIt(List<int[]> points, List<string[]> end)
        {
            points.Add(new int[] { rnd.Next(-10, 10), rnd.Next(-10, 10), rnd.Next(-10, 10), rnd.Next(-10, 10)});
            end.Add(temp);
        }
    }

    class StrategyOutput : IStrategy
    {
        public void DoIt(List<int[]> points, List<string[]> end)
        {
            for(int i = 0; i < points.Count; i++)
            {
                Console.Write($"x1 = {points[i][0]}, y1 = {points[i][1]}, x2 = {points[i][2]}, y2 = {points[i][3]}");
                Console.WriteLine($"[{end[i][0]}, {end[i][1]}]");
            }

            Console.WriteLine();
        }
    }

    class StrategyDo
    {
        List<int[]> points = new List<int[]>();
        List<string[]> end = new List<string[]>();

        public StrategyDo()
        {

        }
        public StrategyDo(IStrategy doit)
        {
            this.doit = doit;
        }

        public IStrategy doit { get; set; }

        public void DoIt()
        {
            doit.DoIt(points, end);            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            StrategyDo strg = new StrategyDo();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Add in List");
                Console.WriteLine("2.Output List");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            strg.doit = new StrategyAdd();
                            strg.DoIt();
                            break;
                        }
                    case "2":
                        {
                            strg.doit = new StrategyOutput();
                            strg.DoIt();
                            Console.ReadLine();
                            break;                            
                        }
                    default: break;
                }
            }
            /*                            
                    case "4":
                        foreach (int[] point in points)
                        {
                            for (int i = 0; i < 4; i++)
                                Console.Write(xy[i] + point[i]);
                            switch (point[4])
                            {
                                case 1: Console.Write("\t(none, "); break;
                                case 2: Console.Write("\t(strelka, "); break;
                                case 3: Console.Write("\t(romb, "); break;
                            }
                            switch (point[5])
                            {
                                case 1: Console.Write("none)"); break;
                                case 2: Console.Write("strelka)"); break;
                                case 3: Console.Write("romb)"); break;
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }
                    */
        }
    }
}