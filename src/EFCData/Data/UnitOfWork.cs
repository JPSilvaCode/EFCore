using System.Threading.Tasks;
using EFCData.Context;
using EFCDomain.Data;

namespace EFCData.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFCContext _context;

        public UnitOfWork(EFCContext context)
        {
            _context = context;
        }

        public async Task<bool> Commit()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Dispose() => _context.Dispose();
    }
}