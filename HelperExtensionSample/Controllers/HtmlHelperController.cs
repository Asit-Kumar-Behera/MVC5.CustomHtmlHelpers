using HelperExtensionSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperExtensionSample.Controllers
{
    public class HtmlHelperController : Controller
    {
        // GET: HtmlHelper
        public ActionResult StringBuilderExtension()
        {
            return View();
        }

        public ActionResult BootstrapButtons()
        {
            return View();
        }

        public ActionResult BootstrapTextBoxFor()
        {
            return View();
        }

        public ActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveEmployee(Employee employee)
        {
            return View("StringBuilderExtension");
        }
    }
}