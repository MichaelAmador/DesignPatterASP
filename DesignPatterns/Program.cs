using DesignPatterns.Factory;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //PatternSingleton
            PatternFactory();
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
    }
}
