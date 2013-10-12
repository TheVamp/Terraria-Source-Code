using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace Terraria
{
	public class Netplay
	{
		public const int bufferSize = 1024;
		public const int maxConnections = 256;
		public static bool stopListen = false;
		public static ServerSock[] serverSock = new ServerSock[256];
		public static ClientSock clientSock = new ClientSock();
		public static TcpListener tcpListener;
		public static IPAddress serverListenIP;
		public static IPAddress serverIP;
		public static int serverPort = 7777;
		public static bool disconnect = false;
		public static string password = "";
		public static string banFile = "banlist.txt";
		public static bool spamCheck = false;
		public static bool anyClients = false;
		public static string portForwardIP;
		public static int portForwardPort;
		public static bool portForwardOpen;
		public static bool uPNP = true;
		public static bool ServerUp = false;
		public static void openPort()
		{
			Netplay.portForwardIP = Netplay.LocalIPAddress();
			Netplay.portForwardPort = Netplay.serverPort;
		}
		public static void closePort()
		{
		}
		public static string LocalIPAddress()
		{
			string result = "";
			IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
			IPAddress[] addressList = hostEntry.AddressList;
			for (int i = 0; i < addressList.Length; i++)
			{
				IPAddress iPAddress = addressList[i];
				if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					result = iPAddress.ToString();
					break;
				}
			}
			return result;
		}
		public static void ResetNetDiag()
		{
			Main.rxMsg = 0;
			Main.rxData = 0;
			Main.txMsg = 0;
			Main.txData = 0;
			for (int i = 0; i < Main.maxMsg; i++)
			{
				Main.rxMsgType[i] = 0;
				Main.rxDataType[i] = 0;
				Main.txMsgType[i] = 0;
				Main.txDataType[i] = 0;
			}
		}
		public static void ResetSections()
		{
			for (int i = 0; i < 256; i++)
			{
				for (int j = 0; j < Main.maxSectionsX; j++)
				{
					for (int k = 0; k < Main.maxSectionsY; k++)
					{
						Netplay.serverSock[i].tileSection[j, k] = false;
					}
				}
			}
		}
		public static void AddBan(int plr)
		{
			string text = Netplay.serverSock[plr].tcpClient.Client.RemoteEndPoint.ToString();
			string value = text;
			for (int i = 0; i < text.Length; i++)
			{
				if (text.Substring(i, 1) == ":")
				{
					value = text.Substring(0, i);
				}
			}
			using (StreamWriter streamWriter = new StreamWriter(Netplay.banFile, true))
			{
				streamWriter.WriteLine("//" + Main.player[plr].name);
				streamWriter.WriteLine(value);
			}
		}
		public static bool CheckBan(string ip)
		{
			try
			{
				string b = ip;
				for (int i = 0; i < ip.Length; i++)
				{
					if (ip.Substring(i, 1) == ":")
					{
						b = ip.Substring(0, i);
					}
				}
				if (File.Exists(Netplay.banFile))
				{
					using (StreamReader streamReader = new StreamReader(Netplay.banFile))
					{
						string a;
						while ((a = streamReader.ReadLine()) != null)
						{
							if (a == b)
							{
								return true;
							}
						}
					}
				}
			}
			catch
			{
			}
			return false;
		}
		public static void newRecent()
		{
			for (int i = 0; i < Main.maxMP; i++)
			{
				if (Main.recentIP[i] == Netplay.serverIP.ToString() && Main.recentPort[i] == Netplay.serverPort)
				{
					for (int j = i; j < Main.maxMP - 1; j++)
					{
						Main.recentIP[j] = Main.recentIP[j + 1];
						Main.recentPort[j] = Main.recentPort[j + 1];
						Main.recentWorld[j] = Main.recentWorld[j + 1];
					}
				}
			}
			for (int k = Main.maxMP - 1; k > 0; k--)
			{
				Main.recentIP[k] = Main.recentIP[k - 1];
				Main.recentPort[k] = Main.recentPort[k - 1];
				Main.recentWorld[k] = Main.recentWorld[k - 1];
			}
			Main.recentIP[0] = Netplay.serverIP.ToString();
			Main.recentPort[0] = Netplay.serverPort;
			Main.recentWorld[0] = Main.worldName;
			Main.SaveRecent();
		}
		public static void ClientLoop(object threadContext)
		{
			Netplay.ResetNetDiag();
			Main.ServerSideCharacter = false;
			if (Main.rand == null)
			{
				Main.rand = new Random((int)DateTime.Now.Ticks);
			}
			if (WorldGen.genRand == null)
			{
				WorldGen.genRand = new Random((int)DateTime.Now.Ticks);
			}
			Main.player[Main.myPlayer].hostile = false;
			Main.clientPlayer = (Player)Main.player[Main.myPlayer].clientClone();
			for (int i = 0; i < 255; i++)
			{
				if (i != Main.myPlayer)
				{
					Main.player[i] = new Player();
				}
			}
			Main.menuMode = 10;
			Main.menuMode = 14;
			if (!Main.autoPass)
			{
				Main.statusText = "Connecting to " + Netplay.serverIP;
			}
			Main.netMode = 1;
			Netplay.disconnect = false;
			Netplay.clientSock = new ClientSock();
			Netplay.clientSock.tcpClient.NoDelay = true;
			Netplay.clientSock.readBuffer = new byte[1024];
			Netplay.clientSock.writeBuffer = new byte[1024];
			bool flag = true;
			while (flag)
			{
				flag = false;
				try
				{
					Netplay.clientSock.tcpClient.Connect(Netplay.serverIP, Netplay.serverPort);
					Netplay.clientSock.networkStream = Netplay.clientSock.tcpClient.GetStream();
					flag = false;
				}
				catch
				{
					if (!Netplay.disconnect && Main.gameMenu)
					{
						flag = true;
					}
				}
			}
			NetMessage.buffer[256].Reset();
			int num = -1;
			while (!Netplay.disconnect)
			{
				if (Netplay.clientSock.tcpClient.Connected)
				{
					if (NetMessage.buffer[256].checkBytes)
					{
						NetMessage.CheckBytes(256);
					}
					Netplay.clientSock.active = true;
					if (Netplay.clientSock.state == 0)
					{
						Main.statusText = "Found server";
						Netplay.clientSock.state = 1;
						NetMessage.SendData(1, -1, -1, "", 0, 0f, 0f, 0f, 0);
					}
					if (Netplay.clientSock.state == 2 && num != Netplay.clientSock.state)
					{
						Main.statusText = "Sending player data...";
					}
					if (Netplay.clientSock.state == 3 && num != Netplay.clientSock.state)
					{
						Main.statusText = "Requesting world information";
					}
					if (Netplay.clientSock.state == 4)
					{
						WorldGen.worldCleared = false;
						Netplay.clientSock.state = 5;
						if (Main.cloudBGActive >= 1f)
						{
							Main.cloudBGAlpha = 1f;
						}
						else
						{
							Main.cloudBGAlpha = 0f;
						}
						Main.windSpeed = Main.windSpeedSet;
						Cloud.resetClouds();
						Main.cloudAlpha = Main.maxRaining;
						WorldGen.clearWorld();
						if (Main.mapEnabled)
						{
							Map.loadMap();
						}
					}
					if (Netplay.clientSock.state == 5 && Main.loadMapLock)
					{
						float num2 = (float)Main.loadMapLastX / (float)Main.maxTilesX;
						Main.statusText = string.Concat(new object[]
						{
							Lang.gen[68],
							" ",
							(int)(num2 * 100f + 1f),
							"%"
						});
					}
					else
					{
						if (Netplay.clientSock.state == 5 && WorldGen.worldCleared)
						{
							Netplay.clientSock.state = 6;
							Main.player[Main.myPlayer].FindSpawn();
							NetMessage.SendData(8, -1, -1, "", Main.player[Main.myPlayer].SpawnX, (float)Main.player[Main.myPlayer].SpawnY, 0f, 0f, 0);
						}
					}
					if (Netplay.clientSock.state == 6 && num != Netplay.clientSock.state)
					{
						Main.statusText = "Requesting tile data";
					}
					if (!Netplay.clientSock.locked && !Netplay.disconnect && Netplay.clientSock.networkStream.DataAvailable)
					{
						Netplay.clientSock.locked = true;
						Netplay.clientSock.networkStream.BeginRead(Netplay.clientSock.readBuffer, 0, Netplay.clientSock.readBuffer.Length, new AsyncCallback(Netplay.clientSock.ClientReadCallBack), Netplay.clientSock.networkStream);
					}
					if (Netplay.clientSock.statusMax > 0 && Netplay.clientSock.statusText != "")
					{
						if (Netplay.clientSock.statusCount >= Netplay.clientSock.statusMax)
						{
							Main.statusText = Netplay.clientSock.statusText + ": Complete!";
							Netplay.clientSock.statusText = "";
							Netplay.clientSock.statusMax = 0;
							Netplay.clientSock.statusCount = 0;
						}
						else
						{
							Main.statusText = string.Concat(new object[]
							{
								Netplay.clientSock.statusText,
								": ",
								(int)((float)Netplay.clientSock.statusCount / (float)Netplay.clientSock.statusMax * 100f),
								"%"
							});
						}
					}
					Thread.Sleep(1);
				}
				else
				{
					if (Netplay.clientSock.active)
					{
						Main.statusText = "Lost connection";
						Netplay.disconnect = true;
					}
				}
				num = Netplay.clientSock.state;
			}
			try
			{
				Netplay.clientSock.networkStream.Close();
				Netplay.clientSock.networkStream = Netplay.clientSock.tcpClient.GetStream();
			}
			catch
			{
			}
			if (!Main.gameMenu)
			{
				Main.netMode = 0;
				Player.SavePlayer(Main.player[Main.myPlayer], Main.playerPathName);
				Main.gameMenu = true;
				Main.menuMode = 14;
			}
			NetMessage.buffer[256].Reset();
			if (Main.menuMode == 15 && Main.statusText == "Lost connection")
			{
				Main.menuMode = 14;
			}
			if (Netplay.clientSock.statusText != "" && Netplay.clientSock.statusText != null)
			{
				Main.statusText = "Lost connection";
			}
			Netplay.clientSock.statusCount = 0;
			Netplay.clientSock.statusMax = 0;
			Netplay.clientSock.statusText = "";
			Main.netMode = 0;
		}
		public static void ServerLoop(object threadContext)
		{
			Netplay.ResetNetDiag();
			if (Main.rand == null)
			{
				Main.rand = new Random((int)DateTime.Now.Ticks);
			}
			if (WorldGen.genRand == null)
			{
				WorldGen.genRand = new Random((int)DateTime.Now.Ticks);
			}
			Main.myPlayer = 255;
			Netplay.serverIP = IPAddress.Any;
			Netplay.serverListenIP = Netplay.serverIP;
			Main.menuMode = 14;
			Main.statusText = "Starting server...";
			Main.netMode = 2;
			Netplay.disconnect = false;
			for (int i = 0; i < 256; i++)
			{
				Netplay.serverSock[i] = new ServerSock();
				Netplay.serverSock[i].Reset();
				Netplay.serverSock[i].whoAmI = i;
				Netplay.serverSock[i].tcpClient = new TcpClient();
				Netplay.serverSock[i].tcpClient.NoDelay = true;
				Netplay.serverSock[i].readBuffer = new byte[1024];
				Netplay.serverSock[i].writeBuffer = new byte[1024];
			}
			Netplay.tcpListener = new TcpListener(Netplay.serverListenIP, Netplay.serverPort);
			try
			{
				Netplay.tcpListener.Start();
			}
			catch (Exception ex)
			{
				Main.menuMode = 15;
				Main.statusText = ex.ToString();
				Netplay.disconnect = true;
			}
			if (!Netplay.disconnect)
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(Netplay.ListenForClients), 1);
				Main.statusText = "Server started";
			}
			if (Netplay.uPNP)
			{
				try
				{
					Netplay.openPort();
				}
				catch
				{
				}
			}
			int num = 0;
			while (!Netplay.disconnect)
			{
				if (Netplay.stopListen)
				{
					int num2 = -1;
					for (int j = 0; j < Main.maxNetPlayers; j++)
					{
						if (!Netplay.serverSock[j].tcpClient.Connected)
						{
							num2 = j;
							break;
						}
					}
					if (num2 >= 0)
					{
						if (Main.ignoreErrors)
						{
							try
							{
								Netplay.tcpListener.Start();
								Netplay.stopListen = false;
								ThreadPool.QueueUserWorkItem(new WaitCallback(Netplay.ListenForClients), 1);
								goto IL_219;
							}
							catch
							{
								goto IL_219;
							}
						}
						Netplay.tcpListener.Start();
						Netplay.stopListen = false;
						ThreadPool.QueueUserWorkItem(new WaitCallback(Netplay.ListenForClients), 1);
					}
				}
				IL_219:
				int num3 = 0;
				for (int k = 0; k < 256; k++)
				{
					if (NetMessage.buffer[k].checkBytes)
					{
						NetMessage.CheckBytes(k);
					}
					if (Netplay.serverSock[k].kill)
					{
						Netplay.serverSock[k].Reset();
						NetMessage.syncPlayers();
					}
					else
					{
						if (Netplay.serverSock[k].tcpClient.Connected)
						{
							if (!Netplay.serverSock[k].active)
							{
								Netplay.serverSock[k].state = 0;
							}
							Netplay.serverSock[k].active = true;
							num3++;
							if (!Netplay.serverSock[k].locked)
							{
								try
								{
									Netplay.serverSock[k].networkStream = Netplay.serverSock[k].tcpClient.GetStream();
									if (Netplay.serverSock[k].networkStream.DataAvailable)
									{
										Netplay.serverSock[k].locked = true;
										Netplay.serverSock[k].networkStream.BeginRead(Netplay.serverSock[k].readBuffer, 0, Netplay.serverSock[k].readBuffer.Length, new AsyncCallback(Netplay.serverSock[k].ServerReadCallBack), Netplay.serverSock[k].networkStream);
									}
								}
								catch
								{
									Netplay.serverSock[k].kill = true;
								}
							}
							if (Netplay.serverSock[k].statusMax > 0 && Netplay.serverSock[k].statusText2 != "")
							{
								if (Netplay.serverSock[k].statusCount >= Netplay.serverSock[k].statusMax)
								{
									Netplay.serverSock[k].statusText = string.Concat(new object[]
									{
										"(",
										Netplay.serverSock[k].tcpClient.Client.RemoteEndPoint,
										") ",
										Netplay.serverSock[k].name,
										" ",
										Netplay.serverSock[k].statusText2,
										": Complete!"
									});
									Netplay.serverSock[k].statusText2 = "";
									Netplay.serverSock[k].statusMax = 0;
									Netplay.serverSock[k].statusCount = 0;
								}
								else
								{
									Netplay.serverSock[k].statusText = string.Concat(new object[]
									{
										"(",
										Netplay.serverSock[k].tcpClient.Client.RemoteEndPoint,
										") ",
										Netplay.serverSock[k].name,
										" ",
										Netplay.serverSock[k].statusText2,
										": ",
										(int)((float)Netplay.serverSock[k].statusCount / (float)Netplay.serverSock[k].statusMax * 100f),
										"%"
									});
								}
							}
							else
							{
								if (Netplay.serverSock[k].state == 0)
								{
									Netplay.serverSock[k].statusText = string.Concat(new object[]
									{
										"(",
										Netplay.serverSock[k].tcpClient.Client.RemoteEndPoint,
										") ",
										Netplay.serverSock[k].name,
										" is connecting..."
									});
								}
								else
								{
									if (Netplay.serverSock[k].state == 1)
									{
										Netplay.serverSock[k].statusText = string.Concat(new object[]
										{
											"(",
											Netplay.serverSock[k].tcpClient.Client.RemoteEndPoint,
											") ",
											Netplay.serverSock[k].name,
											" is sending player data..."
										});
									}
									else
									{
										if (Netplay.serverSock[k].state == 2)
										{
											Netplay.serverSock[k].statusText = string.Concat(new object[]
											{
												"(",
												Netplay.serverSock[k].tcpClient.Client.RemoteEndPoint,
												") ",
												Netplay.serverSock[k].name,
												" requested world information"
											});
										}
										else
										{
											if (Netplay.serverSock[k].state != 3 && Netplay.serverSock[k].state == 10)
											{
												Netplay.serverSock[k].statusText = string.Concat(new object[]
												{
													"(",
													Netplay.serverSock[k].tcpClient.Client.RemoteEndPoint,
													") ",
													Netplay.serverSock[k].name,
													" is playing"
												});
											}
										}
									}
								}
							}
						}
						else
						{
							if (Netplay.serverSock[k].active)
							{
								Netplay.serverSock[k].kill = true;
							}
							else
							{
								Netplay.serverSock[k].statusText2 = "";
								if (k < 255)
								{
									Main.player[k].active = false;
								}
							}
						}
					}
				}
				num++;
				if (num > 10)
				{
					Thread.Sleep(1);
					num = 0;
				}
				else
				{
					Thread.Sleep(0);
				}
				if (!WorldGen.saveLock && !Main.dedServ)
				{
					if (num3 == 0)
					{
						Main.statusText = "Waiting for clients...";
					}
					else
					{
						Main.statusText = num3 + " clients connected";
					}
				}
				if (num3 == 0)
				{
					Netplay.anyClients = false;
				}
				else
				{
					Netplay.anyClients = true;
				}
				Netplay.ServerUp = true;
			}
			Netplay.tcpListener.Stop();
			try
			{
				Netplay.closePort();
			}
			catch
			{
			}
			for (int l = 0; l < 256; l++)
			{
				Netplay.serverSock[l].Reset();
			}
			if (Main.menuMode != 15)
			{
				Main.netMode = 0;
				Main.menuMode = 10;
				WorldGen.saveWorld(false);
				while (WorldGen.saveLock)
				{
				}
				Main.menuMode = 0;
			}
			else
			{
				Main.netMode = 0;
			}
			Main.myPlayer = 0;
		}
		public static void ListenForClients(object threadContext)
		{
			while (!Netplay.disconnect && !Netplay.stopListen)
			{
				int num = -1;
				for (int i = 0; i < Main.maxNetPlayers; i++)
				{
					if (!Netplay.serverSock[i].tcpClient.Connected)
					{
						num = i;
						break;
					}
				}
				if (num >= 0)
				{
					try
					{
						Netplay.serverSock[num].tcpClient = Netplay.tcpListener.AcceptTcpClient();
						Netplay.serverSock[num].tcpClient.NoDelay = true;
						Console.WriteLine(Netplay.serverSock[num].tcpClient.Client.RemoteEndPoint + " is connecting...");
						continue;
					}
					catch (Exception ex)
					{
						if (!Netplay.disconnect)
						{
							Main.menuMode = 15;
							Main.statusText = ex.ToString();
							Netplay.disconnect = true;
						}
						continue;
					}
				}
				Netplay.stopListen = true;
				Netplay.tcpListener.Stop();
			}
		}
		public static void StartClient()
		{
			ThreadPool.QueueUserWorkItem(new WaitCallback(Netplay.ClientLoop), 1);
		}
		public static void StartServer()
		{
			ThreadPool.QueueUserWorkItem(new WaitCallback(Netplay.ServerLoop), 1);
		}
		public static bool SetIP(string newIP)
		{
			try
			{
				Netplay.serverIP = IPAddress.Parse(newIP);
			}
			catch
			{
				return false;
			}
			return true;
		}
		public static bool SetIP2(string newIP)
		{
			bool result;
			try
			{
				IPHostEntry hostEntry = Dns.GetHostEntry(newIP);
				IPAddress[] addressList = hostEntry.AddressList;
				for (int i = 0; i < addressList.Length; i++)
				{
					if (addressList[i].AddressFamily == AddressFamily.InterNetwork)
					{
						Netplay.serverIP = addressList[i];
						result = true;
						return result;
					}
				}
				result = false;
			}
			catch
			{
				result = false;
			}
			return result;
		}
		public static void Init()
		{
			for (int i = 0; i < 257; i++)
			{
				if (i < 256)
				{
					Netplay.serverSock[i] = new ServerSock();
					Netplay.serverSock[i].tcpClient.NoDelay = true;
				}
				NetMessage.buffer[i] = new messageBuffer();
				NetMessage.buffer[i].whoAmI = i;
			}
			Netplay.clientSock.tcpClient.NoDelay = true;
		}
		public static int GetSectionX(int x)
		{
			return x / 200;
		}
		public static int GetSectionY(int y)
		{
			return y / 150;
		}
	}
}
