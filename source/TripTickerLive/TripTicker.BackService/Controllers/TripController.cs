﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TripTicker.BackService.Controllers
{
    [Route("api/[controller]")]
    public class TripController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}