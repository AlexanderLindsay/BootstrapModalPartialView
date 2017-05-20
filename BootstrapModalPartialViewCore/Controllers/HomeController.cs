using BootstrapModalPartialViewCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapModalPartialViewCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public ActionResult ModalFormAction(int Id)
        {
            ViewBag.Id = Id;
            return PartialView("ModalFormContent");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PostModal()
        {
            var closeModal = new CloseModal
            {
                ShouldClose = true,
                FetchData = false
            };

            return PartialView("CloseModal", closeModal);
        }
    }
}
