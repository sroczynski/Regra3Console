using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regra3
{
    class Program
    {
        public static decimal y1 { get; set; }
        public static decimal y2 { get; set; }

        public static decimal x1 { get; set; }
        public static decimal x2 { get; set; }

        static void Main()
        {
            var continuar = true;
            do
            {
                Console.CursorTop = 0;
                y1 = decimal.Parse(Console.ReadLine());

                Console.CursorTop = 2;
                y2 = decimal.Parse(Console.ReadLine());

                Console.CursorTop = 0;
                Console.CursorLeft = 7;
                x1 = decimal.Parse(Console.ReadLine());

                Console.CursorTop = 2;
                Console.CursorLeft = 7;
                Console.Write("X");

                Console.CursorTop = 4;
                Console.CursorLeft = 0;
                Console.WriteLine("X = " + (y2 * x1) / y1);

                Console.WriteLine("1. Continuar");
                continuar = Console.ReadLine() == "1" ? true : false;
                Console.Clear();
            }
            while (continuar);
        }
    }
}
