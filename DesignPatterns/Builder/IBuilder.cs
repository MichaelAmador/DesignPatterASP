using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public interface IBuilder
    {
        public void Reset();
        public void SetAlcohol(decimal alcohol);
        public void SetWater(int water);
        public void SetMilk(int milk);
        public void AddIngredients(string ingredients);
        public void Mix();
        public void Rest(int time);
    }
}
