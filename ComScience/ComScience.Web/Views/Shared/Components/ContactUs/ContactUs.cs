using Microsoft.AspNetCore.Mvc;

namespace ComScience.Web.Views.Shared.Components.ContactUs
{
    public class ContactUs : ViewComponent
    {
        public ContactUs() { }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Default");
        }
    }
}
