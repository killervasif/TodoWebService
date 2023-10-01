using System.Net.Mail;
using System.Net;

namespace TodoWebService.Services
{
    public class MailService : IMailService
    {
        private readonly string _email;
        private readonly string _password;

        public MailService()
        {
            _email = "incorporatedecommerce@gmail.com";
            _password = "euxmstrqlonxxpmz";
        }

        public void SendAlertMessage(string userMail, string receiverName)
        {
            using var smtp = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(_email, _password)
            };

            using var message = new MailMessage()
            {

                IsBodyHtml = false,
                Subject = "Ecommerce Email confirmation",
                Body = $"Dear user {receiverName} you have one day to finish your work"
            };

            message.From = new MailAddress(_email);
            message.To.Add(new MailAddress(userMail));

            smtp.Send(message);
        }
    }

}