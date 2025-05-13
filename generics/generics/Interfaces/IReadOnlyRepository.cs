using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics.Interfaces
{
    public interface IReadOnlyRepository<out TEntity, in TKey>
    {
        TEntity GetEntity(TKey id);
        IEnumerable<TEntity> GetAll();
    }
}
