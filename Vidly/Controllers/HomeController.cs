using System;
namespace Vidly.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }
}