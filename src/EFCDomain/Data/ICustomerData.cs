using EFCDomain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCDomain.Data
{
    public interface ICustomerData : IData<Customer>
    {
        Task<Customer> GetById(Guid id);
        Task<Customer> GetByEmail(string email);
        Task<IEnumerable<Customer>> GetAll();

        void Add(Customer customer);
        void Update(Customer customer);
        void Remove(Customer customer);

        Task<int> SaveChanges();
    }
}