using Microsoft.AspNetCore.Mvc;

namespace BookingApiConsume.ViewComponents.Layout
{
	public class _LayoutSearchBookingBar:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
