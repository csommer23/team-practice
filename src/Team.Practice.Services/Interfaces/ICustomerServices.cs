using System;
using System.Threading.Tasks;
using Team.Practice.Domain.Models;

namespace Team.Practice.Services.Interfaces
{
    public interface ICustomerServices : IDisposable
    {
        bool IsValid(Customer customer);
        Task CreateAsync(Customer customer);
    }
}
