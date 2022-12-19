using Microsoft.AspNetCore.Http;
using MyApp.Entity;
using MyApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.db.Helper
{
    public interface IConvertHelper
    {

        string DataTableToJSONWithStringBuilder(DataTable table);
        string SaveSingleImage(IFormFile file,string hostingpath, ref string profilepic);

        string SaveBusinessLogoImage(IFormFile file, string hostingpath, ref string profilepic);
        string SaveSingleProductImage(IFormFile file, string hostingpath, ref string productpic);

        string SaveSingleProductpdf(IFormFile file, string hostingpath, ref string productpdf);

        string SaveSingleProductVideo(IFormFile file, string hostingpath, ref string productvideo);

        string SaveDataUrlToFile(string hostingpath, string dataUrl);
        string SaveDataUrlToProductImage(string hostingpath, string dataUrl);
        EntityBusinessSustainabilityGoals convertvaluehelper(EntityBusinessSustainabilityGoals OriginalValue);

        DataTable convertvaluehelper(DataTable inputdatatable);
    }
}
