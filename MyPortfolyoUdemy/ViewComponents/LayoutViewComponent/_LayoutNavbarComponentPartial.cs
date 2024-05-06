using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponent
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();

		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount=context.ToDoList.Where(x=>x.Status==false).Count();//videoda ToDoLists yazıyor!!
			var values=context.ToDoList.Where(x=>x.Status==false).ToList();
			return View(values);
		}
	}
}
