using EFCData.Context;
using EFCDomain.Data;
using EFCDomain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EFCData.Data
{
    public class CustomerData : Data<Customer>, ICustomerData
    {
        public CustomerData(EFCContext context) : base(context)
        { }

        #region Read
        public async Task<Customer> GetByEmail(string email)
        {
            return await _context.Customers.AsNoTracking().FirstOrDefaultAsync(c => c.Email == email);
        }
        #endregion
    }
}