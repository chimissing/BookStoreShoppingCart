using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookStoreShoppingCart.Models;
using Microsoft.AspNet.Identity;

namespace BookStoreShoppingCart.Controllers
{    
    public class OrderController : Controller
    {      
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Ship postback)
        {
            if (ModelState.IsValid)
            {   //取得目前購物車
                var currentcart = Operation.GetCurrentCart();

                //取得目前登入使用者Id
                var userId = HttpContext.User.Identity.GetUserId();
                var orderDate = DateTime.Now.Date;

                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    //建立Order物件
                    var order = new Order()
                    {
                        UserId = userId,
                        OrderDate = orderDate,
                        ReceiverName = postback.RecieverName,
                        ReceiverPhone = postback.RecieverPhone,
                        ReceiverAddress = postback.RecieverAddress
                    };
                    //加其入Orders資料表後，儲存變更
                    db.Orders.Add(order);
                    db.SaveChanges();

                    //取得購物車中OrderDetail物件
                    var orderDetails = currentcart.ToOrderDetailList(order.Id, userId);

                    //將其加入OrderDetails資料表後，儲存變更
                    db.OrderDetails.AddRange(orderDetails);
                    db.SaveChanges();
                    currentcart.ClearCart();
                }
                return RedirectToAction("MyOrder","Order");

            }
            return View();
        }



        public ActionResult MyOrder()
        {
            //取得目前登入使用者Id
            var userId = HttpContext.User.Identity.GetUserId();

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var orders = db.Orders.Include("OrderDetails").Where(order => order.UserId == userId).ToList();

                return View(orders);
            }    
        }

        public ActionResult MyOrderDetail(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var result = (from s in db.OrderDetails
                              where s.OrderId == id
                              select s).ToList();

                if (result.Count == 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(result);
                }
            }
        }
    }
}