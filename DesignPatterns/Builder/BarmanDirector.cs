using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class BarmanDirector
    {
        public IBuilder _builder;
        public BarmanDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void PrepareMargarita()
        {
            _builder.Reset();
            _builder.SetAlcohol(9);
            _builder.SetWater(30);
            _builder.AddIngredients("2 lemons");
            _builder.AddIngredients("a pich of salt");
            _builder.AddIngredients("1 /2 cup of Tequil");
            _builder.AddIngredients("3 / 4 cups of orange's liquor");
            _builder.AddIngredients("4 cubes of ice");
            _builder.Mix();
            _builder.Rest(5000);
        }

        public void PreparePinaColada()
        {
            _builder.Reset();
            _builder.SetAlcohol(20);
            _builder.SetWater(10);
            _builder.AddIngredients("1 /2 cup of ron");
            _builder.AddIngredients("1 / 2 coconut's cream");
            _builder.AddIngredients("3 / 4 cubes of pineapple juice");
            _builder.Mix();
            _builder.Rest(2000);
        }
    }
}
