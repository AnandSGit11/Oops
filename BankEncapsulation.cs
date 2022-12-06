using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank.BankPolymerphism;

namespace Bank
{
    class BankEncapsulation
    {
        private String customerName;
        private int CustomerAccno;

        public String Name     //Name is property
        {

            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }

        }
        public int AccNo
        {

            get
            {
                return CustomerAccno;
            }

            set
            {
                CustomerAccno = value;
            }

        }
    }
}
