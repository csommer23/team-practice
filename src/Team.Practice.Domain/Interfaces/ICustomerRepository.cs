using System;
using System.Threading.Tasks;
using Team.Practice.Domain.Models;

namespace Team.Practice.Domain.Interfaces
{
    public interface ICustomerRepository : IDisposable
    {
        Task CreateAsync(Customer customer);
    }
}
