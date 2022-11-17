using DesignPatterns.Models;
using DesignPatterns.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IRepository<Beer> Beers { get; }
        public IRepository<Brand> Brands { get; }
        public void Save();
    }
}
