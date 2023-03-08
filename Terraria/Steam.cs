using System;
using System.Runtime.InteropServices;
namespace Terraria
{
    public class Steam
    {
#if DEBUG
        private static bool SteamAPI_Init()
        {
            return true;
        }

        private static bool SteamAPI_Shutdown()
        {
            return true;
        }

#else
		[DllImport("steam_api.dll")]
		private static extern bool SteamAPI_Init();
		[DllImport("steam_api.dll")]
		private static extern bool SteamAPI_Shutdown();

#endif


        public static bool SteamInit;


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
