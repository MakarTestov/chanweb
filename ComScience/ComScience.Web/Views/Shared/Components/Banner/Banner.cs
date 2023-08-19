using ComScience.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComScience.Web.Views.Shared.Components.Banner
{
    public class Banner : ViewComponent
    {
        public Banner() { }

        public async Task<IViewComponentResult> InvokeAsync(BannerData bannerData)
        {
            return View("Default", bannerData);
        }
    }
}
