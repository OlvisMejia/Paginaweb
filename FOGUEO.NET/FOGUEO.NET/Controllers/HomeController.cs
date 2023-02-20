using FOGUEO.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FOGUEO.NET.Controllers
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

            ViewBag.Message = "Mi matricula es 2021-0701";
            ViewBag.Message2 = "Carrera: Desarrollo de software";
            ViewData["MiNombre"] = "Nombres y apellidos: Olvis Enmanuel Mejia Paredes";
            ViewData["FechaNac"] = "Fecha de nacimiento: 05/02/2004";
            ViewBag.Message3 = "Correo Institucional: 20210701@itla.edu.do";
            ViewBag.UnInt = 20 * 20 * 3;


            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult Index2()
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