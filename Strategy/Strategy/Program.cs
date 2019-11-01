using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static List<Line> lines = new List<Line>();
        //static List<Figure[]> figures = new List<Figure[]>();
        public static char Message()
        {
            Console.WriteLine();
            Console.WriteLine("1. Создать новую линию");
            Console.WriteLine("2. Вывести линии на экран");
            Console.WriteLine("3. Выход из программы");
            return Console.ReadLine()[0];
        }
        public static Figure MessageType()
        {
            Console.WriteLine();
            Console.WriteLine("1. Нет фигуры");
            Console.WriteLine("2. Стрелка");
            Console.WriteLine("3. Ромб");
            char s = Console.ReadLine()[0];
            switch (s)
            {
                case '1':
                    {
                        return new Figure(new None());
                    }
                case '2':
                    {
                        return new Figure(new Arrow());
                    }
                case '3':
                    {
                        return new Figure(new Rhombus());
                    }
            }
            return null;
        }
        public static void CommandPanel()
        {
            char s = Message();
            while (s != '3')
            {
                switch (s)
                {
                    case '1':
                        {
                            Random rnd = new Random();
                            lines.Add(new Line(rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11), MessageType(), MessageType()));
                            break;
                        }
                    case '2':
                        {
                            for (int i = 1; i<= lines.Count; i++)
                            {
                                Console.WriteLine(i + ". " + lines[i-1]);
                            }
                            break;
                        }
                }
                s = Message();
            }
        }
        static void Main(string[] args)
        {
            CommandPanel();
        }
    }
}
