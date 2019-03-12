﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Faqs
{
    public class AttachImageViewModel
    {
        public Guid? FaqId { get; set; }

        public IFormFile Image { get; set; }
    }
}