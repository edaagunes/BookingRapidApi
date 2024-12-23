using Microsoft.AspNetCore.Mvc;

namespace BookingApiConsume.ViewComponents.Layout
{
	public class _LayoutBanner:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
