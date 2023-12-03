using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    public class Check : Payment
    {
        private string name;
        private string bankID;

        public Check(float amount, string name, string bankID)
            : base(amount)
        {
            this.name = name;
            this.bankID = bankID;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string BankID
        {
            get { return bankID; }
            private set { bankID = value; }
        }

        public void Authorized()
        {
            Console.WriteLine("Check Authorization...");
        }
    }
}
