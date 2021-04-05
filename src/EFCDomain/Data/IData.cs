using System;
using EFCDomain.Models;

namespace EFCDomain.Data
{
    public interface IData<T> : IDisposable where T : IAggregateRoot
    {
        
    }
}