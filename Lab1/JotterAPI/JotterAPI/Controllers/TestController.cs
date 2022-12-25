using Microsoft.AspNetCore.Mvc;

namespace JotterAPI.Controllers
{
	[Route("[controller]")]
	public class TestController : Controller
	{
		[HttpGet]
		public string TestMethod()
		{
			return "It works";
		}
	}
}