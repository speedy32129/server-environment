using System.Threading.Tasks;

namespace Web_Server_Environment.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
