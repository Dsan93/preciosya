using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using preciosya.Models;

namespace preciosya.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Inicio(){
            return View();
        }

        public ActionResult MiComercio(){
            return View();
        }

        public ActionResult Productos(){
            return View();
        }

        public ActionResult Reseñas(){
            return View();
        }

        public ActionResult Registrarse(){
            return View();
        }

    }
}
