using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    public class Cash : Payment
    {
        private float cashTendered;

        public Cash(float amount, float cashTendered)
            : base(amount)
        {
            this.cashTendered = cashTendered;
        }

        public float CashTendered
        {
            get { return cashTendered; }
            private set { cashTendered = value; }
        }
    }
}
