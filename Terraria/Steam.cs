using System;
using System.Runtime.InteropServices;
namespace Terraria
{
	public class Steam
	{
		public static bool SteamInit;
		[DllImport("steam_api.dll")]
		private static extern bool SteamAPI_Init();
		[DllImport("steam_api.dll")]
		private static extern bool SteamAPI_Shutdown();
		public static void Init()
		{
			Steam.SteamInit = Steam.SteamAPI_Init();
		}
		public static void Kill()
		{
			Steam.SteamAPI_Shutdown();
		}
	}
}
