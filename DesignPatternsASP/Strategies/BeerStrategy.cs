using DesignPattern.Repository;
using DesignPatterns.Models.Data;
using DesignPatternsASP.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsASP.Strategies
{
    public class BeerStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            var beer = new Beer()
            {
                Name = beerVM.Name,
                Style = beerVM.Style,
                BranId = (Guid)beerVM.BrandId
            };

            unitOfWork.Beers.Add(beer);
            unitOfWork.Save();
        }
    }
}
