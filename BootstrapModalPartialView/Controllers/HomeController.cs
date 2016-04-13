using BootstrapModalPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapModalPartialView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult List()
        {
            return PartialView();
        }

        public ActionResult ModalAction(int Id)
        {
            ViewBag.Id = Id;
            return PartialView("ModalContent");
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
                FetchData = true,
                Destination = Url.Action("List"),
                Target = "list",
                OnSuccess = "success"
            };

            return PartialView("CloseModal", closeModal);
        }
    }
}