using Microsoft.Xna.Framework;
using System;
using System.Text;
namespace Terraria
{
	public class NetMessage
	{
		public static messageBuffer[] buffer = new messageBuffer[257];
		public static void SendData(int msgType, int remoteClient = -1, int ignoreClient = -1, string text = "", int number = 0, float number2 = 0f, float number3 = 0f, float number4 = 0f, int number5 = 0)
		{
			if (Main.netMode == 0)
			{
				return;
			}
			int num = 256;
			if (Main.netMode == 2 && remoteClient >= 0)
			{
				num = remoteClient;
			}
			lock (NetMessage.buffer[num])
			{
				int num2 = 5;
				int num3 = num2;
				if (msgType == 1)
				{
					byte[] bytes = BitConverter.GetBytes(msgType);
					byte[] bytes2 = Encoding.UTF8.GetBytes("Terraria" + Main.curRelease);
					num2 += bytes2.Length;
					byte[] bytes3 = BitConverter.GetBytes(num2 - 4);
					Buffer.BlockCopy(bytes3, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
					Buffer.BlockCopy(bytes, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
					Buffer.BlockCopy(bytes2, 0, NetMessage.buffer[num].writeBuffer, 5, bytes2.Length);
				}
				else
				{
					if (msgType == 2)
					{
						byte[] bytes4 = BitConverter.GetBytes(msgType);
						byte[] bytes5 = Encoding.UTF8.GetBytes(text);
						num2 += bytes5.Length;
						byte[] bytes6 = BitConverter.GetBytes(num2 - 4);
						Buffer.BlockCopy(bytes6, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
						Buffer.BlockCopy(bytes4, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
						Buffer.BlockCopy(bytes5, 0, NetMessage.buffer[num].writeBuffer, 5, bytes5.Length);
						if (Main.dedServ)
						{
							Console.WriteLine(Netplay.serverSock[num].tcpClient.Client.RemoteEndPoint.ToString() + " was booted: " + text);
						}
					}
					else
					{
						if (msgType == 3)
						{
							byte[] bytes7 = BitConverter.GetBytes(msgType);
							byte[] bytes8 = BitConverter.GetBytes(remoteClient);
							num2 += bytes8.Length;
							byte[] bytes9 = BitConverter.GetBytes(num2 - 4);
							Buffer.BlockCopy(bytes9, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
							Buffer.BlockCopy(bytes7, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
							Buffer.BlockCopy(bytes8, 0, NetMessage.buffer[num].writeBuffer, 5, bytes8.Length);
						}
						else
						{
							if (msgType == 4)
							{
								byte[] bytes10 = BitConverter.GetBytes(msgType);
								byte b = (byte)number;
								byte b2 = (byte)Main.player[(int)b].hair;
								byte b3 = 0;
								if (Main.player[(int)b].male)
								{
									b3 = 1;
								}
								byte[] bytes11 = Encoding.UTF8.GetBytes(text);
								num2 += 24 + bytes11.Length + 1;
								byte[] bytes12 = BitConverter.GetBytes(num2 - 4);
								Buffer.BlockCopy(bytes12, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
								Buffer.BlockCopy(bytes10, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
								NetMessage.buffer[num].writeBuffer[5] = b;
								num3++;
								NetMessage.buffer[num].writeBuffer[6] = b2;
								num3++;
								NetMessage.buffer[num].writeBuffer[7] = b3;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].hairColor.R;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].hairColor.G;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].hairColor.B;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].skinColor.R;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].skinColor.G;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].skinColor.B;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].eyeColor.R;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].eyeColor.G;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].eyeColor.B;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].shirtColor.R;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].shirtColor.G;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].shirtColor.B;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].underShirtColor.R;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].underShirtColor.G;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].underShirtColor.B;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].pantsColor.R;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].pantsColor.G;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].pantsColor.B;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].shoeColor.R;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].shoeColor.G;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].shoeColor.B;
								num3++;
								NetMessage.buffer[num].writeBuffer[num3] = Main.player[(int)b].difficulty;
								num3++;
								Buffer.BlockCopy(bytes11, 0, NetMessage.buffer[num].writeBuffer, num3, bytes11.Length);
							}
							else
							{
								if (msgType == 5)
								{
									byte[] bytes13 = BitConverter.GetBytes(msgType);
									byte b4 = (byte)number;
									byte b5 = (byte)number2;
									short num4;
									byte[] bytes14;
									if (number2 < 59f)
									{
										if (Main.player[number].inventory[(int)number2].name == "" || Main.player[number].inventory[(int)number2].stack == 0 || Main.player[number].inventory[(int)number2].type == 0)
										{
											Main.player[number].inventory[(int)number2].netID = 0;
										}
										num4 = (short)Main.player[number].inventory[(int)number2].stack;
										bytes14 = BitConverter.GetBytes((short)Main.player[number].inventory[(int)number2].netID);
									}
									else
									{
										if (number2 >= 70f && number2 <= 72f)
										{
											int num5 = (int)number2 - 58 - 12;
											if (Main.player[number].dye[num5].name == "" || Main.player[number].dye[num5].stack == 0 || Main.player[number].dye[num5].type == 0)
											{
												Main.player[number].dye[num5].SetDefaults(0, false);
											}
											num4 = (short)Main.player[number].dye[num5].stack;
											bytes14 = BitConverter.GetBytes((short)Main.player[number].dye[num5].netID);
										}
										else
										{
											if (Main.player[number].armor[(int)number2 - 58 - 1].name == "" || Main.player[number].armor[(int)number2 - 58 - 1].stack == 0 || Main.player[number].armor[(int)number2 - 58 - 1].type == 0)
											{
												Main.player[number].armor[(int)number2 - 58 - 1].SetDefaults(0, false);
											}
											num4 = (short)Main.player[number].armor[(int)number2 - 58 - 1].stack;
											bytes14 = BitConverter.GetBytes((short)Main.player[number].armor[(int)number2 - 58 - 1].netID);
										}
									}
									if (num4 < 0)
									{
										num4 = 0;
									}
									byte[] bytes15 = BitConverter.GetBytes(num4);
									byte b6 = (byte)number3;
									num2 += 4 + bytes14.Length + 1;
									byte[] bytes16 = BitConverter.GetBytes(num2 - 4);
									Buffer.BlockCopy(bytes16, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
									Buffer.BlockCopy(bytes13, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
									NetMessage.buffer[num].writeBuffer[5] = b4;
									num3++;
									NetMessage.buffer[num].writeBuffer[6] = b5;
									num3++;
									Buffer.BlockCopy(bytes15, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
									num3 += 2;
									NetMessage.buffer[num].writeBuffer[9] = b6;
									num3++;
									Buffer.BlockCopy(bytes14, 0, NetMessage.buffer[num].writeBuffer, num3, bytes14.Length);
								}
								else
								{
									if (msgType == 6)
									{
										byte[] bytes17 = BitConverter.GetBytes(msgType);
										byte[] bytes18 = BitConverter.GetBytes(num2 - 4);
										Buffer.BlockCopy(bytes18, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
										Buffer.BlockCopy(bytes17, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
									}
									else
									{
										if (msgType == 7)
										{
											byte[] bytes19 = BitConverter.GetBytes(msgType);
											byte[] bytes20 = BitConverter.GetBytes((int)Main.time);
											byte b7 = 0;
											if (Main.dayTime)
											{
												b7 = 1;
											}
											byte b8 = (byte)Main.moonPhase;
											byte b9 = 0;
											if (Main.bloodMoon)
											{
												b9 = 1;
											}
											byte b10 = 0;
											if (Main.eclipse)
											{
												b10 = 1;
											}
											byte[] bytes21 = BitConverter.GetBytes(Main.maxTilesX);
											byte[] bytes22 = BitConverter.GetBytes(Main.maxTilesY);
											byte[] bytes23 = BitConverter.GetBytes(Main.spawnTileX);
											byte[] bytes24 = BitConverter.GetBytes(Main.spawnTileY);
											byte[] bytes25 = BitConverter.GetBytes((int)Main.worldSurface);
											byte[] bytes26 = BitConverter.GetBytes((int)Main.rockLayer);
											byte[] bytes27 = BitConverter.GetBytes(Main.worldID);
											byte[] bytes28 = Encoding.UTF8.GetBytes(Main.worldName);
											byte b11 = 0;
											byte b12 = 0;
											byte b13 = (byte)WorldGen.treeBG;
											byte b14 = (byte)WorldGen.corruptBG;
											byte b15 = (byte)WorldGen.jungleBG;
											byte b16 = (byte)WorldGen.snowBG;
											byte b17 = (byte)WorldGen.hallowBG;
											byte b18 = (byte)WorldGen.crimsonBG;
											byte b19 = (byte)WorldGen.desertBG;
											byte b20 = (byte)WorldGen.oceanBG;
											byte[] bytes29 = BitConverter.GetBytes(Main.windSpeedSet);
											byte b21 = (byte)Main.numClouds;
											byte[] bytes30 = BitConverter.GetBytes(Main.treeX[0]);
											byte[] bytes31 = BitConverter.GetBytes(Main.treeX[1]);
											byte[] bytes32 = BitConverter.GetBytes(Main.treeX[2]);
											byte b22 = (byte)Main.treeStyle[0];
											byte b23 = (byte)Main.treeStyle[1];
											byte b24 = (byte)Main.treeStyle[2];
											byte b25 = (byte)Main.treeStyle[3];
											byte[] bytes33 = BitConverter.GetBytes(Main.caveBackX[0]);
											byte[] bytes34 = BitConverter.GetBytes(Main.caveBackX[1]);
											byte[] bytes35 = BitConverter.GetBytes(Main.caveBackX[2]);
											byte b26 = (byte)Main.caveBackStyle[0];
											byte b27 = (byte)Main.caveBackStyle[1];
											byte b28 = (byte)Main.caveBackStyle[2];
											byte b29 = (byte)Main.caveBackStyle[3];
											if (!Main.raining)
											{
												Main.maxRaining = 0f;
											}
											byte[] bytes36 = BitConverter.GetBytes(Main.maxRaining);
											if (WorldGen.shadowOrbSmashed)
											{
												b11 += 1;
											}
											if (NPC.downedBoss1)
											{
												b11 += 2;
											}
											if (NPC.downedBoss2)
											{
												b11 += 4;
											}
											if (NPC.downedBoss3)
											{
												b11 += 8;
											}
											if (Main.hardMode)
											{
												b11 += 16;
											}
											if (NPC.downedClown)
											{
												b11 += 32;
											}
											if (NPC.downedPlantBoss)
											{
												b11 += 128;
											}
											if (NPC.downedMechBoss1)
											{
												b12 += 1;
											}
											if (NPC.downedMechBoss2)
											{
												b12 += 2;
											}
											if (NPC.downedMechBoss3)
											{
												b12 += 4;
											}
											if (NPC.downedMechBossAny)
											{
												b12 += 8;
											}
											if (Main.cloudBGActive >= 1f)
											{
												b12 += 16;
											}
											if (WorldGen.crimson)
											{
												b12 += 32;
											}
											num2 += bytes20.Length + 1 + 1 + 1 + 1 + 1 + bytes21.Length + bytes22.Length + bytes23.Length + bytes24.Length + bytes25.Length + bytes26.Length + bytes27.Length + 1 + bytes28.Length + 12 + 4 + 1 + 3 + 5 + 12 + 4 + 3 + 4 + 1 + 1;
											num2 += 3;
											byte[] bytes37 = BitConverter.GetBytes(num2 - 4);
											Buffer.BlockCopy(bytes37, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
											Buffer.BlockCopy(bytes19, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
											Buffer.BlockCopy(bytes20, 0, NetMessage.buffer[num].writeBuffer, 5, bytes20.Length);
											num3 += bytes20.Length;
											NetMessage.buffer[num].writeBuffer[num3] = b7;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b8;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b9;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b10;
											num3++;
											Buffer.BlockCopy(bytes21, 0, NetMessage.buffer[num].writeBuffer, num3, bytes21.Length);
											num3 += bytes21.Length;
											Buffer.BlockCopy(bytes22, 0, NetMessage.buffer[num].writeBuffer, num3, bytes22.Length);
											num3 += bytes22.Length;
											Buffer.BlockCopy(bytes23, 0, NetMessage.buffer[num].writeBuffer, num3, bytes23.Length);
											num3 += bytes23.Length;
											Buffer.BlockCopy(bytes24, 0, NetMessage.buffer[num].writeBuffer, num3, bytes24.Length);
											num3 += bytes24.Length;
											Buffer.BlockCopy(bytes25, 0, NetMessage.buffer[num].writeBuffer, num3, bytes25.Length);
											num3 += bytes25.Length;
											Buffer.BlockCopy(bytes26, 0, NetMessage.buffer[num].writeBuffer, num3, bytes26.Length);
											num3 += bytes26.Length;
											Buffer.BlockCopy(bytes27, 0, NetMessage.buffer[num].writeBuffer, num3, bytes27.Length);
											num3 += bytes27.Length;
											NetMessage.buffer[num].writeBuffer[num3] = (byte)Main.moonType;
											num3++;
											Buffer.BlockCopy(bytes30, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
											num3 += 4;
											Buffer.BlockCopy(bytes31, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
											num3 += 4;
											Buffer.BlockCopy(bytes32, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
											num3 += 4;
											NetMessage.buffer[num].writeBuffer[num3] = b22;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b23;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b24;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b25;
											num3++;
											Buffer.BlockCopy(bytes33, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
											num3 += 4;
											Buffer.BlockCopy(bytes34, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
											num3 += 4;
											Buffer.BlockCopy(bytes35, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
											num3 += 4;
											NetMessage.buffer[num].writeBuffer[num3] = b26;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b27;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b28;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b29;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b13;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b14;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b15;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b16;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b17;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b18;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b19;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b20;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = (byte)Main.iceBackStyle;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = (byte)Main.jungleBackStyle;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = (byte)Main.hellBackStyle;
											num3++;
											Buffer.BlockCopy(bytes29, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
											num3 += 4;
											NetMessage.buffer[num].writeBuffer[num3] = b21;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b11;
											num3++;
											NetMessage.buffer[num].writeBuffer[num3] = b12;
											num3++;
											Buffer.BlockCopy(bytes36, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
											num3 += 4;
											Buffer.BlockCopy(bytes28, 0, NetMessage.buffer[num].writeBuffer, num3, bytes28.Length);
											num3 += bytes28.Length;
										}
										else
										{
											if (msgType == 8)
											{
												byte[] bytes38 = BitConverter.GetBytes(msgType);
												byte[] bytes39 = BitConverter.GetBytes(number);
												byte[] bytes40 = BitConverter.GetBytes((int)number2);
												num2 += bytes39.Length + bytes40.Length;
												byte[] bytes41 = BitConverter.GetBytes(num2 - 4);
												Buffer.BlockCopy(bytes41, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
												Buffer.BlockCopy(bytes38, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
												Buffer.BlockCopy(bytes39, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
												num3 += 4;
												Buffer.BlockCopy(bytes40, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
											}
											else
											{
												if (msgType == 9)
												{
													byte[] bytes42 = BitConverter.GetBytes(msgType);
													byte[] bytes43 = BitConverter.GetBytes(number);
													byte[] bytes44 = Encoding.UTF8.GetBytes(text);
													num2 += bytes43.Length + bytes44.Length;
													byte[] bytes45 = BitConverter.GetBytes(num2 - 4);
													Buffer.BlockCopy(bytes45, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
													Buffer.BlockCopy(bytes42, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
													Buffer.BlockCopy(bytes43, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
													num3 += 4;
													Buffer.BlockCopy(bytes44, 0, NetMessage.buffer[num].writeBuffer, num3, bytes44.Length);
												}
												else
												{
													if (msgType == 10)
													{
														short num6 = (short)number;
														int num7 = (int)number2;
														int num8 = (int)number3;
														byte[] bytes46 = BitConverter.GetBytes(msgType);
														Buffer.BlockCopy(bytes46, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
														byte[] bytes47 = BitConverter.GetBytes(num6);
														Buffer.BlockCopy(bytes47, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
														num3 += 2;
														byte[] bytes48 = BitConverter.GetBytes(num7);
														Buffer.BlockCopy(bytes48, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
														num3 += 4;
														byte[] bytes49 = BitConverter.GetBytes(num8);
														Buffer.BlockCopy(bytes49, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
														num3 += 4;
														for (int i = num7; i < num7 + (int)num6; i++)
														{
															byte b30 = 0;
															byte b31 = 0;
															byte b32 = 0;
															byte b33 = 0;
															if (Main.tile[i, num8].active())
															{
																b30 += 1;
															}
															if (Main.tile[i, num8].wall > 0)
															{
																b30 += 4;
															}
															if (Main.tile[i, num8].liquid > 0)
															{
																b30 += 8;
															}
															if (Main.tile[i, num8].wire())
															{
																b30 += 16;
															}
															if (Main.tile[i, num8].halfBrick())
															{
																b30 += 32;
															}
															if (Main.tile[i, num8].actuator())
															{
																b30 += 64;
															}
															if (Main.tile[i, num8].inActive())
															{
																b30 += 128;
															}
															if (Main.tile[i, num8].wire2())
															{
																b31 += 1;
															}
															if (Main.tile[i, num8].wire3())
															{
																b31 += 2;
															}
															if ((Main.tile[i, num8].tileHeader3 & 16) == 16)
															{
																b31 += 16;
															}
															if ((Main.tile[i, num8].tileHeader3 & 32) == 32)
															{
																b31 += 32;
															}
															if (Main.tile[i, num8].active() && Main.tile[i, num8].color() > 0)
															{
																b31 += 4;
																b32 = Main.tile[i, num8].color();
															}
															if (Main.tile[i, num8].wall > 0 && Main.tile[i, num8].wallColor() > 0)
															{
																b31 += 8;
																b33 = Main.tile[i, num8].wallColor();
															}
															NetMessage.buffer[num].writeBuffer[num3] = b30;
															num3++;
															NetMessage.buffer[num].writeBuffer[num3] = b31;
															num3++;
															if (b32 > 0)
															{
																NetMessage.buffer[num].writeBuffer[num3] = b32;
																num3++;
															}
															if (b33 > 0)
															{
																NetMessage.buffer[num].writeBuffer[num3] = b33;
																num3++;
															}
															byte[] bytes50 = BitConverter.GetBytes(Main.tile[i, num8].frameX);
															byte[] bytes51 = BitConverter.GetBytes(Main.tile[i, num8].frameY);
															byte wall = Main.tile[i, num8].wall;
															if (Main.tile[i, num8].active())
															{
																NetMessage.buffer[num].writeBuffer[num3] = Main.tile[i, num8].type;
																num3++;
																if (Main.tileFrameImportant[(int)Main.tile[i, num8].type])
																{
																	Buffer.BlockCopy(bytes50, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																	num3 += 2;
																	Buffer.BlockCopy(bytes51, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																	num3 += 2;
																}
															}
															if (wall > 0)
															{
																NetMessage.buffer[num].writeBuffer[num3] = wall;
																num3++;
															}
															if (Main.tile[i, num8].liquid > 0)
															{
																NetMessage.buffer[num].writeBuffer[num3] = Main.tile[i, num8].liquid;
																num3++;
																byte b34 = Main.tile[i, num8].liquidType();
																NetMessage.buffer[num].writeBuffer[num3] = b34;
																num3++;
															}
															short num9 = 1;
															while (i + (int)num9 < num7 + (int)num6 && Main.tile[i, num8].isTheSameAs(Main.tile[i + (int)num9, num8]))
															{
																num9 += 1;
															}
															num9 -= 1;
															byte[] bytes52 = BitConverter.GetBytes(num9);
															Buffer.BlockCopy(bytes52, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
															num3 += 2;
															i += (int)num9;
														}
														byte[] bytes53 = BitConverter.GetBytes(num3 - 4);
														Buffer.BlockCopy(bytes53, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
														num2 = num3;
													}
													else
													{
														if (msgType == 11)
														{
															byte[] bytes54 = BitConverter.GetBytes(msgType);
															byte[] bytes55 = BitConverter.GetBytes(number);
															byte[] bytes56 = BitConverter.GetBytes((int)number2);
															byte[] bytes57 = BitConverter.GetBytes((int)number3);
															byte[] bytes58 = BitConverter.GetBytes((int)number4);
															num2 += bytes55.Length + bytes56.Length + bytes57.Length + bytes58.Length;
															byte[] bytes59 = BitConverter.GetBytes(num2 - 4);
															Buffer.BlockCopy(bytes59, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
															Buffer.BlockCopy(bytes54, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
															Buffer.BlockCopy(bytes55, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
															num3 += 4;
															Buffer.BlockCopy(bytes56, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
															num3 += 4;
															Buffer.BlockCopy(bytes57, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
															num3 += 4;
															Buffer.BlockCopy(bytes58, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
															num3 += 4;
														}
														else
														{
															if (msgType == 12)
															{
																byte[] bytes60 = BitConverter.GetBytes(msgType);
																byte b35 = (byte)number;
																byte[] bytes61 = BitConverter.GetBytes(Main.player[(int)b35].SpawnX);
																byte[] bytes62 = BitConverter.GetBytes(Main.player[(int)b35].SpawnY);
																num2 += 1 + bytes61.Length + bytes62.Length;
																byte[] bytes63 = BitConverter.GetBytes(num2 - 4);
																Buffer.BlockCopy(bytes63, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																Buffer.BlockCopy(bytes60, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																NetMessage.buffer[num].writeBuffer[num3] = b35;
																num3++;
																Buffer.BlockCopy(bytes61, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																num3 += 4;
																Buffer.BlockCopy(bytes62, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																num3 += 4;
															}
															else
															{
																if (msgType == 13)
																{
																	byte[] bytes64 = BitConverter.GetBytes(msgType);
																	byte b36 = (byte)number;
																	byte b37 = 0;
																	if (Main.player[(int)b36].controlUp)
																	{
																		b37 += 1;
																	}
																	if (Main.player[(int)b36].controlDown)
																	{
																		b37 += 2;
																	}
																	if (Main.player[(int)b36].controlLeft)
																	{
																		b37 += 4;
																	}
																	if (Main.player[(int)b36].controlRight)
																	{
																		b37 += 8;
																	}
																	if (Main.player[(int)b36].controlJump)
																	{
																		b37 += 16;
																	}
																	if (Main.player[(int)b36].controlUseItem)
																	{
																		b37 += 32;
																	}
																	if (Main.player[(int)b36].direction == 1)
																	{
																		b37 += 64;
																	}
																	byte b38 = (byte)Main.player[(int)b36].selectedItem;
																	byte[] bytes65 = BitConverter.GetBytes(Main.player[number].position.X);
																	byte[] bytes66 = BitConverter.GetBytes(Main.player[number].position.Y);
																	byte[] bytes67 = BitConverter.GetBytes(Main.player[number].velocity.X);
																	byte[] bytes68 = BitConverter.GetBytes(Main.player[number].velocity.Y);
																	byte b39 = 0;
																	if (Main.player[(int)b36].pulley)
																	{
																		b39 += 1;
																		if (Main.player[(int)b36].pulleyDir == 2)
																		{
																			b39 += 2;
																		}
																	}
																	num2 += 3 + bytes65.Length + bytes66.Length + bytes67.Length + bytes68.Length + 1;
																	byte[] bytes69 = BitConverter.GetBytes(num2 - 4);
																	Buffer.BlockCopy(bytes69, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																	Buffer.BlockCopy(bytes64, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																	NetMessage.buffer[num].writeBuffer[5] = b36;
																	num3++;
																	NetMessage.buffer[num].writeBuffer[6] = b37;
																	num3++;
																	NetMessage.buffer[num].writeBuffer[7] = b38;
																	num3++;
																	Buffer.BlockCopy(bytes65, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																	num3 += 4;
																	Buffer.BlockCopy(bytes66, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																	num3 += 4;
																	Buffer.BlockCopy(bytes67, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																	num3 += 4;
																	Buffer.BlockCopy(bytes68, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																	num3 += 4;
																	NetMessage.buffer[num].writeBuffer[num3] = b39;
																	num3++;
																}
																else
																{
																	if (msgType == 14)
																	{
																		byte[] bytes70 = BitConverter.GetBytes(msgType);
																		byte b40 = (byte)number;
																		byte b41 = (byte)number2;
																		num2 += 2;
																		byte[] bytes71 = BitConverter.GetBytes(num2 - 4);
																		Buffer.BlockCopy(bytes71, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																		Buffer.BlockCopy(bytes70, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																		NetMessage.buffer[num].writeBuffer[5] = b40;
																		NetMessage.buffer[num].writeBuffer[6] = b41;
																	}
																	else
																	{
																		if (msgType == 15)
																		{
																			byte[] bytes72 = BitConverter.GetBytes(msgType);
																			byte[] bytes73 = BitConverter.GetBytes(num2 - 4);
																			Buffer.BlockCopy(bytes73, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																			Buffer.BlockCopy(bytes72, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																		}
																		else
																		{
																			if (msgType == 16)
																			{
																				byte[] bytes74 = BitConverter.GetBytes(msgType);
																				byte b42 = (byte)number;
																				byte[] bytes75 = BitConverter.GetBytes((short)Main.player[(int)b42].statLife);
																				byte[] bytes76 = BitConverter.GetBytes((short)Main.player[(int)b42].statLifeMax);
																				num2 += 1 + bytes75.Length + bytes76.Length;
																				byte[] bytes77 = BitConverter.GetBytes(num2 - 4);
																				Buffer.BlockCopy(bytes77, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																				Buffer.BlockCopy(bytes74, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																				NetMessage.buffer[num].writeBuffer[5] = b42;
																				num3++;
																				Buffer.BlockCopy(bytes75, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																				num3 += 2;
																				Buffer.BlockCopy(bytes76, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																			}
																			else
																			{
																				if (msgType == 17)
																				{
																					byte[] bytes78 = BitConverter.GetBytes(msgType);
																					byte b43 = (byte)number;
																					byte[] bytes79 = BitConverter.GetBytes((int)number2);
																					byte[] bytes80 = BitConverter.GetBytes((int)number3);
																					byte b44 = (byte)number4;
																					num2 += 1 + bytes79.Length + bytes80.Length + 1 + 1;
																					byte[] bytes81 = BitConverter.GetBytes(num2 - 4);
																					Buffer.BlockCopy(bytes81, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																					Buffer.BlockCopy(bytes78, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																					NetMessage.buffer[num].writeBuffer[num3] = b43;
																					num3++;
																					Buffer.BlockCopy(bytes79, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																					num3 += 4;
																					Buffer.BlockCopy(bytes80, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																					num3 += 4;
																					NetMessage.buffer[num].writeBuffer[num3] = b44;
																					num3++;
																					NetMessage.buffer[num].writeBuffer[num3] = (byte)number5;
																				}
																				else
																				{
																					if (msgType == 18)
																					{
																						byte[] bytes82 = BitConverter.GetBytes(msgType);
																						BitConverter.GetBytes((int)Main.time);
																						byte b45 = 0;
																						if (Main.dayTime)
																						{
																							b45 = 1;
																						}
																						byte[] bytes83 = BitConverter.GetBytes((int)Main.time);
																						byte[] bytes84 = BitConverter.GetBytes(Main.sunModY);
																						byte[] bytes85 = BitConverter.GetBytes(Main.moonModY);
																						num2 += 1 + bytes83.Length + bytes84.Length + bytes85.Length;
																						byte[] bytes86 = BitConverter.GetBytes(num2 - 4);
																						Buffer.BlockCopy(bytes86, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																						Buffer.BlockCopy(bytes82, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																						NetMessage.buffer[num].writeBuffer[num3] = b45;
																						num3++;
																						Buffer.BlockCopy(bytes83, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																						num3 += 4;
																						Buffer.BlockCopy(bytes84, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																						num3 += 2;
																						Buffer.BlockCopy(bytes85, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																						num3 += 2;
																					}
																					else
																					{
																						if (msgType == 19)
																						{
																							byte[] bytes87 = BitConverter.GetBytes(msgType);
																							byte b46 = (byte)number;
																							byte[] bytes88 = BitConverter.GetBytes((int)number2);
																							byte[] bytes89 = BitConverter.GetBytes((int)number3);
																							byte b47 = 0;
																							if (number4 == 1f)
																							{
																								b47 = 1;
																							}
																							num2 += 1 + bytes88.Length + bytes89.Length + 1;
																							byte[] bytes90 = BitConverter.GetBytes(num2 - 4);
																							Buffer.BlockCopy(bytes90, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																							Buffer.BlockCopy(bytes87, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																							NetMessage.buffer[num].writeBuffer[num3] = b46;
																							num3++;
																							Buffer.BlockCopy(bytes88, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																							num3 += 4;
																							Buffer.BlockCopy(bytes89, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																							num3 += 4;
																							NetMessage.buffer[num].writeBuffer[num3] = b47;
																						}
																						else
																						{
																							if (msgType == 20)
																							{
																								short num10 = (short)number;
																								int num11 = (int)number2;
																								int num12 = (int)number3;
																								byte[] bytes91 = BitConverter.GetBytes(msgType);
																								Buffer.BlockCopy(bytes91, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																								byte[] bytes92 = BitConverter.GetBytes(num10);
																								Buffer.BlockCopy(bytes92, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																								num3 += 2;
																								byte[] bytes93 = BitConverter.GetBytes(num11);
																								Buffer.BlockCopy(bytes93, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																								num3 += 4;
																								byte[] bytes94 = BitConverter.GetBytes(num12);
																								Buffer.BlockCopy(bytes94, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																								num3 += 4;
																								for (int j = num11; j < num11 + (int)num10; j++)
																								{
																									for (int k = num12; k < num12 + (int)num10; k++)
																									{
																										byte b48 = 0;
																										byte b49 = 0;
																										byte b50 = 0;
																										byte b51 = 0;
																										if (Main.tile[j, k].active())
																										{
																											b48 += 1;
																										}
																										if (Main.tile[j, k].wall > 0)
																										{
																											b48 += 4;
																										}
																										if (Main.tile[j, k].liquid > 0 && Main.netMode == 2)
																										{
																											b48 += 8;
																										}
																										if (Main.tile[j, k].wire())
																										{
																											b48 += 16;
																										}
																										if (Main.tile[j, k].halfBrick())
																										{
																											b48 += 32;
																										}
																										if (Main.tile[j, k].actuator())
																										{
																											b48 += 64;
																										}
																										if (Main.tile[j, k].inActive())
																										{
																											b48 += 128;
																										}
																										if (Main.tile[j, k].wire2())
																										{
																											b49 += 1;
																										}
																										if (Main.tile[j, k].wire3())
																										{
																											b49 += 2;
																										}
																										if ((Main.tile[j, k].tileHeader3 & 16) == 16)
																										{
																											b49 += 16;
																										}
																										if ((Main.tile[j, k].tileHeader3 & 32) == 32)
																										{
																											b49 += 32;
																										}
																										if (Main.tile[j, k].active() && Main.tile[j, k].color() > 0)
																										{
																											b49 += 4;
																											b50 = Main.tile[j, k].color();
																										}
																										if (Main.tile[j, k].wall > 0 && Main.tile[j, k].wallColor() > 0)
																										{
																											b49 += 8;
																											b51 = Main.tile[j, k].wallColor();
																										}
																										NetMessage.buffer[num].writeBuffer[num3] = b48;
																										num3++;
																										NetMessage.buffer[num].writeBuffer[num3] = b49;
																										num3++;
																										if (b50 > 0)
																										{
																											NetMessage.buffer[num].writeBuffer[num3] = b50;
																											num3++;
																										}
																										if (b51 > 0)
																										{
																											NetMessage.buffer[num].writeBuffer[num3] = b51;
																											num3++;
																										}
																										byte[] bytes95 = BitConverter.GetBytes(Main.tile[j, k].frameX);
																										byte[] bytes96 = BitConverter.GetBytes(Main.tile[j, k].frameY);
																										byte wall2 = Main.tile[j, k].wall;
																										if (Main.tile[j, k].active())
																										{
																											NetMessage.buffer[num].writeBuffer[num3] = Main.tile[j, k].type;
																											num3++;
																											if (Main.tileFrameImportant[(int)Main.tile[j, k].type])
																											{
																												Buffer.BlockCopy(bytes95, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																												num3 += 2;
																												Buffer.BlockCopy(bytes96, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																												num3 += 2;
																											}
																										}
																										if (wall2 > 0)
																										{
																											NetMessage.buffer[num].writeBuffer[num3] = wall2;
																											num3++;
																										}
																										if (Main.tile[j, k].liquid > 0 && Main.netMode == 2)
																										{
																											NetMessage.buffer[num].writeBuffer[num3] = Main.tile[j, k].liquid;
																											num3++;
																											byte b52 = Main.tile[j, k].liquidType();
																											NetMessage.buffer[num].writeBuffer[num3] = b52;
																											num3++;
																										}
																									}
																								}
																								byte[] bytes97 = BitConverter.GetBytes(num3 - 4);
																								Buffer.BlockCopy(bytes97, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																								num2 = num3;
																							}
																							else
																							{
																								if (msgType == 21)
																								{
																									byte[] bytes98 = BitConverter.GetBytes(msgType);
																									byte[] bytes99 = BitConverter.GetBytes((short)number);
																									byte[] bytes100 = BitConverter.GetBytes(Main.item[number].position.X);
																									byte[] bytes101 = BitConverter.GetBytes(Main.item[number].position.Y);
																									byte[] bytes102 = BitConverter.GetBytes(Main.item[number].velocity.X);
																									byte[] bytes103 = BitConverter.GetBytes(Main.item[number].velocity.Y);
																									byte[] bytes104 = BitConverter.GetBytes((short)Main.item[number].stack);
																									byte prefix = Main.item[number].prefix;
																									byte b53 = (byte)number2;
																									short value = 0;
																									if (Main.item[number].active && Main.item[number].stack > 0)
																									{
																										value = (short)Main.item[number].netID;
																									}
																									byte[] bytes105 = BitConverter.GetBytes(value);
																									num2 += bytes99.Length + bytes100.Length + bytes101.Length + bytes102.Length + bytes103.Length + 1 + bytes105.Length + 1 + 1 + 1;
																									byte[] bytes106 = BitConverter.GetBytes(num2 - 4);
																									Buffer.BlockCopy(bytes106, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																									Buffer.BlockCopy(bytes98, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																									Buffer.BlockCopy(bytes99, 0, NetMessage.buffer[num].writeBuffer, num3, bytes99.Length);
																									num3 += 2;
																									Buffer.BlockCopy(bytes100, 0, NetMessage.buffer[num].writeBuffer, num3, bytes100.Length);
																									num3 += 4;
																									Buffer.BlockCopy(bytes101, 0, NetMessage.buffer[num].writeBuffer, num3, bytes101.Length);
																									num3 += 4;
																									Buffer.BlockCopy(bytes102, 0, NetMessage.buffer[num].writeBuffer, num3, bytes102.Length);
																									num3 += 4;
																									Buffer.BlockCopy(bytes103, 0, NetMessage.buffer[num].writeBuffer, num3, bytes103.Length);
																									num3 += 4;
																									Buffer.BlockCopy(bytes104, 0, NetMessage.buffer[num].writeBuffer, num3, bytes104.Length);
																									num3 += 2;
																									NetMessage.buffer[num].writeBuffer[num3] = prefix;
																									num3++;
																									NetMessage.buffer[num].writeBuffer[num3] = b53;
																									num3++;
																									Buffer.BlockCopy(bytes105, 0, NetMessage.buffer[num].writeBuffer, num3, bytes105.Length);
																								}
																								else
																								{
																									if (msgType == 22)
																									{
																										byte[] bytes107 = BitConverter.GetBytes(msgType);
																										byte[] bytes108 = BitConverter.GetBytes((short)number);
																										byte b54 = (byte)Main.item[number].owner;
																										num2 += bytes108.Length + 1;
																										byte[] bytes109 = BitConverter.GetBytes(num2 - 4);
																										Buffer.BlockCopy(bytes109, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																										Buffer.BlockCopy(bytes107, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																										Buffer.BlockCopy(bytes108, 0, NetMessage.buffer[num].writeBuffer, num3, bytes108.Length);
																										num3 += 2;
																										NetMessage.buffer[num].writeBuffer[num3] = b54;
																									}
																									else
																									{
																										if (msgType == 23)
																										{
																											byte[] bytes110 = BitConverter.GetBytes(msgType);
																											byte[] bytes111 = BitConverter.GetBytes((short)number);
																											byte[] bytes112 = BitConverter.GetBytes(Main.npc[number].position.X);
																											byte[] bytes113 = BitConverter.GetBytes(Main.npc[number].position.Y);
																											byte[] bytes114 = BitConverter.GetBytes(Main.npc[number].velocity.X);
																											byte[] bytes115 = BitConverter.GetBytes(Main.npc[number].velocity.Y);
																											byte b55 = (byte)Main.npc[number].target;
																											byte[] bytes116 = BitConverter.GetBytes(Main.npc[number].life);
																											if (!Main.npc[number].active)
																											{
																												bytes116 = BitConverter.GetBytes(0);
																											}
																											if (!Main.npc[number].active || Main.npc[number].life <= 0)
																											{
																												Main.npc[number].netSkip = 0;
																											}
																											if (Main.npc[number].name == null)
																											{
																												Main.npc[number].name = "";
																											}
																											byte[] bytes117 = BitConverter.GetBytes((short)Main.npc[number].netID);
																											num2 += bytes111.Length + bytes112.Length + bytes113.Length + bytes114.Length + bytes115.Length + 1 + bytes116.Length + NPC.maxAI * 4 + bytes117.Length + 1 + 1;
																											byte[] bytes118 = BitConverter.GetBytes(num2 - 4);
																											Buffer.BlockCopy(bytes118, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																											Buffer.BlockCopy(bytes110, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																											Buffer.BlockCopy(bytes111, 0, NetMessage.buffer[num].writeBuffer, num3, bytes111.Length);
																											num3 += 2;
																											Buffer.BlockCopy(bytes112, 0, NetMessage.buffer[num].writeBuffer, num3, bytes112.Length);
																											num3 += 4;
																											Buffer.BlockCopy(bytes113, 0, NetMessage.buffer[num].writeBuffer, num3, bytes113.Length);
																											num3 += 4;
																											Buffer.BlockCopy(bytes114, 0, NetMessage.buffer[num].writeBuffer, num3, bytes114.Length);
																											num3 += 4;
																											Buffer.BlockCopy(bytes115, 0, NetMessage.buffer[num].writeBuffer, num3, bytes115.Length);
																											num3 += 4;
																											NetMessage.buffer[num].writeBuffer[num3] = b55;
																											num3++;
																											byte b56 = 0;
																											if (Main.npc[number].direction > 0)
																											{
																												b56 += 1;
																											}
																											if (Main.npc[number].directionY > 0)
																											{
																												b56 += 2;
																											}
																											bool[] array = new bool[4];
																											if (Main.npc[number].ai[3] != 0f)
																											{
																												b56 += 4;
																												array[3] = true;
																											}
																											if (Main.npc[number].ai[2] != 0f)
																											{
																												b56 += 8;
																												array[2] = true;
																											}
																											if (Main.npc[number].ai[1] != 0f)
																											{
																												b56 += 16;
																												array[1] = true;
																											}
																											if (Main.npc[number].ai[0] != 0f)
																											{
																												b56 += 32;
																												array[0] = true;
																											}
																											if (Main.npc[number].spriteDirection > 0)
																											{
																												b56 += 64;
																											}
																											NetMessage.buffer[num].writeBuffer[num3] = b56;
																											num3++;
																											Buffer.BlockCopy(bytes116, 0, NetMessage.buffer[num].writeBuffer, num3, bytes116.Length);
																											num3 += 4;
																											for (int l = 0; l < NPC.maxAI; l++)
																											{
																												if (array[l])
																												{
																													byte[] bytes119 = BitConverter.GetBytes(Main.npc[number].ai[l]);
																													Buffer.BlockCopy(bytes119, 0, NetMessage.buffer[num].writeBuffer, num3, bytes119.Length);
																													num3 += 4;
																												}
																											}
																											Buffer.BlockCopy(bytes117, 0, NetMessage.buffer[num].writeBuffer, num3, bytes117.Length);
																										}
																										else
																										{
																											if (msgType == 24)
																											{
																												byte[] bytes120 = BitConverter.GetBytes(msgType);
																												byte[] bytes121 = BitConverter.GetBytes((short)number);
																												byte b57 = (byte)number2;
																												num2 += bytes121.Length + 1;
																												byte[] bytes122 = BitConverter.GetBytes(num2 - 4);
																												Buffer.BlockCopy(bytes122, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																												Buffer.BlockCopy(bytes120, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																												Buffer.BlockCopy(bytes121, 0, NetMessage.buffer[num].writeBuffer, num3, bytes121.Length);
																												num3 += 2;
																												NetMessage.buffer[num].writeBuffer[num3] = b57;
																											}
																											else
																											{
																												if (msgType == 25)
																												{
																													byte[] bytes123 = BitConverter.GetBytes(msgType);
																													byte b58 = (byte)number;
																													byte[] bytes124 = Encoding.UTF8.GetBytes(text);
																													byte b59 = (byte)number2;
																													byte b60 = (byte)number3;
																													byte b61 = (byte)number4;
																													num2 += 1 + bytes124.Length + 3;
																													byte[] bytes125 = BitConverter.GetBytes(num2 - 4);
																													Buffer.BlockCopy(bytes125, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																													Buffer.BlockCopy(bytes123, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																													NetMessage.buffer[num].writeBuffer[num3] = b58;
																													num3++;
																													NetMessage.buffer[num].writeBuffer[num3] = b59;
																													num3++;
																													NetMessage.buffer[num].writeBuffer[num3] = b60;
																													num3++;
																													NetMessage.buffer[num].writeBuffer[num3] = b61;
																													num3++;
																													Buffer.BlockCopy(bytes124, 0, NetMessage.buffer[num].writeBuffer, num3, bytes124.Length);
																												}
																												else
																												{
																													if (msgType == 26)
																													{
																														byte[] bytes126 = BitConverter.GetBytes(msgType);
																														byte b62 = (byte)number;
																														byte b63 = (byte)(number2 + 1f);
																														byte[] bytes127 = BitConverter.GetBytes((short)number3);
																														byte[] bytes128 = Encoding.UTF8.GetBytes(text);
																														byte b64 = (byte)number4;
																														byte b65 = (byte)number5;
																														num2 += 2 + bytes127.Length + 1 + bytes128.Length + 1;
																														byte[] bytes129 = BitConverter.GetBytes(num2 - 4);
																														Buffer.BlockCopy(bytes129, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																														Buffer.BlockCopy(bytes126, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																														NetMessage.buffer[num].writeBuffer[num3] = b62;
																														num3++;
																														NetMessage.buffer[num].writeBuffer[num3] = b63;
																														num3++;
																														Buffer.BlockCopy(bytes127, 0, NetMessage.buffer[num].writeBuffer, num3, bytes127.Length);
																														num3 += 2;
																														NetMessage.buffer[num].writeBuffer[num3] = b64;
																														num3++;
																														NetMessage.buffer[num].writeBuffer[num3] = b65;
																														num3++;
																														Buffer.BlockCopy(bytes128, 0, NetMessage.buffer[num].writeBuffer, num3, bytes128.Length);
																													}
																													else
																													{
																														if (msgType == 27)
																														{
																															byte[] bytes130 = BitConverter.GetBytes(msgType);
																															byte[] bytes131 = BitConverter.GetBytes((short)Main.projectile[number].identity);
																															byte[] bytes132 = BitConverter.GetBytes(Main.projectile[number].position.X);
																															byte[] bytes133 = BitConverter.GetBytes(Main.projectile[number].position.Y);
																															byte[] bytes134 = BitConverter.GetBytes(Main.projectile[number].velocity.X);
																															byte[] bytes135 = BitConverter.GetBytes(Main.projectile[number].velocity.Y);
																															byte[] bytes136 = BitConverter.GetBytes(Main.projectile[number].knockBack);
																															byte[] bytes137 = BitConverter.GetBytes((short)Main.projectile[number].damage);
																															byte[] bytes138 = BitConverter.GetBytes((short)Main.projectile[number].type);
																															Buffer.BlockCopy(bytes130, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																															Buffer.BlockCopy(bytes131, 0, NetMessage.buffer[num].writeBuffer, num3, bytes131.Length);
																															num3 += 2;
																															Buffer.BlockCopy(bytes132, 0, NetMessage.buffer[num].writeBuffer, num3, bytes132.Length);
																															num3 += 4;
																															Buffer.BlockCopy(bytes133, 0, NetMessage.buffer[num].writeBuffer, num3, bytes133.Length);
																															num3 += 4;
																															Buffer.BlockCopy(bytes134, 0, NetMessage.buffer[num].writeBuffer, num3, bytes134.Length);
																															num3 += 4;
																															Buffer.BlockCopy(bytes135, 0, NetMessage.buffer[num].writeBuffer, num3, bytes135.Length);
																															num3 += 4;
																															Buffer.BlockCopy(bytes136, 0, NetMessage.buffer[num].writeBuffer, num3, bytes136.Length);
																															num3 += 4;
																															Buffer.BlockCopy(bytes137, 0, NetMessage.buffer[num].writeBuffer, num3, bytes137.Length);
																															num3 += 2;
																															NetMessage.buffer[num].writeBuffer[num3] = (byte)Main.projectile[number].owner;
																															num3++;
																															Buffer.BlockCopy(bytes138, 0, NetMessage.buffer[num].writeBuffer, num3, bytes138.Length);
																															num3 += 2;
																															for (int m = 0; m < Projectile.maxAI; m++)
																															{
																																byte[] bytes139 = BitConverter.GetBytes(Main.projectile[number].ai[m]);
																																Buffer.BlockCopy(bytes139, 0, NetMessage.buffer[num].writeBuffer, num3, bytes139.Length);
																																num3 += 4;
																															}
																															num2 += num3;
																															byte[] bytes140 = BitConverter.GetBytes(num2 - 4);
																															Buffer.BlockCopy(bytes140, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																														}
																														else
																														{
																															if (msgType == 28)
																															{
																																byte[] bytes141 = BitConverter.GetBytes(msgType);
																																byte[] bytes142 = BitConverter.GetBytes((short)number);
																																byte[] bytes143 = BitConverter.GetBytes((short)number2);
																																byte[] bytes144 = BitConverter.GetBytes(number3);
																																byte b66 = (byte)(number4 + 1f);
																																byte b67 = (byte)number5;
																																num2 += bytes142.Length + bytes143.Length + bytes144.Length + 1 + 1;
																																byte[] bytes145 = BitConverter.GetBytes(num2 - 4);
																																Buffer.BlockCopy(bytes145, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																Buffer.BlockCopy(bytes141, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																Buffer.BlockCopy(bytes142, 0, NetMessage.buffer[num].writeBuffer, num3, bytes142.Length);
																																num3 += 2;
																																Buffer.BlockCopy(bytes143, 0, NetMessage.buffer[num].writeBuffer, num3, bytes143.Length);
																																num3 += 2;
																																Buffer.BlockCopy(bytes144, 0, NetMessage.buffer[num].writeBuffer, num3, bytes144.Length);
																																num3 += 4;
																																NetMessage.buffer[num].writeBuffer[num3] = b66;
																																num3++;
																																NetMessage.buffer[num].writeBuffer[num3] = b67;
																															}
																															else
																															{
																																if (msgType == 29)
																																{
																																	byte[] bytes146 = BitConverter.GetBytes(msgType);
																																	byte[] bytes147 = BitConverter.GetBytes((short)number);
																																	byte b68 = (byte)number2;
																																	num2 += bytes147.Length + 1;
																																	byte[] bytes148 = BitConverter.GetBytes(num2 - 4);
																																	Buffer.BlockCopy(bytes148, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																	Buffer.BlockCopy(bytes146, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																	Buffer.BlockCopy(bytes147, 0, NetMessage.buffer[num].writeBuffer, num3, bytes147.Length);
																																	num3 += 2;
																																	NetMessage.buffer[num].writeBuffer[num3] = b68;
																																}
																																else
																																{
																																	if (msgType == 30)
																																	{
																																		byte[] bytes149 = BitConverter.GetBytes(msgType);
																																		byte b69 = (byte)number;
																																		byte b70 = 0;
																																		if (Main.player[(int)b69].hostile)
																																		{
																																			b70 = 1;
																																		}
																																		num2 += 2;
																																		byte[] bytes150 = BitConverter.GetBytes(num2 - 4);
																																		Buffer.BlockCopy(bytes150, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																		Buffer.BlockCopy(bytes149, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																		NetMessage.buffer[num].writeBuffer[num3] = b69;
																																		num3++;
																																		NetMessage.buffer[num].writeBuffer[num3] = b70;
																																	}
																																	else
																																	{
																																		if (msgType == 31)
																																		{
																																			byte[] bytes151 = BitConverter.GetBytes(msgType);
																																			byte[] bytes152 = BitConverter.GetBytes(number);
																																			byte[] bytes153 = BitConverter.GetBytes((int)number2);
																																			num2 += bytes152.Length + bytes153.Length;
																																			byte[] bytes154 = BitConverter.GetBytes(num2 - 4);
																																			Buffer.BlockCopy(bytes154, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																			Buffer.BlockCopy(bytes151, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																			Buffer.BlockCopy(bytes152, 0, NetMessage.buffer[num].writeBuffer, num3, bytes152.Length);
																																			num3 += 4;
																																			Buffer.BlockCopy(bytes153, 0, NetMessage.buffer[num].writeBuffer, num3, bytes153.Length);
																																		}
																																		else
																																		{
																																			if (msgType == 32)
																																			{
																																				byte[] bytes155 = BitConverter.GetBytes(msgType);
																																				byte[] bytes156 = BitConverter.GetBytes((short)number);
																																				byte b71 = (byte)number2;
																																				byte[] bytes157 = BitConverter.GetBytes(Main.chest[number].item[(int)number2].stack);
																																				byte prefix2 = Main.chest[number].item[(int)number2].prefix;
																																				byte[] bytes158;
																																				if (Main.chest[number].item[(int)number2].name == null)
																																				{
																																					bytes158 = BitConverter.GetBytes(0);
																																				}
																																				else
																																				{
																																					bytes158 = BitConverter.GetBytes((short)Main.chest[number].item[(int)number2].netID);
																																				}
																																				num2 += bytes156.Length + 1 + 1 + bytes157.Length + bytes158.Length;
																																				byte[] bytes159 = BitConverter.GetBytes(num2 - 4);
																																				Buffer.BlockCopy(bytes159, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																				Buffer.BlockCopy(bytes155, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																				Buffer.BlockCopy(bytes156, 0, NetMessage.buffer[num].writeBuffer, num3, bytes156.Length);
																																				num3 += 2;
																																				NetMessage.buffer[num].writeBuffer[num3] = b71;
																																				num3++;
																																				Buffer.BlockCopy(bytes157, 0, NetMessage.buffer[num].writeBuffer, num3, bytes157.Length);
																																				num3 += 2;
																																				NetMessage.buffer[num].writeBuffer[num3] = prefix2;
																																				num3++;
																																				Buffer.BlockCopy(bytes158, 0, NetMessage.buffer[num].writeBuffer, num3, bytes158.Length);
																																			}
																																			else
																																			{
																																				if (msgType == 33)
																																				{
																																					byte[] bytes160 = BitConverter.GetBytes(msgType);
																																					byte[] bytes161 = BitConverter.GetBytes((short)number);
																																					byte[] bytes162;
																																					byte[] bytes163;
																																					if (number > -1)
																																					{
																																						bytes162 = BitConverter.GetBytes(Main.chest[number].x);
																																						bytes163 = BitConverter.GetBytes(Main.chest[number].y);
																																					}
																																					else
																																					{
																																						bytes162 = BitConverter.GetBytes(0);
																																						bytes163 = BitConverter.GetBytes(0);
																																					}
																																					num2 += bytes161.Length + bytes162.Length + bytes163.Length;
																																					byte[] bytes164 = BitConverter.GetBytes(num2 - 4);
																																					Buffer.BlockCopy(bytes164, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																					Buffer.BlockCopy(bytes160, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																					Buffer.BlockCopy(bytes161, 0, NetMessage.buffer[num].writeBuffer, num3, bytes161.Length);
																																					num3 += 2;
																																					Buffer.BlockCopy(bytes162, 0, NetMessage.buffer[num].writeBuffer, num3, bytes162.Length);
																																					num3 += 4;
																																					Buffer.BlockCopy(bytes163, 0, NetMessage.buffer[num].writeBuffer, num3, bytes163.Length);
																																				}
																																				else
																																				{
																																					if (msgType == 34)
																																					{
																																						byte[] bytes165 = BitConverter.GetBytes(msgType);
																																						byte[] bytes166 = BitConverter.GetBytes(number);
																																						byte[] bytes167 = BitConverter.GetBytes((int)number2);
																																						num2 += bytes166.Length + bytes167.Length;
																																						byte[] bytes168 = BitConverter.GetBytes(num2 - 4);
																																						Buffer.BlockCopy(bytes168, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																						Buffer.BlockCopy(bytes165, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																						Buffer.BlockCopy(bytes166, 0, NetMessage.buffer[num].writeBuffer, num3, bytes166.Length);
																																						num3 += 4;
																																						Buffer.BlockCopy(bytes167, 0, NetMessage.buffer[num].writeBuffer, num3, bytes167.Length);
																																					}
																																					else
																																					{
																																						if (msgType == 35 || msgType == 66)
																																						{
																																							byte[] bytes169 = BitConverter.GetBytes(msgType);
																																							byte b72 = (byte)number;
																																							byte[] bytes170 = BitConverter.GetBytes((short)number2);
																																							num2 += 1 + bytes170.Length;
																																							byte[] bytes171 = BitConverter.GetBytes(num2 - 4);
																																							Buffer.BlockCopy(bytes171, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																							Buffer.BlockCopy(bytes169, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																							NetMessage.buffer[num].writeBuffer[5] = b72;
																																							num3++;
																																							Buffer.BlockCopy(bytes170, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																																						}
																																						else
																																						{
																																							if (msgType == 36)
																																							{
																																								byte[] bytes172 = BitConverter.GetBytes(msgType);
																																								byte b73 = (byte)number;
																																								byte b74 = 0;
																																								if (Main.player[(int)b73].zoneEvil)
																																								{
																																									b74 += 1;
																																								}
																																								if (Main.player[(int)b73].zoneMeteor)
																																								{
																																									b74 += 2;
																																								}
																																								if (Main.player[(int)b73].zoneDungeon)
																																								{
																																									b74 += 4;
																																								}
																																								if (Main.player[(int)b73].zoneJungle)
																																								{
																																									b74 += 8;
																																								}
																																								if (Main.player[(int)b73].zoneHoly)
																																								{
																																									b74 += 16;
																																								}
																																								if (Main.player[(int)b73].zoneSnow)
																																								{
																																									b74 += 32;
																																								}
																																								if (Main.player[(int)b73].zoneBlood)
																																								{
																																									b74 += 64;
																																								}
																																								if (Main.player[(int)b73].zoneCandle)
																																								{
																																									b74 += 128;
																																								}
																																								num2 += 2;
																																								byte[] bytes173 = BitConverter.GetBytes(num2 - 4);
																																								Buffer.BlockCopy(bytes173, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																								Buffer.BlockCopy(bytes172, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																								NetMessage.buffer[num].writeBuffer[num3] = b73;
																																								num3++;
																																								NetMessage.buffer[num].writeBuffer[num3] = b74;
																																								num3++;
																																							}
																																							else
																																							{
																																								if (msgType == 37)
																																								{
																																									byte[] bytes174 = BitConverter.GetBytes(msgType);
																																									byte[] bytes175 = BitConverter.GetBytes(num2 - 4);
																																									Buffer.BlockCopy(bytes175, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																									Buffer.BlockCopy(bytes174, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																								}
																																								else
																																								{
																																									if (msgType == 38)
																																									{
																																										byte[] bytes176 = BitConverter.GetBytes(msgType);
																																										byte[] bytes177 = Encoding.UTF8.GetBytes(text);
																																										num2 += bytes177.Length;
																																										byte[] bytes178 = BitConverter.GetBytes(num2 - 4);
																																										Buffer.BlockCopy(bytes178, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																										Buffer.BlockCopy(bytes176, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																										Buffer.BlockCopy(bytes177, 0, NetMessage.buffer[num].writeBuffer, num3, bytes177.Length);
																																									}
																																									else
																																									{
																																										if (msgType == 39)
																																										{
																																											byte[] bytes179 = BitConverter.GetBytes(msgType);
																																											byte[] bytes180 = BitConverter.GetBytes((short)number);
																																											num2 += bytes180.Length;
																																											byte[] bytes181 = BitConverter.GetBytes(num2 - 4);
																																											Buffer.BlockCopy(bytes181, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																											Buffer.BlockCopy(bytes179, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																											Buffer.BlockCopy(bytes180, 0, NetMessage.buffer[num].writeBuffer, num3, bytes180.Length);
																																										}
																																										else
																																										{
																																											if (msgType == 40)
																																											{
																																												byte[] bytes182 = BitConverter.GetBytes(msgType);
																																												byte b75 = (byte)number;
																																												byte[] bytes183 = BitConverter.GetBytes((short)Main.player[(int)b75].talkNPC);
																																												num2 += 1 + bytes183.Length;
																																												byte[] bytes184 = BitConverter.GetBytes(num2 - 4);
																																												Buffer.BlockCopy(bytes184, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																												Buffer.BlockCopy(bytes182, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																												NetMessage.buffer[num].writeBuffer[num3] = b75;
																																												num3++;
																																												Buffer.BlockCopy(bytes183, 0, NetMessage.buffer[num].writeBuffer, num3, bytes183.Length);
																																												num3 += 2;
																																											}
																																											else
																																											{
																																												if (msgType == 41)
																																												{
																																													byte[] bytes185 = BitConverter.GetBytes(msgType);
																																													byte b76 = (byte)number;
																																													byte[] bytes186 = BitConverter.GetBytes(Main.player[(int)b76].itemRotation);
																																													byte[] bytes187 = BitConverter.GetBytes((short)Main.player[(int)b76].itemAnimation);
																																													num2 += 1 + bytes186.Length + bytes187.Length;
																																													byte[] bytes188 = BitConverter.GetBytes(num2 - 4);
																																													Buffer.BlockCopy(bytes188, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																													Buffer.BlockCopy(bytes185, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																													NetMessage.buffer[num].writeBuffer[num3] = b76;
																																													num3++;
																																													Buffer.BlockCopy(bytes186, 0, NetMessage.buffer[num].writeBuffer, num3, bytes186.Length);
																																													num3 += 4;
																																													Buffer.BlockCopy(bytes187, 0, NetMessage.buffer[num].writeBuffer, num3, bytes187.Length);
																																												}
																																												else
																																												{
																																													if (msgType == 42)
																																													{
																																														byte[] bytes189 = BitConverter.GetBytes(msgType);
																																														byte b77 = (byte)number;
																																														byte[] bytes190 = BitConverter.GetBytes((short)Main.player[(int)b77].statMana);
																																														byte[] bytes191 = BitConverter.GetBytes((short)Main.player[(int)b77].statManaMax);
																																														num2 += 1 + bytes190.Length + bytes191.Length;
																																														byte[] bytes192 = BitConverter.GetBytes(num2 - 4);
																																														Buffer.BlockCopy(bytes192, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																														Buffer.BlockCopy(bytes189, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																														NetMessage.buffer[num].writeBuffer[5] = b77;
																																														num3++;
																																														Buffer.BlockCopy(bytes190, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																																														num3 += 2;
																																														Buffer.BlockCopy(bytes191, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																																													}
																																													else
																																													{
																																														if (msgType == 43)
																																														{
																																															byte[] bytes193 = BitConverter.GetBytes(msgType);
																																															byte b78 = (byte)number;
																																															byte[] bytes194 = BitConverter.GetBytes((short)number2);
																																															num2 += 1 + bytes194.Length;
																																															byte[] bytes195 = BitConverter.GetBytes(num2 - 4);
																																															Buffer.BlockCopy(bytes195, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																															Buffer.BlockCopy(bytes193, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																															NetMessage.buffer[num].writeBuffer[5] = b78;
																																															num3++;
																																															Buffer.BlockCopy(bytes194, 0, NetMessage.buffer[num].writeBuffer, num3, 2);
																																														}
																																														else
																																														{
																																															if (msgType == 44)
																																															{
																																																byte[] bytes196 = BitConverter.GetBytes(msgType);
																																																byte b79 = (byte)number;
																																																byte b80 = (byte)(number2 + 1f);
																																																byte[] bytes197 = BitConverter.GetBytes((short)number3);
																																																byte b81 = (byte)number4;
																																																byte[] bytes198 = Encoding.UTF8.GetBytes(text);
																																																num2 += 2 + bytes197.Length + 1 + bytes198.Length;
																																																byte[] bytes199 = BitConverter.GetBytes(num2 - 4);
																																																Buffer.BlockCopy(bytes199, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																Buffer.BlockCopy(bytes196, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																NetMessage.buffer[num].writeBuffer[num3] = b79;
																																																num3++;
																																																NetMessage.buffer[num].writeBuffer[num3] = b80;
																																																num3++;
																																																Buffer.BlockCopy(bytes197, 0, NetMessage.buffer[num].writeBuffer, num3, bytes197.Length);
																																																num3 += 2;
																																																NetMessage.buffer[num].writeBuffer[num3] = b81;
																																																num3++;
																																																Buffer.BlockCopy(bytes198, 0, NetMessage.buffer[num].writeBuffer, num3, bytes198.Length);
																																																num3 += bytes198.Length;
																																															}
																																															else
																																															{
																																																if (msgType == 45)
																																																{
																																																	byte[] bytes200 = BitConverter.GetBytes(msgType);
																																																	byte b82 = (byte)number;
																																																	byte b83 = (byte)Main.player[(int)b82].team;
																																																	num2 += 2;
																																																	byte[] bytes201 = BitConverter.GetBytes(num2 - 4);
																																																	Buffer.BlockCopy(bytes201, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																	Buffer.BlockCopy(bytes200, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																	NetMessage.buffer[num].writeBuffer[5] = b82;
																																																	num3++;
																																																	NetMessage.buffer[num].writeBuffer[num3] = b83;
																																																}
																																																else
																																																{
																																																	if (msgType == 46)
																																																	{
																																																		byte[] bytes202 = BitConverter.GetBytes(msgType);
																																																		byte[] bytes203 = BitConverter.GetBytes(number);
																																																		byte[] bytes204 = BitConverter.GetBytes((int)number2);
																																																		num2 += bytes203.Length + bytes204.Length;
																																																		byte[] bytes205 = BitConverter.GetBytes(num2 - 4);
																																																		Buffer.BlockCopy(bytes205, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																		Buffer.BlockCopy(bytes202, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																		Buffer.BlockCopy(bytes203, 0, NetMessage.buffer[num].writeBuffer, num3, bytes203.Length);
																																																		num3 += 4;
																																																		Buffer.BlockCopy(bytes204, 0, NetMessage.buffer[num].writeBuffer, num3, bytes204.Length);
																																																	}
																																																	else
																																																	{
																																																		if (msgType == 47)
																																																		{
																																																			byte[] bytes206 = BitConverter.GetBytes(msgType);
																																																			byte[] bytes207 = BitConverter.GetBytes((short)number);
																																																			byte[] bytes208 = BitConverter.GetBytes(Main.sign[number].x);
																																																			byte[] bytes209 = BitConverter.GetBytes(Main.sign[number].y);
																																																			byte[] bytes210 = Encoding.UTF8.GetBytes(Main.sign[number].text);
																																																			num2 += bytes207.Length + bytes208.Length + bytes209.Length + bytes210.Length;
																																																			byte[] bytes211 = BitConverter.GetBytes(num2 - 4);
																																																			Buffer.BlockCopy(bytes211, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																			Buffer.BlockCopy(bytes206, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																			Buffer.BlockCopy(bytes207, 0, NetMessage.buffer[num].writeBuffer, num3, bytes207.Length);
																																																			num3 += bytes207.Length;
																																																			Buffer.BlockCopy(bytes208, 0, NetMessage.buffer[num].writeBuffer, num3, bytes208.Length);
																																																			num3 += bytes208.Length;
																																																			Buffer.BlockCopy(bytes209, 0, NetMessage.buffer[num].writeBuffer, num3, bytes209.Length);
																																																			num3 += bytes209.Length;
																																																			Buffer.BlockCopy(bytes210, 0, NetMessage.buffer[num].writeBuffer, num3, bytes210.Length);
																																																			num3 += bytes210.Length;
																																																		}
																																																		else
																																																		{
																																																			if (msgType == 48)
																																																			{
																																																				byte[] bytes212 = BitConverter.GetBytes(msgType);
																																																				byte[] bytes213 = BitConverter.GetBytes(number);
																																																				byte[] bytes214 = BitConverter.GetBytes((int)number2);
																																																				byte liquid = Main.tile[number, (int)number2].liquid;
																																																				byte b84 = Main.tile[number, (int)number2].liquidType();
																																																				num2 += bytes213.Length + bytes214.Length + 1 + 1;
																																																				byte[] bytes215 = BitConverter.GetBytes(num2 - 4);
																																																				Buffer.BlockCopy(bytes215, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																				Buffer.BlockCopy(bytes212, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																				Buffer.BlockCopy(bytes213, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																																																				num3 += 4;
																																																				Buffer.BlockCopy(bytes214, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																																																				num3 += 4;
																																																				NetMessage.buffer[num].writeBuffer[num3] = liquid;
																																																				num3++;
																																																				NetMessage.buffer[num].writeBuffer[num3] = b84;
																																																				num3++;
																																																			}
																																																			else
																																																			{
																																																				if (msgType == 49)
																																																				{
																																																					byte[] bytes216 = BitConverter.GetBytes(msgType);
																																																					byte[] bytes217 = BitConverter.GetBytes(num2 - 4);
																																																					Buffer.BlockCopy(bytes217, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																					Buffer.BlockCopy(bytes216, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																				}
																																																				else
																																																				{
																																																					if (msgType == 50)
																																																					{
																																																						byte[] bytes218 = BitConverter.GetBytes(msgType);
																																																						byte b85 = (byte)number;
																																																						num2 += 11;
																																																						byte[] bytes219 = BitConverter.GetBytes(num2 - 4);
																																																						Buffer.BlockCopy(bytes219, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																						Buffer.BlockCopy(bytes218, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																						NetMessage.buffer[num].writeBuffer[num3] = b85;
																																																						num3++;
																																																						for (int n = 0; n < 10; n++)
																																																						{
																																																							NetMessage.buffer[num].writeBuffer[num3] = (byte)Main.player[(int)b85].buffType[n];
																																																							num3++;
																																																						}
																																																					}
																																																					else
																																																					{
																																																						if (msgType == 51)
																																																						{
																																																							byte[] bytes220 = BitConverter.GetBytes(msgType);
																																																							num2 += 2;
																																																							byte b86 = (byte)number;
																																																							byte b87 = (byte)number2;
																																																							byte[] bytes221 = BitConverter.GetBytes(num2 - 4);
																																																							Buffer.BlockCopy(bytes221, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																							Buffer.BlockCopy(bytes220, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																							NetMessage.buffer[num].writeBuffer[num3] = b86;
																																																							num3++;
																																																							NetMessage.buffer[num].writeBuffer[num3] = b87;
																																																						}
																																																						else
																																																						{
																																																							if (msgType == 52)
																																																							{
																																																								byte[] bytes222 = BitConverter.GetBytes(msgType);
																																																								byte b88 = (byte)number;
																																																								byte b89 = (byte)number2;
																																																								byte[] bytes223 = BitConverter.GetBytes((int)number3);
																																																								byte[] bytes224 = BitConverter.GetBytes((int)number4);
																																																								num2 += 2 + bytes223.Length + bytes224.Length;
																																																								byte[] bytes225 = BitConverter.GetBytes(num2 - 4);
																																																								Buffer.BlockCopy(bytes225, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																								Buffer.BlockCopy(bytes222, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																								NetMessage.buffer[num].writeBuffer[num3] = b88;
																																																								num3++;
																																																								NetMessage.buffer[num].writeBuffer[num3] = b89;
																																																								num3++;
																																																								Buffer.BlockCopy(bytes223, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																																																								num3 += 4;
																																																								Buffer.BlockCopy(bytes224, 0, NetMessage.buffer[num].writeBuffer, num3, 4);
																																																								num3 += 4;
																																																							}
																																																							else
																																																							{
																																																								if (msgType == 53)
																																																								{
																																																									byte[] bytes226 = BitConverter.GetBytes(msgType);
																																																									byte[] bytes227 = BitConverter.GetBytes((short)number);
																																																									byte b90 = (byte)number2;
																																																									byte[] bytes228 = BitConverter.GetBytes((short)number3);
																																																									num2 += bytes227.Length + 1 + bytes228.Length;
																																																									byte[] bytes229 = BitConverter.GetBytes(num2 - 4);
																																																									Buffer.BlockCopy(bytes229, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																									Buffer.BlockCopy(bytes226, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																									Buffer.BlockCopy(bytes227, 0, NetMessage.buffer[num].writeBuffer, num3, bytes227.Length);
																																																									num3 += bytes227.Length;
																																																									NetMessage.buffer[num].writeBuffer[num3] = b90;
																																																									num3++;
																																																									Buffer.BlockCopy(bytes228, 0, NetMessage.buffer[num].writeBuffer, num3, bytes228.Length);
																																																									num3 += bytes228.Length;
																																																								}
																																																								else
																																																								{
																																																									if (msgType == 54)
																																																									{
																																																										byte[] bytes230 = BitConverter.GetBytes(msgType);
																																																										byte[] bytes231 = BitConverter.GetBytes((short)number);
																																																										num2 += bytes231.Length + 15;
																																																										byte[] bytes232 = BitConverter.GetBytes(num2 - 4);
																																																										Buffer.BlockCopy(bytes232, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																										Buffer.BlockCopy(bytes230, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																										Buffer.BlockCopy(bytes231, 0, NetMessage.buffer[num].writeBuffer, num3, bytes231.Length);
																																																										num3 += bytes231.Length;
																																																										for (int num13 = 0; num13 < 5; num13++)
																																																										{
																																																											NetMessage.buffer[num].writeBuffer[num3] = (byte)Main.npc[(int)((short)number)].buffType[num13];
																																																											num3++;
																																																											byte[] bytes233 = BitConverter.GetBytes(Main.npc[(int)((short)number)].buffTime[num13]);
																																																											Buffer.BlockCopy(bytes233, 0, NetMessage.buffer[num].writeBuffer, num3, bytes233.Length);
																																																											num3 += bytes233.Length;
																																																										}
																																																									}
																																																									else
																																																									{
																																																										if (msgType == 55)
																																																										{
																																																											byte[] bytes234 = BitConverter.GetBytes(msgType);
																																																											byte b91 = (byte)number;
																																																											byte b92 = (byte)number2;
																																																											byte[] bytes235 = BitConverter.GetBytes((short)number3);
																																																											num2 += 2 + bytes235.Length;
																																																											byte[] bytes236 = BitConverter.GetBytes(num2 - 4);
																																																											Buffer.BlockCopy(bytes236, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																											Buffer.BlockCopy(bytes234, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																											NetMessage.buffer[num].writeBuffer[num3] = b91;
																																																											num3++;
																																																											NetMessage.buffer[num].writeBuffer[num3] = b92;
																																																											num3++;
																																																											Buffer.BlockCopy(bytes235, 0, NetMessage.buffer[num].writeBuffer, num3, bytes235.Length);
																																																											num3 += bytes235.Length;
																																																										}
																																																										else
																																																										{
																																																											if (msgType == 56)
																																																											{
																																																												byte[] bytes237 = BitConverter.GetBytes(msgType);
																																																												byte[] bytes238 = BitConverter.GetBytes((short)number);
																																																												byte[] bytes239 = Encoding.UTF8.GetBytes(Main.chrName[number]);
																																																												num2 += bytes238.Length + bytes239.Length;
																																																												byte[] bytes240 = BitConverter.GetBytes(num2 - 4);
																																																												Buffer.BlockCopy(bytes240, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																												Buffer.BlockCopy(bytes237, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																												Buffer.BlockCopy(bytes238, 0, NetMessage.buffer[num].writeBuffer, num3, bytes238.Length);
																																																												num3 += bytes238.Length;
																																																												Buffer.BlockCopy(bytes239, 0, NetMessage.buffer[num].writeBuffer, num3, bytes239.Length);
																																																											}
																																																											else
																																																											{
																																																												if (msgType == 57)
																																																												{
																																																													byte[] bytes241 = BitConverter.GetBytes(msgType);
																																																													num2 += 2;
																																																													byte[] bytes242 = BitConverter.GetBytes(num2 - 4);
																																																													Buffer.BlockCopy(bytes242, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																													Buffer.BlockCopy(bytes241, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																													NetMessage.buffer[num].writeBuffer[num3] = WorldGen.tGood;
																																																													num3++;
																																																													NetMessage.buffer[num].writeBuffer[num3] = WorldGen.tEvil;
																																																												}
																																																												else
																																																												{
																																																													if (msgType == 58)
																																																													{
																																																														byte[] bytes243 = BitConverter.GetBytes(msgType);
																																																														byte b93 = (byte)number;
																																																														byte[] bytes244 = BitConverter.GetBytes(number2);
																																																														num2 += 1 + bytes244.Length;
																																																														byte[] bytes245 = BitConverter.GetBytes(num2 - 4);
																																																														Buffer.BlockCopy(bytes245, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																														Buffer.BlockCopy(bytes243, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																														NetMessage.buffer[num].writeBuffer[num3] = b93;
																																																														num3++;
																																																														Buffer.BlockCopy(bytes244, 0, NetMessage.buffer[num].writeBuffer, num3, bytes244.Length);
																																																													}
																																																													else
																																																													{
																																																														if (msgType == 59)
																																																														{
																																																															byte[] bytes246 = BitConverter.GetBytes(msgType);
																																																															byte[] bytes247 = BitConverter.GetBytes(number);
																																																															byte[] bytes248 = BitConverter.GetBytes((int)number2);
																																																															num2 += bytes247.Length + bytes248.Length;
																																																															byte[] bytes249 = BitConverter.GetBytes(num2 - 4);
																																																															Buffer.BlockCopy(bytes249, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																															Buffer.BlockCopy(bytes246, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																															Buffer.BlockCopy(bytes247, 0, NetMessage.buffer[num].writeBuffer, num3, bytes247.Length);
																																																															num3 += 4;
																																																															Buffer.BlockCopy(bytes248, 0, NetMessage.buffer[num].writeBuffer, num3, bytes248.Length);
																																																														}
																																																														else
																																																														{
																																																															if (msgType == 60)
																																																															{
																																																																byte[] bytes250 = BitConverter.GetBytes(msgType);
																																																																byte[] bytes251 = BitConverter.GetBytes((short)number);
																																																																byte[] bytes252 = BitConverter.GetBytes((short)number2);
																																																																byte[] bytes253 = BitConverter.GetBytes((short)number3);
																																																																byte b94 = (byte)number4;
																																																																num2 += bytes251.Length + bytes252.Length + bytes253.Length + 1;
																																																																byte[] bytes254 = BitConverter.GetBytes(num2 - 4);
																																																																Buffer.BlockCopy(bytes254, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																																Buffer.BlockCopy(bytes250, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																																Buffer.BlockCopy(bytes251, 0, NetMessage.buffer[num].writeBuffer, num3, bytes251.Length);
																																																																num3 += 2;
																																																																Buffer.BlockCopy(bytes252, 0, NetMessage.buffer[num].writeBuffer, num3, bytes252.Length);
																																																																num3 += 2;
																																																																Buffer.BlockCopy(bytes253, 0, NetMessage.buffer[num].writeBuffer, num3, bytes253.Length);
																																																																num3 += 2;
																																																																NetMessage.buffer[num].writeBuffer[num3] = b94;
																																																																num3++;
																																																															}
																																																															else
																																																															{
																																																																if (msgType == 61)
																																																																{
																																																																	byte[] bytes255 = BitConverter.GetBytes(msgType);
																																																																	byte[] bytes256 = BitConverter.GetBytes(number);
																																																																	byte[] bytes257 = BitConverter.GetBytes((int)number2);
																																																																	num2 += bytes256.Length + bytes257.Length;
																																																																	byte[] bytes258 = BitConverter.GetBytes(num2 - 4);
																																																																	Buffer.BlockCopy(bytes258, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																																	Buffer.BlockCopy(bytes255, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																																	Buffer.BlockCopy(bytes256, 0, NetMessage.buffer[num].writeBuffer, num3, bytes256.Length);
																																																																	num3 += bytes256.Length;
																																																																	Buffer.BlockCopy(bytes257, 0, NetMessage.buffer[num].writeBuffer, num3, bytes257.Length);
																																																																}
																																																																else
																																																																{
																																																																	if (msgType == 62)
																																																																	{
																																																																		byte[] bytes259 = BitConverter.GetBytes(msgType);
																																																																		byte[] bytes260 = BitConverter.GetBytes(number);
																																																																		byte[] bytes261 = BitConverter.GetBytes((int)number2);
																																																																		num2 += bytes260.Length + bytes261.Length;
																																																																		byte[] bytes262 = BitConverter.GetBytes(num2 - 4);
																																																																		Buffer.BlockCopy(bytes262, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																																		Buffer.BlockCopy(bytes259, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																																		Buffer.BlockCopy(bytes260, 0, NetMessage.buffer[num].writeBuffer, num3, bytes260.Length);
																																																																		num3 += bytes260.Length;
																																																																		Buffer.BlockCopy(bytes261, 0, NetMessage.buffer[num].writeBuffer, num3, bytes261.Length);
																																																																	}
																																																																	else
																																																																	{
																																																																		if (msgType == 63)
																																																																		{
																																																																			byte[] bytes263 = BitConverter.GetBytes(msgType);
																																																																			byte[] bytes264 = BitConverter.GetBytes(number);
																																																																			byte[] bytes265 = BitConverter.GetBytes((int)number2);
																																																																			byte b95 = (byte)number3;
																																																																			num2 += bytes264.Length + bytes265.Length + 1;
																																																																			byte[] bytes266 = BitConverter.GetBytes(num2 - 4);
																																																																			Buffer.BlockCopy(bytes266, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																																			Buffer.BlockCopy(bytes263, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																																			Buffer.BlockCopy(bytes264, 0, NetMessage.buffer[num].writeBuffer, num3, bytes264.Length);
																																																																			num3 += bytes264.Length;
																																																																			Buffer.BlockCopy(bytes265, 0, NetMessage.buffer[num].writeBuffer, num3, bytes265.Length);
																																																																			num3 += bytes265.Length;
																																																																			NetMessage.buffer[num].writeBuffer[num3] = b95;
																																																																			num3++;
																																																																		}
																																																																		else
																																																																		{
																																																																			if (msgType == 64)
																																																																			{
																																																																				byte[] bytes267 = BitConverter.GetBytes(msgType);
																																																																				byte[] bytes268 = BitConverter.GetBytes(number);
																																																																				byte[] bytes269 = BitConverter.GetBytes((int)number2);
																																																																				byte b96 = (byte)number3;
																																																																				num2 += bytes268.Length + bytes269.Length + 1;
																																																																				byte[] bytes270 = BitConverter.GetBytes(num2 - 4);
																																																																				Buffer.BlockCopy(bytes270, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																																				Buffer.BlockCopy(bytes267, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																																				Buffer.BlockCopy(bytes268, 0, NetMessage.buffer[num].writeBuffer, num3, bytes268.Length);
																																																																				num3 += bytes268.Length;
																																																																				Buffer.BlockCopy(bytes269, 0, NetMessage.buffer[num].writeBuffer, num3, bytes269.Length);
																																																																				num3 += bytes269.Length;
																																																																				NetMessage.buffer[num].writeBuffer[num3] = b96;
																																																																				num3++;
																																																																			}
																																																																			else
																																																																			{
																																																																				if (msgType == 65)
																																																																				{
																																																																					byte[] bytes271 = BitConverter.GetBytes(msgType);
																																																																					byte b97 = 0;
																																																																					byte[] bytes272 = BitConverter.GetBytes((short)number2);
																																																																					byte[] bytes273 = BitConverter.GetBytes(number3);
																																																																					byte[] bytes274 = BitConverter.GetBytes(number4);
																																																																					if ((number & 1) == 1)
																																																																					{
																																																																						b97 += 1;
																																																																					}
																																																																					if ((number & 2) == 2)
																																																																					{
																																																																						b97 += 2;
																																																																					}
																																																																					if ((number5 & 1) == 1)
																																																																					{
																																																																						b97 += 4;
																																																																					}
																																																																					if ((number5 & 2) == 2)
																																																																					{
																																																																						b97 += 8;
																																																																					}
																																																																					num2 += 1 + bytes272.Length + bytes273.Length + bytes274.Length;
																																																																					byte[] bytes275 = BitConverter.GetBytes(num2 - 4);
																																																																					Buffer.BlockCopy(bytes275, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																																					Buffer.BlockCopy(bytes271, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																																					NetMessage.buffer[num].writeBuffer[num3] = b97;
																																																																					num3++;
																																																																					Buffer.BlockCopy(bytes272, 0, NetMessage.buffer[num].writeBuffer, num3, bytes272.Length);
																																																																					num3 += bytes272.Length;
																																																																					Buffer.BlockCopy(bytes273, 0, NetMessage.buffer[num].writeBuffer, num3, bytes273.Length);
																																																																					num3 += bytes273.Length;
																																																																					Buffer.BlockCopy(bytes274, 0, NetMessage.buffer[num].writeBuffer, num3, bytes274.Length);
																																																																					num3 += bytes274.Length;
																																																																				}
																																																																				else
																																																																				{
																																																																					if (msgType != 67 && msgType == 68)
																																																																					{
																																																																						byte[] bytes276 = BitConverter.GetBytes(msgType);
																																																																						byte[] bytes277 = Encoding.UTF8.GetBytes(Main.clientUUID);
																																																																						num2 += bytes277.Length;
																																																																						byte[] bytes278 = BitConverter.GetBytes(num2 - 4);
																																																																						Buffer.BlockCopy(bytes278, 0, NetMessage.buffer[num].writeBuffer, 0, 4);
																																																																						Buffer.BlockCopy(bytes276, 0, NetMessage.buffer[num].writeBuffer, 4, 1);
																																																																						Buffer.BlockCopy(bytes277, 0, NetMessage.buffer[num].writeBuffer, 5, bytes277.Length);
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
				}
				if (Main.netMode == 1)
				{
					if (!Netplay.clientSock.tcpClient.Connected)
					{
						goto IL_5BF9;
					}
					try
					{
						NetMessage.buffer[num].spamCount++;
						Main.txMsg++;
						Main.txData += num2;
						Main.txMsgType[msgType]++;
						Main.txDataType[msgType] += num2;
						Netplay.clientSock.networkStream.BeginWrite(NetMessage.buffer[num].writeBuffer, 0, num2, new AsyncCallback(Netplay.clientSock.ClientWriteCallBack), Netplay.clientSock.networkStream);
						goto IL_5BF9;
					}
					catch
					{
						goto IL_5BF9;
					}
				}
				if (remoteClient == -1)
				{
					if (msgType == 20)
					{
						for (int num14 = 0; num14 < 256; num14++)
						{
							if (num14 != ignoreClient && (NetMessage.buffer[num14].broadcast || (Netplay.serverSock[num14].state >= 3 && msgType == 10)) && Netplay.serverSock[num14].tcpClient.Connected && Netplay.serverSock[num14].SectionRange(number, (int)number2, (int)number3))
							{
								try
								{
									NetMessage.buffer[num14].spamCount++;
									Main.txMsg++;
									Main.txData += num2;
									Main.txMsgType[msgType]++;
									Main.txDataType[msgType] += num2;
									Netplay.serverSock[num14].networkStream.BeginWrite(NetMessage.buffer[num].writeBuffer, 0, num2, new AsyncCallback(Netplay.serverSock[num14].ServerWriteCallBack), Netplay.serverSock[num14].networkStream);
								}
								catch
								{
								}
							}
						}
					}
					else
					{
						if (msgType == 23)
						{
							for (int num15 = 0; num15 < 256; num15++)
							{
								if (num15 != ignoreClient && (NetMessage.buffer[num15].broadcast || (Netplay.serverSock[num15].state >= 3 && msgType == 10)) && Netplay.serverSock[num15].tcpClient.Connected)
								{
									bool flag2 = false;
									if (Main.npc[number].boss || Main.npc[number].netAlways || Main.npc[number].townNPC || !Main.npc[number].active)
									{
										flag2 = true;
									}
									else
									{
										if (Main.npc[number].netSkip <= 0)
										{
											Rectangle rectangle = new Rectangle((int)Main.player[num15].position.X, (int)Main.player[num15].position.Y, Main.player[num15].width, Main.player[num15].height);
											Rectangle value2 = new Rectangle((int)Main.npc[number].position.X, (int)Main.npc[number].position.Y, Main.npc[number].width, Main.npc[number].height);
											value2.X -= 2500;
											value2.Y -= 2500;
											value2.Width += 5000;
											value2.Height += 5000;
											if (rectangle.Intersects(value2))
											{
												flag2 = true;
											}
										}
										else
										{
											flag2 = true;
										}
									}
									if (flag2)
									{
										try
										{
											NetMessage.buffer[num15].spamCount++;
											Main.txMsg++;
											Main.txData += num2;
											Main.txMsgType[msgType]++;
											Main.txDataType[msgType] += num2;
											Netplay.serverSock[num15].networkStream.BeginWrite(NetMessage.buffer[num].writeBuffer, 0, num2, new AsyncCallback(Netplay.serverSock[num15].ServerWriteCallBack), Netplay.serverSock[num15].networkStream);
										}
										catch
										{
										}
									}
								}
							}
							Main.npc[number].netSkip++;
							if (Main.npc[number].netSkip > 4)
							{
								Main.npc[number].netSkip = 0;
							}
						}
						else
						{
							if (msgType == 28)
							{
								for (int num16 = 0; num16 < 256; num16++)
								{
									if (num16 != ignoreClient && (NetMessage.buffer[num16].broadcast || (Netplay.serverSock[num16].state >= 3 && msgType == 10)) && Netplay.serverSock[num16].tcpClient.Connected)
									{
										bool flag3 = false;
										if (Main.npc[number].life <= 0)
										{
											flag3 = true;
										}
										else
										{
											Rectangle rectangle2 = new Rectangle((int)Main.player[num16].position.X, (int)Main.player[num16].position.Y, Main.player[num16].width, Main.player[num16].height);
											Rectangle value3 = new Rectangle((int)Main.npc[number].position.X, (int)Main.npc[number].position.Y, Main.npc[number].width, Main.npc[number].height);
											value3.X -= 3000;
											value3.Y -= 3000;
											value3.Width += 6000;
											value3.Height += 6000;
											if (rectangle2.Intersects(value3))
											{
												flag3 = true;
											}
										}
										if (flag3)
										{
											try
											{
												NetMessage.buffer[num16].spamCount++;
												Main.txMsg++;
												Main.txData += num2;
												Main.txMsgType[msgType]++;
												Main.txDataType[msgType] += num2;
												Netplay.serverSock[num16].networkStream.BeginWrite(NetMessage.buffer[num].writeBuffer, 0, num2, new AsyncCallback(Netplay.serverSock[num16].ServerWriteCallBack), Netplay.serverSock[num16].networkStream);
											}
											catch
											{
											}
										}
									}
								}
							}
							else
							{
								if (msgType == 13)
								{
									for (int num17 = 0; num17 < 256; num17++)
									{
										if (num17 != ignoreClient && (NetMessage.buffer[num17].broadcast || (Netplay.serverSock[num17].state >= 3 && msgType == 10)) && Netplay.serverSock[num17].tcpClient.Connected)
										{
											bool flag4 = true;
											if (flag4)
											{
												try
												{
													NetMessage.buffer[num17].spamCount++;
													Main.txMsg++;
													Main.txData += num2;
													Main.txMsgType[msgType]++;
													Main.txDataType[msgType] += num2;
													Netplay.serverSock[num17].networkStream.BeginWrite(NetMessage.buffer[num].writeBuffer, 0, num2, new AsyncCallback(Netplay.serverSock[num17].ServerWriteCallBack), Netplay.serverSock[num17].networkStream);
												}
												catch
												{
												}
											}
										}
									}
									Main.player[number].netSkip++;
									if (Main.player[number].netSkip > 2)
									{
										Main.player[number].netSkip = 0;
									}
								}
								else
								{
									if (msgType == 27)
									{
										for (int num18 = 0; num18 < 256; num18++)
										{
											if (num18 != ignoreClient && (NetMessage.buffer[num18].broadcast || (Netplay.serverSock[num18].state >= 3 && msgType == 10)) && Netplay.serverSock[num18].tcpClient.Connected)
											{
												bool flag5 = false;
												if (Main.projectile[number].type == 12 || Main.projPet[Main.projectile[number].type] || Main.projectile[number].aiStyle == 11 || Main.projPet[Main.projectile[number].type] || Main.projectile[number].netImportant)
												{
													flag5 = true;
												}
												else
												{
													Rectangle rectangle3 = new Rectangle((int)Main.player[num18].position.X, (int)Main.player[num18].position.Y, Main.player[num18].width, Main.player[num18].height);
													Rectangle value4 = new Rectangle((int)Main.projectile[number].position.X, (int)Main.projectile[number].position.Y, Main.projectile[number].width, Main.projectile[number].height);
													value4.X -= 5000;
													value4.Y -= 5000;
													value4.Width += 10000;
													value4.Height += 10000;
													if (rectangle3.Intersects(value4))
													{
														flag5 = true;
													}
												}
												if (flag5)
												{
													try
													{
														NetMessage.buffer[num18].spamCount++;
														Main.txMsg++;
														Main.txData += num2;
														Main.txMsgType[msgType]++;
														Main.txDataType[msgType] += num2;
														Netplay.serverSock[num18].networkStream.BeginWrite(NetMessage.buffer[num].writeBuffer, 0, num2, new AsyncCallback(Netplay.serverSock[num18].ServerWriteCallBack), Netplay.serverSock[num18].networkStream);
													}
													catch
													{
													}
												}
											}
										}
									}
									else
									{
										for (int num19 = 0; num19 < 256; num19++)
										{
											if (num19 != ignoreClient && (NetMessage.buffer[num19].broadcast || (Netplay.serverSock[num19].state >= 3 && msgType == 10)) && Netplay.serverSock[num19].tcpClient.Connected)
											{
												try
												{
													NetMessage.buffer[num19].spamCount++;
													Main.txMsg++;
													Main.txData += num2;
													Main.txMsgType[msgType]++;
													Main.txDataType[msgType] += num2;
													Netplay.serverSock[num19].networkStream.BeginWrite(NetMessage.buffer[num].writeBuffer, 0, num2, new AsyncCallback(Netplay.serverSock[num19].ServerWriteCallBack), Netplay.serverSock[num19].networkStream);
												}
												catch
												{
												}
											}
										}
									}
								}
							}
						}
					}
				}
				else
				{
					if (Netplay.serverSock[remoteClient].tcpClient.Connected)
					{
						try
						{
							NetMessage.buffer[remoteClient].spamCount++;
							Main.txMsg++;
							Main.txData += num2;
							Main.txMsgType[msgType]++;
							Main.txDataType[msgType] += num2;
							Netplay.serverSock[remoteClient].networkStream.BeginWrite(NetMessage.buffer[num].writeBuffer, 0, num2, new AsyncCallback(Netplay.serverSock[remoteClient].ServerWriteCallBack), Netplay.serverSock[remoteClient].networkStream);
						}
						catch
						{
						}
					}
				}
				IL_5BF9:
				if (Main.verboseNetplay)
				{
					for (int num20 = 0; num20 < num2; num20++)
					{
					}
					for (int num21 = 0; num21 < num2; num21++)
					{
						byte arg_5C30_0 = NetMessage.buffer[num].writeBuffer[num21];
					}
				}
				NetMessage.buffer[num].writeLocked = false;
				if (msgType == 19 && Main.netMode == 1)
				{
					int size = 5;
					NetMessage.SendTileSquare(num, (int)number2, (int)number3, size);
				}
				if (msgType == 2 && Main.netMode == 2)
				{
					Netplay.serverSock[num].kill = true;
				}
			}
		}
		public static void RecieveBytes(byte[] bytes, int streamLength, int i = 256)
		{
			lock (NetMessage.buffer[i])
			{
				try
				{
					Buffer.BlockCopy(bytes, 0, NetMessage.buffer[i].readBuffer, NetMessage.buffer[i].totalData, streamLength);
					NetMessage.buffer[i].totalData += streamLength;
					NetMessage.buffer[i].checkBytes = true;
				}
				catch
				{
					if (Main.netMode == 1)
					{
						Main.menuMode = 15;
						Main.statusText = "Bad header lead to a read buffer overflow.";
						Netplay.disconnect = true;
					}
					else
					{
						Netplay.serverSock[i].kill = true;
					}
				}
			}
		}
		public static void CheckBytes(int i = 256)
		{
			lock (NetMessage.buffer[i])
			{
				int num = 0;
				if (NetMessage.buffer[i].totalData >= 4)
				{
					if (NetMessage.buffer[i].messageLength == 0)
					{
						NetMessage.buffer[i].messageLength = BitConverter.ToInt32(NetMessage.buffer[i].readBuffer, 0) + 4;
					}
					while (NetMessage.buffer[i].totalData >= NetMessage.buffer[i].messageLength + num && NetMessage.buffer[i].messageLength > 0)
					{
						if (!Main.ignoreErrors)
						{
							NetMessage.buffer[i].GetData(num + 4, NetMessage.buffer[i].messageLength - 4);
						}
						else
						{
							try
							{
								NetMessage.buffer[i].GetData(num + 4, NetMessage.buffer[i].messageLength - 4);
							}
							catch
							{
							}
						}
						num += NetMessage.buffer[i].messageLength;
						if (NetMessage.buffer[i].totalData - num >= 4)
						{
							NetMessage.buffer[i].messageLength = BitConverter.ToInt32(NetMessage.buffer[i].readBuffer, num) + 4;
						}
						else
						{
							NetMessage.buffer[i].messageLength = 0;
						}
					}
					if (num == NetMessage.buffer[i].totalData)
					{
						NetMessage.buffer[i].totalData = 0;
					}
					else
					{
						if (num > 0)
						{
							Buffer.BlockCopy(NetMessage.buffer[i].readBuffer, num, NetMessage.buffer[i].readBuffer, 0, NetMessage.buffer[i].totalData - num);
							NetMessage.buffer[i].totalData -= num;
						}
					}
					NetMessage.buffer[i].checkBytes = false;
				}
			}
		}
		public static void BootPlayer(int plr, string msg)
		{
			NetMessage.SendData(2, plr, -1, msg, 0, 0f, 0f, 0f, 0);
		}
		public static void SendTileSquare(int whoAmi, int tileX, int tileY, int size)
		{
			int num = (size - 1) / 2;
			NetMessage.SendData(20, whoAmi, -1, "", size, (float)(tileX - num), (float)(tileY - num), 0f, 0);
		}
		public static void SendSection(int whoAmi, int sectionX, int sectionY)
		{
			if (Main.netMode != 2)
			{
				return;
			}
			try
			{
				if (sectionX >= 0 && sectionY >= 0 && sectionX < Main.maxSectionsX && sectionY < Main.maxSectionsY)
				{
					Netplay.serverSock[whoAmi].tileSection[sectionX, sectionY] = true;
					int num = sectionX * 200;
					int num2 = sectionY * 150;
					for (int i = num2; i < num2 + 150; i++)
					{
						NetMessage.SendData(10, whoAmi, -1, "", 200, (float)num, (float)i, 0f, 0);
					}
					for (int j = 0; j < 200; j++)
					{
						if (Main.npc[j].active && Main.npc[j].townNPC)
						{
							int sectionX2 = Netplay.GetSectionX((int)(Main.npc[j].position.X / 16f));
							int sectionY2 = Netplay.GetSectionY((int)(Main.npc[j].position.Y / 16f));
							if (sectionX2 == sectionX && sectionY2 == sectionY)
							{
								NetMessage.SendData(23, whoAmi, -1, "", j, 0f, 0f, 0f, 0);
							}
						}
					}
				}
			}
			catch
			{
			}
		}
		public static void greetPlayer(int plr)
		{
			if (Main.motd == "")
			{
				NetMessage.SendData(25, plr, -1, Lang.mp[18] + " " + Main.worldName + "!", 255, 255f, 240f, 20f, 0);
			}
			else
			{
				NetMessage.SendData(25, plr, -1, Main.motd, 255, 255f, 240f, 20f, 0);
			}
			string text = "";
			for (int i = 0; i < 255; i++)
			{
				if (Main.player[i].active)
				{
					if (text == "")
					{
						text += Main.player[i].name;
					}
					else
					{
						text = text + ", " + Main.player[i].name;
					}
				}
			}
			NetMessage.SendData(25, plr, -1, "Current players: " + text + ".", 255, 255f, 240f, 20f, 0);
		}
		public static void sendWater(int x, int y)
		{
			if (Main.netMode == 1)
			{
				NetMessage.SendData(48, -1, -1, "", x, (float)y, 0f, 0f, 0);
				return;
			}
			for (int i = 0; i < 256; i++)
			{
				if ((NetMessage.buffer[i].broadcast || Netplay.serverSock[i].state >= 3) && Netplay.serverSock[i].tcpClient.Connected)
				{
					int num = x / 200;
					int num2 = y / 150;
					if (Netplay.serverSock[i].tileSection[num, num2])
					{
						NetMessage.SendData(48, i, -1, "", x, (float)y, 0f, 0f, 0);
					}
				}
			}
		}
		public static void syncPlayers()
		{
			bool flag = false;
			for (int i = 0; i < 255; i++)
			{
				int num = 0;
				if (Main.player[i].active)
				{
					num = 1;
				}
				if (Netplay.serverSock[i].state == 10)
				{
					if (Main.autoShutdown && !flag)
					{
						string text = Netplay.serverSock[i].tcpClient.Client.RemoteEndPoint.ToString();
						string a = text;
						for (int j = 0; j < text.Length; j++)
						{
							if (text.Substring(j, 1) == ":")
							{
								a = text.Substring(0, j);
							}
						}
						if (a == "127.0.0.1")
						{
							flag = true;
						}
					}
					NetMessage.SendData(14, -1, i, "", i, (float)num, 0f, 0f, 0);
					NetMessage.SendData(4, -1, i, Main.player[i].name, i, 0f, 0f, 0f, 0);
					NetMessage.SendData(13, -1, i, "", i, 0f, 0f, 0f, 0);
					NetMessage.SendData(16, -1, i, "", i, 0f, 0f, 0f, 0);
					NetMessage.SendData(30, -1, i, "", i, 0f, 0f, 0f, 0);
					NetMessage.SendData(45, -1, i, "", i, 0f, 0f, 0f, 0);
					NetMessage.SendData(42, -1, i, "", i, 0f, 0f, 0f, 0);
					NetMessage.SendData(50, -1, i, "", i, 0f, 0f, 0f, 0);
					for (int k = 0; k < 59; k++)
					{
						NetMessage.SendData(5, -1, i, Main.player[i].inventory[k].name, i, (float)k, (float)Main.player[i].inventory[k].prefix, 0f, 0);
					}
					NetMessage.SendData(5, -1, i, Main.player[i].armor[0].name, i, 59f, (float)Main.player[i].armor[0].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].armor[1].name, i, 60f, (float)Main.player[i].armor[1].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].armor[2].name, i, 61f, (float)Main.player[i].armor[2].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].armor[3].name, i, 62f, (float)Main.player[i].armor[3].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].armor[4].name, i, 63f, (float)Main.player[i].armor[4].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].armor[5].name, i, 64f, (float)Main.player[i].armor[5].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].armor[6].name, i, 65f, (float)Main.player[i].armor[6].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].armor[7].name, i, 66f, (float)Main.player[i].armor[7].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].armor[8].name, i, 67f, (float)Main.player[i].armor[8].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].armor[9].name, i, 68f, (float)Main.player[i].armor[9].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].armor[10].name, i, 69f, (float)Main.player[i].armor[10].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].dye[0].name, i, 70f, (float)Main.player[i].dye[0].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].dye[1].name, i, 71f, (float)Main.player[i].dye[1].prefix, 0f, 0);
					NetMessage.SendData(5, -1, i, Main.player[i].dye[2].name, i, 72f, (float)Main.player[i].dye[2].prefix, 0f, 0);
					if (!Netplay.serverSock[i].announced)
					{
						Netplay.serverSock[i].announced = true;
						NetMessage.SendData(25, -1, i, Main.player[i].name + " " + Lang.mp[19], 255, 255f, 240f, 20f, 0);
						if (Main.dedServ)
						{
							Console.WriteLine(Main.player[i].name + " " + Lang.mp[19]);
						}
					}
				}
				else
				{
					num = 0;
					NetMessage.SendData(14, -1, i, "", i, (float)num, 0f, 0f, 0);
					if (Netplay.serverSock[i].announced)
					{
						Netplay.serverSock[i].announced = false;
						NetMessage.SendData(25, -1, i, Netplay.serverSock[i].oldName + " " + Lang.mp[20], 255, 255f, 240f, 20f, 0);
						if (Main.dedServ)
						{
							Console.WriteLine(Netplay.serverSock[i].oldName + " " + Lang.mp[20]);
						}
					}
				}
			}
			for (int l = 0; l < 200; l++)
			{
				if (Main.npc[l].active && Main.npc[l].townNPC && NPC.TypeToNum(Main.npc[l].type) != -1)
				{
					int num2 = 0;
					if (Main.npc[l].homeless)
					{
						num2 = 1;
					}
					NetMessage.SendData(60, -1, -1, "", l, (float)Main.npc[l].homeTileX, (float)Main.npc[l].homeTileY, (float)num2, 0);
				}
			}
			if (Main.autoShutdown && !flag)
			{
				WorldGen.saveWorld(false);
				Netplay.disconnect = true;
			}
		}
	}
}
