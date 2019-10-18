using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookStoreShoppingCart.Models;
using BookStoreShoppingCart.ViewModels;
using System.Data.Entity;
using System.IO;

namespace BookStoreShoppingCart.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Publisher).Include(p => p.Genre).ToList();
            return View(products);
        }
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            var product = db.Products.Include(p => p.Publisher).Include(p => p.Genre).SingleOrDefault(p => p.Id == id);
            if (User.IsInRole("Admin"))
            {
                return View("AdminDetails",product);
            }
            return View(product);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult New()
        {
            var viewModel = new ProductFormViewModel
            {

                Publishers = db.Publishers.ToList(),
                Genres = db.Genres.ToList()
            };
            return View("ProductForm", viewModel);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            var product = db.Products.SingleOrDefault(p => p.Id == id);

            var viewModel = new ProductFormViewModel(product)
            {
                Genres = db.Genres.ToList(),
                Publishers = db.Publishers.ToList()
            };

            return View("ProductForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Product product, HttpPostedFileBase file)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new ProductFormViewModel(product)
                {
                    Publishers = db.Publishers.ToList(),
                    Genres = db.Genres.ToList()
                };
                return View("ProductForm", viewModel);
            }

            if (file != null)
            {
                //圖片存資料夾
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Images"), fileName);
                file.SaveAs(path);
                product.ImageUrl = "/Content/Images/" + fileName;
            }

            if (product.Id == 0)
            {
                db.Products.Add(product);
            }
            else
            {
                var productInDb = db.Products.Single(p => p.Id == product.Id);
                productInDb.Name = product.Name;
                productInDb.Genre = product.Genre;
                productInDb.GenreId = product.GenreId;
                productInDb.Publisher = product.Publisher;
                productInDb.PublisherId = product.PublisherId;
                productInDb.PublishDate = product.PublishDate;
                productInDb.Price = product.Price;

                if (file != null)
                    productInDb.ImageUrl = product.ImageUrl;
            }
            db.SaveChanges();
            return RedirectToAction("Details", new { id = product.Id });
        }

        public ActionResult Delete(int id)
        {
            var productInDb = db.Products.SingleOrDefault(p => p.Id == id);
            db.Products.Remove(productInDb);
            db.SaveChanges();
            return RedirectToAction("Index", "Products");
        }

            protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}