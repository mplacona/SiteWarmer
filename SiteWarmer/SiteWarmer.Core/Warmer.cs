﻿using System.Collections.Generic;

namespace SiteWarmer.Core
{
	public class Warmer
	{
		private readonly IConfig _config;
		private readonly Requester _requester;
		private readonly ILogger _logger;

		public Warmer(IConfig config, Requester requester, ILogger logger)
		{
			_config = config;
			_requester = requester;
			_logger = logger;
		}

		public List<Check> Warm()
		{
			var checks = _config.Checks;

			foreach (var check in checks)
			{
				_requester.Check(check);
				_logger.Log(check);
			}

			return checks;
		}
	}
}
