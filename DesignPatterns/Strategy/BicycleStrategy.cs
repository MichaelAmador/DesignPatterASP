using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class BicycleStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("I'm a bicycle and have two wheels");
        }
    }
}
