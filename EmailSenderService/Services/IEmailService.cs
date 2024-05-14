using MimeKit;
using MailKit.Net.Smtp;

namespace EmailSenderService.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
