using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using Team.Practice.Domain.Models;
using Team.Practice.Infra.Data.Repository.Interfce;

namespace Team.Practice.Infra.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task AddAsync(Customer obj)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Customer> GetByIdAsync(ObjectId id)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveAsync(ObjectId id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Customer obj)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
