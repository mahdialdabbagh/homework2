using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    public class OrderDetail
    {
        private int quality;
        private string taxStatus;

        public OrderDetail(int quality, string taxStatus)
        {
            this.quality = quality;
            this.taxStatus = taxStatus;
        }

        public int Quality
        {
            get { return quality; }
            private set { quality = value; }
        }

        public string TaxStatus
        {
            get { return taxStatus; }
            private set { taxStatus = value; }
        }

        public void CalcSubTotal()
        {
        
            Console.WriteLine("Calculating SubTotal for OrderDetail...");
        }

        public void CalcWeight()
        {

            Console.WriteLine("Calculating Weight for OrderDetail...");
        }

        public void CalcTax()
        {
         
            Console.WriteLine("Calculating Tax for OrderDetail...");
        }
    }
}
