using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{


    public class Item
    {
        private double shippingWeight;
        private string description;

        public Item(double shippingWeight, string description)
        {
            this.shippingWeight = shippingWeight;
            this.description = description;
        }

        public double ShippingWeight
        {
            get { return shippingWeight; }
            private set { shippingWeight = value; }
        }

        public string Description
        {
            get { return description; }
            private set { description = value; }
        }

        public double GetPriceForQuantity()
        {
            Console.WriteLine("Calculating Price for Quantity...");
            return 0.0;
        }

        public double GetTax()
        {
            Console.WriteLine("Calculating Tax for Item...");
            return 0.0;
        }

        public bool InStock()
        {
            Console.WriteLine("Checking Stock for Item...");
            return false;
        }
    }

}
