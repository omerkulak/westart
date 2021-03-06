﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using helloword2.Models;

namespace helloword2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult deneme () {
            ViewBag.icerik ="asasasd";
            TempData["uyari"]="hata";
            RedirectToAction("index","Home");
            return View();
        }
         public ActionResult login() {
             return View();
         }

         [HttpPost]
         public ActionResult login(string username, string password){
             if(username == "ömer" && password=="123"){
                 ViewBag.hata="Giriş Başarılı Hoşgeldiniz";
                return RedirectToAction("index","home");
             }else{
                 ViewBag.hata = "Kullanıcı veya şifre hatalı";
                 return  View();
             }
             

         }

        public ActionResult hakkimizda() {
            return View();    

        }      

    }
}
