using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AccountigConsumable
{
    public class SenderMail
    {
        public static int IntId { get; set; }
        public static string PosName { get; set; }
        string All = "qwertyuiopasdfghjklzxcvbnm1234567890", result;
        public string SenderCode()
        {
            result = "";
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                result += All[rnd.Next(All.Length)];
            }
            return result;
        }
        public void senderMAil(string email, string code)
        {
            string htmlString = @"<html>
                      <body>
                      <p></p>
                      <p> Ваш код для авторизации в системе: " + code + @".</p></body>
                      <p>С уважением,<br>-Hitcom</br></p>
                      </body>
                      </html>
                     ";
            SmtpClient client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "hitcomlog@gmail.com",
                    Password = "qwenqwen1"
                }

            };
            MailAddress fromEmail = new MailAddress("hitcomlog@gmail.com");
            MailAddress toemail = new MailAddress(email);
            MailMessage Message = new MailMessage()
            {
                From = fromEmail,
                Subject = "Тестирование передеачи сообщений",
                IsBodyHtml = true,
                Body = htmlString
            };
            Message.To.Add(toemail);
            try
            {
                client.Send(Message);
                MessageBox.Show("отправленно", "done");
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong" + ex.InnerException.Message, "error");
            }

        }
    }
}
