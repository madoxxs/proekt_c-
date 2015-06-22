using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SistemaBudjet
    {
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        private string razhod;

        public string Razhod
        {
            get { return razhod; }
            set { razhod = value; }
        }
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public SistemaBudjet(DateTime date, string razhod, double price)
        {
            this.data = date;
            this.razhod = razhod;
            this.price = price;
        }
        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", data.ToShortDateString(), razhod, price);
        }
    }
}
