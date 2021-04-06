using System;
using System.Threading.Tasks;

namespace EFCDomain.Data
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
    }
}