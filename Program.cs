using System;

namespace TypesOfPolymorphism
{
    class Program
    {
        public void getPayment()
        {
            Console.WriteLine("cash on delivery");
        }
        public void getPayment(int cardno)
        {
            Console.WriteLine("pay through credit or debit card");
        }
        public void getPayment(string upi, int pin)
        {
            Console.WriteLine("online payment ");
        }
        static void Main(string[] args)
        {
           

            Bank b = new Machine();
            b.deposit();
        }
    }
        class Bank
        {
            public virtual void deposit()
            {
                Console.WriteLine("credit through bank");
            }
        }
        class Machine : Bank
        {
            public virtual void deposit()
            {
                Console.WriteLine("credit through machine");
            }
        }
    

}
