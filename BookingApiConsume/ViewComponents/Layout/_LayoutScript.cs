using Microsoft.AspNetCore.Mvc;

namespace BookingApiConsume.ViewComponents.Layout
{
	public class _LayoutScript:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
