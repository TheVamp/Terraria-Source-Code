using Microsoft.Xna.Framework;
using System;
namespace Terraria
{
	public class Chest
	{
		public static int maxItems = 40;
		public Item[] item = new Item[Chest.maxItems];
		public int x;
		public int y;
		public object Clone()
		{
			return base.MemberwiseClone();
		}
		public static void Unlock(int X, int Y)
		{
			Main.PlaySound(22, X * 16, Y * 16, 1);
			for (int i = X; i <= X + 1; i++)
			{
				for (int j = Y; j <= Y + 1; j++)
				{
					if (Main.tile[i, j] == null)
					{
						Main.tile[i, j] = new Tile();
					}
					if ((Main.tile[i, j].frameX >= 72 && Main.tile[i, j].frameX <= 106) || (Main.tile[i, j].frameX >= 144 && Main.tile[i, j].frameX <= 178))
					{
						Tile expr_A3 = Main.tile[i, j];
						expr_A3.frameX -= 36;
						for (int k = 0; k < 4; k++)
						{
							Dust.NewDust(new Vector2((float)(i * 16), (float)(j * 16)), 16, 16, 11, 0f, 0f, 0, default(Color), 1f);
						}
					}
					else
					{
						if (Main.tile[i, j].frameX >= 828 && Main.tile[i, j].frameX <= 990)
						{
							Tile expr_134 = Main.tile[i, j];
							expr_134.frameX -= 180;
							for (int l = 0; l < 4; l++)
							{
								Dust.NewDust(new Vector2((float)(i * 16), (float)(j * 16)), 16, 16, 11, 0f, 0f, 0, default(Color), 1f);
							}
						}
					}
				}
			}
		}
		public static int UsingChest(int i)
		{
			if (Main.chest[i] != null)
			{
				for (int j = 0; j < 255; j++)
				{
					if (Main.player[j].active && Main.player[j].chest == i)
					{
						return j;
					}
				}
			}
			return -1;
		}
		public static int FindChest(int X, int Y)
		{
			for (int i = 0; i < 1000; i++)
			{
				if (Main.chest[i] != null && Main.chest[i].x == X && Main.chest[i].y == Y)
				{
					return i;
				}
			}
			return -1;
		}
		public static int CreateChest(int X, int Y)
		{
			for (int i = 0; i < 1000; i++)
			{
				if (Main.chest[i] != null && Main.chest[i].x == X && Main.chest[i].y == Y)
				{
					return -1;
				}
			}
			for (int j = 0; j < 1000; j++)
			{
				if (Main.chest[j] == null)
				{
					Main.chest[j] = new Chest();
					Main.chest[j].x = X;
					Main.chest[j].y = Y;
					for (int k = 0; k < Chest.maxItems; k++)
					{
						Main.chest[j].item[k] = new Item();
					}
					return j;
				}
			}
			return -1;
		}
		public static bool DestroyChest(int X, int Y)
		{
			for (int i = 0; i < 1000; i++)
			{
				if (Main.chest[i] != null && Main.chest[i].x == X && Main.chest[i].y == Y)
				{
					for (int j = 0; j < Chest.maxItems; j++)
					{
						if (Main.chest[i].item[j].type > 0 && Main.chest[i].item[j].stack > 0)
						{
							return false;
						}
					}
					Main.chest[i] = null;
					return true;
				}
			}
			return true;
		}
		public void AddShop(Item newItem)
		{
			int i = 0;
			while (i < 39)
			{
				if (this.item[i] == null || this.item[i].type == 0)
				{
					this.item[i] = (Item)newItem.Clone();
					this.item[i].buyOnce = true;
					if (this.item[i].value <= 0)
					{
						break;
					}
					this.item[i].value = this.item[i].value / 5;
					if (this.item[i].value < 1)
					{
						this.item[i].value = 1;
						return;
					}
					break;
				}
				else
				{
					i++;
				}
			}
		}
		public void SetupShop(int type)
		{
			for (int i = 0; i < Chest.maxItems; i++)
			{
				this.item[i] = new Item();
			}
			int num = 0;
			if (type == 1)
			{
				this.item[num].SetDefaults("Mining Helmet");
				num++;
				this.item[num].SetDefaults("Piggy Bank");
				num++;
				this.item[num].SetDefaults("Iron Anvil");
				num++;
				this.item[num].SetDefaults("Copper Pickaxe");
				num++;
				this.item[num].SetDefaults("Copper Axe");
				num++;
				this.item[num].SetDefaults("Torch");
				num++;
				this.item[num].SetDefaults("Lesser Healing Potion");
				num++;
				if (Main.player[Main.myPlayer].statManaMax == 200)
				{
					this.item[num].SetDefaults("Lesser Mana Potion");
					num++;
				}
				this.item[num].SetDefaults("Wooden Arrow");
				num++;
				this.item[num].SetDefaults("Shuriken");
				num++;
				this.item[num].SetDefaults("Rope");
				num++;
				if (Main.player[Main.myPlayer].zoneSnow)
				{
					this.item[num].SetDefaults(967, false);
					num++;
				}
				if (Main.bloodMoon)
				{
					this.item[num].SetDefaults("Throwing Knife");
					num++;
				}
				if (!Main.dayTime)
				{
					this.item[num].SetDefaults("Glowstick");
					num++;
				}
				if (NPC.downedBoss3)
				{
					this.item[num].SetDefaults("Safe");
					num++;
				}
				if (Main.hardMode)
				{
					this.item[num].SetDefaults(488, false);
					num++;
				}
				for (int j = 0; j < 58; j++)
				{
					if (Main.player[Main.myPlayer].inventory[j].type == 930)
					{
						this.item[num].SetDefaults(931, false);
						num++;
						this.item[num].SetDefaults(1614, false);
						num++;
						break;
					}
				}
				if (Main.hardMode)
				{
					this.item[num].SetDefaults(1348, false);
				}
				num++;
			}
			else
			{
				if (type == 2)
				{
					this.item[num].SetDefaults("Musket Ball");
					num++;
					if (Main.bloodMoon || Main.hardMode)
					{
						this.item[num].SetDefaults("Silver Bullet");
						num++;
					}
					if ((NPC.downedBoss2 && !Main.dayTime) || Main.hardMode)
					{
						this.item[num].SetDefaults(47, false);
						num++;
					}
					this.item[num].SetDefaults("Flintlock Pistol");
					num++;
					this.item[num].SetDefaults("Minishark");
					num++;
					if (!Main.dayTime)
					{
						this.item[num].SetDefaults(324, false);
						num++;
					}
					if (Main.hardMode)
					{
						this.item[num].SetDefaults(534, false);
						num++;
					}
					if (Main.hardMode)
					{
						this.item[num].SetDefaults(1432, false);
						num++;
					}
					if (Main.player[Main.myPlayer].HasItem(1258))
					{
						this.item[num].SetDefaults(1261, false);
						num++;
					}
				}
				else
				{
					if (type == 3)
					{
						if (Main.bloodMoon)
						{
							this.item[num].SetDefaults(67, false);
							num++;
							this.item[num].SetDefaults(59, false);
							num++;
						}
						else
						{
							this.item[num].SetDefaults("Purification Powder");
							num++;
							this.item[num].SetDefaults("Grass Seeds");
							num++;
							this.item[num].SetDefaults("Sunflower");
							num++;
						}
						this.item[num].SetDefaults("Acorn");
						num++;
						this.item[num].SetDefaults(114, false);
						num++;
						this.item[num].SetDefaults(745, false);
						num++;
						this.item[num].SetDefaults(747, false);
						num++;
						if (Main.hardMode)
						{
							this.item[num].SetDefaults(746, false);
						}
						num++;
						if (Main.hardMode)
						{
							this.item[num].SetDefaults(369, false);
						}
						num++;
						if (Main.shroomTiles > 50)
						{
							this.item[num].SetDefaults(194, false);
						}
						num++;
					}
					else
					{
						if (type == 4)
						{
							this.item[num].SetDefaults("Grenade");
							num++;
							this.item[num].SetDefaults("Bomb");
							num++;
							this.item[num].SetDefaults("Dynamite");
							num++;
							if (Main.hardMode)
							{
								this.item[num].SetDefaults("Hellfire Arrow");
								num++;
							}
							if (Main.hardMode && NPC.downedGolemBoss && NPC.downedPirates)
							{
								this.item[num].SetDefaults(937, false);
								num++;
							}
							if (Main.hardMode)
							{
								this.item[num].SetDefaults(1347, false);
								num++;
							}
						}
						else
						{
							if (type == 5)
							{
								this.item[num].SetDefaults(254, false);
								num++;
								this.item[num].SetDefaults(981, false);
								num++;
								if (Main.dayTime)
								{
									this.item[num].SetDefaults(242, false);
									num++;
								}
								if (Main.moonPhase == 0)
								{
									this.item[num].SetDefaults(245, false);
									num++;
									this.item[num].SetDefaults(246, false);
									num++;
								}
								else
								{
									if (Main.moonPhase == 1)
									{
										this.item[num].SetDefaults(325, false);
										num++;
										this.item[num].SetDefaults(326, false);
										num++;
									}
								}
								this.item[num].SetDefaults(269, false);
								num++;
								this.item[num].SetDefaults(270, false);
								num++;
								this.item[num].SetDefaults(271, false);
								num++;
								if (NPC.downedClown)
								{
									this.item[num].SetDefaults(503, false);
									num++;
									this.item[num].SetDefaults(504, false);
									num++;
									this.item[num].SetDefaults(505, false);
									num++;
								}
								if (Main.bloodMoon)
								{
									this.item[num].SetDefaults(322, false);
									num++;
								}
								if (Main.player[Main.myPlayer].zoneSnow)
								{
									this.item[num].SetDefaults(1429, false);
								}
								num++;
								if (Main.hardMode)
								{
									if (Main.moonPhase == 2)
									{
										this.item[num].SetDefaults(869, false);
										num++;
									}
									if (Main.moonPhase == 4)
									{
										this.item[num].SetDefaults(864, false);
										num++;
										this.item[num].SetDefaults(865, false);
										num++;
									}
									if (Main.moonPhase == 6)
									{
										this.item[num].SetDefaults(873, false);
										num++;
										this.item[num].SetDefaults(874, false);
										num++;
										this.item[num].SetDefaults(875, false);
										num++;
									}
								}
								if (NPC.downedFrost)
								{
									this.item[num].SetDefaults(1275, false);
									num++;
									this.item[num].SetDefaults(1276, false);
									num++;
								}
							}
							else
							{
								if (type == 6)
								{
									this.item[num].SetDefaults(128, false);
									num++;
									this.item[num].SetDefaults(486, false);
									num++;
									this.item[num].SetDefaults(398, false);
									num++;
									this.item[num].SetDefaults(84, false);
									num++;
									this.item[num].SetDefaults(407, false);
									num++;
									this.item[num].SetDefaults(161, false);
									num++;
								}
								else
								{
									if (type == 7)
									{
										this.item[num].SetDefaults(487, false);
										num++;
										this.item[num].SetDefaults(496, false);
										num++;
										this.item[num].SetDefaults(500, false);
										num++;
										this.item[num].SetDefaults(507, false);
										num++;
										this.item[num].SetDefaults(508, false);
										num++;
										this.item[num].SetDefaults(531, false);
										num++;
										this.item[num].SetDefaults(576, false);
										num++;
									}
									else
									{
										if (type == 8)
										{
											this.item[num].SetDefaults(509, false);
											num++;
											this.item[num].SetDefaults(850, false);
											num++;
											this.item[num].SetDefaults(851, false);
											num++;
											this.item[num].SetDefaults(510, false);
											num++;
											this.item[num].SetDefaults(530, false);
											num++;
											this.item[num].SetDefaults(513, false);
											num++;
											this.item[num].SetDefaults(538, false);
											num++;
											this.item[num].SetDefaults(529, false);
											num++;
											this.item[num].SetDefaults(541, false);
											num++;
											this.item[num].SetDefaults(542, false);
											num++;
											this.item[num].SetDefaults(543, false);
											num++;
											this.item[num].SetDefaults(852, false);
											num++;
											this.item[num].SetDefaults(853, false);
											num++;
											this.item[num].SetDefaults(849, false);
											num++;
										}
										else
										{
											if (type == 9)
											{
												this.item[num].SetDefaults(588, false);
												num++;
												this.item[num].SetDefaults(589, false);
												num++;
												this.item[num].SetDefaults(590, false);
												num++;
												this.item[num].SetDefaults(597, false);
												num++;
												this.item[num].SetDefaults(598, false);
												num++;
												this.item[num].SetDefaults(596, false);
												num++;
											}
											else
											{
												if (type == 10)
												{
													this.item[num].SetDefaults(756, false);
													num++;
													this.item[num].SetDefaults(787, false);
													num++;
													this.item[num].SetDefaults(868, false);
													num++;
													this.item[num].SetDefaults(1551, false);
													num++;
													this.item[num].SetDefaults(1181, false);
													num++;
													this.item[num].SetDefaults(783, false);
													num++;
												}
												else
												{
													if (type == 11)
													{
														this.item[num].SetDefaults(779, false);
														num++;
														if (Main.moonPhase >= 4)
														{
															this.item[num].SetDefaults(748, false);
															num++;
														}
														else
														{
															this.item[num].SetDefaults(839, false);
															num++;
															this.item[num].SetDefaults(840, false);
															num++;
															this.item[num].SetDefaults(841, false);
															num++;
														}
														if (Main.dayTime)
														{
															this.item[num].SetDefaults(998, false);
															num++;
														}
														else
														{
															this.item[num].SetDefaults(995, false);
															num++;
														}
														this.item[num].SetDefaults(1263, false);
														num++;
														if (Main.eclipse || Main.bloodMoon)
														{
															if (WorldGen.crimson)
															{
																this.item[num].SetDefaults(784, false);
																num++;
															}
															else
															{
																this.item[num].SetDefaults(782, false);
																num++;
															}
														}
														else
														{
															if (Main.player[Main.myPlayer].zoneHoly)
															{
																this.item[num].SetDefaults(781, false);
																num++;
															}
															else
															{
																this.item[num].SetDefaults(780, false);
																num++;
															}
														}
														if (Main.hardMode)
														{
															this.item[num].SetDefaults(1344, false);
														}
														num++;
													}
													else
													{
														if (type == 12)
														{
															this.item[num].SetDefaults(1037, false);
															num++;
															this.item[num].SetDefaults(1120, false);
															num++;
														}
														else
														{
															if (type == 13)
															{
																this.item[num].SetDefaults(1000, false);
																num++;
																this.item[num].SetDefaults(1168, false);
																num++;
																this.item[num].SetDefaults(1449, false);
																num++;
																this.item[num].SetDefaults(1345, false);
																num++;
																this.item[num].SetDefaults(1450, false);
																num++;
																if (Main.hardMode)
																{
																	this.item[num].SetDefaults(970, false);
																	num++;
																	this.item[num].SetDefaults(971, false);
																	num++;
																	this.item[num].SetDefaults(972, false);
																	num++;
																	this.item[num].SetDefaults(973, false);
																	num++;
																}
															}
															else
															{
																if (type == 14)
																{
																	this.item[num].SetDefaults(771, false);
																	num++;
																	if (Main.bloodMoon)
																	{
																		this.item[num].SetDefaults(772, false);
																		num++;
																	}
																	if (!Main.dayTime || Main.eclipse)
																	{
																		this.item[num].SetDefaults(773, false);
																		num++;
																	}
																	if (Main.eclipse)
																	{
																		this.item[num].SetDefaults(774, false);
																		num++;
																	}
																	if (Main.hardMode)
																	{
																		this.item[num].SetDefaults(760, false);
																		num++;
																	}
																	if (Main.hardMode)
																	{
																		this.item[num].SetDefaults(1346, false);
																		num++;
																	}
																}
																else
																{
																	if (type == 15)
																	{
																		this.item[num].SetDefaults(1071, false);
																		num++;
																		this.item[num].SetDefaults(1072, false);
																		num++;
																		this.item[num].SetDefaults(1100, false);
																		num++;
																		for (int k = 1073; k <= 1084; k++)
																		{
																			this.item[num].SetDefaults(k, false);
																			num++;
																		}
																		this.item[num].SetDefaults(1097, false);
																		num++;
																		this.item[num].SetDefaults(1099, false);
																		num++;
																		this.item[num].SetDefaults(1098, false);
																		num++;
																		this.item[num].SetDefaults(1490, false);
																		num++;
																		if (Main.moonPhase <= 1)
																		{
																			this.item[num].SetDefaults(1481, false);
																			num++;
																		}
																		else
																		{
																			if (Main.moonPhase <= 3)
																			{
																				this.item[num].SetDefaults(1482, false);
																				num++;
																			}
																			else
																			{
																				if (Main.moonPhase <= 5)
																				{
																					this.item[num].SetDefaults(1483, false);
																					num++;
																				}
																				else
																				{
																					this.item[num].SetDefaults(1484, false);
																					num++;
																				}
																			}
																		}
																		if (Main.player[Main.myPlayer].zoneBlood)
																		{
																			this.item[num].SetDefaults(1492, false);
																			num++;
																		}
																		if (Main.player[Main.myPlayer].zoneEvil)
																		{
																			this.item[num].SetDefaults(1488, false);
																			num++;
																		}
																		if (Main.player[Main.myPlayer].zoneHoly)
																		{
																			this.item[num].SetDefaults(1489, false);
																			num++;
																		}
																		if (Main.player[Main.myPlayer].zoneJungle)
																		{
																			this.item[num].SetDefaults(1486, false);
																			num++;
																		}
																		if (Main.player[Main.myPlayer].zoneSnow)
																		{
																			this.item[num].SetDefaults(1487, false);
																			num++;
																		}
																		if (Main.sandTiles > 1000)
																		{
																			this.item[num].SetDefaults(1491, false);
																			num++;
																		}
																		if (Main.bloodMoon)
																		{
																			this.item[num].SetDefaults(1493, false);
																			num++;
																		}
																		if ((double)(Main.player[Main.myPlayer].position.Y / 16f) < Main.worldSurface * 0.34999999403953552)
																		{
																			this.item[num].SetDefaults(1485, false);
																			num++;
																		}
																		if ((double)(Main.player[Main.myPlayer].position.Y / 16f) < Main.worldSurface * 0.34999999403953552 && Main.hardMode)
																		{
																			this.item[num].SetDefaults(1494, false);
																			num++;
																		}
																	}
																	else
																	{
																		if (type == 16)
																		{
																			this.item[num].SetDefaults(1430, false);
																			num++;
																			this.item[num].SetDefaults(986, false);
																			num++;
																			if (Main.hardMode && NPC.downedPlantBoss)
																			{
																				if (Main.player[Main.myPlayer].HasItem(1157))
																				{
																					this.item[num].SetDefaults(1159, false);
																					num++;
																					this.item[num].SetDefaults(1160, false);
																					num++;
																					this.item[num].SetDefaults(1161, false);
																					num++;
																					if (!Main.dayTime)
																					{
																						this.item[num].SetDefaults(1158, false);
																						num++;
																					}
																					if (Main.player[Main.myPlayer].zoneJungle)
																					{
																						this.item[num].SetDefaults(1167, false);
																						num++;
																					}
																				}
																				this.item[num].SetDefaults(1339, false);
																				num++;
																			}
																			if (Main.hardMode && Main.player[Main.myPlayer].zoneJungle)
																			{
																				this.item[num].SetDefaults(1171, false);
																				num++;
																				if (!Main.dayTime)
																				{
																					this.item[num].SetDefaults(1162, false);
																					num++;
																				}
																			}
																			if (Main.hardMode && NPC.downedGolemBoss)
																			{
																				this.item[num].SetDefaults(909, false);
																				num++;
																				this.item[num].SetDefaults(910, false);
																				num++;
																				this.item[num].SetDefaults(940, false);
																				num++;
																				this.item[num].SetDefaults(941, false);
																				num++;
																				this.item[num].SetDefaults(942, false);
																				num++;
																				this.item[num].SetDefaults(943, false);
																				num++;
																				this.item[num].SetDefaults(944, false);
																				num++;
																				this.item[num].SetDefaults(945, false);
																				num++;
																			}
																			if (Main.player[Main.myPlayer].HasItem(1258))
																			{
																				this.item[num].SetDefaults(1261, false);
																				num++;
																			}
																		}
																		else
																		{
																			if (type == 17)
																			{
																				this.item[num].SetDefaults(928, false);
																				num++;
																				this.item[num].SetDefaults(929, false);
																				num++;
																				this.item[num].SetDefaults(876, false);
																				num++;
																				this.item[num].SetDefaults(877, false);
																				num++;
																				this.item[num].SetDefaults(878, false);
																				num++;
																				int num2 = (int)((Main.screenPosition.X + (float)(Main.screenWidth / 2)) / 16f);
																				if ((double)(Main.screenPosition.Y / 16f) < Main.worldSurface + 10.0 && (num2 < 380 || num2 > Main.maxTilesX - 380))
																				{
																					this.item[num].SetDefaults(1180, false);
																					num++;
																				}
																				if (Main.hardMode && NPC.downedMechBossAny && NPC.AnyNPCs(208))
																				{
																					this.item[num].SetDefaults(1337, false);
																					num++;
																					this.item[num].SetDefaults(1338, false);
																					num++;
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
			if (Main.player[Main.myPlayer].discount)
			{
				for (int l = 0; l < num; l++)
				{
					this.item[l].value = (int)((float)this.item[l].value * 0.8f);
				}
			}
		}
	}
}
