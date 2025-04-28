using Microsoft.AspNetCore.Mvc;

namespace LAB02.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Save()
        {
            return RedirectToAction("Index");
        }
    }
}
