using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;

namespace LinksConfigurationAssignment.Controllers
{
	public class HomeController : Controller
	{
		private readonly SocialMediaLinksOptions _socialMediaLinkOptions;

		public HomeController(IOptions<SocialMediaLinksOptions> socialMediaLinkOptions) 
		{
			_socialMediaLinkOptions = socialMediaLinkOptions.Value;
		}

		[Route("/")]
		public IActionResult Index()
		{
			ViewBag.FacebookLink = _socialMediaLinkOptions.Facebook;
			ViewBag.YoutubeLink = _socialMediaLinkOptions.Youtube;
			ViewBag.TwitterLink = _socialMediaLinkOptions.Twitter;
			ViewBag.InstagramLink = _socialMediaLinkOptions.Instagram;
			return View();
		}
	}
}
