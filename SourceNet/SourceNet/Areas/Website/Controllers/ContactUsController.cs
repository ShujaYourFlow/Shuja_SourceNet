using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MimeKit;
using MyApp.db.Encryption;
using MyApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SourceNet.Areas.Website.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        DataTable dt = new DataTable();
        private string errMsg = string.Empty;
        private readonly IEncryption _encrypt;

        //public IActionResult contactus()
        //{
        //    ViewBag.PageTitle = "Contact Us";
        //    //ContactUsEntity cue = new ContactUsEntity
        //    //{
        //    //    ToUser = new String { "jigyasabansal14@gmail.com" }

        //    //};
        //    //SendEmail(cue, body);
        //    return View();
        //}

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
      
        private readonly IMailService mailService;

        [HttpPost()]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMail([FromForm] ContactUsEntity request)
        {
            try
            {
                await SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        private readonly ContactUsEntity _mailSettings;
        public ContactUsController(IOptions<ContactUsEntity> mailSettings, IEncryption encrypt)
        {
            _encrypt = encrypt;
            _mailSettings = mailSettings.Value;
            this.mailService = mailService;
        }
        public async Task SendEmailAsync(ContactUsEntity mailRequest)
        {

            var email = new MimeMessage();
            string body = string.Empty;
           
            email.Sender = MailboxAddress.Parse(_mailSettings.From);
            email.To.Add(MailboxAddress.Parse(mailRequest.emailaddress));
            //email.Subject = mailRequest.subject;
            var builder = new BodyBuilder();

            builder.HtmlBody = mailRequest.Description;
            email.Body = builder.ToMessageBody();

            using var smtp = new MailKit.Net.Smtp.SmtpClient();

            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            try
            {
                smtp.Authenticate(_mailSettings.UserName, _encrypt.Decryptdata(_mailSettings.password));
            }
            catch (Exception ex)
            {

            }

            await smtp.SendAsync(email);
            smtp.Disconnect(true);

        }
    }
    public interface IMailService
    {
        Task SendEmailAsync(ContactUsEntity mailRequest);

    }
   
}

