using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index() //ındex method,IActionResult türünde
        {
            return View();
        }
    }
}
