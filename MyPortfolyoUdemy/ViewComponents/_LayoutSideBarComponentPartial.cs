using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.ViewComponents
{
	public class _LayoutSideBarComponentPartial:ViewComponent	
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
