using System;
using System.Threading.Tasks;
using Team.Practice.Domain.Models;

namespace Team.Practice.Application.Interfaces
{
    public interface ICustomerApplication : IDisposable
    {
        Task RegisterNewCustomerAndSendMail(Customer customer);
    }
}
