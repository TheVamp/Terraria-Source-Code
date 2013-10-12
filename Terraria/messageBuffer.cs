using Microsoft.Xna.Framework;
using System;
using System.Text;
namespace Terraria
{
	public class messageBuffer
	{
		public const int readBufferMax = 65535;
		public const int writeBufferMax = 65535;
		public bool broadcast;
		public byte[] readBuffer = new byte[65535];
		public byte[] writeBuffer = new byte[65535];
		public bool writeLocked;
		public int messageLength;
		public int totalData;
		public int whoAmI;
		public int spamCount;
		public int maxSpam;
		public bool checkBytes;
		public void Reset()
		{
			this.writeBuffer = new byte[65535];
			this.writeLocked = false;
			this.messageLength = 0;
			this.totalData = 0;
			this.spamCount = 0;
			this.broadcast = false;
			this.checkBytes = false;
		}
		public void GetData(int start, int length)
		{
			if (this.whoAmI < 256)
			{
				Netplay.serverSock[this.whoAmI].timeOut = 0;
			}
			else
			{
				Netplay.clientSock.timeOut = 0;
			}
			int num = start + 1;
			byte b = this.readBuffer[start];
			Main.rxMsg++;
			Main.rxData += length;
			Main.rxMsgType[(int)b]++;
			Main.rxDataType[(int)b] += length;
			if (Main.netMode == 1 && Netplay.clientSock.statusMax > 0)
			{
				Netplay.clientSock.statusCount++;
			}
			if (Main.verboseNetplay)
			{
				for (int i = start; i < start + length; i++)
				{
				}
				for (int j = start; j < start + length; j++)
				{
					byte arg_CD_0 = this.readBuffer[j];
				}
			}
			if (Main.netMode == 2 && b != 38 && Netplay.serverSock[this.whoAmI].state == -1)
			{
				NetMessage.SendData(2, this.whoAmI, -1, Lang.mp[1], 0, 0f, 0f, 0f, 0);
				return;
			}
			if (Main.netMode == 2 && Netplay.serverSock[this.whoAmI].state < 10 && b > 12 && b != 16 && b != 42 && b != 50 && b != 38 && b != 68)
			{
				NetMessage.BootPlayer(this.whoAmI, Lang.mp[2]);
			}
			if (b == 1 && Main.netMode == 2)
			{
				if (Main.dedServ && Netplay.CheckBan(Netplay.serverSock[this.whoAmI].tcpClient.Client.RemoteEndPoint.ToString()))
				{
					NetMessage.SendData(2, this.whoAmI, -1, Lang.mp[3], 0, 0f, 0f, 0f, 0);
					return;
				}
				if (Netplay.serverSock[this.whoAmI].state == 0)
				{
					string @string = Encoding.UTF8.GetString(this.readBuffer, start + 1, length - 1);
					if (!(@string == "Terraria" + Main.curRelease))
					{
						NetMessage.SendData(2, this.whoAmI, -1, Lang.mp[4], 0, 0f, 0f, 0f, 0);
						return;
					}
					if (Netplay.password == null || Netplay.password == "")
					{
						Netplay.serverSock[this.whoAmI].state = 1;
						NetMessage.SendData(3, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
						return;
					}
					Netplay.serverSock[this.whoAmI].state = -1;
					NetMessage.SendData(37, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
					return;
				}
			}
			else
			{
				if (b == 2 && Main.netMode == 1)
				{
					Netplay.disconnect = true;
					Main.statusText = Encoding.UTF8.GetString(this.readBuffer, start + 1, length - 1);
					return;
				}
				if (b == 3 && Main.netMode == 1)
				{
					if (Netplay.clientSock.state == 1)
					{
						Netplay.clientSock.state = 2;
					}
					int num2 = (int)this.readBuffer[start + 1];
					if (num2 != Main.myPlayer)
					{
						Main.player[num2] = (Player)Main.player[Main.myPlayer].Clone();
						Main.player[Main.myPlayer] = new Player();
						Main.player[num2].whoAmi = num2;
						Main.myPlayer = num2;
					}
					NetMessage.SendData(4, -1, -1, Main.player[Main.myPlayer].name, Main.myPlayer, 0f, 0f, 0f, 0);
					NetMessage.SendData(68, -1, -1, "", Main.myPlayer, 0f, 0f, 0f, 0);
					NetMessage.SendData(16, -1, -1, "", Main.myPlayer, 0f, 0f, 0f, 0);
					NetMessage.SendData(42, -1, -1, "", Main.myPlayer, 0f, 0f, 0f, 0);
					NetMessage.SendData(50, -1, -1, "", Main.myPlayer, 0f, 0f, 0f, 0);
					for (int k = 0; k < 59; k++)
					{
						NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].inventory[k].name, Main.myPlayer, (float)k, (float)Main.player[Main.myPlayer].inventory[k].prefix, 0f, 0);
					}
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[0].name, Main.myPlayer, 59f, (float)Main.player[Main.myPlayer].armor[0].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[1].name, Main.myPlayer, 60f, (float)Main.player[Main.myPlayer].armor[1].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[2].name, Main.myPlayer, 61f, (float)Main.player[Main.myPlayer].armor[2].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[3].name, Main.myPlayer, 62f, (float)Main.player[Main.myPlayer].armor[3].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[4].name, Main.myPlayer, 63f, (float)Main.player[Main.myPlayer].armor[4].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[5].name, Main.myPlayer, 64f, (float)Main.player[Main.myPlayer].armor[5].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[6].name, Main.myPlayer, 65f, (float)Main.player[Main.myPlayer].armor[6].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[7].name, Main.myPlayer, 66f, (float)Main.player[Main.myPlayer].armor[7].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[8].name, Main.myPlayer, 67f, (float)Main.player[Main.myPlayer].armor[8].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[9].name, Main.myPlayer, 68f, (float)Main.player[Main.myPlayer].armor[9].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].armor[10].name, Main.myPlayer, 69f, (float)Main.player[Main.myPlayer].armor[10].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].dye[0].name, Main.myPlayer, 70f, (float)Main.player[Main.myPlayer].dye[0].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].dye[1].name, Main.myPlayer, 71f, (float)Main.player[Main.myPlayer].dye[1].prefix, 0f, 0);
					NetMessage.SendData(5, -1, -1, Main.player[Main.myPlayer].dye[2].name, Main.myPlayer, 72f, (float)Main.player[Main.myPlayer].dye[2].prefix, 0f, 0);
					NetMessage.SendData(6, -1, -1, "", 0, 0f, 0f, 0f, 0);
					if (Netplay.clientSock.state == 2)
					{
						Netplay.clientSock.state = 3;
						return;
					}
				}
				else
				{
					if (b == 4)
					{
						bool flag = false;
						int num3 = (int)this.readBuffer[start + 1];
						if (Main.netMode == 2)
						{
							num3 = this.whoAmI;
						}
						if (num3 == Main.myPlayer && !Main.ServerSideCharacter)
						{
							return;
						}
						int num4 = (int)this.readBuffer[start + 2];
						if (num4 >= 51)
						{
							num4 = 0;
						}
						Main.player[num3].hair = num4;
						Main.player[num3].whoAmi = num3;
						num += 2;
						byte b2 = this.readBuffer[num];
						num++;
						if (b2 == 1)
						{
							Main.player[num3].male = true;
						}
						else
						{
							Main.player[num3].male = false;
						}
						Main.player[num3].hairColor.R = this.readBuffer[num];
						num++;
						Main.player[num3].hairColor.G = this.readBuffer[num];
						num++;
						Main.player[num3].hairColor.B = this.readBuffer[num];
						num++;
						Main.player[num3].skinColor.R = this.readBuffer[num];
						num++;
						Main.player[num3].skinColor.G = this.readBuffer[num];
						num++;
						Main.player[num3].skinColor.B = this.readBuffer[num];
						num++;
						Main.player[num3].eyeColor.R = this.readBuffer[num];
						num++;
						Main.player[num3].eyeColor.G = this.readBuffer[num];
						num++;
						Main.player[num3].eyeColor.B = this.readBuffer[num];
						num++;
						Main.player[num3].shirtColor.R = this.readBuffer[num];
						num++;
						Main.player[num3].shirtColor.G = this.readBuffer[num];
						num++;
						Main.player[num3].shirtColor.B = this.readBuffer[num];
						num++;
						Main.player[num3].underShirtColor.R = this.readBuffer[num];
						num++;
						Main.player[num3].underShirtColor.G = this.readBuffer[num];
						num++;
						Main.player[num3].underShirtColor.B = this.readBuffer[num];
						num++;
						Main.player[num3].pantsColor.R = this.readBuffer[num];
						num++;
						Main.player[num3].pantsColor.G = this.readBuffer[num];
						num++;
						Main.player[num3].pantsColor.B = this.readBuffer[num];
						num++;
						Main.player[num3].shoeColor.R = this.readBuffer[num];
						num++;
						Main.player[num3].shoeColor.G = this.readBuffer[num];
						num++;
						Main.player[num3].shoeColor.B = this.readBuffer[num];
						num++;
						byte difficulty = this.readBuffer[num];
						Main.player[num3].difficulty = difficulty;
						num++;
						string text = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
						text = text.Trim();
						Main.player[num3].name = text.Trim();
						if (Main.netMode == 2)
						{
							if (Netplay.serverSock[this.whoAmI].state < 10)
							{
								for (int l = 0; l < 255; l++)
								{
									if (l != num3 && text == Main.player[l].name && Netplay.serverSock[l].active)
									{
										flag = true;
									}
								}
							}
							if (flag)
							{
								NetMessage.SendData(2, this.whoAmI, -1, text + " " + Lang.mp[5], 0, 0f, 0f, 0f, 0);
								return;
							}
							if (text.Length > Player.nameLen)
							{
								NetMessage.SendData(2, this.whoAmI, -1, "Name is too long.", 0, 0f, 0f, 0f, 0);
								return;
							}
							if (text == "")
							{
								NetMessage.SendData(2, this.whoAmI, -1, "Empty name.", 0, 0f, 0f, 0f, 0);
								return;
							}
							Netplay.serverSock[this.whoAmI].oldName = text;
							Netplay.serverSock[this.whoAmI].name = text;
							NetMessage.SendData(4, -1, this.whoAmI, text, num3, 0f, 0f, 0f, 0);
							return;
						}
					}
					else
					{
						if (b == 5)
						{
							int num5 = (int)this.readBuffer[start + 1];
							if (Main.netMode == 2)
							{
								num5 = this.whoAmI;
							}
							if (num5 == Main.myPlayer && !Main.ServerSideCharacter)
							{
								return;
							}
							lock (Main.player[num5])
							{
								int num6 = (int)this.readBuffer[start + 2];
								int stack = (int)BitConverter.ToInt16(this.readBuffer, start + 3);
								byte b3 = this.readBuffer[start + 5];
								int type = (int)BitConverter.ToInt16(this.readBuffer, start + 6);
								if (num6 < 59)
								{
									Main.player[num5].inventory[num6] = new Item();
									Main.player[num5].inventory[num6].netDefaults(type);
									Main.player[num5].inventory[num6].stack = stack;
									Main.player[num5].inventory[num6].Prefix((int)b3);
								}
								else
								{
									if (num6 >= 70 && num6 <= 72)
									{
										int num7 = num6 - 58 - 12;
										Main.player[num5].dye[num7] = new Item();
										Main.player[num5].dye[num7].netDefaults(type);
										Main.player[num5].dye[num7].stack = stack;
										Main.player[num5].dye[num7].Prefix((int)b3);
									}
									else
									{
										Main.player[num5].armor[num6 - 58 - 1] = new Item();
										Main.player[num5].armor[num6 - 58 - 1].netDefaults(type);
										Main.player[num5].armor[num6 - 58 - 1].stack = stack;
										Main.player[num5].armor[num6 - 58 - 1].Prefix((int)b3);
									}
								}
								if (Main.netMode == 2 && num5 == this.whoAmI)
								{
									NetMessage.SendData(5, -1, this.whoAmI, "", num5, (float)num6, (float)b3, 0f, 0);
								}
								return;
							}
						}
						if (b == 6)
						{
							if (Main.netMode == 2)
							{
								if (Netplay.serverSock[this.whoAmI].state == 1)
								{
									Netplay.serverSock[this.whoAmI].state = 2;
								}
								NetMessage.SendData(7, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
								return;
							}
						}
						else
						{
							if (b == 7)
							{
								if (Main.netMode == 1)
								{
									Main.time = (double)BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.dayTime = false;
									if (this.readBuffer[num] == 1)
									{
										Main.dayTime = true;
									}
									num++;
									Main.moonPhase = (int)this.readBuffer[num];
									num++;
									int num8 = (int)this.readBuffer[num];
									num++;
									int num9 = (int)this.readBuffer[num];
									num++;
									if (num8 == 1)
									{
										Main.bloodMoon = true;
									}
									else
									{
										Main.bloodMoon = false;
									}
									if (num9 == 1)
									{
										Main.eclipse = true;
									}
									else
									{
										Main.eclipse = false;
									}
									Main.maxTilesX = BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.maxTilesY = BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.spawnTileX = BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.spawnTileY = BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.worldSurface = (double)BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.rockLayer = (double)BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.worldID = BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.moonType = (int)this.readBuffer[num];
									num++;
									Main.treeX[0] = BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.treeX[1] = BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.treeX[2] = BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.treeStyle[0] = (int)this.readBuffer[num];
									num++;
									Main.treeStyle[1] = (int)this.readBuffer[num];
									num++;
									Main.treeStyle[2] = (int)this.readBuffer[num];
									num++;
									Main.treeStyle[3] = (int)this.readBuffer[num];
									num++;
									Main.caveBackX[0] = BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.caveBackX[1] = BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.caveBackX[2] = BitConverter.ToInt32(this.readBuffer, num);
									num += 4;
									Main.caveBackStyle[0] = (int)this.readBuffer[num];
									num++;
									Main.caveBackStyle[1] = (int)this.readBuffer[num];
									num++;
									Main.caveBackStyle[2] = (int)this.readBuffer[num];
									num++;
									Main.caveBackStyle[3] = (int)this.readBuffer[num];
									num++;
									byte style = this.readBuffer[num];
									num++;
									byte style2 = this.readBuffer[num];
									num++;
									byte style3 = this.readBuffer[num];
									num++;
									byte style4 = this.readBuffer[num];
									num++;
									byte style5 = this.readBuffer[num];
									num++;
									byte style6 = this.readBuffer[num];
									num++;
									byte style7 = this.readBuffer[num];
									num++;
									byte style8 = this.readBuffer[num];
									num++;
									WorldGen.setBG(0, (int)style);
									WorldGen.setBG(1, (int)style2);
									WorldGen.setBG(2, (int)style3);
									WorldGen.setBG(3, (int)style4);
									WorldGen.setBG(4, (int)style5);
									WorldGen.setBG(5, (int)style6);
									WorldGen.setBG(6, (int)style7);
									WorldGen.setBG(7, (int)style8);
									Main.iceBackStyle = (int)this.readBuffer[num];
									num++;
									Main.jungleBackStyle = (int)this.readBuffer[num];
									num++;
									Main.hellBackStyle = (int)this.readBuffer[num];
									num++;
									Main.windSpeedSet = BitConverter.ToSingle(this.readBuffer, num);
									num += 4;
									Main.numClouds = (int)this.readBuffer[num];
									num++;
									byte b4 = this.readBuffer[num];
									num++;
									byte b5 = this.readBuffer[num];
									num++;
									float num10 = BitConverter.ToSingle(this.readBuffer, num);
									num += 4;
									Main.maxRaining = num10;
									if (num10 > 0f)
									{
										Main.raining = true;
									}
									else
									{
										Main.raining = false;
									}
									bool flag3 = false;
									bool crimson = false;
									if ((b4 & 1) == 1)
									{
										WorldGen.shadowOrbSmashed = true;
									}
									if ((b4 & 2) == 2)
									{
										NPC.downedBoss1 = true;
									}
									if ((b4 & 4) == 4)
									{
										NPC.downedBoss2 = true;
									}
									if ((b4 & 8) == 8)
									{
										NPC.downedBoss3 = true;
									}
									if ((b4 & 16) == 16)
									{
										Main.hardMode = true;
									}
									if ((b4 & 32) == 32)
									{
										NPC.downedClown = true;
									}
									if ((b4 & 64) == 64)
									{
										Main.ServerSideCharacter = true;
									}
									if ((b4 & 128) == 128)
									{
										NPC.downedPlantBoss = true;
									}
									if ((b5 & 1) == 1)
									{
										NPC.downedMechBoss1 = true;
									}
									if ((b5 & 2) == 2)
									{
										NPC.downedMechBoss2 = true;
									}
									if ((b5 & 4) == 4)
									{
										NPC.downedMechBoss3 = true;
									}
									if ((b5 & 8) == 8)
									{
										NPC.downedMechBossAny = true;
									}
									if ((b5 & 16) == 16)
									{
										flag3 = true;
									}
									if ((b5 & 32) == 32)
									{
										crimson = true;
									}
									if (flag3)
									{
										Main.cloudBGActive = 1f;
									}
									if (!flag3)
									{
										Main.cloudBGActive = 0f;
									}
									WorldGen.crimson = crimson;
									Main.worldName = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
									if (Netplay.clientSock.state == 3)
									{
										Netplay.clientSock.state = 4;
										return;
									}
								}
							}
							else
							{
								if (b == 8)
								{
									if (Main.netMode == 2)
									{
										int num11 = BitConverter.ToInt32(this.readBuffer, num);
										num += 4;
										int num12 = BitConverter.ToInt32(this.readBuffer, num);
										num += 4;
										bool flag4 = true;
										if (num11 == -1 || num12 == -1)
										{
											flag4 = false;
										}
										else
										{
											if (num11 < 10 || num11 > Main.maxTilesX - 10)
											{
												flag4 = false;
											}
											else
											{
												if (num12 < 10 || num12 > Main.maxTilesY - 10)
												{
													flag4 = false;
												}
											}
										}
										int num13 = 1350;
										if (flag4)
										{
											num13 *= 2;
										}
										if (Netplay.serverSock[this.whoAmI].state == 2)
										{
											Netplay.serverSock[this.whoAmI].state = 3;
										}
										NetMessage.SendData(9, this.whoAmI, -1, Lang.inter[44], num13, 0f, 0f, 0f, 0);
										Netplay.serverSock[this.whoAmI].statusText2 = "is receiving tile data";
										Netplay.serverSock[this.whoAmI].statusMax += num13;
										int sectionX = Netplay.GetSectionX(Main.spawnTileX);
										int sectionY = Netplay.GetSectionY(Main.spawnTileY);
										for (int m = sectionX - 2; m < sectionX + 3; m++)
										{
											for (int n = sectionY - 1; n < sectionY + 2; n++)
											{
												NetMessage.SendSection(this.whoAmI, m, n);
											}
										}
										if (flag4)
										{
											num11 = Netplay.GetSectionX(num11);
											num12 = Netplay.GetSectionY(num12);
											for (int num14 = num11 - 2; num14 < num11 + 3; num14++)
											{
												for (int num15 = num12 - 1; num15 < num12 + 2; num15++)
												{
													NetMessage.SendSection(this.whoAmI, num14, num15);
												}
											}
											NetMessage.SendData(11, this.whoAmI, -1, "", num11 - 2, (float)(num12 - 1), (float)(num11 + 2), (float)(num12 + 1), 0);
										}
										NetMessage.SendData(11, this.whoAmI, -1, "", sectionX - 2, (float)(sectionY - 1), (float)(sectionX + 2), (float)(sectionY + 1), 0);
										for (int num16 = 0; num16 < 400; num16++)
										{
											if (Main.item[num16].active)
											{
												NetMessage.SendData(21, this.whoAmI, -1, "", num16, 0f, 0f, 0f, 0);
												NetMessage.SendData(22, this.whoAmI, -1, "", num16, 0f, 0f, 0f, 0);
											}
										}
										for (int num17 = 0; num17 < 200; num17++)
										{
											if (Main.npc[num17].active)
											{
												NetMessage.SendData(23, this.whoAmI, -1, "", num17, 0f, 0f, 0f, 0);
											}
										}
										for (int num18 = 0; num18 < 1000; num18++)
										{
											if (Main.projectile[num18].active && (Main.projPet[Main.projectile[num18].type] || Main.projectile[num18].netImportant))
											{
												NetMessage.SendData(27, this.whoAmI, -1, "", num18, 0f, 0f, 0f, 0);
											}
										}
										NetMessage.SendData(49, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
										NetMessage.SendData(57, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 17, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 18, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 19, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 20, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 22, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 38, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 54, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 107, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 108, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 124, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 160, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 178, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 207, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 208, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 209, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 227, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 228, 0f, 0f, 0f, 0);
										NetMessage.SendData(56, this.whoAmI, -1, "", 229, 0f, 0f, 0f, 0);
										NetMessage.SendData(7, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
										return;
									}
								}
								else
								{
									if (b == 9)
									{
										if (Main.netMode == 1)
										{
											int num19 = BitConverter.ToInt32(this.readBuffer, start + 1);
											string string2 = Encoding.UTF8.GetString(this.readBuffer, start + 5, length - 5);
											Netplay.clientSock.statusMax += num19;
											Netplay.clientSock.statusText = string2;
											return;
										}
									}
									else
									{
										if (b == 10 && Main.netMode == 1)
										{
											short num20 = BitConverter.ToInt16(this.readBuffer, start + 1);
											int num21 = BitConverter.ToInt32(this.readBuffer, start + 3);
											int num22 = BitConverter.ToInt32(this.readBuffer, start + 7);
											num = start + 11;
											for (int num23 = num21; num23 < num21 + (int)num20; num23++)
											{
												if (Main.tile[num23, num22] == null)
												{
													Main.tile[num23, num22] = new Tile();
												}
												byte b6 = this.readBuffer[num];
												num++;
												byte b7 = this.readBuffer[num];
												num++;
												bool flag5 = Main.tile[num23, num22].active();
												if ((b6 & 1) == 1)
												{
													Main.tile[num23, num22].active(true);
												}
												else
												{
													Main.tile[num23, num22].active(false);
												}
												byte arg_1BFD_0 = (byte)(b6 & 2);
												if ((b6 & 4) == 4)
												{
													Main.tile[num23, num22].wall = 1;
												}
												else
												{
													Main.tile[num23, num22].wall = 0;
												}
												if ((b6 & 8) == 8)
												{
													Main.tile[num23, num22].liquid = 1;
												}
												else
												{
													Main.tile[num23, num22].liquid = 0;
												}
												if ((b6 & 16) == 16)
												{
													Main.tile[num23, num22].wire(true);
												}
												else
												{
													Main.tile[num23, num22].wire(false);
												}
												if ((b6 & 32) == 32)
												{
													Main.tile[num23, num22].halfBrick(true);
												}
												else
												{
													Main.tile[num23, num22].halfBrick(false);
												}
												if ((b6 & 64) == 64)
												{
													Main.tile[num23, num22].actuator(true);
												}
												else
												{
													Main.tile[num23, num22].actuator(false);
												}
												if ((b6 & 128) == 128)
												{
													Main.tile[num23, num22].inActive(true);
												}
												else
												{
													Main.tile[num23, num22].inActive(false);
												}
												if ((b7 & 1) == 1)
												{
													Main.tile[num23, num22].wire2(true);
												}
												else
												{
													Main.tile[num23, num22].wire2(false);
												}
												if ((b7 & 2) == 2)
												{
													Main.tile[num23, num22].wire3(true);
												}
												else
												{
													Main.tile[num23, num22].wire3(false);
												}
												if ((b7 & 4) == 4)
												{
													Main.tile[num23, num22].color(this.readBuffer[num]);
													num++;
												}
												else
												{
													Main.tile[num23, num22].color(0);
												}
												if ((b7 & 8) == 8)
												{
													Main.tile[num23, num22].wallColor(this.readBuffer[num]);
													num++;
												}
												else
												{
													Main.tile[num23, num22].wallColor(0);
												}
												if (Main.tile[num23, num22].active())
												{
													int type2 = (int)Main.tile[num23, num22].type;
													Main.tile[num23, num22].type = this.readBuffer[num];
													num++;
													if (Main.tileFrameImportant[(int)Main.tile[num23, num22].type])
													{
														Main.tile[num23, num22].frameX = BitConverter.ToInt16(this.readBuffer, num);
														num += 2;
														Main.tile[num23, num22].frameY = BitConverter.ToInt16(this.readBuffer, num);
														num += 2;
													}
													else
													{
														if (!flag5 || (int)Main.tile[num23, num22].type != type2)
														{
															Main.tile[num23, num22].frameX = -1;
															Main.tile[num23, num22].frameY = -1;
														}
													}
													byte b8 = 0;
													if ((b7 & 16) == 16)
													{
														b8 += 1;
													}
													if ((b7 & 32) == 32)
													{
														b8 += 2;
													}
													Main.tile[num23, num22].slope(b8);
												}
												if (Main.tile[num23, num22].wall > 0)
												{
													Main.tile[num23, num22].wall = this.readBuffer[num];
													num++;
												}
												if (Main.tile[num23, num22].liquid > 0)
												{
													Main.tile[num23, num22].liquid = this.readBuffer[num];
													num++;
													byte liquidType = this.readBuffer[num];
													num++;
													Main.tile[num23, num22].liquidType((int)liquidType);
												}
												short num24 = BitConverter.ToInt16(this.readBuffer, num);
												num += 2;
												int num25 = num23;
												while (num24 > 0)
												{
													num25++;
													num24 -= 1;
													if (Main.tile[num25, num22] == null)
													{
														Main.tile[num25, num22] = new Tile();
													}
													Main.tile[num25, num22].active(Main.tile[num23, num22].active());
													Main.tile[num25, num22].type = Main.tile[num23, num22].type;
													Main.tile[num25, num22].wall = Main.tile[num23, num22].wall;
													Main.tile[num25, num22].wire(Main.tile[num23, num22].wire());
													if (Main.tileFrameImportant[(int)Main.tile[num25, num22].type])
													{
														Main.tile[num25, num22].frameX = Main.tile[num23, num22].frameX;
														Main.tile[num25, num22].frameY = Main.tile[num23, num22].frameY;
													}
													else
													{
														Main.tile[num25, num22].frameX = -1;
														Main.tile[num25, num22].frameY = -1;
													}
													Main.tile[num25, num22].liquid = Main.tile[num23, num22].liquid;
													Main.tile[num25, num22].liquidType((int)Main.tile[num23, num22].liquidType());
													Main.tile[num25, num22].halfBrick(Main.tile[num23, num22].halfBrick());
													Main.tile[num25, num22].slope(Main.tile[num23, num22].slope());
													Main.tile[num25, num22].actuator(Main.tile[num23, num22].actuator());
													Main.tile[num25, num22].inActive(Main.tile[num23, num22].inActive());
													Main.tile[num25, num22].wire2(Main.tile[num23, num22].wire2());
													Main.tile[num25, num22].wire3(Main.tile[num23, num22].wire3());
													Main.tile[num25, num22].color(Main.tile[num23, num22].color());
													Main.tile[num25, num22].wallColor(Main.tile[num23, num22].wallColor());
												}
												num23 = num25;
											}
											if (Main.netMode == 2)
											{
												NetMessage.SendData((int)b, -1, this.whoAmI, "", (int)num20, (float)num21, (float)num22, 0f, 0);
												return;
											}
										}
										else
										{
											if (b == 11)
											{
												if (Main.netMode == 1)
												{
													int startX = (int)BitConverter.ToInt16(this.readBuffer, num);
													num += 4;
													int startY = (int)BitConverter.ToInt16(this.readBuffer, num);
													num += 4;
													int endX = (int)BitConverter.ToInt16(this.readBuffer, num);
													num += 4;
													int endY = (int)BitConverter.ToInt16(this.readBuffer, num);
													num += 4;
													WorldGen.SectionTileFrame(startX, startY, endX, endY);
													return;
												}
											}
											else
											{
												if (b == 12)
												{
													int num26 = (int)this.readBuffer[num];
													if (Main.netMode == 2)
													{
														num26 = this.whoAmI;
													}
													num++;
													Main.player[num26].SpawnX = BitConverter.ToInt32(this.readBuffer, num);
													num += 4;
													Main.player[num26].SpawnY = BitConverter.ToInt32(this.readBuffer, num);
													num += 4;
													Main.player[num26].Spawn();
													if (Main.netMode == 2 && Netplay.serverSock[this.whoAmI].state >= 3)
													{
														if (Netplay.serverSock[this.whoAmI].state == 3)
														{
															Netplay.serverSock[this.whoAmI].state = 10;
															NetMessage.greetPlayer(this.whoAmI);
															NetMessage.buffer[this.whoAmI].broadcast = true;
															NetMessage.syncPlayers();
															NetMessage.SendData(12, -1, this.whoAmI, "", this.whoAmI, 0f, 0f, 0f, 0);
															return;
														}
														NetMessage.SendData(12, -1, this.whoAmI, "", this.whoAmI, 0f, 0f, 0f, 0);
														return;
													}
												}
												else
												{
													if (b == 13)
													{
														int num27 = (int)this.readBuffer[num];
														if (num27 == Main.myPlayer && !Main.ServerSideCharacter)
														{
															return;
														}
														if (Main.netMode == 1)
														{
															bool arg_24C7_0 = Main.player[num27].active;
														}
														if (Main.netMode == 2)
														{
															num27 = this.whoAmI;
														}
														num++;
														int num28 = (int)this.readBuffer[num];
														num++;
														int selectedItem = (int)this.readBuffer[num];
														num++;
														float x = BitConverter.ToSingle(this.readBuffer, num);
														num += 4;
														float num29 = BitConverter.ToSingle(this.readBuffer, num);
														num += 4;
														float x2 = BitConverter.ToSingle(this.readBuffer, num);
														num += 4;
														float y = BitConverter.ToSingle(this.readBuffer, num);
														num += 4;
														byte b9 = this.readBuffer[num];
														num++;
														Main.player[num27].selectedItem = selectedItem;
														Main.player[num27].position.X = x;
														Main.player[num27].position.Y = num29;
														Main.player[num27].velocity.X = x2;
														Main.player[num27].velocity.Y = y;
														Main.player[num27].oldVelocity = Main.player[num27].velocity;
														Main.player[num27].fallStart = (int)(num29 / 16f);
														Main.player[num27].controlUp = false;
														Main.player[num27].controlDown = false;
														Main.player[num27].controlLeft = false;
														Main.player[num27].controlRight = false;
														Main.player[num27].controlJump = false;
														Main.player[num27].controlUseItem = false;
														Main.player[num27].direction = -1;
														if ((num28 & 1) == 1)
														{
															Main.player[num27].controlUp = true;
														}
														if ((num28 & 2) == 2)
														{
															Main.player[num27].controlDown = true;
														}
														if ((num28 & 4) == 4)
														{
															Main.player[num27].controlLeft = true;
														}
														if ((num28 & 8) == 8)
														{
															Main.player[num27].controlRight = true;
														}
														if ((num28 & 16) == 16)
														{
															Main.player[num27].controlJump = true;
														}
														if ((num28 & 32) == 32)
														{
															Main.player[num27].controlUseItem = true;
														}
														if ((num28 & 64) == 64)
														{
															Main.player[num27].direction = 1;
														}
														if ((b9 & 1) == 1)
														{
															Main.player[num27].pulley = true;
															if ((b9 & 2) == 2)
															{
																Main.player[num27].pulleyDir = 2;
															}
															else
															{
																Main.player[num27].pulleyDir = 1;
															}
														}
														else
														{
															Main.player[num27].pulley = false;
														}
														if (Main.netMode == 2 && Netplay.serverSock[this.whoAmI].state == 10)
														{
															NetMessage.SendData(13, -1, this.whoAmI, "", num27, 0f, 0f, 0f, 0);
															return;
														}
													}
													else
													{
														if (b == 14)
														{
															if (Main.netMode == 1)
															{
																int num30 = (int)this.readBuffer[num];
																num++;
																int num31 = (int)this.readBuffer[num];
																if (num31 == 1)
																{
																	if (!Main.player[num30].active)
																	{
																		Main.player[num30] = new Player();
																	}
																	Main.player[num30].active = true;
																	return;
																}
																Main.player[num30].active = false;
																return;
															}
														}
														else
														{
															if (b == 15)
															{
																if (Main.netMode == 2)
																{
																	return;
																}
															}
															else
															{
																if (b == 16)
																{
																	int num32 = (int)this.readBuffer[num];
																	num++;
																	if (num32 == Main.myPlayer && !Main.ServerSideCharacter)
																	{
																		return;
																	}
																	int statLife = (int)BitConverter.ToInt16(this.readBuffer, num);
																	num += 2;
																	int num33 = (int)BitConverter.ToInt16(this.readBuffer, num);
																	if (Main.netMode == 2)
																	{
																		num32 = this.whoAmI;
																	}
																	Main.player[num32].statLife = statLife;
																	if (num33 < 100)
																	{
																		num33 = 100;
																	}
																	Main.player[num32].statLifeMax = num33;
																	if (Main.player[num32].statLife <= 0)
																	{
																		Main.player[num32].dead = true;
																	}
																	if (Main.netMode == 2)
																	{
																		NetMessage.SendData(16, -1, this.whoAmI, "", num32, 0f, 0f, 0f, 0);
																		return;
																	}
																}
																else
																{
																	if (b == 17)
																	{
																		byte b10 = this.readBuffer[num];
																		num++;
																		int num34 = BitConverter.ToInt32(this.readBuffer, num);
																		num += 4;
																		int num35 = BitConverter.ToInt32(this.readBuffer, num);
																		num += 4;
																		byte b11 = this.readBuffer[num];
																		num++;
																		int num36 = (int)this.readBuffer[num];
																		bool flag6 = false;
																		if (b11 == 1)
																		{
																			flag6 = true;
																		}
																		if (Main.tile[num34, num35] == null)
																		{
																			Main.tile[num34, num35] = new Tile();
																		}
																		if (Main.netMode == 2)
																		{
																			if (!flag6)
																			{
																				if (b10 == 0 || b10 == 2 || b10 == 4)
																				{
																					Netplay.serverSock[this.whoAmI].spamDelBlock += 1f;
																				}
																				else
																				{
																					if (b10 == 1 || b10 == 3)
																					{
																						Netplay.serverSock[this.whoAmI].spamAddBlock += 1f;
																					}
																				}
																			}
																			if (!Netplay.serverSock[this.whoAmI].tileSection[Netplay.GetSectionX(num34), Netplay.GetSectionY(num35)])
																			{
																				flag6 = true;
																			}
																		}
																		if (b10 == 0)
																		{
																			WorldGen.KillTile(num34, num35, flag6, false, false);
																		}
																		else
																		{
																			if (b10 == 1)
																			{
																				WorldGen.PlaceTile(num34, num35, (int)b11, false, true, -1, num36);
																			}
																			else
																			{
																				if (b10 == 2)
																				{
																					WorldGen.KillWall(num34, num35, flag6);
																				}
																				else
																				{
																					if (b10 == 3)
																					{
																						WorldGen.PlaceWall(num34, num35, (int)b11, false);
																					}
																					else
																					{
																						if (b10 == 4)
																						{
																							WorldGen.KillTile(num34, num35, flag6, false, true);
																						}
																						else
																						{
																							if (b10 == 5)
																							{
																								WorldGen.PlaceWire(num34, num35);
																							}
																							else
																							{
																								if (b10 == 6)
																								{
																									WorldGen.KillWire(num34, num35);
																								}
																								else
																								{
																									if (b10 == 7)
																									{
																										WorldGen.PoundTile(num34, num35);
																									}
																									else
																									{
																										if (b10 == 8)
																										{
																											WorldGen.PlaceActuator(num34, num35);
																										}
																										else
																										{
																											if (b10 == 9)
																											{
																												WorldGen.KillActuator(num34, num35);
																											}
																											else
																											{
																												if (b10 == 10)
																												{
																													WorldGen.PlaceWire2(num34, num35);
																												}
																												else
																												{
																													if (b10 == 11)
																													{
																														WorldGen.KillWire2(num34, num35);
																													}
																													else
																													{
																														if (b10 == 12)
																														{
																															WorldGen.PlaceWire3(num34, num35);
																														}
																														else
																														{
																															if (b10 == 13)
																															{
																																WorldGen.KillWire3(num34, num35);
																															}
																															else
																															{
																																if (b10 == 14)
																																{
																																	WorldGen.SlopeTile(num34, num35, (int)b11);
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																		if (Main.netMode == 2)
																		{
																			NetMessage.SendData(17, -1, this.whoAmI, "", (int)b10, (float)num34, (float)num35, (float)b11, num36);
																			if (b10 == 1 && b11 == 53)
																			{
																				NetMessage.SendTileSquare(-1, num34, num35, 1);
																				return;
																			}
																		}
																	}
																	else
																	{
																		if (b == 18)
																		{
																			if (Main.netMode == 1)
																			{
																				byte b12 = this.readBuffer[num];
																				num++;
																				int num37 = BitConverter.ToInt32(this.readBuffer, num);
																				num += 4;
																				short sunModY = BitConverter.ToInt16(this.readBuffer, num);
																				num += 2;
																				short moonModY = BitConverter.ToInt16(this.readBuffer, num);
																				num += 2;
																				if (b12 == 1)
																				{
																					Main.dayTime = true;
																				}
																				else
																				{
																					Main.dayTime = false;
																				}
																				Main.time = (double)num37;
																				Main.sunModY = sunModY;
																				Main.moonModY = moonModY;
																				if (Main.netMode == 2)
																				{
																					NetMessage.SendData(18, -1, this.whoAmI, "", 0, 0f, 0f, 0f, 0);
																					return;
																				}
																			}
																		}
																		else
																		{
																			if (b == 19)
																			{
																				byte b13 = this.readBuffer[num];
																				num++;
																				int num38 = BitConverter.ToInt32(this.readBuffer, num);
																				num += 4;
																				int num39 = BitConverter.ToInt32(this.readBuffer, num);
																				num += 4;
																				int num40 = (int)this.readBuffer[num];
																				int direction = 0;
																				if (num40 == 0)
																				{
																					direction = -1;
																				}
																				if (b13 == 0)
																				{
																					WorldGen.OpenDoor(num38, num39, direction);
																				}
																				else
																				{
																					if (b13 == 1)
																					{
																						WorldGen.CloseDoor(num38, num39, true);
																					}
																				}
																				if (Main.netMode == 2)
																				{
																					NetMessage.SendData(19, -1, this.whoAmI, "", (int)b13, (float)num38, (float)num39, (float)num40, 0);
																					return;
																				}
																			}
																			else
																			{
																				if (b == 20)
																				{
																					short num41 = BitConverter.ToInt16(this.readBuffer, start + 1);
																					int num42 = BitConverter.ToInt32(this.readBuffer, start + 3);
																					int num43 = BitConverter.ToInt32(this.readBuffer, start + 7);
																					num = start + 11;
																					for (int num44 = num42; num44 < num42 + (int)num41; num44++)
																					{
																						for (int num45 = num43; num45 < num43 + (int)num41; num45++)
																						{
																							if (Main.tile[num44, num45] == null)
																							{
																								Main.tile[num44, num45] = new Tile();
																							}
																							byte b14 = this.readBuffer[num];
																							num++;
																							byte b15 = this.readBuffer[num];
																							num++;
																							bool flag7 = Main.tile[num44, num45].active();
																							if ((b14 & 1) == 1)
																							{
																								Main.tile[num44, num45].active(true);
																							}
																							else
																							{
																								Main.tile[num44, num45].active(false);
																							}
																							if ((b14 & 4) == 4)
																							{
																								Main.tile[num44, num45].wall = 1;
																							}
																							else
																							{
																								Main.tile[num44, num45].wall = 0;
																							}
																							bool flag8 = false;
																							if ((b14 & 8) == 8)
																							{
																								flag8 = true;
																							}
																							if (Main.netMode != 2)
																							{
																								if (flag8)
																								{
																									Main.tile[num44, num45].liquid = 1;
																								}
																								else
																								{
																									Main.tile[num44, num45].liquid = 0;
																								}
																							}
																							if ((b14 & 16) == 16)
																							{
																								Main.tile[num44, num45].wire(true);
																							}
																							else
																							{
																								Main.tile[num44, num45].wire(false);
																							}
																							if ((b14 & 32) == 32)
																							{
																								Main.tile[num44, num45].halfBrick(true);
																							}
																							else
																							{
																								Main.tile[num44, num45].halfBrick(false);
																							}
																							if ((b14 & 64) == 64)
																							{
																								Main.tile[num44, num45].actuator(true);
																							}
																							else
																							{
																								Main.tile[num44, num45].actuator(false);
																							}
																							if ((b14 & 128) == 128)
																							{
																								Main.tile[num44, num45].inActive(true);
																							}
																							else
																							{
																								Main.tile[num44, num45].inActive(false);
																							}
																							if ((b15 & 1) == 1)
																							{
																								Main.tile[num44, num45].wire2(true);
																							}
																							else
																							{
																								Main.tile[num44, num45].wire2(false);
																							}
																							if ((b15 & 2) == 2)
																							{
																								Main.tile[num44, num45].wire3(true);
																							}
																							else
																							{
																								Main.tile[num44, num45].wire3(false);
																							}
																							if ((b15 & 4) == 4)
																							{
																								Main.tile[num44, num45].color(this.readBuffer[num]);
																								num++;
																							}
																							if ((b15 & 8) == 8)
																							{
																								Main.tile[num44, num45].wallColor(this.readBuffer[num]);
																								num++;
																							}
																							if (Main.tile[num44, num45].active())
																							{
																								int type3 = (int)Main.tile[num44, num45].type;
																								Main.tile[num44, num45].type = this.readBuffer[num];
																								num++;
																								if (Main.tileFrameImportant[(int)Main.tile[num44, num45].type])
																								{
																									Main.tile[num44, num45].frameX = BitConverter.ToInt16(this.readBuffer, num);
																									num += 2;
																									Main.tile[num44, num45].frameY = BitConverter.ToInt16(this.readBuffer, num);
																									num += 2;
																								}
																								else
																								{
																									if (!flag7 || (int)Main.tile[num44, num45].type != type3)
																									{
																										Main.tile[num44, num45].frameX = -1;
																										Main.tile[num44, num45].frameY = -1;
																									}
																								}
																								byte b16 = 0;
																								if ((b15 & 16) == 16)
																								{
																									b16 += 1;
																								}
																								if ((b15 & 32) == 32)
																								{
																									b16 += 2;
																								}
																								Main.tile[num44, num45].slope(b16);
																							}
																							if (Main.tile[num44, num45].wall > 0)
																							{
																								Main.tile[num44, num45].wall = this.readBuffer[num];
																								num++;
																							}
																							if (flag8)
																							{
																								Main.tile[num44, num45].liquid = this.readBuffer[num];
																								num++;
																								byte liquidType2 = this.readBuffer[num];
																								num++;
																								Main.tile[num44, num45].liquidType((int)liquidType2);
																							}
																						}
																					}
																					WorldGen.RangeFrame(num42, num43, num42 + (int)num41, num43 + (int)num41);
																					if (Main.netMode == 2)
																					{
																						NetMessage.SendData((int)b, -1, this.whoAmI, "", (int)num41, (float)num42, (float)num43, 0f, 0);
																						return;
																					}
																				}
																				else
																				{
																					if (b == 21)
																					{
																						short num46 = BitConverter.ToInt16(this.readBuffer, num);
																						num += 2;
																						float num47 = BitConverter.ToSingle(this.readBuffer, num);
																						num += 4;
																						float num48 = BitConverter.ToSingle(this.readBuffer, num);
																						num += 4;
																						float x3 = BitConverter.ToSingle(this.readBuffer, num);
																						num += 4;
																						float y2 = BitConverter.ToSingle(this.readBuffer, num);
																						num += 4;
																						short stack2 = BitConverter.ToInt16(this.readBuffer, num);
																						num += 2;
																						byte pre = this.readBuffer[num];
																						num++;
																						byte b17 = this.readBuffer[num];
																						num++;
																						short num49 = BitConverter.ToInt16(this.readBuffer, num);
																						if (Main.netMode == 1)
																						{
																							if (num49 == 0)
																							{
																								Main.item[(int)num46].active = false;
																								return;
																							}
																							Main.item[(int)num46].netDefaults((int)num49);
																							Main.item[(int)num46].Prefix((int)pre);
																							Main.item[(int)num46].stack = (int)stack2;
																							Main.item[(int)num46].position.X = num47;
																							Main.item[(int)num46].position.Y = num48;
																							Main.item[(int)num46].velocity.X = x3;
																							Main.item[(int)num46].velocity.Y = y2;
																							Main.item[(int)num46].active = true;
																							Main.item[(int)num46].wet = Collision.WetCollision(Main.item[(int)num46].position, Main.item[(int)num46].width, Main.item[(int)num46].height);
																							return;
																						}
																						else
																						{
																							if (num49 == 0)
																							{
																								if (num46 < 400)
																								{
																									Main.item[(int)num46].active = false;
																									NetMessage.SendData(21, -1, -1, "", (int)num46, 0f, 0f, 0f, 0);
																									return;
																								}
																							}
																							else
																							{
																								bool flag9 = false;
																								if (num46 == 400)
																								{
																									flag9 = true;
																								}
																								if (flag9)
																								{
																									Item item = new Item();
																									item.netDefaults((int)num49);
																									num46 = (short)Item.NewItem((int)num47, (int)num48, item.width, item.height, item.type, (int)stack2, true, 0, false);
																								}
																								Main.item[(int)num46].netDefaults((int)num49);
																								Main.item[(int)num46].Prefix((int)pre);
																								Main.item[(int)num46].stack = (int)stack2;
																								Main.item[(int)num46].position.X = num47;
																								Main.item[(int)num46].position.Y = num48;
																								Main.item[(int)num46].velocity.X = x3;
																								Main.item[(int)num46].velocity.Y = y2;
																								Main.item[(int)num46].active = true;
																								Main.item[(int)num46].owner = Main.myPlayer;
																								if (flag9)
																								{
																									NetMessage.SendData(21, -1, -1, "", (int)num46, 0f, 0f, 0f, 0);
																									if (b17 == 0)
																									{
																										Main.item[(int)num46].ownIgnore = this.whoAmI;
																										Main.item[(int)num46].ownTime = 100;
																									}
																									Main.item[(int)num46].FindOwner((int)num46);
																									return;
																								}
																								NetMessage.SendData(21, -1, this.whoAmI, "", (int)num46, 0f, 0f, 0f, 0);
																								return;
																							}
																						}
																					}
																					else
																					{
																						if (b == 22)
																						{
																							short num50 = BitConverter.ToInt16(this.readBuffer, num);
																							num += 2;
																							byte b18 = this.readBuffer[num];
																							if (Main.netMode == 2 && Main.item[(int)num50].owner != this.whoAmI)
																							{
																								return;
																							}
																							Main.item[(int)num50].owner = (int)b18;
																							if ((int)b18 == Main.myPlayer)
																							{
																								Main.item[(int)num50].keepTime = 15;
																							}
																							else
																							{
																								Main.item[(int)num50].keepTime = 0;
																							}
																							if (Main.netMode == 2)
																							{
																								Main.item[(int)num50].owner = 255;
																								Main.item[(int)num50].keepTime = 15;
																								NetMessage.SendData(22, -1, -1, "", (int)num50, 0f, 0f, 0f, 0);
																								return;
																							}
																						}
																						else
																						{
																							if (b == 23 && Main.netMode == 1)
																							{
																								short num51 = BitConverter.ToInt16(this.readBuffer, num);
																								num += 2;
																								float x4 = BitConverter.ToSingle(this.readBuffer, num);
																								num += 4;
																								float y3 = BitConverter.ToSingle(this.readBuffer, num);
																								num += 4;
																								float x5 = BitConverter.ToSingle(this.readBuffer, num);
																								num += 4;
																								float y4 = BitConverter.ToSingle(this.readBuffer, num);
																								num += 4;
																								int target = (int)this.readBuffer[num];
																								num++;
																								byte b19 = this.readBuffer[num];
																								num++;
																								int direction2 = -1;
																								int directionY = -1;
																								if ((b19 & 1) == 1)
																								{
																									direction2 = 1;
																								}
																								if ((b19 & 2) == 2)
																								{
																									directionY = 1;
																								}
																								bool[] array = new bool[4];
																								if ((b19 & 4) == 4)
																								{
																									array[3] = true;
																								}
																								if ((b19 & 8) == 8)
																								{
																									array[2] = true;
																								}
																								if ((b19 & 16) == 16)
																								{
																									array[1] = true;
																								}
																								if ((b19 & 32) == 32)
																								{
																									array[0] = true;
																								}
																								int spriteDirection = -1;
																								if ((b19 & 64) == 64)
																								{
																									spriteDirection = 1;
																								}
																								int num52 = BitConverter.ToInt32(this.readBuffer, num);
																								num += 4;
																								float[] array2 = new float[NPC.maxAI];
																								for (int num53 = 0; num53 < NPC.maxAI; num53++)
																								{
																									if (array[num53])
																									{
																										array2[num53] = BitConverter.ToSingle(this.readBuffer, num);
																										num += 4;
																									}
																									else
																									{
																										array2[num53] = 0f;
																									}
																								}
																								int num54 = (int)BitConverter.ToInt16(this.readBuffer, num);
																								int num55 = -1;
																								if (!Main.npc[(int)num51].active || Main.npc[(int)num51].netID != num54)
																								{
																									if (Main.npc[(int)num51].active)
																									{
																										num55 = Main.npc[(int)num51].type;
																									}
																									Main.npc[(int)num51].active = true;
																									Main.npc[(int)num51].netDefaults(num54);
																								}
																								Main.npc[(int)num51].position.X = x4;
																								Main.npc[(int)num51].position.Y = y3;
																								Main.npc[(int)num51].velocity.X = x5;
																								Main.npc[(int)num51].velocity.Y = y4;
																								Main.npc[(int)num51].target = target;
																								Main.npc[(int)num51].direction = direction2;
																								Main.npc[(int)num51].directionY = directionY;
																								Main.npc[(int)num51].spriteDirection = spriteDirection;
																								Main.npc[(int)num51].life = num52;
																								if (num52 <= 0)
																								{
																									Main.npc[(int)num51].active = false;
																								}
																								for (int num56 = 0; num56 < NPC.maxAI; num56++)
																								{
																									Main.npc[(int)num51].ai[num56] = array2[num56];
																								}
																								if (num55 > -1 && num55 != Main.npc[(int)num51].type)
																								{
																									Main.npc[(int)num51].xForm(num55, Main.npc[(int)num51].type);
																								}
																								if (num54 == 262)
																								{
																									NPC.plantBoss = (int)num51;
																								}
																								if (num54 == 245)
																								{
																									NPC.golemBoss = (int)num51;
																									return;
																								}
																							}
																							else
																							{
																								if (b == 24)
																								{
																									short num57 = BitConverter.ToInt16(this.readBuffer, num);
																									num += 2;
																									byte b20 = this.readBuffer[num];
																									if (Main.netMode == 2)
																									{
																										b20 = (byte)this.whoAmI;
																									}
																									Main.npc[(int)num57].StrikeNPC(Main.player[(int)b20].inventory[Main.player[(int)b20].selectedItem].damage, Main.player[(int)b20].inventory[Main.player[(int)b20].selectedItem].knockBack, Main.player[(int)b20].direction, false, false);
																									if (Main.netMode == 2)
																									{
																										NetMessage.SendData(24, -1, this.whoAmI, "", (int)num57, (float)b20, 0f, 0f, 0);
																										NetMessage.SendData(23, -1, -1, "", (int)num57, 0f, 0f, 0f, 0);
																										return;
																									}
																								}
																								else
																								{
																									if (b == 25)
																									{
																										int num58 = (int)this.readBuffer[start + 1];
																										if (Main.netMode == 2)
																										{
																											num58 = this.whoAmI;
																										}
																										byte b21 = this.readBuffer[start + 2];
																										byte b22 = this.readBuffer[start + 3];
																										byte b23 = this.readBuffer[start + 4];
																										if (Main.netMode == 2)
																										{
																											b21 = 255;
																											b22 = 255;
																											b23 = 255;
																										}
																										string string3 = Encoding.UTF8.GetString(this.readBuffer, start + 5, length - 5);
																										if (Main.netMode == 1)
																										{
																											string newText = string3;
																											if (num58 < 255)
																											{
																												newText = "<" + Main.player[num58].name + "> " + string3;
																												Main.player[num58].chatText = string3;
																												Main.player[num58].chatShowTime = Main.chatLength / 2;
																											}
																											Main.NewText(newText, b21, b22, b23, false);
																											return;
																										}
																										if (Main.netMode == 2)
																										{
																											string text2 = string3.ToLower();
																											if (text2 == Lang.mp[6] || text2 == Lang.mp[21])
																											{
																												string text3 = "";
																												for (int num59 = 0; num59 < 255; num59++)
																												{
																													if (Main.player[num59].active)
																													{
																														if (text3 == "")
																														{
																															text3 += Main.player[num59].name;
																														}
																														else
																														{
																															text3 = text3 + ", " + Main.player[num59].name;
																														}
																													}
																												}
																												NetMessage.SendData(25, this.whoAmI, -1, Lang.mp[7] + " " + text3 + ".", 255, 255f, 240f, 20f, 0);
																												return;
																											}
																											if (text2.Length >= 4 && text2.Substring(0, 4) == "/me ")
																											{
																												NetMessage.SendData(25, -1, -1, "*" + Main.player[this.whoAmI].name + " " + string3.Substring(4), 255, 200f, 100f, 0f, 0);
																												return;
																											}
																											if (text2 == Lang.mp[8])
																											{
																												NetMessage.SendData(25, -1, -1, string.Concat(new object[]
																												{
																													"*",
																													Main.player[this.whoAmI].name,
																													" ",
																													Lang.mp[9],
																													" ",
																													Main.rand.Next(1, 101)
																												}), 255, 255f, 240f, 20f, 0);
																												return;
																											}
																											if (text2.Length >= 3 && text2.Substring(0, 3) == "/p ")
																											{
																												if (Main.player[this.whoAmI].team != 0)
																												{
																													for (int num60 = 0; num60 < 255; num60++)
																													{
																														if (Main.player[num60].team == Main.player[this.whoAmI].team)
																														{
																															NetMessage.SendData(25, num60, -1, string3.Substring(3), num58, (float)Main.teamColor[Main.player[this.whoAmI].team].R, (float)Main.teamColor[Main.player[this.whoAmI].team].G, (float)Main.teamColor[Main.player[this.whoAmI].team].B, 0);
																														}
																													}
																													return;
																												}
																												NetMessage.SendData(25, this.whoAmI, -1, Lang.mp[10], 255, 255f, 240f, 20f, 0);
																												return;
																											}
																											else
																											{
																												if (Main.player[this.whoAmI].difficulty == 2)
																												{
																													b21 = Main.hcColor.R;
																													b22 = Main.hcColor.G;
																													b23 = Main.hcColor.B;
																												}
																												else
																												{
																													if (Main.player[this.whoAmI].difficulty == 1)
																													{
																														b21 = Main.mcColor.R;
																														b22 = Main.mcColor.G;
																														b23 = Main.mcColor.B;
																													}
																												}
																												NetMessage.SendData(25, -1, -1, string3, num58, (float)b21, (float)b22, (float)b23, 0);
																												if (Main.dedServ)
																												{
																													Console.WriteLine("<" + Main.player[this.whoAmI].name + "> " + string3);
																													return;
																												}
																											}
																										}
																									}
																									else
																									{
																										if (b == 26)
																										{
																											byte b24 = this.readBuffer[num];
																											if (Main.netMode == 2 && this.whoAmI != (int)b24 && (!Main.player[(int)b24].hostile || !Main.player[this.whoAmI].hostile))
																											{
																												return;
																											}
																											num++;
																											int num61 = (int)(this.readBuffer[num] - 1);
																											num++;
																											short num62 = BitConverter.ToInt16(this.readBuffer, num);
																											num += 2;
																											byte b25 = this.readBuffer[num];
																											num++;
																											bool pvp = false;
																											byte b26 = this.readBuffer[num];
																											num++;
																											bool crit = false;
																											string string4 = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
																											if (b25 != 0)
																											{
																												pvp = true;
																											}
																											if (b26 != 0)
																											{
																												crit = true;
																											}
																											Main.player[(int)b24].Hurt((int)num62, num61, pvp, true, string4, crit);
																											if (Main.netMode == 2)
																											{
																												NetMessage.SendData(26, -1, this.whoAmI, string4, (int)b24, (float)num61, (float)num62, (float)b25, (int)b26);
																												return;
																											}
																										}
																										else
																										{
																											if (b == 27)
																											{
																												short num63 = BitConverter.ToInt16(this.readBuffer, num);
																												num += 2;
																												float x6 = BitConverter.ToSingle(this.readBuffer, num);
																												num += 4;
																												float y5 = BitConverter.ToSingle(this.readBuffer, num);
																												num += 4;
																												float x7 = BitConverter.ToSingle(this.readBuffer, num);
																												num += 4;
																												float y6 = BitConverter.ToSingle(this.readBuffer, num);
																												num += 4;
																												float knockBack = BitConverter.ToSingle(this.readBuffer, num);
																												num += 4;
																												short damage = BitConverter.ToInt16(this.readBuffer, num);
																												num += 2;
																												byte b27 = this.readBuffer[num];
																												num++;
																												short num64 = BitConverter.ToInt16(this.readBuffer, num);
																												num += 2;
																												float[] array3 = new float[Projectile.maxAI];
																												if (Main.netMode == 2)
																												{
																													b27 = (byte)this.whoAmI;
																													if (Main.projHostile[(int)num64])
																													{
																														return;
																													}
																												}
																												for (int num65 = 0; num65 < Projectile.maxAI; num65++)
																												{
																													array3[num65] = BitConverter.ToSingle(this.readBuffer, num);
																													num += 4;
																												}
																												int num66 = 1000;
																												for (int num67 = 0; num67 < 1000; num67++)
																												{
																													if (Main.projectile[num67].owner == (int)b27 && Main.projectile[num67].identity == (int)num63 && Main.projectile[num67].active)
																													{
																														num66 = num67;
																														break;
																													}
																												}
																												if (num66 == 1000)
																												{
																													for (int num68 = 0; num68 < 1000; num68++)
																													{
																														if (!Main.projectile[num68].active)
																														{
																															num66 = num68;
																															break;
																														}
																													}
																												}
																												if (!Main.projectile[num66].active || Main.projectile[num66].type != (int)num64)
																												{
																													Main.projectile[num66].SetDefaults((int)num64);
																													if (Main.netMode == 2)
																													{
																														Netplay.serverSock[this.whoAmI].spamProjectile += 1f;
																													}
																												}
																												Main.projectile[num66].identity = (int)num63;
																												Main.projectile[num66].position.X = x6;
																												Main.projectile[num66].position.Y = y5;
																												Main.projectile[num66].velocity.X = x7;
																												Main.projectile[num66].velocity.Y = y6;
																												Main.projectile[num66].damage = (int)damage;
																												Main.projectile[num66].type = (int)num64;
																												Main.projectile[num66].owner = (int)b27;
																												Main.projectile[num66].knockBack = knockBack;
																												for (int num69 = 0; num69 < Projectile.maxAI; num69++)
																												{
																													Main.projectile[num66].ai[num69] = array3[num69];
																												}
																												if (Main.netMode == 2)
																												{
																													NetMessage.SendData(27, -1, this.whoAmI, "", num66, 0f, 0f, 0f, 0);
																													return;
																												}
																											}
																											else
																											{
																												if (b == 28)
																												{
																													short num70 = BitConverter.ToInt16(this.readBuffer, num);
																													num += 2;
																													short num71 = BitConverter.ToInt16(this.readBuffer, num);
																													num += 2;
																													float num72 = BitConverter.ToSingle(this.readBuffer, num);
																													num += 4;
																													int num73 = (int)(this.readBuffer[num] - 1);
																													num++;
																													int num74 = (int)this.readBuffer[num];
																													if (num71 >= 0)
																													{
																														if (num74 == 1)
																														{
																															Main.npc[(int)num70].StrikeNPC((int)num71, num72, num73, true, false);
																														}
																														else
																														{
																															Main.npc[(int)num70].StrikeNPC((int)num71, num72, num73, false, false);
																														}
																													}
																													else
																													{
																														Main.npc[(int)num70].life = 0;
																														Main.npc[(int)num70].HitEffect(0, 10.0);
																														Main.npc[(int)num70].active = false;
																													}
																													if (Main.netMode == 2)
																													{
																														if (Main.npc[(int)num70].life <= 0)
																														{
																															NetMessage.SendData(28, -1, this.whoAmI, "", (int)num70, (float)num71, num72, (float)num73, num74);
																															NetMessage.SendData(23, -1, -1, "", (int)num70, 0f, 0f, 0f, 0);
																															return;
																														}
																														NetMessage.SendData(28, -1, this.whoAmI, "", (int)num70, (float)num71, num72, (float)num73, num74);
																														Main.npc[(int)num70].netUpdate = true;
																														return;
																													}
																												}
																												else
																												{
																													if (b == 29)
																													{
																														short num75 = BitConverter.ToInt16(this.readBuffer, num);
																														num += 2;
																														byte b28 = this.readBuffer[num];
																														if (Main.netMode == 2)
																														{
																															b28 = (byte)this.whoAmI;
																														}
																														for (int num76 = 0; num76 < 1000; num76++)
																														{
																															if (Main.projectile[num76].owner == (int)b28 && Main.projectile[num76].identity == (int)num75 && Main.projectile[num76].active)
																															{
																																Main.projectile[num76].Kill();
																																break;
																															}
																														}
																														if (Main.netMode == 2)
																														{
																															NetMessage.SendData(29, -1, this.whoAmI, "", (int)num75, (float)b28, 0f, 0f, 0);
																															return;
																														}
																													}
																													else
																													{
																														if (b == 30)
																														{
																															byte b29 = this.readBuffer[num];
																															if (Main.netMode == 2)
																															{
																																b29 = (byte)this.whoAmI;
																															}
																															num++;
																															byte b30 = this.readBuffer[num];
																															if (b30 == 1)
																															{
																																Main.player[(int)b29].hostile = true;
																															}
																															else
																															{
																																Main.player[(int)b29].hostile = false;
																															}
																															if (Main.netMode == 2)
																															{
																																NetMessage.SendData(30, -1, this.whoAmI, "", (int)b29, 0f, 0f, 0f, 0);
																																string str = " " + Lang.mp[11];
																																if (b30 == 0)
																																{
																																	str = " " + Lang.mp[12];
																																}
																																NetMessage.SendData(25, -1, -1, Main.player[(int)b29].name + str, 255, (float)Main.teamColor[Main.player[(int)b29].team].R, (float)Main.teamColor[Main.player[(int)b29].team].G, (float)Main.teamColor[Main.player[(int)b29].team].B, 0);
																																return;
																															}
																														}
																														else
																														{
																															if (b == 31)
																															{
																																if (Main.netMode == 2)
																																{
																																	int x8 = BitConverter.ToInt32(this.readBuffer, num);
																																	num += 4;
																																	int y7 = BitConverter.ToInt32(this.readBuffer, num);
																																	num += 4;
																																	int num77 = Chest.FindChest(x8, y7);
																																	if (num77 > -1 && Chest.UsingChest(num77) == -1)
																																	{
																																		for (int num78 = 0; num78 < Chest.maxItems; num78++)
																																		{
																																			NetMessage.SendData(32, this.whoAmI, -1, "", num77, (float)num78, 0f, 0f, 0);
																																		}
																																		NetMessage.SendData(33, this.whoAmI, -1, "", num77, 0f, 0f, 0f, 0);
																																		Main.player[this.whoAmI].chest = num77;
																																		return;
																																	}
																																}
																															}
																															else
																															{
																																if (b == 32)
																																{
																																	int num79 = (int)BitConverter.ToInt16(this.readBuffer, num);
																																	num += 2;
																																	int num80 = (int)this.readBuffer[num];
																																	num++;
																																	int stack3 = (int)BitConverter.ToInt16(this.readBuffer, num);
																																	num += 2;
																																	int pre2 = (int)this.readBuffer[num];
																																	num++;
																																	int type4 = (int)BitConverter.ToInt16(this.readBuffer, num);
																																	if (Main.chest[num79] == null)
																																	{
																																		Main.chest[num79] = new Chest();
																																	}
																																	if (Main.chest[num79].item[num80] == null)
																																	{
																																		Main.chest[num79].item[num80] = new Item();
																																	}
																																	Main.chest[num79].item[num80].netDefaults(type4);
																																	Main.chest[num79].item[num80].Prefix(pre2);
																																	Main.chest[num79].item[num80].stack = stack3;
																																	return;
																																}
																																if (b == 33)
																																{
																																	int num81 = (int)BitConverter.ToInt16(this.readBuffer, num);
																																	num += 2;
																																	int chestX = BitConverter.ToInt32(this.readBuffer, num);
																																	num += 4;
																																	int chestY = BitConverter.ToInt32(this.readBuffer, num);
																																	if (Main.netMode == 1)
																																	{
																																		if (Main.player[Main.myPlayer].chest == -1)
																																		{
																																			Main.playerInventory = true;
																																			Main.PlaySound(10, -1, -1, 1);
																																		}
																																		else
																																		{
																																			if (Main.player[Main.myPlayer].chest != num81 && num81 != -1)
																																			{
																																				Main.playerInventory = true;
																																				Main.PlaySound(12, -1, -1, 1);
																																			}
																																			else
																																			{
																																				if (Main.player[Main.myPlayer].chest != -1 && num81 == -1)
																																				{
																																					Main.PlaySound(11, -1, -1, 1);
																																				}
																																			}
																																		}
																																		Main.player[Main.myPlayer].chest = num81;
																																		Main.player[Main.myPlayer].chestX = chestX;
																																		Main.player[Main.myPlayer].chestY = chestY;
																																		return;
																																	}
																																	Main.player[this.whoAmI].chest = num81;
																																	return;
																																}
																																else
																																{
																																	if (b == 34)
																																	{
																																		if (Main.netMode == 2)
																																		{
																																			int num82 = BitConverter.ToInt32(this.readBuffer, num);
																																			num += 4;
																																			int num83 = BitConverter.ToInt32(this.readBuffer, num);
																																			if (Main.tile[num82, num83].type == 21)
																																			{
																																				WorldGen.KillTile(num82, num83, false, false, false);
																																				if (!Main.tile[num82, num83].active())
																																				{
																																					NetMessage.SendData(17, -1, -1, "", 0, (float)num82, (float)num83, 0f, 0);
																																					return;
																																				}
																																			}
																																		}
																																	}
																																	else
																																	{
																																		if (b == 35)
																																		{
																																			int num84 = (int)this.readBuffer[num];
																																			if (Main.netMode == 2)
																																			{
																																				num84 = this.whoAmI;
																																			}
																																			num++;
																																			int num85 = (int)BitConverter.ToInt16(this.readBuffer, num);
																																			num += 2;
																																			if (num84 != Main.myPlayer || Main.ServerSideCharacter)
																																			{
																																				Main.player[num84].HealEffect(num85, true);
																																			}
																																			if (Main.netMode == 2)
																																			{
																																				NetMessage.SendData(35, -1, this.whoAmI, "", num84, (float)num85, 0f, 0f, 0);
																																				return;
																																			}
																																		}
																																		else
																																		{
																																			if (b == 36)
																																			{
																																				int num86 = (int)this.readBuffer[num];
																																				if (Main.netMode == 2)
																																				{
																																					num86 = this.whoAmI;
																																				}
																																				num++;
																																				byte b31 = this.readBuffer[num];
																																				num++;
																																				if ((b31 & 1) == 1)
																																				{
																																					Main.player[num86].zoneEvil = true;
																																				}
																																				else
																																				{
																																					Main.player[num86].zoneEvil = false;
																																				}
																																				if ((b31 & 2) == 2)
																																				{
																																					Main.player[num86].zoneMeteor = true;
																																				}
																																				else
																																				{
																																					Main.player[num86].zoneMeteor = false;
																																				}
																																				if ((b31 & 4) == 4)
																																				{
																																					Main.player[num86].zoneDungeon = true;
																																				}
																																				else
																																				{
																																					Main.player[num86].zoneDungeon = false;
																																				}
																																				if ((b31 & 8) == 8)
																																				{
																																					Main.player[num86].zoneJungle = true;
																																				}
																																				else
																																				{
																																					Main.player[num86].zoneJungle = false;
																																				}
																																				if ((b31 & 16) == 16)
																																				{
																																					Main.player[num86].zoneHoly = true;
																																				}
																																				else
																																				{
																																					Main.player[num86].zoneHoly = false;
																																				}
																																				if ((b31 & 32) == 32)
																																				{
																																					Main.player[num86].zoneSnow = true;
																																				}
																																				else
																																				{
																																					Main.player[num86].zoneSnow = false;
																																				}
																																				if ((b31 & 64) == 64)
																																				{
																																					Main.player[num86].zoneBlood = true;
																																				}
																																				else
																																				{
																																					Main.player[num86].zoneBlood = false;
																																				}
																																				if ((b31 & 128) == 128)
																																				{
																																					Main.player[num86].zoneCandle = true;
																																				}
																																				else
																																				{
																																					Main.player[num86].zoneCandle = false;
																																				}
																																				if (Main.netMode == 2)
																																				{
																																					NetMessage.SendData(36, -1, this.whoAmI, "", num86, 0f, 0f, 0f, 0);
																																					return;
																																				}
																																			}
																																			else
																																			{
																																				if (b == 37)
																																				{
																																					if (Main.netMode == 1)
																																					{
																																						if (Main.autoPass)
																																						{
																																							NetMessage.SendData(38, -1, -1, Netplay.password, 0, 0f, 0f, 0f, 0);
																																							Main.autoPass = false;
																																							return;
																																						}
																																						Netplay.password = "";
																																						Main.menuMode = 31;
																																						return;
																																					}
																																				}
																																				else
																																				{
																																					if (b == 38)
																																					{
																																						if (Main.netMode == 2)
																																						{
																																							string string5 = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
																																							if (string5 == Netplay.password)
																																							{
																																								Netplay.serverSock[this.whoAmI].state = 1;
																																								NetMessage.SendData(3, this.whoAmI, -1, "", 0, 0f, 0f, 0f, 0);
																																								return;
																																							}
																																							NetMessage.SendData(2, this.whoAmI, -1, Lang.mp[1], 0, 0f, 0f, 0f, 0);
																																							return;
																																						}
																																					}
																																					else
																																					{
																																						if (b == 39 && Main.netMode == 1)
																																						{
																																							short num87 = BitConverter.ToInt16(this.readBuffer, num);
																																							Main.item[(int)num87].owner = 255;
																																							NetMessage.SendData(22, -1, -1, "", (int)num87, 0f, 0f, 0f, 0);
																																							return;
																																						}
																																						if (b == 40)
																																						{
																																							byte b32 = this.readBuffer[num];
																																							if (Main.netMode == 2)
																																							{
																																								b32 = (byte)this.whoAmI;
																																							}
																																							num++;
																																							int talkNPC = (int)BitConverter.ToInt16(this.readBuffer, num);
																																							num += 2;
																																							Main.player[(int)b32].talkNPC = talkNPC;
																																							if (Main.netMode == 2)
																																							{
																																								NetMessage.SendData(40, -1, this.whoAmI, "", (int)b32, 0f, 0f, 0f, 0);
																																								return;
																																							}
																																						}
																																						else
																																						{
																																							if (b == 41)
																																							{
																																								byte b33 = this.readBuffer[num];
																																								if (Main.netMode == 2)
																																								{
																																									b33 = (byte)this.whoAmI;
																																								}
																																								num++;
																																								float itemRotation = BitConverter.ToSingle(this.readBuffer, num);
																																								num += 4;
																																								int itemAnimation = (int)BitConverter.ToInt16(this.readBuffer, num);
																																								Main.player[(int)b33].itemRotation = itemRotation;
																																								Main.player[(int)b33].itemAnimation = itemAnimation;
																																								Main.player[(int)b33].channel = Main.player[(int)b33].inventory[Main.player[(int)b33].selectedItem].channel;
																																								if (Main.netMode == 2)
																																								{
																																									NetMessage.SendData(41, -1, this.whoAmI, "", (int)b33, 0f, 0f, 0f, 0);
																																									return;
																																								}
																																							}
																																							else
																																							{
																																								if (b == 42)
																																								{
																																									int num88 = (int)this.readBuffer[num];
																																									if (Main.netMode == 2)
																																									{
																																										num88 = this.whoAmI;
																																									}
																																									num++;
																																									int statMana = (int)BitConverter.ToInt16(this.readBuffer, num);
																																									num += 2;
																																									int statManaMax = (int)BitConverter.ToInt16(this.readBuffer, num);
																																									if (Main.netMode == 2)
																																									{
																																										num88 = this.whoAmI;
																																									}
																																									else
																																									{
																																										if (Main.myPlayer == num88 && !Main.ServerSideCharacter)
																																										{
																																											return;
																																										}
																																									}
																																									Main.player[num88].statMana = statMana;
																																									Main.player[num88].statManaMax = statManaMax;
																																									if (Main.netMode == 2)
																																									{
																																										NetMessage.SendData(42, -1, this.whoAmI, "", num88, 0f, 0f, 0f, 0);
																																										return;
																																									}
																																								}
																																								else
																																								{
																																									if (b == 43)
																																									{
																																										int num89 = (int)this.readBuffer[num];
																																										if (Main.netMode == 2)
																																										{
																																											num89 = this.whoAmI;
																																										}
																																										num++;
																																										int num90 = (int)BitConverter.ToInt16(this.readBuffer, num);
																																										num += 2;
																																										if (num89 != Main.myPlayer)
																																										{
																																											Main.player[num89].ManaEffect(num90);
																																										}
																																										if (Main.netMode == 2)
																																										{
																																											NetMessage.SendData(43, -1, this.whoAmI, "", num89, (float)num90, 0f, 0f, 0);
																																											return;
																																										}
																																									}
																																									else
																																									{
																																										if (b == 44)
																																										{
																																											byte b34 = this.readBuffer[num];
																																											if ((int)b34 == Main.myPlayer)
																																											{
																																												return;
																																											}
																																											if (Main.netMode == 2)
																																											{
																																												b34 = (byte)this.whoAmI;
																																											}
																																											num++;
																																											int num91 = (int)(this.readBuffer[num] - 1);
																																											num++;
																																											short num92 = BitConverter.ToInt16(this.readBuffer, num);
																																											num += 2;
																																											byte b35 = this.readBuffer[num];
																																											num++;
																																											string string6 = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
																																											bool pvp2 = false;
																																											if (b35 != 0)
																																											{
																																												pvp2 = true;
																																											}
																																											Main.player[(int)b34].KillMe((double)num92, num91, pvp2, string6);
																																											if (Main.netMode == 2)
																																											{
																																												NetMessage.SendData(44, -1, this.whoAmI, string6, (int)b34, (float)num91, (float)num92, (float)b35, 0);
																																												return;
																																											}
																																										}
																																										else
																																										{
																																											if (b == 45)
																																											{
																																												int num93 = (int)this.readBuffer[num];
																																												if (Main.netMode == 2)
																																												{
																																													num93 = this.whoAmI;
																																												}
																																												num++;
																																												int num94 = (int)this.readBuffer[num];
																																												num++;
																																												int team = Main.player[num93].team;
																																												Main.player[num93].team = num94;
																																												if (Main.netMode == 2)
																																												{
																																													NetMessage.SendData(45, -1, this.whoAmI, "", num93, 0f, 0f, 0f, 0);
																																													string str2 = "";
																																													if (num94 == 0)
																																													{
																																														str2 = " " + Lang.mp[13];
																																													}
																																													else
																																													{
																																														if (num94 == 1)
																																														{
																																															str2 = " " + Lang.mp[14];
																																														}
																																														else
																																														{
																																															if (num94 == 2)
																																															{
																																																str2 = " " + Lang.mp[15];
																																															}
																																															else
																																															{
																																																if (num94 == 3)
																																																{
																																																	str2 = " " + Lang.mp[16];
																																																}
																																																else
																																																{
																																																	if (num94 == 4)
																																																	{
																																																		str2 = " " + Lang.mp[17];
																																																	}
																																																}
																																															}
																																														}
																																													}
																																													for (int num95 = 0; num95 < 255; num95++)
																																													{
																																														if (num95 == this.whoAmI || (team > 0 && Main.player[num95].team == team) || (num94 > 0 && Main.player[num95].team == num94))
																																														{
																																															NetMessage.SendData(25, num95, -1, Main.player[num93].name + str2, 255, (float)Main.teamColor[num94].R, (float)Main.teamColor[num94].G, (float)Main.teamColor[num94].B, 0);
																																														}
																																													}
																																													return;
																																												}
																																											}
																																											else
																																											{
																																												if (b == 46)
																																												{
																																													if (Main.netMode == 2)
																																													{
																																														int i2 = BitConverter.ToInt32(this.readBuffer, num);
																																														num += 4;
																																														int j2 = BitConverter.ToInt32(this.readBuffer, num);
																																														num += 4;
																																														int num96 = Sign.ReadSign(i2, j2);
																																														if (num96 >= 0)
																																														{
																																															NetMessage.SendData(47, this.whoAmI, -1, "", num96, 0f, 0f, 0f, 0);
																																															return;
																																														}
																																													}
																																												}
																																												else
																																												{
																																													if (b == 47)
																																													{
																																														int num97 = (int)BitConverter.ToInt16(this.readBuffer, num);
																																														num += 2;
																																														int x9 = BitConverter.ToInt32(this.readBuffer, num);
																																														num += 4;
																																														int y8 = BitConverter.ToInt32(this.readBuffer, num);
																																														num += 4;
																																														string string7 = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
																																														Main.sign[num97] = new Sign();
																																														Main.sign[num97].x = x9;
																																														Main.sign[num97].y = y8;
																																														Sign.TextSign(num97, string7);
																																														if (Main.netMode == 1 && Main.sign[num97] != null && num97 != Main.player[Main.myPlayer].sign)
																																														{
																																															Main.playerInventory = false;
																																															Main.player[Main.myPlayer].talkNPC = -1;
																																															Main.editSign = false;
																																															Main.PlaySound(10, -1, -1, 1);
																																															Main.player[Main.myPlayer].sign = num97;
																																															Main.npcChatText = Main.sign[num97].text;
																																															return;
																																														}
																																													}
																																													else
																																													{
																																														if (b == 48)
																																														{
																																															int num98 = BitConverter.ToInt32(this.readBuffer, num);
																																															num += 4;
																																															int num99 = BitConverter.ToInt32(this.readBuffer, num);
																																															num += 4;
																																															byte liquid = this.readBuffer[num];
																																															num++;
																																															byte liquidType3 = this.readBuffer[num];
																																															num++;
																																															if (Main.netMode == 2 && Netplay.spamCheck)
																																															{
																																																int num100 = this.whoAmI;
																																																int num101 = (int)(Main.player[num100].position.X + (float)(Main.player[num100].width / 2));
																																																int num102 = (int)(Main.player[num100].position.Y + (float)(Main.player[num100].height / 2));
																																																int num103 = 10;
																																																int num104 = num101 - num103;
																																																int num105 = num101 + num103;
																																																int num106 = num102 - num103;
																																																int num107 = num102 + num103;
																																																if (num101 < num104 || num101 > num105 || num102 < num106 || num102 > num107)
																																																{
																																																	NetMessage.BootPlayer(this.whoAmI, "Cheating attempt detected: Liquid spam");
																																																	return;
																																																}
																																															}
																																															if (Main.tile[num98, num99] == null)
																																															{
																																																Main.tile[num98, num99] = new Tile();
																																															}
																																															lock (Main.tile[num98, num99])
																																															{
																																																Main.tile[num98, num99].liquid = liquid;
																																																Main.tile[num98, num99].liquidType((int)liquidType3);
																																																if (Main.netMode == 2)
																																																{
																																																	WorldGen.SquareTileFrame(num98, num99, true);
																																																}
																																																return;
																																															}
																																														}
																																														if (b == 49)
																																														{
																																															if (Netplay.clientSock.state == 6)
																																															{
																																																Netplay.clientSock.state = 10;
																																																Main.player[Main.myPlayer].Spawn();
																																																return;
																																															}
																																														}
																																														else
																																														{
																																															if (b == 50)
																																															{
																																																int num108 = (int)this.readBuffer[num];
																																																num++;
																																																if (Main.netMode == 2)
																																																{
																																																	num108 = this.whoAmI;
																																																}
																																																else
																																																{
																																																	if (num108 == Main.myPlayer && !Main.ServerSideCharacter)
																																																	{
																																																		return;
																																																	}
																																																}
																																																for (int num109 = 0; num109 < 10; num109++)
																																																{
																																																	Main.player[num108].buffType[num109] = (int)this.readBuffer[num];
																																																	if (Main.player[num108].buffType[num109] > 0)
																																																	{
																																																		Main.player[num108].buffTime[num109] = 60;
																																																	}
																																																	else
																																																	{
																																																		Main.player[num108].buffTime[num109] = 0;
																																																	}
																																																	num++;
																																																}
																																																if (Main.netMode == 2)
																																																{
																																																	NetMessage.SendData(50, -1, this.whoAmI, "", num108, 0f, 0f, 0f, 0);
																																																	return;
																																																}
																																															}
																																															else
																																															{
																																																if (b == 51)
																																																{
																																																	byte b36 = this.readBuffer[num];
																																																	num++;
																																																	byte b37 = this.readBuffer[num];
																																																	if (b37 == 1)
																																																	{
																																																		NPC.SpawnSkeletron();
																																																		return;
																																																	}
																																																	if (b37 == 2)
																																																	{
																																																		if (Main.netMode != 2)
																																																		{
																																																			Main.PlaySound(2, (int)Main.player[(int)b36].position.X, (int)Main.player[(int)b36].position.Y, 1);
																																																			return;
																																																		}
																																																		if (Main.netMode == 2)
																																																		{
																																																			NetMessage.SendData(51, -1, this.whoAmI, "", (int)b36, (float)b37, 0f, 0f, 0);
																																																			return;
																																																		}
																																																	}
																																																}
																																																else
																																																{
																																																	if (b == 52)
																																																	{
																																																		byte number = this.readBuffer[num];
																																																		num++;
																																																		byte b38 = this.readBuffer[num];
																																																		num++;
																																																		int num110 = BitConverter.ToInt32(this.readBuffer, num);
																																																		num += 4;
																																																		int num111 = BitConverter.ToInt32(this.readBuffer, num);
																																																		num += 4;
																																																		if (b38 == 1)
																																																		{
																																																			Chest.Unlock(num110, num111);
																																																			if (Main.netMode == 2)
																																																			{
																																																				NetMessage.SendData(52, -1, this.whoAmI, "", (int)number, (float)b38, (float)num110, (float)num111, 0);
																																																				NetMessage.SendTileSquare(-1, num110, num111, 2);
																																																			}
																																																		}
																																																		if (b38 == 2)
																																																		{
																																																			WorldGen.UnlockDoor(num110, num111);
																																																			if (Main.netMode == 2)
																																																			{
																																																				NetMessage.SendData(52, -1, this.whoAmI, "", (int)number, (float)b38, (float)num110, (float)num111, 0);
																																																				NetMessage.SendTileSquare(-1, num110, num111, 2);
																																																				return;
																																																			}
																																																		}
																																																	}
																																																	else
																																																	{
																																																		if (b == 53)
																																																		{
																																																			short num112 = BitConverter.ToInt16(this.readBuffer, num);
																																																			num += 2;
																																																			byte type5 = this.readBuffer[num];
																																																			num++;
																																																			short time = BitConverter.ToInt16(this.readBuffer, num);
																																																			num += 2;
																																																			Main.npc[(int)num112].AddBuff((int)type5, (int)time, true);
																																																			if (Main.netMode == 2)
																																																			{
																																																				NetMessage.SendData(54, -1, -1, "", (int)num112, 0f, 0f, 0f, 0);
																																																				return;
																																																			}
																																																		}
																																																		else
																																																		{
																																																			if (b == 54)
																																																			{
																																																				if (Main.netMode == 1)
																																																				{
																																																					short num113 = BitConverter.ToInt16(this.readBuffer, num);
																																																					num += 2;
																																																					for (int num114 = 0; num114 < 5; num114++)
																																																					{
																																																						Main.npc[(int)num113].buffType[num114] = (int)this.readBuffer[num];
																																																						num++;
																																																						Main.npc[(int)num113].buffTime[num114] = (int)BitConverter.ToInt16(this.readBuffer, num);
																																																						num += 2;
																																																					}
																																																					return;
																																																				}
																																																			}
																																																			else
																																																			{
																																																				if (b == 55)
																																																				{
																																																					byte b39 = this.readBuffer[num];
																																																					num++;
																																																					byte b40 = this.readBuffer[num];
																																																					num++;
																																																					short num115 = BitConverter.ToInt16(this.readBuffer, num);
																																																					num += 2;
																																																					if (Main.netMode == 2 && (int)b39 != this.whoAmI && !Main.pvpBuff[(int)b40])
																																																					{
																																																						return;
																																																					}
																																																					if (Main.netMode == 1 && (int)b39 == Main.myPlayer)
																																																					{
																																																						Main.player[(int)b39].AddBuff((int)b40, (int)num115, true);
																																																						return;
																																																					}
																																																					if (Main.netMode == 2)
																																																					{
																																																						NetMessage.SendData(55, (int)b39, -1, "", (int)b39, (float)b40, (float)num115, 0f, 0);
																																																						return;
																																																					}
																																																				}
																																																				else
																																																				{
																																																					if (b == 56)
																																																					{
																																																						if (Main.netMode == 1)
																																																						{
																																																							short num116 = BitConverter.ToInt16(this.readBuffer, num);
																																																							num += 2;
																																																							string string8 = Encoding.UTF8.GetString(this.readBuffer, num, length - num + start);
																																																							Main.chrName[(int)num116] = string8;
																																																							return;
																																																						}
																																																					}
																																																					else
																																																					{
																																																						if (b == 57)
																																																						{
																																																							if (Main.netMode == 1)
																																																							{
																																																								WorldGen.tGood = this.readBuffer[num];
																																																								num++;
																																																								WorldGen.tEvil = this.readBuffer[num];
																																																								return;
																																																							}
																																																						}
																																																						else
																																																						{
																																																							if (b == 58)
																																																							{
																																																								byte b41 = this.readBuffer[num];
																																																								if (Main.netMode == 2)
																																																								{
																																																									b41 = (byte)this.whoAmI;
																																																								}
																																																								num++;
																																																								float num117 = BitConverter.ToSingle(this.readBuffer, num);
																																																								num += 4;
																																																								if (Main.netMode == 2)
																																																								{
																																																									NetMessage.SendData(58, -1, this.whoAmI, "", this.whoAmI, num117, 0f, 0f, 0);
																																																									return;
																																																								}
																																																								Main.harpNote = num117;
																																																								int style9 = 26;
																																																								if (Main.player[(int)b41].inventory[Main.player[(int)b41].selectedItem].type == 507)
																																																								{
																																																									style9 = 35;
																																																								}
																																																								Main.PlaySound(2, (int)Main.player[(int)b41].position.X, (int)Main.player[(int)b41].position.Y, style9);
																																																								return;
																																																							}
																																																							else
																																																							{
																																																								if (b == 59)
																																																								{
																																																									int num118 = BitConverter.ToInt32(this.readBuffer, num);
																																																									num += 4;
																																																									int num119 = BitConverter.ToInt32(this.readBuffer, num);
																																																									num += 4;
																																																									WorldGen.hitSwitch(num118, num119);
																																																									if (Main.netMode == 2)
																																																									{
																																																										NetMessage.SendData(59, -1, this.whoAmI, "", num118, (float)num119, 0f, 0f, 0);
																																																										return;
																																																									}
																																																								}
																																																								else
																																																								{
																																																									if (b == 60)
																																																									{
																																																										short num120 = BitConverter.ToInt16(this.readBuffer, num);
																																																										num += 2;
																																																										short num121 = BitConverter.ToInt16(this.readBuffer, num);
																																																										num += 2;
																																																										short num122 = BitConverter.ToInt16(this.readBuffer, num);
																																																										num += 2;
																																																										byte b42 = this.readBuffer[num];
																																																										num++;
																																																										bool homeless = false;
																																																										if (b42 == 1)
																																																										{
																																																											homeless = true;
																																																										}
																																																										if (Main.netMode == 1)
																																																										{
																																																											Main.npc[(int)num120].homeless = homeless;
																																																											Main.npc[(int)num120].homeTileX = (int)num121;
																																																											Main.npc[(int)num120].homeTileY = (int)num122;
																																																											return;
																																																										}
																																																										if (b42 == 0)
																																																										{
																																																											WorldGen.kickOut((int)num120);
																																																											return;
																																																										}
																																																										WorldGen.moveRoom((int)num121, (int)num122, (int)num120);
																																																										return;
																																																									}
																																																									else
																																																									{
																																																										if (b == 61)
																																																										{
																																																											int plr = BitConverter.ToInt32(this.readBuffer, num);
																																																											num += 4;
																																																											int num123 = BitConverter.ToInt32(this.readBuffer, num);
																																																											num += 4;
																																																											if (Main.netMode == 2)
																																																											{
																																																												if (num123 == 4 || num123 == 13 || num123 == 50 || num123 == 125 || num123 == 126 || num123 == 134 || num123 == 127 || num123 == 128 || num123 == 222 || num123 == 245 || num123 == 266)
																																																												{
																																																													bool flag11 = true;
																																																													for (int num124 = 0; num124 < 200; num124++)
																																																													{
																																																														if (Main.npc[num124].active && Main.npc[num124].type == num123)
																																																														{
																																																															flag11 = false;
																																																														}
																																																													}
																																																													if (flag11)
																																																													{
																																																														NPC.SpawnOnPlayer(plr, num123);
																																																														return;
																																																													}
																																																												}
																																																												else
																																																												{
																																																													if (num123 < 0)
																																																													{
																																																														int num125 = -1;
																																																														if (num123 == -1)
																																																														{
																																																															num125 = 1;
																																																														}
																																																														if (num123 == -2)
																																																														{
																																																															num125 = 2;
																																																														}
																																																														if (num123 == -3)
																																																														{
																																																															num125 = 3;
																																																														}
																																																														if (num125 > 0 && Main.invasionType == 0)
																																																														{
																																																															Main.invasionDelay = 0;
																																																															Main.StartInvasion(num125);
																																																															return;
																																																														}
																																																													}
																																																												}
																																																											}
																																																										}
																																																										else
																																																										{
																																																											if (b == 62)
																																																											{
																																																												int num126 = BitConverter.ToInt32(this.readBuffer, num);
																																																												num += 4;
																																																												int num127 = BitConverter.ToInt32(this.readBuffer, num);
																																																												num += 4;
																																																												if (Main.netMode == 2)
																																																												{
																																																													num126 = this.whoAmI;
																																																												}
																																																												if (num127 == 1)
																																																												{
																																																													Main.player[num126].NinjaDodge();
																																																												}
																																																												if (num127 == 2)
																																																												{
																																																													Main.player[num126].ShadowDodge();
																																																												}
																																																												if (Main.netMode == 2)
																																																												{
																																																													NetMessage.SendData(62, -1, this.whoAmI, "", num126, (float)num127, 0f, 0f, 0);
																																																													return;
																																																												}
																																																											}
																																																											else
																																																											{
																																																												if (b == 63)
																																																												{
																																																													int num128 = BitConverter.ToInt32(this.readBuffer, num);
																																																													num += 4;
																																																													int num129 = BitConverter.ToInt32(this.readBuffer, num);
																																																													num += 4;
																																																													byte b43 = this.readBuffer[num];
																																																													WorldGen.paintTile(num128, num129, b43, false);
																																																													if (Main.netMode == 2)
																																																													{
																																																														NetMessage.SendData(63, -1, this.whoAmI, "", num128, (float)num129, (float)b43, 0f, 0);
																																																														return;
																																																													}
																																																												}
																																																												else
																																																												{
																																																													if (b == 64)
																																																													{
																																																														int num130 = BitConverter.ToInt32(this.readBuffer, num);
																																																														num += 4;
																																																														int num131 = BitConverter.ToInt32(this.readBuffer, num);
																																																														num += 4;
																																																														byte b44 = this.readBuffer[num];
																																																														WorldGen.paintWall(num130, num131, b44, false);
																																																														if (Main.netMode == 2)
																																																														{
																																																															NetMessage.SendData(64, -1, this.whoAmI, "", num130, (float)num131, (float)b44, 0f, 0);
																																																															return;
																																																														}
																																																													}
																																																													else
																																																													{
																																																														if (b == 65)
																																																														{
																																																															byte b45 = this.readBuffer[num];
																																																															num++;
																																																															short num132 = BitConverter.ToInt16(this.readBuffer, num);
																																																															if (Main.netMode == 2)
																																																															{
																																																																num132 = (short)this.whoAmI;
																																																															}
																																																															num += 2;
																																																															Vector2 newPos;
																																																															newPos.X = BitConverter.ToSingle(this.readBuffer, num);
																																																															num += 4;
																																																															newPos.Y = BitConverter.ToSingle(this.readBuffer, num);
																																																															num += 4;
																																																															int num133 = 0;
																																																															int num134 = 0;
																																																															if ((b45 & 1) == 1)
																																																															{
																																																																num133++;
																																																															}
																																																															if ((b45 & 2) == 2)
																																																															{
																																																																num133 += 2;
																																																															}
																																																															if ((b45 & 4) == 4)
																																																															{
																																																																num134++;
																																																															}
																																																															if ((b45 & 8) == 8)
																																																															{
																																																																num134++;
																																																															}
																																																															if (num133 == 0)
																																																															{
																																																																Main.player[(int)num132].Teleport(newPos, num134);
																																																															}
																																																															else
																																																															{
																																																																if (num133 == 1)
																																																																{
																																																																	Main.npc[(int)num132].Teleport(newPos, num134);
																																																																}
																																																															}
																																																															if (Main.netMode == 2 && num133 == 0)
																																																															{
																																																																NetMessage.SendData(65, -1, this.whoAmI, "", 0, (float)num132, newPos.X, newPos.Y, num134);
																																																																return;
																																																															}
																																																														}
																																																														else
																																																														{
																																																															if (b == 66)
																																																															{
																																																																int num135 = (int)this.readBuffer[num];
																																																																num++;
																																																																int num136 = (int)BitConverter.ToInt16(this.readBuffer, num);
																																																																num += 2;
																																																																if (num136 > 0)
																																																																{
																																																																	Main.player[num135].statLife += num136;
																																																																	if (Main.player[num135].statLife > Main.player[num135].statLifeMax)
																																																																	{
																																																																		Main.player[num135].statLife = Main.player[num135].statLifeMax;
																																																																	}
																																																																	Main.player[num135].HealEffect(num136, false);
																																																																	if (Main.netMode == 2)
																																																																	{
																																																																		NetMessage.SendData(66, -1, this.whoAmI, "", num135, (float)num136, 0f, 0f, 0);
																																																																		return;
																																																																	}
																																																																}
																																																															}
																																																															else
																																																															{
																																																																if (b == 67)
																																																																{
																																																																	return;
																																																																}
																																																																if (b == 68)
																																																																{
																																																																	Encoding.UTF8.GetString(this.readBuffer, start + 1, length - 1);
																																																																}
																																																															}
																																																														}
																																																													}
																																																												}
																																																											}
																																																										}
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
