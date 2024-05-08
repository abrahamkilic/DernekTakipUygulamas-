using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using DAL;
using System.IO;
using System.Windows.Forms;

namespace BL
{
    public class BLEmailSender
    {

        public static List<ELDebt> GetDebts()
        {
            return DALdebt.GetDebts();
        }

        public static void SendEmails(List<ELDebt> debts, string subject, string body, object someOtherValue,string file)
        {
            foreach (var debt in debts)
            {
                SendEmail(debt.email, subject, string.Format(body, debt.DeptAmount,debt.Name,debt.Surname, someOtherValue), file);
            }
        }

        private static void SendEmail(string email, string subject, string body, string file)
        {
            try
            {
                // Geçerli e-posta adresi kontrolü
                MailAddress toAddress = new MailAddress(email);

                // E-posta gönderme işlemini gerçekleştir
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

                SmtpClient client = new SmtpClient();
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("dernektakip@outlook.com", "1dernek234");
                client.Port = 587; // SSL için kullanılan port
                client.Host = "smtp.outlook.com";
                client.EnableSsl = true;

                // E-posta oluştur
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("dernektakip@outlook.com", "Fenerbahçeliler Derneği");
                mail.To.Add(toAddress);
                mail.IsBodyHtml = true;
                mail.Subject = subject;
                mail.Body = body;

                if (!string.IsNullOrEmpty(file) && File.Exists(file))
                {
                    mail.Attachments.Add(new Attachment(file));
                }

                client.Send(mail);
            }
            catch (FormatException )
            {
                
            }
            catch (SmtpException )
            {
                
            }

        }


        public static void SendAutomaticEmails(string subject, string body, object someOtherValue,string file )
        {
            // Borç listesini al
            List<ELDebt> debts = GetDebts();

            // E-posta gönderme işlemini gerçekleştir
            SendEmails(debts, subject, body, someOtherValue,file);
        }
    }
}
