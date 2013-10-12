using System;
using System.IO;
using System.Windows.Forms;
namespace Terraria
{
	internal static class Program
	{
		private static void Main(string[] args)
		{
			using (Main main = new Main())
			{
				try
				{
					for (int i = 0; i < args.Length; i++)
					{
						if (args[i].ToLower() == "-port" || args[i].ToLower() == "-p")
						{
							i++;
							try
							{
								int serverPort = Convert.ToInt32(args[i]);
								Netplay.serverPort = serverPort;
							}
							catch
							{
							}
						}
						if (args[i].ToLower() == "-join" || args[i].ToLower() == "-j")
						{
							i++;
							try
							{
								main.AutoJoin(args[i]);
							}
							catch
							{
							}
						}
						if (args[i].ToLower() == "-pass" || args[i].ToLower() == "-password")
						{
							i++;
							Netplay.password = args[i];
							main.AutoPass();
						}
						if (args[i].ToLower() == "-host")
						{
							main.AutoHost();
						}
						if (args[i].ToLower() == "-loadlib")
						{
							i++;
							string path = args[i];
							main.loadLib(path);
						}
					}
					Steam.Init();
					if (Steam.SteamInit)
					{
						main.Run();
					}
					else
					{
						MessageBox.Show("Please launch the game from your Steam client.", "Error");
					}
				}
				catch (Exception ex)
				{
					try
					{
						using (StreamWriter streamWriter = new StreamWriter("client-crashlog.txt", true))
						{
							streamWriter.WriteLine(DateTime.Now);
							streamWriter.WriteLine(ex);
							streamWriter.WriteLine("/n");
						}
						MessageBox.Show(ex.ToString(), "Terraria: Error");
					}
					catch
					{
					}
				}
			}
		}
	}
}
