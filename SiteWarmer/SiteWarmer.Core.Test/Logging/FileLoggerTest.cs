﻿using NUnit.Framework;
using SiteWarmer.Core.Logging;

namespace SiteWarmer.Core.Test.Logging
{
	[TestFixture]
	class FileLoggerTest
	{
		[Test]
		public void FileLogger_ImplementsILogger()
		{
			var logger = new FileLogger();

			Assert.IsInstanceOf(typeof(ILogger), logger);
		}
	}
}
