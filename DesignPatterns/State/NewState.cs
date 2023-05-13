using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class NewState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            Console.WriteLine($"Add money to your residue:{amount}");
            customerContext.Residue = amount;
            customerContext.SetState(new NotDebtorState());
        }
    }
}
