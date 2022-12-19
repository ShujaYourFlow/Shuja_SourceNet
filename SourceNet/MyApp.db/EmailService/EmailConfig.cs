using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MyApp.Entity;
using Microsoft.Extensions.Configuration;
using MyApp.db.Encryption;
using MyApp.Entity.Entities;

namespace MyApp.db.EmailService
{
    public class EmailConfig : IEmailConfig
    {
        private IConfiguration _config;
        private IEncryption _encrypt;
        public EmailConfig(IConfiguration config, IEncryption encrypt)
        {
            _config = config;
            _encrypt = encrypt;

        }
        public EmailStatus SendEmail(ContactUsEntity CUE,string body)
        {
            EmailStatus es = new EmailStatus();
            EmailSetting est = new EmailSetting(_config, _encrypt);

            try
            {
                using (var client = new SmtpClient())
                {
                    client.Host = est.fromEmailuserhost();
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(est.fromEmailuser(), est.fromEmailuserpassword());


                    var message = new MailMessage();
                    message.To.Add(new MailAddress(CUE.ToUser));
                    message.From = new MailAddress(est.fromEmailuser(), "Social Outcome Solutions - Marketplace");
                    message.Subject = CUE.subject;
                   
                    message.Body = body;
                    message.BodyEncoding = Encoding.UTF8;
                    message.IsBodyHtml = true;

                    client.Send(message);
                }
                es.Status = true;
                es.errMsg = null;


            }
            catch (Exception ex)
            {
                while (ex.InnerException != null) { ex = ex.InnerException; }
                es.Status = false;
                es.errMsg = ex.Message.ToString();
            }

            return es;
        }
        public EmailStatus SendEmailOtp(ContactUsEntity CUE,string templatepath,string OTP)
        {
            EmailStatus es = new EmailStatus();
            EmailSetting est = new EmailSetting(_config, _encrypt);

            try
            {


                string body = string.Empty;
                using (StreamReader reader = new StreamReader(templatepath))
                {
                    body = reader.ReadToEnd();
                    body = body.Replace("USERNAME", CUE.Name.ToString());
                    body = body.Replace("OTP", OTP);
                }


                using (var client = new SmtpClient())
                {
                    client.Host = est.fromEmailuserhost();
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(est.fromEmailuser(), est.fromEmailuserpassword());


                    var message = new MailMessage();
                    message.To.Add(new MailAddress(CUE.ToUser));
                    message.From = new MailAddress(est.fromEmailuser(), "Social Outcome Solutions - Marketplace");
                    message.Subject = CUE.subject;
                   
                    message.Body = body;
                    message.BodyEncoding = Encoding.UTF8;
                    message.IsBodyHtml = true;

                    client.Send(message);
                }
                es.Status = true;
                es.errMsg = null;


            }
            catch (Exception ex)
            {
                while (ex.InnerException != null) { ex = ex.InnerException; }
                es.Status = false;
                es.errMsg = ex.Message.ToString();
            }

            return es;
        }
        public EmailStatus SendEmailConfirm(ContactUsEntity CUE,string templatepath)
        {
            EmailStatus es = new EmailStatus();
            EmailSetting est = new EmailSetting(_config, _encrypt);

            try
            {


                string body = string.Empty;
                using (StreamReader reader = new StreamReader(templatepath))
                {
                    body = reader.ReadToEnd();
                    body = body.Replace("USERNAME", CUE.Name.ToString());
                 
                }


                using (var client = new SmtpClient())
                {
                    client.Host = est.fromEmailuserhost();
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(est.fromEmailuser(), est.fromEmailuserpassword());


                    var message = new MailMessage();
                    message.To.Add(new MailAddress(CUE.ToUser));
                    message.From = new MailAddress(est.fromEmailuser(), "Social Outcome Solutions - Marketplace");
                    message.Subject = CUE.subject;
                   
                    message.Body = body;
                    message.BodyEncoding = Encoding.UTF8;
                    message.IsBodyHtml = true;

                    client.Send(message);
                }
                es.Status = true;
                es.errMsg = null;


            }
            catch (Exception ex)
            {
                while (ex.InnerException != null) { ex = ex.InnerException; }
                es.Status = false;
                es.errMsg = ex.Message.ToString();
            }

            return es;
        }

       
    }


    public class EmailStatus
    {
        public bool Status { get; set; }
        public string errMsg { get; set; }
    }

    

}
