﻿using System;
using System.Threading.Tasks;
using SiteWarmer.Core.Comms;
using SiteWarmer.Core.Config;

namespace SiteWarmer.Core
{
	public class CustomWarmer
	{
		private readonly IConfig _config;
		private readonly IRequester _requester;

		public CustomWarmer(IConfig config, IRequester requester)
		{
			_config = config;
			_requester = requester;
		}

		public void Warm(Action<Check> action)
		{
			Parallel.ForEach(_config.Checks, check =>
				{
					_requester.Check(check);
					action.Invoke(check);
				});
		}
	}
}
