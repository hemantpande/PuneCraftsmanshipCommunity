using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PuneCrafters.Presentation.Web.Controllers
{
    public class OrganizersController : Controller
    {
        public ActionResult Schedule()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Schedule(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
