using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DesignPatterns.Builder
{
    public class PreparedAlcoholicDrinkConcreteBuilder : IBuilder
    {
        private PreparedBeverage _preparedBeverage;

        public PreparedAlcoholicDrinkConcreteBuilder()
        {
            Reset();
        }

        public void AddIngredients(string ingredients)
        {
            if (_preparedBeverage.Ingredients == null)
                _preparedBeverage.Ingredients = new List<string>();

            _preparedBeverage.Ingredients.Add(ingredients);
        }

        public void Mix()
        {
            string ingredientes = _preparedBeverage.Ingredients.Aggregate((i, j) => i + ", " + j);
            _preparedBeverage.Result = $"Beverage made with {_preparedBeverage.Alcohol} of alcohol, and the following ingredients {ingredientes}";
            Console.WriteLine("Ingredients were mixed");
        }

        public void Reset()
        {
            _preparedBeverage = new PreparedBeverage();
        }

        public void Rest(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine("Ready to drink");
        }

        public void SetAlcohol(decimal alcohol)
        {
            _preparedBeverage.Alcohol = alcohol;
        }

        public void SetMilk(int milk)
        {
            _preparedBeverage.Milk = milk;
        }

        public void SetWater(int water)
        {
            _preparedBeverage.Water = water;
        }

        public PreparedBeverage GetPreparedBeverage() => _preparedBeverage;
    }
}
