using Microsoft.AspNetCore.Mvc;

namespace ComScience.Web.Views.Shared.Components.Header
{
    public class Header : ViewComponent
    {
        public Header() { }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Default");
        }
    }
}
