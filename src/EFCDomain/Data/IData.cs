using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EFCDomain.Models;

namespace EFCDomain.Data
{
    public interface IData<T> : IDisposable where T : class, IAggregateRoot
    {
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();

        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}