using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values=context.Expriences.ToList();
            return View(values);
     
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }


		[HttpPost]
		public IActionResult CreateExperience(Exprience experience)
		{
            context.Expriences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
		}

		public IActionResult DeleteExperience(int id)
		{
			var value=context.Expriences.Find(id);
            context.Expriences.Remove(value);   
            context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
        [HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			var value = context.Expriences.Find(id);
		
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateExperience(Exprience exprience)
		{
			context.Expriences.Update(exprience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
