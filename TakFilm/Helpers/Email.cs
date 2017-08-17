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
                return "Leilanasrollahi1368@gmail.com";
            else
                return "";
        }
        public static MailAddress GetMailAddress(EmailType type)
        {
            if (type == EmailType.Info)
                return new MailAddress("Leilanasrollahi1368@gmail.com", "تک فیلم");
           
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
                    Credentials = new NetworkCredential("Leilanasrollahi1368@gmail.com", "Leila1368")
                };
           
            else
                return new SmtpClient();
        }


    }
}