using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class PreparedBeverage
    {
        public List<string> Ingredients = new List<string>();
        public int Milk;
        public int Water;
        public decimal Alcohol;
        public string Result;
    }
}
