using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestTaskTwo.Models;

namespace TestTaskTwo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var repo = new PizzaRepository();
            var pizzas = repo.GetPizzas();
            return View(pizzas);
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
