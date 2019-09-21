using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreShoppingCart.Models
{
    public class Order : IEnumerable<OrderDetail>
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int Id { get; set; }
        public string UserId { get; set; }

        public DateTime OrderDate { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverAddress { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        // 訂單總金額
        public decimal TotalAmount
        {
            get
            {
                decimal totalAmount = 0;
                foreach (var orderDetail in OrderDetails)
                {
                    totalAmount += orderDetail.Amount;
                }
                return totalAmount;
            }
        }

        

        public string GetUserName()
        {
            //使用Order類別中的UserId到AspNetUsers資料表中搜尋出UserName
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var result = (from s in db.Users
                              where s.Id == UserId
                              select s.UserName).FirstOrDefault();

                //回傳找到的UserName
                return result;
            }
        }

        #region IEnumerator
        IEnumerator<OrderDetail> IEnumerable<OrderDetail>.GetEnumerator()
        {
            return OrderDetails.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return OrderDetails.GetEnumerator();
        }
        #endregion
    }
}
