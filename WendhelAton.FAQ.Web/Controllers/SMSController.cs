using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Pomelo.Data.MySql.Memcached;
using WendhelAton.FAQ.Web.Infrastructure.Data.Helpers;
using WendhelAton.FAQ.Web.Infrastructure.Data.Models;
using WendhelAton.FAQ.Web.ViewModels.Sms;

namespace WendhelAton.FAQ.Web.Controllers
{
    public class SMSController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private string emailUserName;
        private string emailPassword;
        private IHostingEnvironment _env;
        private string message;
        private string number;
        private string api_code;

        public SMSController(DefaultDbContext context, IConfiguration iConfiguration, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
            message = ("");
            this._config = iConfiguration;
        }

        [HttpGet, Route("account/register")]
        public IActionResult RegisterSms()
        {
            return View();
        }
        [HttpPost, Route("account/register")]
        public IActionResult RegisterSms(RegisterViewModel model)
        {
            if (model.Password != model.ConfirmPassword)
            {
                ModelState.AddModelError("", "Password and Confirmation does not match.");
                return View();
            }
            var duplicate = this._context.Users.FirstOrDefault(u => u.EmailAddress.ToLower() == model.EmailAddress.ToLower());
            if (duplicate == null)
            {
         
                User user = new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EmailAddress = model.EmailAddress.ToLower(),
                    Gender = model.Gender,
                    LoginStatus = Infrastructure.Data.Enums.LoginStatus.NewRegister,

                    Password = BCrypt.BCryptHelper.HashPassword(model.Password, BCrypt.BCryptHelper.GenerateSalt(8))
                };
                this._context.Users.Add(user);
                this._context.SaveChanges();

              


                return RedirectPermanent("~/account/verify");
            }
            return View();
        }



        //########################################################################################
        //iTexmo API for C# / ASP --> go to www.itexmo.com/developers.php for API Documentation
        //########################################################################################
        public object itexmo(string Number, string Message, string API_CODE)
        {
            object functionReturnValue = null;
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                System.Collections.Specialized.NameValueCollection parameter = new System.Collections.Specialized.NameValueCollection();
                string url = "https://www.itexmo.com/php_api/api.php";
                parameter.Add("09565574596", Number);
                parameter.Add("This is your Verification Code ", Message);
                parameter.Add("TR-LOUHA804953_1J73K ", API_CODE);
                dynamic rpb = client.UploadValues(url, "POST", parameter);
                functionReturnValue = (new System.Text.UTF8Encoding()).GetString(rpb);
            }
            return functionReturnValue;

        }
        //########################################################################################
        //API END     '###########################################################################
        //########################################################################################



        [HttpPost, Route("sms/sendmessage")]
        public IActionResult SMS(string Number, string Message,string API_CODE)
        {
            
            return View();
        }
    }
}
