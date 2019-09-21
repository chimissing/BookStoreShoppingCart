using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookStoreShoppingCart.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "書名")]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }
        [Display(Name = "類別")]
        public int GenreId { get; set; }

        public Publisher Publisher { get; set; }
        [Display(Name = "出版商")]
        public int PublisherId { get; set; }


        [Display(Name = "出版日期")]
        public DateTime PublishDate { get; set; }

        [Display(Name = "單價")]
        public decimal Price { get; set; }

        [StringLength(1023)]
        public string ImageUrl { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        // to fetch the selling quantity information
    }
}