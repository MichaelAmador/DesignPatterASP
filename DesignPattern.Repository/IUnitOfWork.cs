using DesignPatterns.Models.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository
{
    public interface IUnitOfWork
    {
        public IRepository<Beer> Beers { get; }
        public IRepository<Brand> Brands { get; }
        public void Save();
    }
}
