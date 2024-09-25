using Microsoft.AspNetCore.Mvc;

namespace C_SharpFinal.Controllers {
    public class HomeController : Controller {
        [HttpGet]
        public IActionResult Index() {
            ViewBag.WeeklySalary = 0;
            ViewBag.StudentBadge = "Hello Student Worker"; // Just wanted to do something with the name and id
            return View();
        }

        [HttpPost]
        public IActionResult Index(C_SharpFinal.Models.StudentWorkerModel model) {
            if (ModelState.IsValid) {
                ViewBag.WeeklySalary = model.weeklySalary();
                ViewBag.StudentBadge = "Hello, here's your name and ID: " + model.ReturnBadge();
            } else {
                ViewBag.WeeklySalary = 0;
                ViewBag.StudentBadge = "Hello Student Worker";
            }

            return View(model);
        }
    }
}
