using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Repository
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> Get();

        Beer Get(int id);

        void Add(Beer data);

        void Delete(int id);

        void Update(Beer data);

        void Save();
    }
}
