using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MyApp.db.MydbContext;
using MyApp.Entity;
using MyApp.db.Encryption;
using System.Data.Common;
using MyApp.Entity.Entities;

namespace MyApp.db.SqlFunctions
{
    public class BalCustomer : IBalCustomer
    {
        private readonly AppdbContext _context;
        private readonly IEncryption _encryption;
        Int16 vCount = 0;
        DataTable dt = null;
        DataSet ds = null;
        SqlParameter[] para = null;

        public BalCustomer(AppdbContext context, IEncryption encryption)
        {
            _context = context;
            _encryption = encryption;
        }

        public String SaveCustomer(String pMode, EntityCustomer oEntity, ref string OutPutParam,ref string customerkey)
        {

            try
            {
                vCount = 0;
                para = new SqlParameter[23];
                para[vCount] = new SqlParameter("@SELECT_ACTION", SqlDbType.VarChar, 50);
                para[vCount++].Value = pMode;
                para[vCount] = new SqlParameter("@RETURN_KEY", SqlDbType.Int);
                para[vCount].Direction = ParameterDirection.InputOutput;
                para[vCount++].Value = 0;

                para[vCount] = new SqlParameter("@MAST_CUSTOMER_KEY", SqlDbType.BigInt);
                para[vCount].Direction = ParameterDirection.InputOutput;
                para[vCount++].Value = oEntity.MAST_CUSTOMER_KEY;

                para[vCount] = new SqlParameter("@FIRSTNAME", SqlDbType.VarChar, 200);
                para[vCount++].Value = oEntity.FIRSTNAME == null ? "" : oEntity.FIRSTNAME; 


                para[vCount] = new SqlParameter("@LASTNAME", SqlDbType.VarChar, 200);
                para[vCount++].Value = oEntity.LASTNAME == null ? "" : oEntity.LASTNAME;
                para[vCount] = new SqlParameter("@EMAIL", SqlDbType.VarChar, 200);
                para[vCount++].Value = oEntity.EMAIL == null ? "" : oEntity.EMAIL;

                para[vCount] = new SqlParameter("@PHONE_NO", SqlDbType.VarChar, 20);
                para[vCount++].Value = oEntity.PHONE_NO == null ? "" : oEntity.PHONE_NO;
                para[vCount] = new SqlParameter("@PHONE_CODE", SqlDbType.VarChar, 20);
                para[vCount++].Value = oEntity.PHONE_CODE == null ? "" : oEntity.PHONE_CODE;

                para[vCount] = new SqlParameter("@CUSTOMER_COMPANY_NAME", SqlDbType.VarChar, 500);
                para[vCount++].Value = oEntity.CUSTOMER_COMPANY_NAME == null ? "" : oEntity.CUSTOMER_COMPANY_NAME;
                para[vCount] = new SqlParameter("@CUSTOMER_POSITION", SqlDbType.VarChar, 100);
                para[vCount++].Value = oEntity.CUSTOMER_POSITION == null ? "" : oEntity.CUSTOMER_POSITION;


                para[vCount] = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 200);
                para[vCount++].Value = oEntity.PASSWORD == null ? "" : _encryption.Encryptdata(oEntity.PASSWORD);

                para[vCount] = new SqlParameter("@NEWPASSWORD", SqlDbType.VarChar, 200);
                para[vCount++].Value = oEntity.NEWPASSWORD==null? "" : _encryption.Encryptdata(oEntity.NEWPASSWORD);
                para[vCount] = new SqlParameter("@PROFILE_PIC", SqlDbType.VarChar, 100);
                para[vCount++].Value = oEntity.PROFILE_PIC==null? "" : oEntity.PROFILE_PIC;
                para[vCount] = new SqlParameter("@ADDRESS", SqlDbType.VarChar, 500);
                para[vCount++].Value = oEntity.ADDRESS == null? "" : oEntity.ADDRESS;
                para[vCount] = new SqlParameter("@LAT", SqlDbType.Float);
                para[vCount++].Value = oEntity.LAT == 0? 0 : oEntity.LAT;
                para[vCount] = new SqlParameter("@LONG", SqlDbType.Float);
                para[vCount++].Value = oEntity.LONG == 0? 0 : oEntity.LONG;

                para[vCount] = new SqlParameter("@TAG_ACTIVATION", SqlDbType.Int);
                para[vCount++].Value = oEntity.TAG_ACTIVATION;
                para[vCount] = new SqlParameter("@USER_ROLE", SqlDbType.Int);
                para[vCount++].Value = oEntity.USER_ROLE;


                para[vCount] = new SqlParameter("@ENT_USER_KEY", SqlDbType.Int);
                para[vCount++].Value = oEntity.ENT_USER_KEY;
                para[vCount] = new SqlParameter("@EDIT_USER_KEY", SqlDbType.Int);
                para[vCount++].Value = oEntity.EDIT_USER_KEY;
                para[vCount] = new SqlParameter("@TAG_ACTIVE", SqlDbType.TinyInt);
                para[vCount++].Value = oEntity.TAG_ACTIVE;
                para[vCount] = new SqlParameter("@TAG_DELETE", SqlDbType.TinyInt);
                para[vCount++].Value = oEntity.TAG_DELETE;
                para[vCount] = new SqlParameter("@TRIAL_CUSTOMER_COMPANY", SqlDbType.VarChar);
                para[vCount++].Value = oEntity.TRIAL_CUSTOMER_COMPANY == null ? "" : oEntity.TRIAL_CUSTOMER_COMPANY;

                DbConnection connection = _context.Database.GetDbConnection();
                DbProviderFactory dbFactory = DbProviderFactories.GetFactory(connection);
                using (var cmd = dbFactory.CreateCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_SAVE_MAST_CUSTOMER";
                    if (para != null)
                    {
                        foreach (var item in para)
                        {
                            cmd.Parameters.Add(item);
                        }
                    }
                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    //outputparam = Convert.ToString(cmd.Parameters["@RETURN_KEY"].Value);
                    OutPutParam = Convert.ToString(cmd.Parameters["@RETURN_KEY"].Value);
                    customerkey = Convert.ToString(cmd.Parameters["@MAST_CUSTOMER_KEY"].Value);
                    cmd.Connection.Close();


                }



                return OutPutParam.ToString();
            }

