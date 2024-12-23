using Microsoft.AspNetCore.Mvc;

namespace BookingApiConsume.Controllers
{
	public class LayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
