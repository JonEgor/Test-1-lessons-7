
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Debt
{
     internal class Debt1
    {
        private double _initialBalance;
            private double _interestRate;


        public Debt1(double balance, double interestRate)
        {
            _initialBalance = balance;
            _interestRate = interestRate; 
        }
        public void PrintBalance()
        {
            Console.WriteLine($"Your dept is: {_initialBalance}");

        }
        public void WaitOneYear()
        {
            _initialBalance *= _interestRate;
        }
        

    }
}
