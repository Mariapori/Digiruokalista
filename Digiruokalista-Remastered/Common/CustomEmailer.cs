using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;

namespace Digiruokalista_Remastered.Common
{
    public class CustomEmailer : IEmailSender
    {
        public string host { get; set; } = null!;
        public string password { get; set; } = null!;
        public int port { get; set; } = default!;
        public bool useSSL { get; set; } = default!;
        public string email { get; set; } = null!;

        public Task SendEmailAsync(string toEmail, string subject, string htmlMessage)
        {
            using(var smtpClient = new SmtpClient())
            {
                smtpClient.Connect(host, port,useSSL);
                smtpClient.Authenticate(email, password);
                var viesti = new MimeMessage();
                viesti.From.Add(InternetAddress.Parse(email));
                viesti.To.Add(InternetAddress.Parse(toEmail));
                viesti.Subject = subject;
                var bodybuilder = new BodyBuilder();
                bodybuilder.HtmlBody = htmlMessage;
                viesti.Body = bodybuilder.ToMessageBody();
                smtpClient.SendAsync(viesti);
            }
            return Task.CompletedTask;
        }
    }
}
