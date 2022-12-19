using MyApp.Entity;
using MyApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.db.SqlFunctions
{
    public interface IBalCustomer
    {
        String SaveCustomer(String pMode, EntityCustomer oEntity, ref string OutPutParam, ref string customerkey);

        DataTable Get<T>(String pMode, T pKey, String pSEARCH_TEXT, Int16 pCompanyKey, ref String pMsg, String pAccYr, Int16? pCompany_key);
        
    }
}
