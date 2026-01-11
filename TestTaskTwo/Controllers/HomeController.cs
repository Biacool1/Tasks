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
        public IActionResult Detail(int id)
        {
            var repo = new PizzaRepository();
            var pizzas = repo.FindById(id);
            return View(pizzas);
        }
        public IActionResult IndexNew() {
            var repo = new PizzaRepository();
            var pizzas = repo.GetPizzas();
            return View(pizzas);
        }

        [HttpGet]
        public IActionResult GetPizza()
        {
            var repo = new PizzaRepository();
            var pizzas = repo.pizzas;
            return new JsonResult(pizzas);
        }
        [HttpGet]
        public IActionResult IndexNewJson(int id)
        {
            var repo = new PizzaRepository();
            var pizza = repo.FindById(id);
            if (pizza == null) return NotFound();
            return Json(pizza);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
