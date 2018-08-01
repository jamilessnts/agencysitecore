﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Agency.Feature.Services.Models;

namespace Agency.Feature.Services.Controllers
{
    public class ServiceContainerController : GlassController
    {
        // GET: ServiceContainer
        public ActionResult ServicesContainer()

        {
            var services = this.GetDataSourceItem<ServicesContainer>();
            return View(services);
        }
    }
}