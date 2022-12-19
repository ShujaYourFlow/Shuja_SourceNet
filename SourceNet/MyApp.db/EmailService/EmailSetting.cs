using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MyApp.db.Encryption;

namespace MyApp.db.EmailService
{
   public class EmailSetting
    {
        private string fromEmail;

        private readonly IConfiguration _configuration;
        private IEncryption _encrypt;
        public EmailSetting(IConfiguration configuration, IEncryption encrypt)
        {
            _configuration = configuration;
            _encrypt = encrypt;
        }


        public string fromEmailuser()
        {
            if(String.IsNullOrWhiteSpace(fromEmail)){

                fromEmail = _configuration["AppSettings:EMAIL_USER"];
            }
            return fromEmail;
        }

        private string password;
        public string fromEmailuserpassword()
        {
            if(String.IsNullOrWhiteSpace(password)){

                password = _encrypt.Decryptdata(_configuration["AppSettings:EMAIL_PASSWORD"].ToString());
            }
            return password;
        }

      

        private string host;
        public string fromEmailuserhost()
        {
           
            if(String.IsNullOrWhiteSpace(host)){

                host = _configuration["AppSettings:EMAIL_HOST"];
            }
            return host;
        }
    
    
    }
}
