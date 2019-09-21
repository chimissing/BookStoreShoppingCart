using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStoreShoppingCart.Startup))]
namespace BookStoreShoppingCart
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
