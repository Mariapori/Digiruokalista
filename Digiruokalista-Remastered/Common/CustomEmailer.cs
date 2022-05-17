using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MimeKit;

namespace Digiruokalista_Remastered.Common
{
    public class CustomEmailer : IEmailSender
    {
        public CustomEmailer(IOptions<CustomEmailerOptions> options)
        {
            this.Options = options.Value;
        }
        public CustomEmailerOptions Options { get; set; }
        public class CustomEmailerOptions
        {
            public CustomEmailerOptions()
            {

            }
            public string Email { get; set; }
            public string Host { get; set; }
            public int Port { get; set; }
            public bool UseSSL { get; set; }
            public string Password { get; set; }
        }
        public Task SendEmailAsync(string toEmail, string subject, string htmlMessage)
        {
            using(var smtpClient = new SmtpClient())
            {
                smtpClient.Connect(Options.Host, Options.Port, Options.UseSSL);
                smtpClient.Authenticate(Options.Email, Options.Password);
                var viesti = new MimeMessage();
                viesti.From.Add(InternetAddress.Parse(Options.Email));
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
