using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookStoreShoppingCart.Models;

namespace BookStoreShoppingCart.Controllers
{
    public class ManageOrderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        public ActionResult Index()
        {
            var orders = db.Orders.ToList();
            return View(orders);
        }

        public ActionResult Details(int id)
        {
            var order = (from s in db.OrderDetails
                         where s.OrderId == id
                         select s).ToList();
            if (order.Count == 0)
            {   //如果商品數目為零，代表該訂單異常(無商品)，則導回商品列表
                return RedirectToAction("Index");
            }
            else
            {
                return View(order);
            }
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}