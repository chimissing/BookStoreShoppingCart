using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookStoreShoppingCart.Models
{
    public class CartItem
    {        
        public int Id { get; set; }

        [StringLength(255)]
        public string ProductName { get; set; }
        
        public decimal Price { get; set; }
       
        public int Quantity { get; set; }

        // single item amount
        public decimal Amount
        {
            get
            {
                return Price * Quantity;
            }
        }

        [StringLength(1023)]
        public string ImageURL { get; set; }
    }
}
