﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Faqs
{
    public class UpdateContentViewModel
    {
        public Guid? FaqId { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }
     
    }
}