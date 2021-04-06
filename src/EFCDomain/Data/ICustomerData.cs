using EFCDomain.Models;
using System.Threading.Tasks;

namespace EFCDomain.Data
{
    public interface ICustomerData : IData<Customer>
    {
        Task<Customer> GetByEmail(string email);
    }
}