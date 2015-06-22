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
            Console.WriteLine("Моля изберете една от следните опции:\n  1.Въвеждане на нов запис.\n  2.Изчисление на разходите за последната седмица. \n  3.Изчисление на разходите за последния месец. \n  4.Изчисление на разходите за последната година.\n  5.Запиши в файл. \n  6.Прочети от файл.\n  7.Изход. \n--------------------------------------------------\n");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 7)
            {
                switch (choice)
                {
                    case 1: Methods.AddRecord(); break;
                    case 2: Methods.LastWeekExpenses(); break;
                    case 3: Methods.LastMonthExpenses(); break;
                    case 4: Methods.LastYearExpenses(); break;
                    case 5: Methods.Export(); break;
                    case 6: Methods.Import(); break;
                    case 7: return;
                    default: Console.WriteLine("Моля въведете цифра от 1 до 6!"); break;

                }
                choice = int.Parse(Console.ReadLine());
            }
        }
    }
}
