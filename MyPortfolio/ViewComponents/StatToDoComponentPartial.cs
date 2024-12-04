using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
	public class StatToDoComponentPartial :ViewComponent
	{
		MyPortfolioContext context =new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			var toDoLists = context.ToDoLists.Where(x => x.Status == false).ToList(); // Yapilmamis gorevler

			return View(toDoLists);
		}
	}
}
