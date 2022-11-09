using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DependencyInjection
{
    public class DrinkWithBeer
    {
        private Beer _beer;
        private decimal _water;
        private decimal _sugar;

        public DrinkWithBeer(decimal water, decimal sugar, Beer beer)
        {
            _beer = beer;
            _water = water;
            _sugar = sugar;
        }

        public void Build()
        {
            Console.WriteLine($"We prepared a drink that has {_water} of water and {_sugar} of sugar with name {_beer.Name}");
        }
    }
}
