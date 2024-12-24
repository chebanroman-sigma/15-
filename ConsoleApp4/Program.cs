using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {/// <summary>
     /// Задача 2. Одна штука некоторого товара стоит 20,4 руб. Напечатать таблицу стоимости 2, 3, ..., 20 штук этого товара.
     /// </summary>
     /// <param name="args"></param>
        
        
        static void Func()
        { decimal Cena = 20.40M;
            decimal Cena1 = 20.40M;
            for (int i=2;i<=20;i++)
            {
                 Cena = Cena + Cena1;
                Console.WriteLine($"\t{i} шт:{Cena} руб");
            }
        }
        
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
    }
}
