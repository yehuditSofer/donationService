using Newtonsoft.Json.Linq;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MailSendingWithWebApi.Controllers
{
    public class EmailController : ApiController
    {
        public async Task SendEmail()
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress("yehudit sofer < sey.yes656@gmail.com>"));
            message.From = new MailAddress("yehudit sofer <amitmohanty@email.com>");
            message.Subject = "הצלחת תשלום";
            message.Body = createEmailBody("yehudit sofer", "התשלום בוצע בהצלחה");
            message.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                await smtp.SendMailAsync(message);
                await Task.FromResult(0);
            }
        }

        private string createEmailBody(string userName, string message)
        {
            string body = string.Empty;
            using (StreamReader reader = new StreamReader(HttpContext.Current.Server.MapPath("/htmlTemplate.html")))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{UserName}", userName);
            body = body.Replace("{message}", message);
            return body;
        }
    }
}