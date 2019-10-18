using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using BookStoreShoppingCart.Models;
using System.ComponentModel.DataAnnotations;

namespace BookStoreShoppingCart.ViewModels
{
    public class ProductFormViewModel
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }
        [Required]
        [Display(Name = "書名")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "類別")]
        public int? GenreId { get; set; }

        [Required]
        [Display(Name = "出版商")]
        public int? PublisherId { get; set; }

       
        [Required]
        [Display(Name = "出版日期")]
        public DateTime? PublishDate { get; set; }

        [Required]
        [Display(Name = "單價")]
        public decimal? Price { get; set; }

        [Display(Name = "上傳圖片")]
        public string ImageUrl { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "編輯商品" : "新增商品";
            }
        }

        public ProductFormViewModel()
        {
            Id = 0;
        }

        public ProductFormViewModel(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            GenreId = product.GenreId;
            PublisherId = product.PublisherId;
            PublishDate = product.PublishDate;
            Price = product.Price;
            ImageUrl = product.ImageUrl;       
        }
    }
}