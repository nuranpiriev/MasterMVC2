﻿using Microsoft.AspNetCore.Mvc;

namespace MastersMVC2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
