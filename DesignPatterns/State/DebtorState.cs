using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class DebtorState : IState
    {
        public void Action(CustomerContext customerContext, decimal amount)
        {
            Console.WriteLine("You can't buy, you don't have enough credits");
        }
    }
}
