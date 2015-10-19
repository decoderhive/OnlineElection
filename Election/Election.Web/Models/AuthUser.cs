using System;
using System.ComponentModel.DataAnnotations;

namespace Election.Web
{
	public class AuthUser
	{
		public AuthUser ()
		{
		}

		[Required(ErrorMessage="Login name required")]
		public string LoginName{get;set;}
		[Required(ErrorMessage="Password required")]
		public string Password{ get; set;}
	}
}

