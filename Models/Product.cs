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
        public int GenreId { get; set; }

        public Publisher Publisher { get; set; }        
        public int PublisherId { get; set; }

       
        [Display(Name = "出版日期")]
        public DateTime PublishDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Display(Name = "單價")]
        public decimal Price { get; set; }

        [StringLength(1023)]
        [Display(Name = "圖片位址")]
        public string ImageUrl { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        // to fetch the selling quantity information
    }
}