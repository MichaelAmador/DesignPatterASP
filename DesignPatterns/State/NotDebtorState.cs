using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class NotDebtorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            if (amount <= customerContext.Residue)
            {
                customerContext.Discount(amount);
                Console.WriteLine($"Request approved, spend {amount} and your residue is {customerContext.Residue}");

                if (customerContext.Residue <= 0) customerContext.SetState(new DebtorState());
            }
            else
            {
                Console.WriteLine($"There is no enough money to continue: residue {customerContext.Residue}, amount: {amount}");
            }
        }
    }
}
