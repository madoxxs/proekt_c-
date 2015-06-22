using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Methods
    {
        private static List<SistemaBudjet> list;
        private static string filename = string.Empty;

        public static string Filename
        {
            get { return filename; }
            set { filename = value; }
        }
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

        private static double GetExpenses(int option)
        {
            List<SistemaBudjet> lastWeek = FileMethods.ReadFile(Filename, 7);
            double result = 0;
            foreach (SistemaBudjet item in lastWeek)
            {
                result += item.Price;
            }
            return result;

        }

        public static double LastWeekExpenses()
        {
            double result = GetExpenses(7);
            return result;
        }
        public static double LastMonthExpenses()
        {
            double result = GetExpenses(30);
            return result;
        }
        public static double LastYearExpenses()
        {
            double result = GetExpenses(365);
            return result;
        }

        public static void Export()
        {
            Console.WriteLine("Въведете име на файл за запис: ");
            string filename = Console.ReadLine();
            FileMethods.WriteFile(filename);
        }
        public static void Import()
        {
            Console.WriteLine("Въведете име на файл за четене: ");
            string filename = Console.ReadLine();
            Filename = filename;
        }
    }
}
