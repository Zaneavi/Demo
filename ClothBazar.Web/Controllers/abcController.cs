﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class abcController : Controller
    {
        // GET: abc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult Index2()
        {
            Console.WriteLine("Hello Avishek");
            return View();
        }

    }
}