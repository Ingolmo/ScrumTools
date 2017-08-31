using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;

namespace ScrumTools.Helpers
{
	public static class Settings
	{
        private const string DisplayKey = "display_key";
        private const string TimerMinutesKey = "timer_minutes_key";

        private static ISettings AppSettings
		{
			get	{ return CrossSettings.Current;	}
		}

        public static class CardDisplay
        {
            public const string Grid = "grid";
            public const string List = "list";

            public static string Display
            {
                get { return AppSettings.GetValueOrDefault(DisplayKey, Grid); }
                set { AppSettings.AddOrUpdateValue(DisplayKey, value); }
            }
        }

        public static class Timer
        {
            private const int DefaultMinutes = 5;
            public static TimeSpan Time
            {
                get
                {
                    int minutes = AppSettings.GetValueOrDefault(TimerMinutesKey, DefaultMinutes);
                    return new TimeSpan(0, minutes, 0); }
                set
                {
                    AppSettings.AddOrUpdateValue(TimerMinutesKey, value.Minutes);
                }
            }
        }

	}
}