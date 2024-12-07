using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _TestimonialComponentPartial :ViewComponent
    {
        MyPortfolioContext context =new MyPortfolioContext();
        public IViewComponentResult Invoke() {  
            
            var value=context.Testimonials.ToList();
            return View(value); }    
    }
}
