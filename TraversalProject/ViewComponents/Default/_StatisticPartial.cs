﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProject.ViewComponents.Default
{
    public class _StatisticPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "283";
            return View();
        }
    }
}
