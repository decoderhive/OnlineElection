using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Election.Web.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }

		[ValidateAntiForgeryToken]
		[HttpPost]
		public ActionResult Index(AuthUser user)
		{
			if (ModelState.IsValid)
			{
				
			}
			return View (user);
		}
    }
}
