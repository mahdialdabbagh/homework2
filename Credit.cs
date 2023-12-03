using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    public class Credit : Payment
    {
        private string name;
        private string type;
        private DateTime expDate;

        public Credit(float amount, string name, string type, DateTime expDate)
            : base(amount)
        {
            this.name = name;
            this.type = type;
            this.expDate = expDate;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Type
        {
            get { return type; }
            private set { type = value; }
        }

        public DateTime ExpDate
        {
            get { return expDate; }
            private set { expDate = value; }
        }

        public void Authorized()
        {
            Console.WriteLine("Credit Authorization...");
        }
    }

}
