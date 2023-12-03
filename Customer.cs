using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{


    class Customer
    {
        // Private fields
        private string name;
        private string address;

        // Constructor
        public Customer(string aName, string aAddress)
        {
            name = aName;
            address = aAddress;
        }

        // Public property for Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Public property for Address
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // Additional method (example)
        public void DisplayInfo()
        {
            Console.WriteLine($"Customer: {Name}\nAddress: {Address}");
        }
    }

}
