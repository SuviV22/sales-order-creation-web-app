using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using sales_order_creation.Models;

namespace sales_order_creation.Controllers
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

        [HttpPost("SaveData")]
        public IActionResult SaveData([FromBody] List savedData)
        {
            //Items items = new Items()
            //{
            //    name = name,
            //    code = code,
            //    qty = qty,
            //    price = price
            //};

            return Ok();
        }
    }
}