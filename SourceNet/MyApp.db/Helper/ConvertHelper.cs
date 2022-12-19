using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MyApp.Entity;
using System.Reflection;
using MyApp.Entity.Entities;

namespace MyApp.db.Helper
{
   public class ConvertHelper : IConvertHelper
    {
        private readonly IConfiguration _configuration;

        public ConvertHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string DataTableToJSONWithStringBuilder(DataTable table)
        {
            var JSONString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                JSONString.Append("[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }
            return JSONString.ToString();
        }




        #region Image

        public string SaveSingleImage(IFormFile file, string hostingpath, ref string profilepic)
        {


                
                try
                {
             
                  var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".webp", ".svg", ".jfif" };
                    String DOC_PATH = hostingpath + _configuration["AppSeettings:PROFILE_PATH"];
                    var ext = Path.GetExtension(file.FileName);
                    if (allowedExtensions.Contains(ext.ToLower()))
                    {
                    string imagename = System.DateTime.Now.ToString("yyyyMMdd_hhmmssffff") + ext;
                        string filepath = DOC_PATH + imagename;

                        using (Stream fileStream = new FileStream(filepath, FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }

                    profilepic = imagename;
                    }
                    else
                    {
                        return "Please Upload only image file";
                    }


                    return String.Empty;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                finally
                {

                }
            

        }
     
        
        public string SaveSingleProductImage(IFormFile file, string hostingpath, ref string productpic)
        {


                
                try
                {
             
                  var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".webp", ".svg", ".jfif" };
                    String DOC_PATH = hostingpath;
                    var ext = Path.GetExtension(file.FileName);
                    if (allowedExtensions.Contains(ext.ToLower()))
                    {
                    string imagename = System.DateTime.Now.ToString("yyyyMMdd_hhmmssffff") + ext;
                        string filepath = DOC_PATH + imagename;

                        using (Stream fileStream = new FileStream(filepath, FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }

                    productpic = imagename;
                    }
                    else
                    {
                        return "Please Upload only image file";
                    }


                    return String.Empty;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                finally
                {

                }
            

        }
        
        public string SaveBusinessLogoImage(IFormFile file, string hostingpath, ref string profilepic)
        {


                
                try
                {
             
                  var allowedExtensions = new[] { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".webp", ".svg", ".jfif" };
                    String DOC_PATH = hostingpath + _configuration["AppSeettings:BUSINESS_LOGO_PATH"];
                    var ext = Path.GetExtension(file.FileName);
                    if (allowedExtensions.Contains(ext.ToLower()))
                    {
                    string imagename = System.DateTime.Now.ToString("yyyyMMdd_hhmmssffff") + ext;
                        string filepath = DOC_PATH + imagename;

                        using (Stream fileStream = new FileStream(filepath, FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }

                    profilepic = imagename;
                    }
                    else
                    {
                        return "Please Upload only image file";
                    }


                    return String.Empty;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                finally
                {

                }
            

        }



        public string SaveSingleProductpdf(IFormFile file, string hostingpath, ref string productpdf)
        {



            try
            {

                var allowedExtensions = new[] { ".pdf", ".docx" };
                String DOC_PATH = hostingpath;
                var ext = Path.GetExtension(file.FileName);
                if (allowedExtensions.Contains(ext.ToLower()))
                {
                    string imagename = System.DateTime.Now.ToString("yyyyMMdd_hhmmssffff") + ext;
                    string filepath = DOC_PATH + imagename;

                    using (Stream fileStream = new FileStream(filepath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    productpdf = imagename;
                }
                else
                {
                    return "Please Upload only Pdf and Docx file";
                }


                return String.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {

            }


        }
        
        public string SaveSingleProductVideo(IFormFile file, string hostingpath, ref string productvideo)
        {



            try
            {


                String DOC_PATH = hostingpath;

                string imagename = System.DateTime.Now.ToString("yyyyMMdd_hhmmssffff") + ".mp4";
                string filepath = DOC_PATH + imagename;

                using (Stream fileStream = new FileStream(filepath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                productvideo = imagename;

                return String.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {

            }


        }

        #endregion


        #region Base64Image


        public string SaveDataUrlToFile(string hostingpath,string dataUrl) //image saving code
        {
            string Images1;
            string folderPath = hostingpath + _configuration["AppSeettings:MESSAGE_IMAGE_PATH"]; ;  //Create a Folder in your Root directory on your solution.
            string base64StringData = dataUrl; // Your base 64 string data
            Images1 = "";
            if (base64StringData != "")
            {
                string[] indexingarrloop = base64StringData.Split('|');

                for (int j = 0; j < indexingarrloop.Length; j++)
                {
                    if(indexingarrloop[j] != "")
                    {
                        indexingarrloop[j] = indexingarrloop[j].Replace("|", "");
                        string fileName = System.DateTime.Now.ToString("yyyyMMdd_hhmmssffff") + ".jpeg"; // set the image name
                        string imagePath = folderPath + fileName;


                        int index1 = indexingarrloop[j].IndexOf("base64");

                        string cleandata = indexingarrloop[j].Remove(0, index1 + 7);
                        string decryptedbase64 = cleandata;

                        byte[] data = System.Convert.FromBase64String(decryptedbase64);
                        MemoryStream ms = new MemoryStream(data);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                        if (!System.IO.File.Exists(imagePath))
                        {
                            img.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                            img.Dispose();

                            ms.Dispose();
                        }



                        Images1 += fileName + "|";

                    }
                    
                }
                return Images1;
            }
            return "0";

        }

        

        public string SaveDataUrlToProductImage(string hostingpath,string dataUrl) //image saving code
        {
            string Images1;
            string folderPath = hostingpath;  //Create a Folder in your Root directory on your solution.
            string base64StringData = dataUrl; // Your base 64 string data
            Images1 = "";
            if (base64StringData != "")
            {
                string[] indexingarrloop = base64StringData.Split('|');

                for (int j = 0; j < indexingarrloop.Length; j++)
                {
                    if(indexingarrloop[j] != "")
                    {
                        indexingarrloop[j] = indexingarrloop[j].Replace("|", "");
                        string fileName =  j + System.DateTime.Now.ToString("yyyyMMdd_hhmmssffff") + ".jpeg"; // set the image name
                        string imagePath = folderPath + fileName;


                        int index1 = indexingarrloop[j].IndexOf("base64");

                        string cleandata = indexingarrloop[j].Remove(0, index1 + 7);
                        string decryptedbase64 = cleandata;

                        byte[] data = System.Convert.FromBase64String(decryptedbase64);
                        MemoryStream ms = new MemoryStream(data);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                        if (!System.IO.File.Exists(imagePath))
                        {
                            img.Save(imagePath, System.Drawing.Imaging.ImageFormat.Jpeg);

                            img.Dispose();

                            ms.Dispose();
                        }



                        Images1 += fileName + "|";

                    }
                    
                }
                return Images1;
            }
            return "0";

        }



        #endregion


        #region Value Change Helper

        public EntityBusinessSustainabilityGoals convertvaluehelper(EntityBusinessSustainabilityGoals OriginalValue)
        {
            //EntityBusinessSustainabilityGoals person = new EntityBusinessSustainabilityGoals();

            Type type = typeof(EntityBusinessSustainabilityGoals);
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
               // Console.WriteLine("{0} = {1}", property.Name, property.GetValue(person, null));

                var value = property.GetValue(OriginalValue, null);
                if (value.ToString() == "true")
                {
                    property.SetValue(OriginalValue,"1");
                }
                else if (value.ToString() == "false")
                {
                    property.SetValue(OriginalValue, "0");
                }
              
            }

            return OriginalValue;


            //foreach (var item in OriginalValue.GetType().GetProperties())
            //{
            //   var value = item.GetValue(this,null);


            //}

        }



        public DataTable convertvaluehelper(DataTable inputdatatable)
        {

            DataTable dt = new DataTable();

            DataRow dr = dt.NewRow();

            foreach (var item in inputdatatable.Columns)
            {

                dt.Columns.Add(item.ToString());

                if (inputdatatable.Rows[0][item.ToString()].ToString()  == "1" && item.ToString() != "BUSINESS_DETAILS_KEY"
                    && item.ToString() != "MAST_BUSINESS_SUSTAINBILITY_GOALS_KEY")
                {
                    dr[item.ToString()] ="true";
                }
                else if (inputdatatable.Rows[0][item.ToString()].ToString() == "0")
                {
                    dr[item.ToString()] = "false";
                }
                else
                {
                    dr[item.ToString()] = inputdatatable.Rows[0][item.ToString()].ToString();
                }

              

            }

            dt.Rows.Add(dr);

            return dt;

        }


        #endregion


    }
}
