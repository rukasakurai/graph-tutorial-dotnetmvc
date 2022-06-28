using Microsoft.AspNetCore.Mvc;

namespace graph_tutorial_dotnetmvc.Controllers
{
	public class HomeController1 : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
