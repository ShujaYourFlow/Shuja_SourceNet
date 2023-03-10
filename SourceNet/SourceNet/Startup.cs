using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using MyApp.db.EmailService;
using MyApp.db.Encryption;
using MyApp.db.Helper;
using MyApp.db.MydbContext;
using MyApp.db.SqlFunctions;
using MyApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace SourceNet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContextPool<AppdbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("ServerConnection")));


            services.AddScoped<IEmailConfig, EmailConfig>();
            services.AddScoped<IEncryption, Encrypted>();
            services.AddScoped<IBalCustomer, BalCustomer>();
            services.AddScoped<IConvertHelper, ConvertHelper>();
            //services.AddTransient<IMailService, Services.MailService>();
            services.Configure<ContactUsEntity>(Configuration.GetSection("EmailConfiguration"));


            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
              
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "Documents")),
                RequestPath = "/Documents"
            });
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            { 
                endpoints.MapControllerRoute(
                    name: "privacypolicy",
                    pattern: "Home/Privacy",
                    defaults: new {area= "Website", controller = "Home", action = "Privacy" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{area=Website}/{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
