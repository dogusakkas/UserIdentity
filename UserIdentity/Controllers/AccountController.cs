﻿using Microsoft.AspNetCore.Mvc;

namespace UserIdentity.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
