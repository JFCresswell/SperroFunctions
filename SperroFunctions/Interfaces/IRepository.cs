using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Interfaces
{
    public interface IRepository<TEntity, in TKey> where TEntity : class
    {
        int Count { get; }
        TEntity GetById(TKey id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
