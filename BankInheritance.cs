using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankInheritance
    {

        string name = "SBI";

        class Bank2Inheritance : BankInheritance
        {
            string address = "Bhubaneswar";


            static void Main(string[] args)
            {

                Bank2Inheritance hi = new Bank2Inheritance();


                Console.WriteLine(hi.name);
                Console.WriteLine(hi.address);
                Console.ReadLine();

                BankDetail bankDetail = new BankDetail();  // Create a HospitalDetail object
                bankDetail.Banksname();
                bankDetail.IFSC();
                Console.ReadLine();

                BankPolymerphism bankPolymerphis = new BankPolymerphism();
                BankPolymerphism bankReview = new BankReview();
                BankPolymerphism bankCharges = new BankCharges();
                bankPolymerphis.Bank();
                bankReview.Bank();
                bankCharges.Bank();

                Console.ReadLine();


                BankMethodOverload bankMethodOverload = new BankMethodOverload();
                bankMethodOverload.BankData("Anand");
                bankMethodOverload.BankData("Anand", 12343);
                Console.ReadLine();


                BankEncapsulation bankEncapsulatio = new BankEncapsulation();
                bankEncapsulatio.Name = "Anand";
                bankEncapsulatio.AccNo = 27;
                Console.WriteLine("Name: " + bankEncapsulatio.Name);
                Console.WriteLine("Accno: " + bankEncapsulatio.AccNo);
                Console.ReadLine();
            }
        }
    }
}

