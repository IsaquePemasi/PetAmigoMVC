using Microsoft.AspNetCore.Mvc;
using PetAmigoMVC.Models;
using System.Diagnostics;

namespace PetAmigoMVC.Controllers
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

        public IActionResult Adocao()
        {
            return View();
        }

        public IActionResult Doacao()
        {
            return View();
        }

        public IActionResult Perdido()
        {
            return View();
        }
        public IActionResult Produtos()
        {
            return View();
        }
        public IActionResult Parceiros()
        {
            return View();
        }
        public IActionResult PerguntasFrequentes()
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