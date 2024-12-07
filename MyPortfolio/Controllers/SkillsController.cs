using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
	public class SkillsController : Controller
	{
		MyPortfolioContext context=new MyPortfolioContext();
		public IActionResult Index()
		{
			var value=context.Skills.ToList();
			return View(value);
		}
		public IActionResult DeleteSkills(int id )
		{
			var value = context.Skills.Find(id);
			context.Skills.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult CreateSkills()
		{
			
			return View();
		}
		[HttpPost]
		public IActionResult CreateSkills(Skill skill)
		{
			context.Skills.Add(skill);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateSkills(int id)
		{
			var value = context.Skills.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateSkills(Skill skill)
		{
		    context.Skills.Update(skill);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}
