using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()//Genelde metodların ismi ınvoke olarak adlandırılır
        {
            return View();
        }
    }
}
