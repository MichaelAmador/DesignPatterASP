using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public interface IState
    {
        public void Action(CustomerContext customerContext, decimal amount);
    }
}
