using EFCDomain.Data;
using EFCDomain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EFCData.Context;
using Microsoft.EntityFrameworkCore;

namespace EFCData.Data
{
    public class CustomerData : ICustomerData
    {
        private readonly EFCContext Db;
        private readonly DbSet<Customer> DbSet;

        public CustomerData(EFCContext context)
        {
            Db = context;
            DbSet = Db.Set<Customer>();
        }

        #region Read
        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<Customer> GetByEmail(string email)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.Email == email);
        }

        public async Task<Customer> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }
        #endregion

        #region write
        public void Add(Customer customer)
        {
            DbSet.Add(customer);
        }

        public void Remove(Customer customer)
        {
            DbSet.Remove(customer);
        }

        public void Update(Customer customer)
        {
            DbSet.Update(customer);
        }
        #endregion

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}