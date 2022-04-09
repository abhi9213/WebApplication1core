using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1core.Models;

namespace WebApplication1core.Controllers
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
            ViewBag.test1 = 12324;
            ViewBag.test2 = "amit kumar";
            ViewBag.test3 = 12345.7656d;
            ViewBag.test4 = DateTime.Now;
            ViewBag.List = new List<string>()
            {
                "india","usa","uk","japan"
            };




            return View();
        }

        public IActionResult vdata()
        {
            ViewData["id"] = 12324;
            ViewData["name"] = "amit kumar";
            ViewData["per"] = 12345.7656d;
            ViewData["time"] = DateTime.Now;
            ViewData["list"] = new List<string>()
            {
                "india","usa","uk","japan"
            };
            return View();
        }
        public IActionResult tdata()
        {
            TempData["head"] = "this is temp data example";
            TempData["id"] = 12324;
            TempData["name"] = "amit kumar";
            TempData["per"] = 12345.7656d;
            TempData["time"] = DateTime.Now;
            TempData["list"] = new List<string>()
            {
                "india","usa","uk","japan"
            };
           
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