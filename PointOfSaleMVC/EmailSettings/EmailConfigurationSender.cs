using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;

namespace PointOfSaleMVC.EmailSer
{
    public class EmailConfigurationSender : IEmailConfigurationSender
    {
        private readonly EmailSettings _emailSettings;

        public EmailConfigurationSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            using (var client = new SmtpClient())
            {
                client.Host = _emailSettings.SmtpServer;
                client.Port = _emailSettings.SmtpPort;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(_emailSettings.Email, _emailSettings.Password);
                client.EnableSsl = true;

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(_emailSettings.Email),
                    Subject = subject,
                    Body = message,
                    IsBodyHtml = true
                };

                mailMessage.To.Add(email);

                await client.SendMailAsync(mailMessage);
            }
        }
    }

}
