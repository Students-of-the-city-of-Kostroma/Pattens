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
        /// <summary>
        /// Ввод данных
        /// </summary>
        /// <returns></returns>
        public static char Message()
        {
            Console.WriteLine();
            Console.WriteLine("Let's make a choice");
            Console.WriteLine("1. New Line");
            Console.WriteLine("2. Print Lines");
            Console.WriteLine("3. Exit");
            return Console.ReadLine()[0];
        }
        /// <summary>
        /// Выбираем наши окончания
        /// </summary>
        /// <returns></returns>
        public static Figure MessageType()
        {
            Console.WriteLine();
            Console.WriteLine("Select sides");
            Console.WriteLine("1. None");
            Console.WriteLine("2. Arrow");
            Console.WriteLine("3. Rhombus");
            char key = Console.ReadLine()[0];
            switch (key)
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
        /// <summary>
        /// Вывод данных на экран
        /// </summary>
        public static void CommandPanel()
        {
            char key_2 = Message();
            while (key_2 != '3')
            {
                switch (key_2)
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
                key_2 = Message();
            }
        }
        static void Main(string[] args)
        {
            CommandPanel();
        }
    }
}
