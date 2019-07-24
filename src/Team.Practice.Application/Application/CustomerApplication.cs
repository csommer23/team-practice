using System.Threading.Tasks;
using Team.Practice.Application.Interfaces;
using Team.Practice.Domain.Models;
using Team.Practice.Services.Interfaces;

namespace Team.Practice.Application.Application
{
    public class CustomerApplication : ICustomerApplication
    {
        private readonly ICustomerServices _customerServices;
        private readonly ISendMailServices _sendMailServices;

        public CustomerApplication(ICustomerServices customerServices, ISendMailServices sendMailServices)
        {
            _customerServices = customerServices;
            _sendMailServices = sendMailServices;
        }      

        public async Task RegisterNewCustomerAndSendMail(Customer customer)
        {
            await _customerServices.CreateAsync(customer);
            await _sendMailServices.Send(customer);
        }

        public void Dispose()
        {
            _customerServices.Dispose();
            _sendMailServices.Dispose();
        }
    }
}
