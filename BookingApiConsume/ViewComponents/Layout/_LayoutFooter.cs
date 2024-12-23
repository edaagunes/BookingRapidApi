using Microsoft.AspNetCore.Mvc;

namespace BookingApiConsume.ViewComponents.Layout
{
	public class _LayoutFooter:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
