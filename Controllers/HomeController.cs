using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using sales_order_creation.Models;
using System.IO.Pipelines;
using System.Xml.Linq;

namespace sales_order_creation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _applicationDbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _applicationDbContext = applicationDbContext;
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

        [HttpPost("/test/SaveData")]
        public IActionResult SaveData([FromBody] List<Items> savedData)
        {
            foreach (var item in savedData)
            {
                Items order = new Items()
                {
                    orderId = item.orderId,
                    name = item.name,
                    code = item.code,
                    qty = item.qty,
                    price = item.price
                };
                _applicationDbContext.Add(order);
            }
            _applicationDbContext.SaveChanges();

            return Json(new { message = "Data saved successfully" });
        }
    }
}