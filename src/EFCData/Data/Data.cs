using EFCData.Context;
using EFCDomain.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EFCDomain.Models;

namespace EFCData.Data
{
    public class Data<T> : IData<T> where T : class, IAggregateRoot
    {
        protected readonly EFCContext _context;

        protected Data(EFCContext context)
        {
            _context = context;
        }

        #region read
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        #endregion

        #region write
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        #endregion
        
        public void Dispose() => _context.Dispose();
    }
}