using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCDomain.Data
{
    public interface IData<T> : IDisposable where T : class
    {
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();

        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}