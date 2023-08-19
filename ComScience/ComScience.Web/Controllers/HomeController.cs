using ComScience.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace ComScience.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly StorageData _storage;

        public HomeController(StorageData storage)
        {
            _storage = storage;
        }

        public IActionResult Products()
        {
            return View(_storage);
        }

        public IActionResult News()
        {
            return View(_storage);
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

    }
}
