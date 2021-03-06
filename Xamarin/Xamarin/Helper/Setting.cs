// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;

namespace Xamarin.Helper
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Setting
	{
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

		#region Setting Constants

		private const string SettingsKey = "settings_key";
		private static readonly string SettingsDefault = string.Empty;

		#endregion


		public static string Username
		{
			get
			{
				return AppSettings.GetValueOrDefault("Username", "");
			}
			set
			{
				AppSettings.AddOrUpdateValue("Username", value);
			}
		}
		public static string Password
		{
			get
			{
				return AppSettings.GetValueOrDefault("Password", "");
			}
			set
			{
				AppSettings.AddOrUpdateValue("Password", value);
			}
		}
		//public static DateTime AccessTokenExpirationDate
		//{
		//	get
		//	{
		//		return AppSettings.GetValueOrDefault("AccessTokenExpirationDate", "");
		//	}
		//	set
		//	{
		//		AppSettings.AddOrUpdateValue("AccessTokenExpirationDate", value);
		//	}
		//}
		public static string AccessToken
		{
			get
			{
				return AppSettings.GetValueOrDefault("AccessToken", "");
			}
			set
			{
				AppSettings.AddOrUpdateValue("AccessToken", value);
			}
		}

	}
}