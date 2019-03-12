using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WendhelAton.FAQ.Web.Infrastructure.Data.Helpers;
using WendhelAton.FAQ.Web.Infrastructure.Data.Models;
using WendhelAton.FAQ.Web.Models;
using System.IO;
using WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Faqs;
using WendhelAton.FAQ.Web.ViewModels;
using IndexViewModel = WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Faqs.IndexViewModel;
using Microsoft.AspNetCore.Hosting;
using WendhelAton.FAQ.Web.ViewModels.Faqs;
using Newtonsoft.Json;

namespace WendhelAton.FAQ.Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly DefaultDbContext _context;
        private IHostingEnvironment _env;


        public HomeController(DefaultDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }



        [HttpGet, Route("")]
        [HttpGet, Route("home")]
        [HttpGet, Route("home/index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, Route("home/initialize")]
        public IActionResult Init()
        {
            var faq = this._context.Faqs.FirstOrDefault();

            if (faq == null)
            {

                using (StreamReader r = new StreamReader(_env.WebRootPath + "\\data.json"))
                {
                    string json = r.ReadToEnd();
                    List<FaqImportViewModel> items = JsonConvert.DeserializeObject<List<FaqImportViewModel>>(json);
                    int ctr = 0;

                    foreach (var item in items)
                    {
                        this._context.Faqs.Add(new Faq()
                        {
                            Id = Guid.Parse(item.Answer),
                            Timestamp = DateTime.UtcNow.AddHours(ctr),
                            PostExpiry = DateTime.UtcNow.AddDays(ctr),
                            IsPublished = true,
                            TemplateName = "faq1",
                            Question = item.Question,
                            Description = item.Description,
                            Answer = item.Answer.Replace("'", @"\'")
                        });
                        ctr = ctr + 1;
                    }
                }

                this._context.SaveChanges();
            }

            var user = this._context.Users.FirstOrDefault();

            if (user == null)
            {
                var admin = new User()
                {
                    Id = Guid.Parse("b2e5a4fc-ca4e-4d3f-b9ac-d8a088cd6401"),
                    EmailAddress = "louhangregorio@gmail.com",
                    FirstName = "louhan",
                    LastName = "Gregorio",
                    Gender = Infrastructure.Data.Enums.gender.Male,
                    LoginStatus = Infrastructure.Data.Enums.LoginStatus.Active,
                    LoginTrials = 0,
                    RegistrationCode = RandomString(6),
                    Password = BCrypt.BCryptHelper.HashPassword("Taiwan09132012", BCrypt.BCryptHelper.GenerateSalt(8))
                };

                this._context.Users.Add(admin);
                this._context.SaveChanges();

                this._context.UserRoles.Add(new UserRole()
                {
                    Id = Guid.Parse("b2e5a4fc-ca4e-4d3f-b9ac-d8a088cd6401"),
                    Role = Infrastructure.Data.Enums.Role.Admins,
                    UserId = admin.Id
                });

                this._context.SaveChanges();
            }

            return RedirectToAction("index");

            //return RedirectPermanent("~/posts/index");
        }

        private Random random = new Random();
        private string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

