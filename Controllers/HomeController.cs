using GitHubUserExam.Services.Interfaces;
using System;
using System.Web.Mvc;

namespace GitHubUserExam.Controllers
{
	public class HomeController : Controller
	{
        private readonly IUserServices _userService;

        public HomeController(IUserServices userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult Index()
		{
            var user = _userService.GetUser("InitialEntry");
			return View(user);
		}

        [HttpPost]
        public ActionResult Index(string name)
        {
            var user = _userService.GetUser(name);
            return View(user);
        }
	}
}