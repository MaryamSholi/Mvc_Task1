using Microsoft.AspNetCore.Mvc;
using Mvc_Task1.Data;

namespace Mvc_Task1.Controllers
{
	public class EmployeeController : Controller
	{
		ApplicationDbContext context = new ApplicationDbContext();
		public IActionResult Index()
		{
			var employees =context.Employees.ToList();
			return View("Index", employees);
		}
	}
}
