using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    public class Payment
    {
        private float amount;

        public Payment(float amount)
        {
            this.amount = amount;
        }

        public float Amount
        {
            get { return amount; }
            private set { amount = value; }
        }
    
