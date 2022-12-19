using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Entity;
using MyApp.Entity.Entities;

namespace MyApp.db.EmailService
{
    public interface IEmailConfig
    {
        EmailStatus SendEmail(ContactUsEntity CUE,string body);
        EmailStatus SendEmailOtp(ContactUsEntity CUE, string templatepath, string OTP);
        EmailStatus SendEmailConfirm(ContactUsEntity CUE, string templatepath);

    }
}
