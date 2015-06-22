using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Methods
    {
        private List<SistemaBudjet> list;
        public static void AddRecord()
        {
            Console.WriteLine("Въведете дата: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Въведете име на разход: ");
            string name = Console.ReadLine();
            Console.WriteLine("Въведете цена: ");
            double price = double.Parse(Console.ReadLine());

            SistemaBudjet entry = new SistemaBudjet(date, name, price);
        }
        public static int LastWeekExpenses()
        {
            FileMetods 
        }
        public static int LastMonthExpenses();
        public static int LastYearExpenses();

        public static void Export();
        public static void Import();
    }
}
