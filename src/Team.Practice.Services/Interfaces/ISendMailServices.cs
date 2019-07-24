
using System;
using System.Threading.Tasks;

namespace Team.Practice.Services.Interfaces
{
    public interface ISendMailServices : IDisposable
    {
        Task Send(object message);
    }
}
