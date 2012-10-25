﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace AgileMonitoring.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var apiExplorer = GlobalConfiguration.Configuration.Services.GetApiExplorer();
            return View(apiExplorer);
        }
    }
}
