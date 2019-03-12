using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendhelAton.FAQ.Web.Infrastructure.Data.Enums;

namespace WendhelAton.FAQ.Web.ViewModels
{
    public class RegistrationViewModel
    {

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public gender Gender { get; set; }

    public string EmailAddress { get; set; }

    public string Password { get; set; }

   
    }
}