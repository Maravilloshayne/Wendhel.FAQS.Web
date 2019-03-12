using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Threads
{
    public class AttachImageViewModel
    {
        public Guid? ThreadId { get; set; }
        public IFormFile Image { get; set; }
    }
}
