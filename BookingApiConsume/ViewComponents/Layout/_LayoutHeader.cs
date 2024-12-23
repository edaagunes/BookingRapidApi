using Microsoft.AspNetCore.Mvc;

namespace BookingApiConsume.ViewComponents.Layout
{
	public class _LayoutHeader:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
