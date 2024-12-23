using Microsoft.AspNetCore.Mvc;

namespace BookingApiConsume.Controllers
{
	public class BookingController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
