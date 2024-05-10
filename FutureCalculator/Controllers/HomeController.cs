using FutureCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FutureCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Models.FutureValueCalc futureValueCalc)
        {
            ViewBag.FutureValue = Math.Round(futureValueCalc.calculateFutureValue(),2);
            return View(futureValueCalc);
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
