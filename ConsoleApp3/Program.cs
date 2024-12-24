using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{/// <summary>
/// Задача 1. Напечатать ряд чисел 20 в виде: 20 20 20 20 20 20 20 20 20 20.
/// </summary>
    class Program
    {
        //static void Func()
        //{
            
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{20}\t");
        //    }

        //}

        //////
       
        //static void Func()
        //{
        //    int i = 0;
        //    while(i<10)
        //    {
        //        Console.Write($"{20}\t");
        //        i++;
        //    }
        //}

     
        /// ////////
  
        static void Func()
        {
            int i = 0;
            do
            {
                Console.Write($"{20}\t");
                i++;
            } while (i<10);
        }
      


        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
    }
}