            catch (Exception ex)
            {

                return "0";
            }
        }

        public DataTable Get<T>(String pMode, T pKey, String pSEARCH_TEXT, Int16 pCompanyKey, ref String pMsg, String pAccYr, Int16? pCompany_key)
        {

            try
            {
                dt = new DataTable();
                vCount = 0;
                para = new SqlParameter[5];
                para[vCount] = new SqlParameter("@GET_REC_TYPE", SqlDbType.VarChar, 20);
                para[vCount++].Value = pMode;
                para[vCount] = new SqlParameter("@SEARCH_KEY", SqlDbType.Int);
                para[vCount++].Value = pKey;
                para[vCount] = new SqlParameter("@SEARCH_TEXT", SqlDbType.VarChar, 50);
                para[vCount++].Value = pSEARCH_TEXT;
                para[vCount] = new SqlParameter("@COMPANY_KEY", SqlDbType.SmallInt);
                para[vCount++].Value = pCompanyKey;
                para[vCount] = new SqlParameter("@COMPANY_DB_NAME", SqlDbType.VarChar, 50);
                para[vCount++].Value = "";


                //var stotreprocstring = "SP_GET_SYS_USER @GET_REC_TYPE, @SEARCH_KEY,@SEARCH_TEXT, " +
                //    "@COMPANY_KEY,@COMPANY_DB_NAME";

                DbConnection connection = _context.Database.GetDbConnection();
                DbProviderFactory dbFactory = DbProviderFactories.GetFactory(connection);
                using (var cmd = dbFactory.CreateCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_GET_SYS_USER";
                    if (para != null)
                    {
                        foreach (var item in para)
                        {
                            cmd.Parameters.Add(item);
                        }
                    }
                    using (DbDataAdapter adapter = dbFactory.CreateDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                    }
                }

            }
            catch (Exception ex)
            {
                pMsg = ex.Message;
            }
            return dt;
        }


    }
}
