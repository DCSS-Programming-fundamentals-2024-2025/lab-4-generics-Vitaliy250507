using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using generics.Interfaces;

namespace generics.Entities
{
    public class InMemoryRepository<TEntity, TKey> : IRepository<TEntity, TKey>, IReadOnlyRepository<TEntity, TKey>
    where TEntity : class
    where TKey : struct
    {
        private Dictionary<TKey, TEntity> _storage = new Dictionary<TKey, TEntity>();


        public void Add(TKey id, TEntity entity)
        {
            _storage[id] = entity;
        }
        public TEntity Get(TKey id) 
        {
            if (_storage.TryGetValue(id, out var entity))
            {
                return entity;
            }
            throw new KeyNotFoundException($"Key {id} not found in repository.");
        }

        public TEntity GetEntity(TKey id) 
        {
            if (_storage.TryGetValue(id, out var entity))
            {
                return entity;
            }
            throw new KeyNotFoundException($"Key {id} not found in repository.");
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _storage.Values;
        }
        public void Remove(TKey id)
        {
            _storage.Remove(id);
        }
    }
}
