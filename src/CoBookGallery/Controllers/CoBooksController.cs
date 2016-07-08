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
           


            ViewBag.SeriesTitle = "The Amazing Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>This is where information will about the c book will go..";
            ViewBag.Artists = new string[]
                {
                    "Script: Dan Slott",
                    "Pencils: Humberto Ramos",
                    "Inks: Victor Olazaba",
                    "Colors: Edgar Delgado",
                    "Letters: Chris Eliopoulos"

                };

                return View();

        }
    }
}
