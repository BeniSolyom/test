﻿using System;
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

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Valami proba");
            }


            Console.WriteLine("Stash proba szöveg van itt testelni");

            Console.WriteLine("Only branch text test");

            Console.ReadKey();
        }
    }
}
