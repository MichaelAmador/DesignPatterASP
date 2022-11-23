using DesignPatterns.Builder;
using DesignPatterns.DependencyInjection;
using DesignPatterns.Factory;
using DesignPatterns.Models;
using DesignPatterns.Repository;
using DesignPatterns.Strategy;
using DesignPatterns.UnitOfWork;
using System;
using System.Linq;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //PatternSingleton
            //PatternFactory();
            //PatternDependencyInjection();
            //PatternRepository();
            //PatternUnitOfWork();
            //PatternStrategy();
            PatternBuilder();
        }

        static void PatternSingleton()
        {
            var log = Singleton.Log.Instance;
            log.Save("This is a fucking test!");
            log.Save("This is a fucking test2!");
        }

        static void PatternFactory()
        {
            SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            SaleFactory internetSaleFactory = new InternetSaleFactory(2);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(10);

            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);
        }

        static void PatternDependencyInjection()
        {
            var beer = new DependencyInjection.Beer("Pikantus", "Erdinger");
            var drinWithBeer = new DrinkWithBeer(10, 1, beer);
            drinWithBeer.Build();
        }

        static void PatternRepository()
        {
            using (var context = new DesignPatternsContext())
            {
                // MANUAL
                //var beerRepository = new BeerRepository(context);
                //var beer = new Models.Beer
                //{
                //    Name = "Corona",
                //    Style = "Pilsner"
                //};
                //beerRepository.Add(beer);
                //beerRepository.Save();

                //foreach (var b in beerRepository.Get())
                //{
                //    Console.WriteLine($"{b.Name}");
                //}

                // USING GENERICS
                var beerRepository = new Repository<Models.Beer>(context);
                var beer = new Models.Beer { Name = "Fuller", Style = "Stron Ale" };
                beerRepository.Add(beer);
                beerRepository.Save();

                foreach (var item in beerRepository.Get())
                {
                    Console.WriteLine($"{item.Name}");
                }

            }
        }

        static void PatternUnitOfWork()
        {
            using (var context = new DesignPatternsContext())
            {
                var unitOfWork = new UnitOfWork.UnitOfWork(context);
                var beers = unitOfWork.Beers;
                var beer = new Models.Beer
                {
                    Name = "Fuller",
                    Style = "Porter"
                };

                beers.Add(beer);

                var brands = unitOfWork.Brands;
                var brand = new Models.Brand
                {
                    Name = "Fuller"
                };

                brands.Add(brand);

                unitOfWork.Save();
            }
        }

        static void PatternStrategy()
        {
            var context = new Context(new CarStrategy());
            context.Run();

            context.Strategy = new MotoStrategy();
            context.Run();

            context.Strategy = new BicycleStrategy();
            context.Run();
        }

        static void PatternBuilder()
        {
            var builder = new PreparedAlcoholicDrinkConcreteBuilder();
            var barmanDirector = new BarmanDirector(builder);

            //barmanDirector.PrepareMargarita();
            barmanDirector.PreparePinaColada();

            var preparedBeverage = builder.GetPreparedBeverage();

            Console.WriteLine(preparedBeverage.Result);
        }
    }
}
