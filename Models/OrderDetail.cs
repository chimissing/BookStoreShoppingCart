using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookStoreShoppingCart.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string ProductName { get; set; }        

        public virtual Order Order { get; set; }
        public int OrderId { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }

        [StringLength(255)]
        public string UserId { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }

        // Single item amount
        public decimal Amount
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
}