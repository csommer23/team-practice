
using System.Threading.Tasks;
using Team.Practice.Domain.Models;
using Team.Practice.Infra.Data.Repository.Interfce;
using Team.Practice.Services.Interfaces;

namespace Team.Practice.Services.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerServices(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public bool IsValid(Customer customer)
        {
            if (customer.Name.Equals(string.Empty))
                return false;

            return true;
        }

        public async Task CreateAsync(Customer customer)
        {
            if (!IsValid(customer)) return;
            await _customerRepository.AddAsync(customer);
        }       

        public void Dispose()
        {
            _customerRepository.Dispose();
        }        
    }
}
