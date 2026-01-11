using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
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

        [HttpGet]
        public IActionResult GetPizza()
        {
            var repo = new PizzaRepository();
            var pizzas = repo.pizzas;
            return new JsonResult(pizzas);
        }
        public IActionResult Detail(int id)
        {
            var repo = new PizzaRepository();
            var pizzas = repo.FindById(id);
            return View(pizzas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
