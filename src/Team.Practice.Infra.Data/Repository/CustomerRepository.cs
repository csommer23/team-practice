using System.Threading.Tasks;
using Team.Practice.Domain.Interfaces;
using Team.Practice.Domain.Models;

namespace Team.Practice.Infra.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        //TODO: Create ctor with dependence context

        public Task CreateAsync(Customer customer)
        {
            //TODO: Create method async
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
