using isteksikayet.Business.Abstract;
using isteksikayet.Business.Concrete;
using isteksikayet.Data.Abstract;
using isteksikayet.Data.Concrete;
using isteksikayet.Data.Context;
using isteksikayet.webui.EMailSend;
using isteksikayet.webui.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace isteksikayet.webui
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
            services.AddSession();

            // services add user
            services.AddDbContext<DataContext>();

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DataContext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                //add ýdentity options
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 10;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                // Lockout
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(20);
                options.Lockout.AllowedForNewUsers = true;
                //sýgn in options
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.User.RequireUniqueEmail = true;
                options.User.AllowedUserNameCharacters = "abcçdefghiýjklmnoöpqrsþtuüvwxyzABCÇDEFGHIÝJKLMNOÖPQRSÞTUÜVWXYZ0123456789-._+";


            });
            services.ConfigureApplicationCookie(options =>
            {
                //login road
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                //cookie setting
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name=".datadb.Cookie",
                    SameSite = SameSiteMode.Strict
                };

            });
            // add data
            services.AddScoped<IComplaintRepository, EfComplaintepository>();
            services.AddScoped<IDepartmentRepository, EfDepartmentRepository>();
            services.AddScoped<IComplaintReplyRepository, EfComplaintReplyRepository>();
            services.AddScoped<ISiteConfigRepository, EfSiteConfigRepository>();

            // add Business
            services.AddScoped<IComplaintService, ComplaintManager>();
            services.AddScoped<IDepartmentService, DepartmentManager>();
            services.AddScoped<IComplaintReplyService, ComplaintReplyManager>();
            services.AddScoped<ISÝteConfigService, SiteCOnfigManager>();
            services.AddScoped<IDataAdd, DataAdd>();

            //mail sender
            services.AddScoped<IEMailSend, TEMailSend>();
            
            
            

            services.AddControllersWithViews();
            //seriliazer control

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
            }
            app.UseSession();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
