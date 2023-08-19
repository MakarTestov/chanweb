using Microsoft.AspNetCore.Mvc;

namespace ComScience.Web.Views.Shared.Components.Footer
{
    public class Footer : ViewComponent
    {
        public Footer() { }        

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Default");
        }
    }
}
