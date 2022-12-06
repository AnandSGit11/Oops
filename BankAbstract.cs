using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    // Abstract class
    abstract class Bankname
    {
        // Abstract method (does not have a body)
        public abstract void Banksname();
        // Regular method
        public void IFSC()
        {
            Console.WriteLine("120000083");
        }
    }

    // Derived class (inherit from HospitalName )
    class BankDetail : Bankname
    {
        public override void Banksname()
        {
            // The body of HosName() is provided here
            Console.WriteLine("Hospital name is SBI");
        }


    }


}
