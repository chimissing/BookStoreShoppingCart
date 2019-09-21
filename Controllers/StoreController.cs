using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookStoreShoppingCart.Models;
using PagedList;

namespace BookStoreShoppingCart.Controllers
{
    public class StoreController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        // url: "store/{genre}"
        public ActionResult Browse(int? page, string genre)
        {
            // Retrieve Genre and its associated products from database
            var genreModel = db.Genres.Include("Products").Single(g => g.Name == genre).Products;

            return View(genreModel.ToList().ToPagedList(page ?? 1, 6));
        }

        //[ChildActionOnly]
        public ActionResult GenreMenu()   // left-side Menu
        {            
            var genres = db.Genres.ToList();
            return PartialView("_GenreMenu", genres);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}