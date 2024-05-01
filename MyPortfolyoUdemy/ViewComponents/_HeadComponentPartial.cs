using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()//Genelde metodların ismi ınvoke olarak adlandırılır
        {
            return View();
        }
    }
}
