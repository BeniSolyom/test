using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(i+1);

                Console.WriteLine("Változtatás!");

            }

            Console.ReadKey();
        }
    }
}
