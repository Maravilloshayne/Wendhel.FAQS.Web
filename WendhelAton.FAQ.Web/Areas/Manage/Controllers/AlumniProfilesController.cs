﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WendhelAton.FAQ.Web.Areas.Manage.Controllers
{
    public class AlumniProfilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}