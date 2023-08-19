using ComScience.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComScience.Web.Views.Shared.Components.Articles
{
    public class Articles : ViewComponent
    {
        public Articles() { }

        public async Task<IViewComponentResult> InvokeAsync(IEnumerable<Article> articles)
        {
            return View("Default", articles.OrderBy(x => x.Id));
        }
    }
}
