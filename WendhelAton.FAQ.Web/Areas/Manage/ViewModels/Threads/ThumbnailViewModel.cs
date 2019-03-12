using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Threads
{
    public class ThumbnailViewModel
    {
        public Guid? ThreadId { get; set; }
        public IFormFile Thumbnail { get; set; }
    }
}