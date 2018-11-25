using System.Threading.Tasks;

namespace Schematic.Core
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}