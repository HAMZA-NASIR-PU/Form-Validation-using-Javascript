using Form_Validation_using_Javascript.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Form_Validation_using_Javascript.Controllers
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


        [HttpPost]
        public JsonResult AddStudent(StudentViewModel stdObj)
        {
            if (!ModelState.IsValid)
            {
            }
            return Json(stdObj);
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