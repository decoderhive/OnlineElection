using System;
using System.ComponentModel.DataAnnotations;

namespace Election.Web
{
	public class AuthUser
	{
		public AuthUser ()
		{
		}

		public string LoginName{get;set;}
		public int Password{ get; set;}
	}
}

