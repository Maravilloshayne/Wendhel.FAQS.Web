﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendhelAton.FAQ.Web.Infrastructure.Data.Helpers;
using WendhelAton.FAQ.Web.Infrastructure.Data.Models;

namespace WendhelAton.FAQ.Web.Areas.Manage.ViewModels.Users
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}

