using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendhelAton.FAQ.Web.Infrastructure.Data.Helpers;
using WendhelAton.FAQ.Web.Infrastructure.Data.Models;

namespace WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Faqs
{
    public class IndexViewModel
    {
        public Page<Faq> Faqs { get; set; }
    }
}

