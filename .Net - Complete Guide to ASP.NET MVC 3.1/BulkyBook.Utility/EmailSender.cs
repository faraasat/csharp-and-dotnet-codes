using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace BulkyBook.Utility
{
    public class EmailSender : IEmailSender
    {

        private readonly EmailOptions emailOptions;

        public EmailSender(IOptions<EmailOptions> options)
        {
            emailOptions = options.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            await Execute(emailOptions.SendGridKey, subject, htmlMessage, email);
        } 

        private async Task Execute(string sendFGridKey, string subject, string message, string email)
        {
            var client = new SendGridClient(sendFGridKey);
            var from = new EmailAddress("farasataliazeemi1@gmail.com", "Bulky Books");
            var to = new EmailAddress(email, "End User");
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "", message);
            var response = await client.SendEmailAsync(msg);
            Console.WriteLine(response.Body.ToString());
            Console.WriteLine(response.Body.Headers);
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Headers);
            Console.WriteLine("Hello");
        }

    }
}
