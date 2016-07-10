using CoBookGallery.Data;
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
        private CoBookRepository _coBookRepository = null;

        public CoBooksController()
        {
            _coBookRepository = new CoBookRepository();
        }

        public ActionResult Index()
        {
            var coBooks = _coBookRepository.GetCoBooks();

            return View(coBooks);
        }
        public ActionResult Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }

            var coBook = _coBookRepository.GetCoBook(id.Value);

return View(coBook);
            
        }
    }
}
