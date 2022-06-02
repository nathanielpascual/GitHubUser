
using GitHubUserExam.Controllers;
using GitHubUserExam.Services.Implementation;
using GitHubUserExam.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GitHubUserExam
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{

			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			UnityConfig.RegisterComponents();
			
		}
	}
}
