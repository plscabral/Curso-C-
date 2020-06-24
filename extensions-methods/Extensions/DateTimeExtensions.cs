﻿using System.Globalization;

namespace System
{
	static class DateTimeExtensions
	{
		public static string ElapesdTime(this DateTime thisObj)
		{
			TimeSpan duration = DateTime.Now.Subtract(thisObj);

			if (duration.TotalHours < 24.0)
			{
				return duration.TotalHours.ToString("f1", CultureInfo.InvariantCulture) + " hours";
			}
			else
			{
				return duration.TotalDays.ToString("f1", CultureInfo.InvariantCulture) + " days";
			}
		}
	}
}
