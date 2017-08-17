using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TakFilmClass.Helpers;
using System.Net;
using System.Net.Mail;



namespace TakFilmClass.Helpers
{
    public enum EmailType { Empty, Info }

    public class Email
    {
        public static string GetMailName(EmailType type)
        {
            if (type == EmailType.Info)
                return "LeilaAsp.Net@gmail.com";
            else
                return "";
        }
        public static MailAddress GetMailAddress(EmailType type)
        {
            if (type == EmailType.Info)
                return new MailAddress("LeilaAsp.Net@gmail.com", "تک فیلم");
           
            else
                return new MailAddress("");
        }

        public static SmtpClient GetSmtp(EmailType type)
        {
            if (type == EmailType.Info)
                return new SmtpClient
                {
                    Host = "Smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("LeilaAsp.Net@gmail.com", "Leila13681396")
                };
           
            else
                return new SmtpClient();
        }


    }
}