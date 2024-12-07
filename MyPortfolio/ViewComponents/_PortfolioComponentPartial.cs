using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
		MyPortfolioContext context = new MyPortfolioContext();

		public IViewComponentResult Invoke()
        {
			var value = context.Portfolios.ToList();
			return View(value);
        }
    }
}
