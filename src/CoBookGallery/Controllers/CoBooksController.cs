using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoBookGallery.Controllers
{
    public class CoBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                return  Redirect("/");
            }
            return Content("Hello from the co books controller");

        }
    }
}
