﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LadoUsuario.Models;

namespace LadoUsuario.Controllers
{
    public class ThankYouController : Controller
    {
        // GET: ThankYou
        public ActionResult Index()
        {
            ViewBag.cartBox = null;
            ViewBag.Total = null;
            ViewBag.NoOfItem = null;
            TempShpData.items = null;
            return View("Thankyou");
        }
    }
}