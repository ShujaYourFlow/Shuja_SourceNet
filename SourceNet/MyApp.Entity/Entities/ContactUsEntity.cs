using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApp.Entity.Entities
{
    public class ContactUsEntity
    {
        public string Name { get; set; }
        public string subject { get; set; }
        public string emailaddress { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string host { get; set; }
        public string company { get; set; }
        public string position { get; set; }
        public string ToUser { get; set; }
        public string body { get; set; }
        public string From { get; set; }
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }


        public string CountryCode { get; set; }
        public string Description { get; set; }
        public string message { get; set; }
        public string CONTACT_NO { get; set; }
        public string FACEBOOK_LINK { get; set; }
        public string TWITTER_LINK { get; set; }
        public string LINKEDIN_LINK { get; set; }
        public string MAIL { get; set; }
        public string GOOGLEPLUS_LINK { get; set; }



    }
}