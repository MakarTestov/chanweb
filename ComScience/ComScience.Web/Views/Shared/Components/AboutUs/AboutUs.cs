using Microsoft.AspNetCore.Mvc;

namespace ComScience.Web.Views.Shared.Components.AboutUs
{
    public class AboutUs : ViewComponent
    {
        public AboutUs() { }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Default");
        }
    }
}
