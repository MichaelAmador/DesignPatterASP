using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Repository
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity Get(int id);
        void Add(TEntity data);
        void Delete(int id);
        void Update(TEntity data);
        void Save();
    }
}
