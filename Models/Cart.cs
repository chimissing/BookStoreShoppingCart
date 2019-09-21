using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreShoppingCart.Models
{
    public class Cart : IEnumerable<CartItem>
    {
        public Cart()
        {
            cartItems = new List<CartItem>();
        }
        
        private List<CartItem> cartItems;
       
        public int Count
        {
            get
            {
                return cartItems.Count;
            }
        }
        
        public decimal TotalAmount
        {
            get
            {
                decimal totalAmount = 0;
                foreach (var cartItem in cartItems)
                {
                    totalAmount +=cartItem.Amount;
                }
                return totalAmount;
            }
        }

        //新增一筆Product，使用ProductId
        public bool AddProduct(int ProductId)
        {
            var findItem = cartItems
                            .Where(s => s.Id == ProductId)
                            .Select(s => s)
                            .FirstOrDefault();

            //判斷相同Id的CartItem是否已經存在購物車內
            if (findItem == default(CartItem))
            {   //不存在購物車內，則新增一筆
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    //var product = (from s in db.Products
                    //               where s.Id == ProductId
                    //               select s).FirstOrDefault();
                    var product = db.Products.FirstOrDefault(p => p.Id == ProductId);

                    if (product != default(Product))
                    {
                        AddProduct(product);
                    }
                }
            }
            else
            {   //存在購物車內，則將商品數量累加
                findItem.Quantity += 1;
            }
            return true;
        }

        //新增一筆Product，使用Product物件
        private bool AddProduct(Product product)
        {
            //將Product轉為CartItem
            var cartItem = new CartItem()
            {
                Id = product.Id,
                ProductName = product.Name,
                Price = product.Price,
                ImageURL = product.ImageUrl,
                Quantity = 1
            };

            //加入CartItem至購物車
            cartItems.Add(cartItem);
            return true;
        }

        //移除一筆Product，使用ProductId
        public bool RemoveProduct(int ProductId)
        {
            var findItem = this.cartItems
                            .Where(s => s.Id == ProductId)
                            .Select(s => s)
                            .FirstOrDefault();

            //判斷相同Id的CartItem是否已經存在購物車內
            if (findItem == default(CartItem))
            {
                //不存在購物車內，不需做任何動作
            }
            else
            {   //存在購物車內，將商品移除
                cartItems.Remove(findItem);
            }
            return true;
        }

        //清空購物車
        public bool ClearCart()
        {
            cartItems.Clear();
            return true;
        }

        //將購物車商品轉成OrderDetail的List
        public List<OrderDetail> ToOrderDetailList(int orderId, string userId)
        {

            var result = new List<OrderDetail>();
            foreach (var cartItem in cartItems)
            {
                result.Add(new OrderDetail()
                {
                    ProductName = cartItem.ProductName,
                    Price = cartItem.Price,
                    Quantity = cartItem.Quantity,
                    OrderId = orderId,
                    UserId = userId,
                    ProductId=cartItem.Id
                });
            }
            return result;
        }

        #region IEnumaretor
        IEnumerator<CartItem> IEnumerable<CartItem>.GetEnumerator()
        {
            return cartItems.GetEnumerator();            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return cartItems.GetEnumerator();            
        }
        #endregion
    }
}
