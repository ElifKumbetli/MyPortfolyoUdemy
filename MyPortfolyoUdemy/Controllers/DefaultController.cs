using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index() //ındex method,IActionResult türünde
        {
            return View();
        }
    }
}
