using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Flight_kursach.Services.Mailing;

namespace Flight_kursach.Extensions
{
    public static class EmailSenderExtensions
    {
        public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link)
        {
            return emailSender.SendEmailAsync(email, "Подтвердите ваш адрес электронной почты",
                $"Подтвердите ваш адрес электронной почты <a href='{HtmlEncoder.Default.Encode(link)}'>link</a>");
        }
    }
}
