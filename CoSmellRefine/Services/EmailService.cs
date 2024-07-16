using System.Net.Mail;
using System.Net;

namespace CoSmellRefine.Services
{
    public class EmailService
    {
        private readonly string _outlookAddress;
        private readonly string _outlookPassword;

        public EmailService(IConfiguration configuration)
        {
            _outlookAddress = configuration["Outlook:OutlookAddress"];
            _outlookPassword = configuration["Outlook:OutlookPassword"];

        }

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            var client = new SmtpClient("smtp.office365.com", 587)
            {
                Credentials = new NetworkCredential(_outlookAddress, _outlookPassword),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(_outlookAddress),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };

            mailMessage.To.Add(toEmail);

            await client.SendMailAsync(mailMessage);
        }
    }
}
