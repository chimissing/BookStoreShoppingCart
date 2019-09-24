using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookStoreShoppingCart.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "類別")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}