using DesignPatterns.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Repository
{
    public class BeerRepository : IBeerRepository
    {
        private DesignPatternsContext _context;

        public BeerRepository(DesignPatternsContext context)
        {
            _context = context;
        }

        public void Add(Beer data) => _context.Beer.Add(data);

        public void Delete(int id)
        {
            var beer = _context.Beer.Find(id);
            _context.Beer.Remove(beer);
        }

        public IEnumerable<Beer> Get() => _context.Beer.ToList();

        public Beer Get(int id) => _context.Beer.Find(id);

        public void Update(Beer data) => _context.Entry(data).State = EntityState.Modified;

        public void Save() => _context.SaveChanges();
    }
}
