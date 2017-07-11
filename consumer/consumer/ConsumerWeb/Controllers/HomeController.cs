using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repro110717.MainPackage;

namespace ConsumerWeb.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "Home Page";

			var types = typeof(Class1).Assembly.GetExportedTypes();
			var type = types.Single();
			var member = type.GetMember("IsWorking").Single();
			var attribs = member.GetCustomAttributes(false);
			
			return View();
		}
	}
}
