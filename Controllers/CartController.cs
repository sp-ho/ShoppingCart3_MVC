﻿using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart3.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}
