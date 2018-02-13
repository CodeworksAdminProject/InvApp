using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    class SMTP_CLIENT
    {
        string Style;
        string Html;
 
        public void SentMail(string body, string email)
        {
            Style = "<style>";
            Style = Style + "TABLE{border-width: 1px;border-style: solid;border-color: black;border-collapse: collapse;}";
            Style = Style + "TH{border-width: 2px;padding: 0px;border-style: solid;border-color: black;background-color:thistle;}";
            Style = Style + ".select1{border-width: 2px;padding: 0px;border-style: solid;border-color: black;background-color:palegoldenrod; text-indent: 1em;}";
            Style = Style + ".select2{border-width: 2px;padding: 0px;border-style: solid;border-color: black;background-color:LightSkyBlue; text-indent: 1em;}";
            Style = Style + "TD{border-width: 2px;padding: 0px;border-style: solid;border-color: black;background-color:palegoldenrod;}";
            Style = Style + "</style>";

            Html = "<!DOCTYPE HTML>";
            Html = Html + "<html>";
            Html = Html + "<head>"+ Style;
            Html = Html + "<meta charset='utf-8'>";
            Html = Html + "<title>Таблица Железа </title>";
            Html = Html + "<body>";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("report@codeworks.by", "Изменения  в базе  инвентаризации");
                mail.To.Add(new MailAddress(email));
                mail.Subject = "Пользователем " + System.Environment.UserName + " в базу инвентаризации внесены  изменения";
                mail.IsBodyHtml = true;
                mail.Body = Html + body + "</body></html>";

                SmtpClient client = new SmtpClient();
                client.Host = "mail.codeworks.by";
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("report@codeworks.by", "g4b5M249G");
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                client.Send(mail);
                mail.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void SentMail(string body, string email, string subject, string fileName)
        {
            Style = "<style>";
            Style = Style + "TABLE{border-width: 1px;border-style: solid;border-color: black;border-collapse: collapse;}";
            Style = Style + "TH{border-width: 2px;padding: 0px;border-style: solid;border-color: black;background-color:thistle;}";
            Style = Style + ".select1{border-width: 2px;padding: 0px;border-style: solid;border-color: black;background-color:palegoldenrod; text-indent: 1em;}";
            Style = Style + ".select2{border-width: 2px;padding: 0px;border-style: solid;border-color: black;background-color:LightSkyBlue; text-indent: 1em;}";
            Style = Style + "TD{border-width: 2px;padding: 0px;border-style: solid;border-color: black;background-color:palegoldenrod;}";
            Style = Style + "</style>";

            Html = "<!DOCTYPE HTML>";
            Html = Html + "<html>";
            Html = Html + "<head>" + Style;
            Html = Html + "<meta charset='utf-8'>";
            Html = Html + "<title>Таблица Железа </title>";
            Html = Html + "<body>";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("report@codeworks.by", "От пользователеля: " + System.Environment.UserName + ". Сообщение для разработчиков");
                mail.To.Add(new MailAddress(email));

                if (fileName != null)
                {
                    System.Net.Mail.Attachment file = new Attachment(fileName);
                    mail.Attachments.Add(file);
                }
                    

                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = Html + body + "</body></html>";                      

                SmtpClient client = new SmtpClient();
                client.Host = "mail.codeworks.by";
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("report@codeworks.by", "g4b5M249G");
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                client.Send(mail);
                mail.Dispose();
                MessageBox.Show("Ваше сообщение отправлено!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
