namespace KupujemProdajemWebScraping.Tools
{
    using KupujemProdajemWebScraping.Interfaces;
    using System.Net.Mail;

    public class EmailNotifier : IEmailNotifier
    {
        private readonly string _smtpServer = "smtp.example.com";
        private readonly int _port = 587;
        private readonly string _senderEmail = "your_email@example.com";
        private readonly string _password = "your_password";

        public async Task SendEmailAsync(string recipient, string subject, string body)
        {
            using var client = new SmtpClient(_smtpServer, _port)
            {
                Credentials = new System.Net.NetworkCredential(_senderEmail, _password),
                EnableSsl = true
            };

            var mail = new MailMessage(_senderEmail, recipient, subject, body);
            await client.SendMailAsync(mail);
        }
    }
}