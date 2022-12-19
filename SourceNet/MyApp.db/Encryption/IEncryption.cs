using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.db.Encryption
{
   public interface IEncryption
    {
        String Encryptdata(String strText);
        String Decryptdata(String strText);
        string EncryptASCII(string strText);
        string DecryptASCII(string strText);


    }
}
