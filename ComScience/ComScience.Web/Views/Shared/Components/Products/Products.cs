using ComScience.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComScience.Web.Views.Shared.Components.Products
{
    public class Products : ViewComponent
    {
        public Products() { }

        public async Task<IViewComponentResult> InvokeAsync(IEnumerable<Product> products)
        {
            return View("Default", products);
        }
    }
}
