using CoBookGallery.Models;
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

            var coBook = new CoBook()
            {
                SeriesTitle = "The Amazing Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>This is where information will about the c book will go..</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script"},
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils"},
                    new Artist() { Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() { Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters"},
                }
        };



                return View(coBook);

        }
    }
}
