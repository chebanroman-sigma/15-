using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {/// <summary>
     /// Задача 3. Вывести четные двузначные числа и подсчитать их количество.
     /// </summary>
     /// <param name="args"></param>
       
        static void Func()
        {
            int count = 0;
            for(int i = 10;i<99;i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine($"count={count}");
        }
        
        
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
    }
}
