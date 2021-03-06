﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using WendhelAton.FAQ.Web.Infrastructure.Data.Helpers;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using WendhelAton.FAQ.Web.Infrastructure.Security;

namespace WendhelAton.FAQ.Web
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

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
           .AddCookie(options =>
           {
               options.Cookie.Expiration = TimeSpan.FromDays(1);
               options.Cookie.MaxAge = TimeSpan.FromDays(1);
               options.Cookie.Name = "WendhelAton.FAQ.Web";
           });


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<DefaultDbContext>(options => options.UseMySql(Configuration.GetConnectionString("DefaultDbContextMySQL"), m => m.MigrationsAssembly("WendhelAton.FAQ.Web")));
                services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
                services.AddScoped<IAuthorizationHandler, AuthorizeAdminRequirementHandler>();
                services.AddAuthorization(options =>
                {
                    options.AddPolicy("SignedIn", policy => policy.RequireAuthenticatedUser());
                    options.AddPolicy("AuthorizeAdmin", policy => policy.Requirements.Add(new AuthorizeAdminRequirement()));
                });


                services.AddSession(options =>
                {
                    options.IdleTimeout = TimeSpan.FromDays(1);
                });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseSession();

            app.UseStaticFiles();

            app.UseAuthentication();

            Infrastructure.Security.WebUser.Services = app.ApplicationServices;

            app.UseCookiePolicy();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
