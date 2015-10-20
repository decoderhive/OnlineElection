using System;

namespace Election.Data.Install
{
	public class DbInstall : IDbInstall
	{
		private IDbInstall _dbinstall = null;
		private DbInstall ()
		{
			_dbinstall = this;
		}

		public IDbInstall Install{ get { return _dbinstall; } }

	}
}

