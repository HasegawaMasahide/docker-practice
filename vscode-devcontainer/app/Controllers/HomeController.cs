﻿using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using app.Data;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        protected ApplicationDbContext db;
        public HomeController(ApplicationDbContext context){
            this.db = context;
        }

        public IActionResult Index()
        {
            ViewData["List"] = db.NewTableList.ToList();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
