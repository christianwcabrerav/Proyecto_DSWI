﻿using LadoUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LadoUsuario.Controllers
{
    public class HomeController : Controller
    {
        LadoUsuarioEntities db = new LadoUsuarioEntities();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MenProduct = db.Products.Where(x => x.Category.Name.Equals("Men")).ToList();
            ViewBag.WomenProduct = db.Products.Where(x => x.Category.Name.Equals("Women")).ToList();
            ViewBag.SportsProduct = db.Products.Where(x => x.Category.Name.Equals("Sports")).ToList();
            ViewBag.ElectronicsProduct = db.Products.Where(x => x.Category.Name.Equals("Phones")).ToList();
            ViewBag.Slider = db.genMainSliders.ToList();
            ViewBag.PromoRight = db.genPromoRights.ToList();

            this.GetDefaultData();

            return View();
        }      

    }
}