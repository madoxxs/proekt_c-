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
        public static List<SistemaBudjet> ReadFile(string file, int day)
        {
            StreamReader readFile = new StreamReader(file);
            string line;
            List<SistemaBudjet> result = new List<SistemaBudjet>();
            using (readFile)
            {
                line = readFile.ReadLine();
                while (line != null)
                {

                    string[] lineMass = line.Split('|');
                    DateTime date = DateTime.Parse(lineMass[0]);
                    double cena = double.Parse(lineMass[2]);
                    SistemaBudjet temp = new SistemaBudjet(date, lineMass[1], cena);
                    DateTime dnes = DateTime.Now;
                    DateTime daysBefore = dnes.Subtract(TimeSpan.FromDays(day));

                    if (temp.Data <= dnes && temp.Data >= daysBefore)
                    {
                        result.Add(temp);
                    }


                }
            }
            return result;
        }



        public static void WriteFile(List<SistemaBudjet> list, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName,true);
            using (writer)
            { 
                
                foreach (var item in list)
                {
                    Console.WriteLine(item.ToString());
                }
                
            }
             
            
        }





    }
}
