using Microsoft.AspNetCore.Mvc;

namespace ComScience.Web.Controllers
{

    public class ContactsUsController : Controller
    {
        [HttpGet]
        public void Send(string firstName, string email, string message)
        {
            // созранить куда-нибудь
        }
    }
}
