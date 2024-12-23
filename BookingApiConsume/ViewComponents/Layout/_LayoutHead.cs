using Microsoft.AspNetCore.Mvc;

namespace BookingApiConsume.ViewComponents.Layout
{
	public class _LayoutHead:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
