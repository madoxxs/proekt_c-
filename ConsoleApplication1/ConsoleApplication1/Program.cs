using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 7)
            {
                switch (choice)
                {
                    case 1: 
                    case 2:
                    case 3:
                    case 4:
                    case 5: 
                    case 6:
                    case 7: return;
                    default: Console.WriteLine("Моля въведете цифра от 1 до 6!"); break;

                }
                choice = int.Parse(Console.ReadLine());
            }
        }
    }
}
