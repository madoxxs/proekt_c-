using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FileMethods
    {
        public static List<SistemaBudjet> ReadFile(string file, Options option)
        {
            StreamReader readFile = new StreamReader(file);
            string line;
            List<SistemaBudjet> result = new List<SistemaBudjet>();

            DateTime today = DateTime.Now;
            DateTime daysBefore = today;

            if (option == Options.week)
            {
                daysBefore = new DateTime(today.Year, today.Month, today.Day - 7);
            }
            else if (option == Options.month)
            {
                daysBefore = new DateTime(today.Year, today.Month - 1, today.Day);
            }
            else if (option == Options.year)
            {
                daysBefore = new DateTime(today.Year - 1, today.Month, today.Day);
            }

            using (readFile)
            {
                try
                {
 line = readFile.ReadLine();
                while (line != null)
                {

                    string[] splitedLine = line.Split('|');
                    DateTime date = DateTime.Parse(splitedLine[0]);
                    double cena = double.Parse(splitedLine[2]);
                    SistemaBudjet temp = new SistemaBudjet(date, splitedLine[1], cena);

                    if (temp.Data <= today && temp.Data >= daysBefore)
                    {
                        result.Add(temp);
                    }
                }
                }
                catch (FileNotFoundException a)
                {

                    Console.WriteLine(a.Message);
                }
                catch (IOException a)
                {
                    Console.WriteLine(a.Message);
                }
            }
            return result;
        }



        public static void WriteFile(List<SistemaBudjet> list, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName,true);
            using (writer)
            {
                try
                {
                    foreach (var item in list)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }
    }
}
