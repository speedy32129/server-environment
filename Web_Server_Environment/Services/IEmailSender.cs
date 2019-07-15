using System.Threading.Tasks;

namespace Web_Server_Environment.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
