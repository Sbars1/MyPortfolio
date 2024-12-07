using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial :ViewComponent{ 

		MyPortfolioContext context { get; set; }
        public IViewComponentResult Invoke() {


			//var values = context.Contacts.ToList();
			//return View(values);

			return View();	
			 }
    }
}
