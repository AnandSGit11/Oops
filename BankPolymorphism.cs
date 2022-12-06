using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankPolymerphism
    {
        public virtual void Bank()
        {
            Console.WriteLine("This is a good Bank");
        }
    }
    class BankReview : BankPolymerphism
    {
        public override void Bank()
        {
            Console.WriteLine("A solid 9 out of 10 for their customer service");
        }
    }
    class BankCharges : BankPolymerphism
    {
        public override void Bank()
        {
            Console.WriteLine("Charges are very high for private sectors");
        }
    }
}
