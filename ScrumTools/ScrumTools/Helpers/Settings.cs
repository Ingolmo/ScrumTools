using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace ScrumTools.Helpers
{
	public static class Settings
	{
        private const string DisplayKey = "display_key";

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

	}
}