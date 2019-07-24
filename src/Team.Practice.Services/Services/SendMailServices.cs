using System.Threading.Tasks;
using Team.Practice.Services.Interfaces;

namespace Team.Practice.Services.Services
{
    public class SendMailServices : ISendMailServices
    {
        public async Task Send(object message)
        {
            //TODO: Send mail SMTP

            message.ToString();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
