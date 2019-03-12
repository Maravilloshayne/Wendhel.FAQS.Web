using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendhelAton.FAQ.Web.Infrastructure.Data.Enums;
using WendhelAton.FAQ.Web.Infrastructure.Data.Helpers;

namespace WendhelAton.FAQ.Web.Infrastructure.Data.Models
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public gender Gender { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public LoginStatus LoginStatus { get; set; }
        public string RegistrationCode { get; set; }
        public int LoginTrials { get; set; }
    }
}