using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
