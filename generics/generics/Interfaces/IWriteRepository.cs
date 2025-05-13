using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.Interfaces
{
    public interface IWriteRepository<in TEntity, in TKey>
    {
        void Add(TEntity entity);
        void Remove(TKey id);
    }
}
