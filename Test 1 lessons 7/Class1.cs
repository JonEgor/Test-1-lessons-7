using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Debt;

Debt1 mortgage = new Debt1(120000.0, 1.01);
    mortgage.PrintBalance();

    mortgage.WaitOneYear();
    mortgage.PrintBalance();

    //Wait 20 years
    int years = 0;
    while (years < 20)
    {
        mortgage.WaitOneYear();
        years = years + 1;
    }
    mortgage.PrintBalance();
