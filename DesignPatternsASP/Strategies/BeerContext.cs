using DesignPattern.Repository;
using DesignPatternsASP.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsASP.Strategies
{
    public class BeerContext
    {
        public IBeerStrategy _beerStrategy;

        public IBeerStrategy BeerStrategy
        {
            set
            {
                _beerStrategy = value;
            }
        }

        public BeerContext(IBeerStrategy beerStrategy)
        {
            _beerStrategy = beerStrategy;
        }

        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            _beerStrategy.Add(beerVM, unitOfWork);
        }
    }
}
