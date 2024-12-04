using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{

   
    public class _ExperienceComponentPartial : ViewComponent
     {
        MyPortfolioContext context  =new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Expriences.ToList();
            return View(values);
        }
    }
}
