using Microsoft.Xna.Framework;
using System;
namespace Terraria
{
	public class Item
	{
		public static int potionDelay = 3600;
		public static int[] headType = new int[112];
		public static int[] bodyType = new int[75];
		public static int[] legType = new int[64];
		public bool flame;
		public bool mech;
		public bool wet;
		public bool honeyWet;
		public byte wetCount;
		public bool lavaWet;
		public Vector2 position;
		public Vector2 velocity;
		public int width;
		public int height;
		public bool active;
		public int noGrabDelay;
		public bool beingGrabbed;
		public int spawnTime;
		public int tileWand = -1;
		public bool wornArmor;
		public byte dye;
		public byte paint;
		public int ownIgnore = -1;
		public int ownTime;
		public int keepTime;
		public int type;
		public string name;
		public int holdStyle;
		public int useStyle;
		public bool channel;
		public bool accessory;
		public int useAnimation;
		public int useTime;
		public int stack;
		public int maxStack;
		public int pick;
		public int axe;
		public int hammer;
		public int tileBoost;
		public int createTile = -1;
		public int createWall = -1;
		public int placeStyle;
		public int damage;
		public float knockBack;
		public int healLife;
		public int healMana;
		public bool potion;
		public bool consumable;
		public bool autoReuse;
		public bool useTurn;
		public Color color;
		public int alpha;
		public float scale = 1f;
		public int useSound;
		public int defense;
		public int headSlot = -1;
		public int bodySlot = -1;
		public int legSlot = -1;
		public string toolTip;
		public string toolTip2;
		public int owner = 255;
		public int rare;
		public int shoot;
		public float shootSpeed;
		public int ammo;
		public bool notAmmo;
		public int useAmmo;
		public int lifeRegen;
		public int manaIncrease;
		public bool buyOnce;
		public int mana;
		public bool noUseGraphic;
		public bool noMelee;
		public int release;
		public int value;
		public bool buy;
		public bool social;
		public bool vanity;
		public bool material;
		public bool noWet;
		public int buffType;
		public int buffTime;
		public int netID;
		public int crit;
		public byte prefix;
		public bool melee;
		public bool magic;
		public bool ranged;
		public bool summon;
		public int reuseDelay;
		public bool Prefix(int pre)
		{
			if (pre == 0 || this.type == 0)
			{
				return false;
			}
			int num = pre;
			float num2 = 1f;
			float num3 = 1f;
			float num4 = 1f;
			float num5 = 1f;
			float num6 = 1f;
			float num7 = 1f;
			int num8 = 0;
			bool flag = true;
			while (flag)
			{
				num2 = 1f;
				num3 = 1f;
				num4 = 1f;
				num5 = 1f;
				num6 = 1f;
				num7 = 1f;
				num8 = 0;
				flag = false;
				if (num == -1 && Main.rand.Next(4) == 0)
				{
					num = 0;
				}
				if (pre < -1)
				{
					num = -1;
				}
				if (num == -1 || num == -2 || num == -3)
				{
					if (this.type == 1 || this.type == 4 || this.type == 6 || this.type == 7 || this.type == 10 || this.type == 24 || this.type == 45 || this.type == 46 || this.type == 103 || this.type == 104 || this.type == 121 || this.type == 122 || this.type == 155 || this.type == 190 || this.type == 196 || this.type == 198 || this.type == 199 || this.type == 200 || this.type == 201 || this.type == 202 || this.type == 203 || this.type == 204 || this.type == 213 || this.type == 217 || this.type == 273 || this.type == 367 || this.type == 368 || this.type == 426 || this.type == 482 || this.type == 483 || this.type == 484 || this.type == 653 || this.type == 654 || this.type == 656 || this.type == 657 || this.type == 659 || this.type == 660 || this.type == 671 || this.type == 672 || this.type == 674 || this.type == 675 || this.type == 676 || this.type == 723 || this.type == 724 || this.type == 757 || this.type == 776 || this.type == 777 || this.type == 778 || this.type == 787 || this.type == 795 || this.type == 797 || this.type == 798 || this.type == 799 || this.type == 881 || this.type == 882 || this.type == 921 || this.type == 922 || this.type == 989 || this.type == 990 || this.type == 991 || this.type == 992 || this.type == 993 || this.type == 1123 || this.type == 1166 || this.type == 1185 || this.type == 1188 || this.type == 1192 || this.type == 1195 || this.type == 1199 || this.type == 1202 || this.type == 1222 || this.type == 1223 || this.type == 1224 || this.type == 1226 || this.type == 1227 || this.type == 1230 || this.type == 1233 || this.type == 1234 || this.type == 1294 || this.type == 1304 || this.type == 1305 || this.type == 1306 || this.type == 1320 || this.type == 1327 || this.type == 1506 || this.type == 1507)
					{
						int num9 = Main.rand.Next(40);
						if (num9 == 0)
						{
							num = 1;
						}
						if (num9 == 1)
						{
							num = 2;
						}
						if (num9 == 2)
						{
							num = 3;
						}
						if (num9 == 3)
						{
							num = 4;
						}
						if (num9 == 4)
						{
							num = 5;
						}
						if (num9 == 5)
						{
							num = 6;
						}
						if (num9 == 6)
						{
							num = 7;
						}
						if (num9 == 7)
						{
							num = 8;
						}
						if (num9 == 8)
						{
							num = 9;
						}
						if (num9 == 9)
						{
							num = 10;
						}
						if (num9 == 10)
						{
							num = 11;
						}
						if (num9 == 11)
						{
							num = 12;
						}
						if (num9 == 12)
						{
							num = 13;
						}
						if (num9 == 13)
						{
							num = 14;
						}
						if (num9 == 14)
						{
							num = 15;
						}
						if (num9 == 15)
						{
							num = 36;
						}
						if (num9 == 16)
						{
							num = 37;
						}
						if (num9 == 17)
						{
							num = 38;
						}
						if (num9 == 18)
						{
							num = 53;
						}
						if (num9 == 19)
						{
							num = 54;
						}
						if (num9 == 20)
						{
							num = 55;
						}
						if (num9 == 21)
						{
							num = 39;
						}
						if (num9 == 22)
						{
							num = 40;
						}
						if (num9 == 23)
						{
							num = 56;
						}
						if (num9 == 24)
						{
							num = 41;
						}
						if (num9 == 25)
						{
							num = 57;
						}
						if (num9 == 26)
						{
							num = 42;
						}
						if (num9 == 27)
						{
							num = 43;
						}
						if (num9 == 28)
						{
							num = 44;
						}
						if (num9 == 29)
						{
							num = 45;
						}
						if (num9 == 30)
						{
							num = 46;
						}
						if (num9 == 31)
						{
							num = 47;
						}
						if (num9 == 32)
						{
							num = 48;
						}
						if (num9 == 33)
						{
							num = 49;
						}
						if (num9 == 34)
						{
							num = 50;
						}
						if (num9 == 35)
						{
							num = 51;
						}
						if (num9 == 36)
						{
							num = 59;
						}
						if (num9 == 37)
						{
							num = 60;
						}
						if (num9 == 38)
						{
							num = 61;
						}
						if (num9 == 39)
						{
							num = 81;
						}
					}
					else
					{
						if (this.type == 162 || this.type == 160 || this.type == 163 || this.type == 220 || this.type == 274 || this.type == 277 || this.type == 280 || this.type == 383 || this.type == 384 || this.type == 385 || this.type == 386 || this.type == 387 || this.type == 388 || this.type == 389 || this.type == 390 || this.type == 406 || this.type == 537 || this.type == 550 || this.type == 579 || this.type == 756 || this.type == 759 || this.type == 801 || this.type == 802 || this.type == 1186 || this.type == 1189 || this.type == 1190 || this.type == 1193 || this.type == 1196 || this.type == 1197 || this.type == 1200 || this.type == 1203 || this.type == 1204 || this.type == 1228 || this.type == 1231 || this.type == 1232 || this.type == 1259 || this.type == 1262 || this.type == 1297 || this.type == 1314 || this.type == 1325)
						{
							int num10 = Main.rand.Next(14);
							if (num10 == 0)
							{
								num = 36;
							}
							if (num10 == 1)
							{
								num = 37;
							}
							if (num10 == 2)
							{
								num = 38;
							}
							if (num10 == 3)
							{
								num = 53;
							}
							if (num10 == 4)
							{
								num = 54;
							}
							if (num10 == 5)
							{
								num = 55;
							}
							if (num10 == 6)
							{
								num = 39;
							}
							if (num10 == 7)
							{
								num = 40;
							}
							if (num10 == 8)
							{
								num = 56;
							}
							if (num10 == 9)
							{
								num = 41;
							}
							if (num10 == 10)
							{
								num = 57;
							}
							if (num10 == 11)
							{
								num = 59;
							}
							if (num10 == 12)
							{
								num = 60;
							}
							if (num10 == 13)
							{
								num = 61;
							}
						}
						else
						{
							if (this.type == 39 || this.type == 44 || this.type == 95 || this.type == 96 || this.type == 98 || this.type == 99 || this.type == 120 || this.type == 164 || this.type == 197 || this.type == 219 || this.type == 266 || this.type == 281 || this.type == 434 || this.type == 435 || this.type == 436 || this.type == 481 || this.type == 506 || this.type == 533 || this.type == 534 || this.type == 578 || this.type == 655 || this.type == 658 || this.type == 661 || this.type == 679 || this.type == 682 || this.type == 725 || this.type == 758 || this.type == 759 || this.type == 760 || this.type == 796 || this.type == 800 || this.type == 905 || this.type == 964 || this.type == 986 || this.type == 1156 || this.type == 1187 || this.type == 1194 || this.type == 1201 || this.type == 1229 || this.type == 1254 || this.type == 1255 || this.type == 1258 || this.type == 1265 || this.type == 1319 || this.type == 1553)
							{
								int num11 = Main.rand.Next(36);
								if (num11 == 0)
								{
									num = 16;
								}
								if (num11 == 1)
								{
									num = 17;
								}
								if (num11 == 2)
								{
									num = 18;
								}
								if (num11 == 3)
								{
									num = 19;
								}
								if (num11 == 4)
								{
									num = 20;
								}
								if (num11 == 5)
								{
									num = 21;
								}
								if (num11 == 6)
								{
									num = 22;
								}
								if (num11 == 7)
								{
									num = 23;
								}
								if (num11 == 8)
								{
									num = 24;
								}
								if (num11 == 9)
								{
									num = 25;
								}
								if (num11 == 10)
								{
									num = 58;
								}
								if (num11 == 11)
								{
									num = 36;
								}
								if (num11 == 12)
								{
									num = 37;
								}
								if (num11 == 13)
								{
									num = 38;
								}
								if (num11 == 14)
								{
									num = 53;
								}
								if (num11 == 15)
								{
									num = 54;
								}
								if (num11 == 16)
								{
									num = 55;
								}
								if (num11 == 17)
								{
									num = 39;
								}
								if (num11 == 18)
								{
									num = 40;
								}
								if (num11 == 19)
								{
									num = 56;
								}
								if (num11 == 20)
								{
									num = 41;
								}
								if (num11 == 21)
								{
									num = 57;
								}
								if (num11 == 22)
								{
									num = 42;
								}
								if (num11 == 23)
								{
									num = 43;
								}
								if (num11 == 24)
								{
									num = 44;
								}
								if (num11 == 25)
								{
									num = 45;
								}
								if (num11 == 26)
								{
									num = 46;
								}
								if (num11 == 27)
								{
									num = 47;
								}
								if (num11 == 28)
								{
									num = 48;
								}
								if (num11 == 29)
								{
									num = 49;
								}
								if (num11 == 30)
								{
									num = 50;
								}
								if (num11 == 31)
								{
									num = 51;
								}
								if (num11 == 32)
								{
									num = 59;
								}
								if (num11 == 33)
								{
									num = 60;
								}
								if (num11 == 34)
								{
									num = 61;
								}
								if (num11 == 35)
								{
									num = 82;
								}
							}
							else
							{
								if (this.type == 64 || this.type == 65 || this.type == 112 || this.type == 113 || this.type == 127 || this.type == 157 || this.type == 165 || this.type == 218 || this.type == 272 || this.type == 494 || this.type == 495 || this.type == 496 || this.type == 514 || this.type == 517 || this.type == 518 || this.type == 519 || this.type == 683 || this.type == 726 || this.type == 739 || this.type == 740 || this.type == 741 || this.type == 742 || this.type == 743 || this.type == 744 || this.type == 788 || this.type == 1121 || this.type == 1155 || this.type == 1157 || this.type == 1178 || this.type == 1244 || this.type == 1256 || this.type == 1260 || this.type == 1264 || this.type == 1266 || this.type == 1295 || this.type == 1296 || this.type == 1308 || this.type == 1309 || this.type == 1313 || this.type == 1336 || this.type == 1444 || this.type == 1445 || this.type == 1446 || this.type == 1572)
								{
									int num12 = Main.rand.Next(36);
									if (num12 == 0)
									{
										num = 26;
									}
									if (num12 == 1)
									{
										num = 27;
									}
									if (num12 == 2)
									{
										num = 28;
									}
									if (num12 == 3)
									{
										num = 29;
									}
									if (num12 == 4)
									{
										num = 30;
									}
									if (num12 == 5)
									{
										num = 31;
									}
									if (num12 == 6)
									{
										num = 32;
									}
									if (num12 == 7)
									{
										num = 33;
									}
									if (num12 == 8)
									{
										num = 34;
									}
									if (num12 == 9)
									{
										num = 35;
									}
									if (num12 == 10)
									{
										num = 52;
									}
									if (num12 == 11)
									{
										num = 36;
									}
									if (num12 == 12)
									{
										num = 37;
									}
									if (num12 == 13)
									{
										num = 38;
									}
									if (num12 == 14)
									{
										num = 53;
									}
									if (num12 == 15)
									{
										num = 54;
									}
									if (num12 == 16)
									{
										num = 55;
									}
									if (num12 == 17)
									{
										num = 39;
									}
									if (num12 == 18)
									{
										num = 40;
									}
									if (num12 == 19)
									{
										num = 56;
									}
									if (num12 == 20)
									{
										num = 41;
									}
									if (num12 == 21)
									{
										num = 57;
									}
									if (num12 == 22)
									{
										num = 42;
									}
									if (num12 == 23)
									{
										num = 43;
									}
									if (num12 == 24)
									{
										num = 44;
									}
									if (num12 == 25)
									{
										num = 45;
									}
									if (num12 == 26)
									{
										num = 46;
									}
									if (num12 == 27)
									{
										num = 47;
									}
									if (num12 == 28)
									{
										num = 48;
									}
									if (num12 == 29)
									{
										num = 49;
									}
									if (num12 == 30)
									{
										num = 50;
									}
									if (num12 == 31)
									{
										num = 51;
									}
									if (num12 == 32)
									{
										num = 59;
									}
									if (num12 == 33)
									{
										num = 60;
									}
									if (num12 == 34)
									{
										num = 61;
									}
									if (num12 == 35)
									{
										num = 83;
									}
								}
								else
								{
									if (this.type == 55 || this.type == 119 || this.type == 191 || this.type == 284 || this.type == 670 || this.type == 1122 || this.type == 1513 || this.type == 1569 || this.type == 1571)
									{
										int num13 = Main.rand.Next(14);
										if (num13 == 0)
										{
											num = 36;
										}
										if (num13 == 1)
										{
											num = 37;
										}
										if (num13 == 2)
										{
											num = 38;
										}
										if (num13 == 3)
										{
											num = 53;
										}
										if (num13 == 4)
										{
											num = 54;
										}
										if (num13 == 5)
										{
											num = 55;
										}
										if (num13 == 6)
										{
											num = 39;
										}
										if (num13 == 7)
										{
											num = 40;
										}
										if (num13 == 8)
										{
											num = 56;
										}
										if (num13 == 9)
										{
											num = 41;
										}
										if (num13 == 10)
										{
											num = 57;
										}
										if (num13 == 11)
										{
											num = 59;
										}
										if (num13 == 12)
										{
											num = 60;
										}
										if (num13 == 13)
										{
											num = 61;
										}
									}
									else
									{
										if (!this.accessory || this.type == 267 || this.type == 562 || this.type == 563 || this.type == 564 || this.type == 565 || this.type == 566 || this.type == 567 || this.type == 568 || this.type == 569 || this.type == 570 || this.type == 571 || this.type == 572 || this.type == 573 || this.type == 574 || this.type == 576 || this.type == 1307)
										{
											return false;
										}
										num = Main.rand.Next(62, 81);
									}
								}
							}
						}
					}
				}
				if (pre == -3)
				{
					return true;
				}
				if (pre == -1 && (num == 7 || num == 8 || num == 9 || num == 10 || num == 11 || num == 22 || num == 23 || num == 24 || num == 29 || num == 30 || num == 31 || num == 39 || num == 40 || num == 56 || num == 41 || num == 47 || num == 48 || num == 49) && Main.rand.Next(3) != 0)
				{
					num = 0;
				}
				if (num == 1)
				{
					num5 = 1.12f;
				}
				else
				{
					if (num == 2)
					{
						num5 = 1.18f;
					}
					else
					{
						if (num == 3)
						{
							num2 = 1.05f;
							num8 = 2;
							num5 = 1.05f;
						}
						else
						{
							if (num == 4)
							{
								num2 = 1.1f;
								num5 = 1.1f;
								num3 = 1.1f;
							}
							else
							{
								if (num == 5)
								{
									num2 = 1.15f;
								}
								else
								{
									if (num == 6)
									{
										num2 = 1.1f;
									}
									else
									{
										if (num == 81)
										{
											num3 = 1.15f;
											num2 = 1.15f;
											num8 = 5;
											num4 = 0.9f;
											num5 = 1.1f;
										}
										else
										{
											if (num == 7)
											{
												num5 = 0.82f;
											}
											else
											{
												if (num == 8)
												{
													num3 = 0.85f;
													num2 = 0.85f;
													num5 = 0.87f;
												}
												else
												{
													if (num == 9)
													{
														num5 = 0.9f;
													}
													else
													{
														if (num == 10)
														{
															num2 = 0.85f;
														}
														else
														{
															if (num == 11)
															{
																num4 = 1.1f;
																num3 = 0.9f;
																num5 = 0.9f;
															}
															else
															{
																if (num == 12)
																{
																	num3 = 1.1f;
																	num2 = 1.05f;
																	num5 = 1.1f;
																	num4 = 1.15f;
																}
																else
																{
																	if (num == 13)
																	{
																		num3 = 0.8f;
																		num2 = 0.9f;
																		num5 = 1.1f;
																	}
																	else
																	{
																		if (num == 14)
																		{
																			num3 = 1.15f;
																			num4 = 1.1f;
																		}
																		else
																		{
																			if (num == 15)
																			{
																				num3 = 0.9f;
																				num4 = 0.85f;
																			}
																			else
																			{
																				if (num == 16)
																				{
																					num2 = 1.1f;
																					num8 = 3;
																				}
																				else
																				{
																					if (num == 17)
																					{
																						num4 = 0.85f;
																						num6 = 1.1f;
																					}
																					else
																					{
																						if (num == 18)
																						{
																							num4 = 0.9f;
																							num6 = 1.15f;
																						}
																						else
																						{
																							if (num == 19)
																							{
																								num3 = 1.15f;
																								num6 = 1.05f;
																							}
																							else
																							{
																								if (num == 20)
																								{
																									num3 = 1.05f;
																									num6 = 1.05f;
																									num2 = 1.1f;
																									num4 = 0.95f;
																									num8 = 2;
																								}
																								else
																								{
																									if (num == 21)
																									{
																										num3 = 1.15f;
																										num2 = 1.1f;
																									}
																									else
																									{
																										if (num == 82)
																										{
																											num3 = 1.15f;
																											num2 = 1.15f;
																											num8 = 5;
																											num4 = 0.9f;
																											num6 = 1.1f;
																										}
																										else
																										{
																											if (num == 22)
																											{
																												num3 = 0.9f;
																												num6 = 0.9f;
																												num2 = 0.85f;
																											}
																											else
																											{
																												if (num == 23)
																												{
																													num4 = 1.15f;
																													num6 = 0.9f;
																												}
																												else
																												{
																													if (num == 24)
																													{
																														num4 = 1.1f;
																														num3 = 0.8f;
																													}
																													else
																													{
																														if (num == 25)
																														{
																															num4 = 1.1f;
																															num2 = 1.15f;
																															num8 = 1;
																														}
																														else
																														{
																															if (num == 58)
																															{
																																num4 = 0.85f;
																																num2 = 0.85f;
																															}
																															else
																															{
																																if (num == 26)
																																{
																																	num7 = 0.85f;
																																	num2 = 1.1f;
																																}
																																else
																																{
																																	if (num == 27)
																																	{
																																		num7 = 0.85f;
																																	}
																																	else
																																	{
																																		if (num == 28)
																																		{
																																			num7 = 0.85f;
																																			num2 = 1.15f;
																																			num3 = 1.05f;
																																		}
																																		else
																																		{
																																			if (num == 83)
																																			{
																																				num3 = 1.15f;
																																				num2 = 1.15f;
																																				num8 = 5;
																																				num4 = 0.9f;
																																				num7 = 0.9f;
																																			}
																																			else
																																			{
																																				if (num == 29)
																																				{
																																					num7 = 1.1f;
																																				}
																																				else
																																				{
																																					if (num == 30)
																																					{
																																						num7 = 1.2f;
																																						num2 = 0.9f;
																																					}
																																					else
																																					{
																																						if (num == 31)
																																						{
																																							num3 = 0.9f;
																																							num2 = 0.9f;
																																						}
																																						else
																																						{
																																							if (num == 32)
																																							{
																																								num7 = 1.15f;
																																								num2 = 1.1f;
																																							}
																																							else
																																							{
																																								if (num == 33)
																																								{
																																									num7 = 1.1f;
																																									num3 = 1.1f;
																																									num4 = 0.9f;
																																								}
																																								else
																																								{
																																									if (num == 34)
																																									{
																																										num7 = 0.9f;
																																										num3 = 1.1f;
																																										num4 = 1.1f;
																																										num2 = 1.1f;
																																									}
																																									else
																																									{
																																										if (num == 35)
																																										{
																																											num7 = 1.2f;
																																											num2 = 1.15f;
																																											num3 = 1.15f;
																																										}
																																										else
																																										{
																																											if (num == 52)
																																											{
																																												num7 = 0.9f;
																																												num2 = 0.9f;
																																												num4 = 0.9f;
																																											}
																																											else
																																											{
																																												if (num == 36)
																																												{
																																													num8 = 3;
																																												}
																																												else
																																												{
																																													if (num == 37)
																																													{
																																														num2 = 1.1f;
																																														num8 = 3;
																																														num3 = 1.1f;
																																													}
																																													else
																																													{
																																														if (num == 38)
																																														{
																																															num3 = 1.15f;
																																														}
																																														else
																																														{
																																															if (num == 53)
																																															{
																																																num2 = 1.1f;
																																															}
																																															else
																																															{
																																																if (num == 54)
																																																{
																																																	num3 = 1.15f;
																																																}
																																																else
																																																{
																																																	if (num == 55)
																																																	{
																																																		num3 = 1.15f;
																																																		num2 = 1.05f;
																																																	}
																																																	else
																																																	{
																																																		if (num == 59)
																																																		{
																																																			num3 = 1.15f;
																																																			num2 = 1.15f;
																																																			num8 = 5;
																																																		}
																																																		else
																																																		{
																																																			if (num == 60)
																																																			{
																																																				num2 = 1.15f;
																																																				num8 = 5;
																																																			}
																																																			else
																																																			{
																																																				if (num == 61)
																																																				{
																																																					num8 = 5;
																																																				}
																																																				else
																																																				{
																																																					if (num == 39)
																																																					{
																																																						num2 = 0.7f;
																																																						num3 = 0.8f;
																																																					}
																																																					else
																																																					{
																																																						if (num == 40)
																																																						{
																																																							num2 = 0.85f;
																																																						}
																																																						else
																																																						{
																																																							if (num == 56)
																																																							{
																																																								num3 = 0.8f;
																																																							}
																																																							else
																																																							{
																																																								if (num == 41)
																																																								{
																																																									num3 = 0.85f;
																																																									num2 = 0.9f;
																																																								}
																																																								else
																																																								{
																																																									if (num == 57)
																																																									{
																																																										num3 = 0.9f;
																																																										num2 = 1.18f;
																																																									}
																																																									else
																																																									{
																																																										if (num == 42)
																																																										{
																																																											num4 = 0.9f;
																																																										}
																																																										else
																																																										{
																																																											if (num == 43)
																																																											{
																																																												num2 = 1.1f;
																																																												num4 = 0.9f;
																																																											}
																																																											else
																																																											{
																																																												if (num == 44)
																																																												{
																																																													num4 = 0.9f;
																																																													num8 = 3;
																																																												}
																																																												else
																																																												{
																																																													if (num == 45)
																																																													{
																																																														num4 = 0.95f;
																																																													}
																																																													else
																																																													{
																																																														if (num == 46)
																																																														{
																																																															num8 = 3;
																																																															num4 = 0.94f;
																																																															num2 = 1.07f;
																																																														}
																																																														else
																																																														{
																																																															if (num == 47)
																																																															{
																																																																num4 = 1.15f;
																																																															}
																																																															else
																																																															{
																																																																if (num == 48)
																																																																{
																																																																	num4 = 1.2f;
																																																																}
																																																																else
																																																																{
																																																																	if (num == 49)
																																																																	{
																																																																		num4 = 1.08f;
																																																																	}
																																																																	else
																																																																	{
																																																																		if (num == 50)
																																																																		{
																																																																			num2 = 0.8f;
																																																																			num4 = 1.15f;
																																																																		}
																																																																		else
																																																																		{
																																																																			if (num == 51)
																																																																			{
																																																																				num3 = 0.9f;
																																																																				num4 = 0.9f;
																																																																				num2 = 1.05f;
																																																																				num8 = 2;
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
				if (num2 != 1f && Math.Round((double)((float)this.damage * num2)) == (double)this.damage)
				{
					flag = true;
					num = -1;
				}
				if (num4 != 1f && Math.Round((double)((float)this.useAnimation * num4)) == (double)this.useAnimation)
				{
					flag = true;
					num = -1;
				}
				if (num7 != 1f && Math.Round((double)((float)this.mana * num7)) == (double)this.mana)
				{
					flag = true;
					num = -1;
				}
				if (num3 != 1f && this.knockBack == 0f)
				{
					flag = true;
					num = -1;
				}
				if (pre == -2 && num == 0)
				{
					num = -1;
					flag = true;
				}
			}
			this.damage = (int)Math.Round((double)((float)this.damage * num2));
			this.useAnimation = (int)Math.Round((double)((float)this.useAnimation * num4));
			this.useTime = (int)Math.Round((double)((float)this.useTime * num4));
			this.reuseDelay = (int)Math.Round((double)((float)this.reuseDelay * num4));
			this.mana = (int)Math.Round((double)((float)this.mana * num7));
			this.knockBack *= num3;
			this.scale *= num5;
			this.shootSpeed *= num6;
			this.crit += num8;
			float num14 = 1f * num2 * (2f - num4) * (2f - num7) * num5 * num3 * num6 * (1f + (float)this.crit * 0.02f);
			if (num == 62 || num == 69 || num == 73 || num == 77)
			{
				num14 *= 1.05f;
			}
			if (num == 63 || num == 70 || num == 74 || num == 78 || num == 67)
			{
				num14 *= 1.1f;
			}
			if (num == 64 || num == 71 || num == 75 || num == 79 || num == 66)
			{
				num14 *= 1.15f;
			}
			if (num == 65 || num == 72 || num == 76 || num == 80 || num == 68)
			{
				num14 *= 1.2f;
			}
			if ((double)num14 >= 1.2)
			{
				this.rare += 2;
			}
			else
			{
				if ((double)num14 >= 1.05)
				{
					this.rare++;
				}
				else
				{
					if ((double)num14 <= 0.8)
					{
						this.rare -= 2;
					}
					else
					{
						if ((double)num14 <= 0.95)
						{
							this.rare--;
						}
					}
				}
			}
			if (this.rare < -1)
			{
				this.rare = -1;
			}
			if (this.rare > 9)
			{
				this.rare = 9;
			}
			num14 *= num14;
			this.value = (int)((float)this.value * num14);
			this.prefix = (byte)num;
			return true;
		}
		public string AffixName()
		{
			string text = "";
			if (Lang.lang <= 1)
			{
				if (this.prefix == 1)
				{
					text = "Large";
				}
				if (this.prefix == 2)
				{
					text = "Massive";
				}
				if (this.prefix == 3)
				{
					text = "Dangerous";
				}
				if (this.prefix == 4)
				{
					text = "Savage";
				}
				if (this.prefix == 5)
				{
					text = "Sharp";
				}
				if (this.prefix == 6)
				{
					text = "Pointy";
				}
				if (this.prefix == 7)
				{
					text = "Tiny";
				}
				if (this.prefix == 8)
				{
					text = "Terrible";
				}
				if (this.prefix == 9)
				{
					text = "Small";
				}
				if (this.prefix == 10)
				{
					text = "Dull";
				}
				if (this.prefix == 11)
				{
					text = "Unhappy";
				}
				if (this.prefix == 12)
				{
					text = "Bulky";
				}
				if (this.prefix == 13)
				{
					text = "Shameful";
				}
				if (this.prefix == 14)
				{
					text = "Heavy";
				}
				if (this.prefix == 15)
				{
					text = "Light";
				}
				if (this.prefix == 16)
				{
					text = "Sighted";
				}
				if (this.prefix == 17)
				{
					text = "Rapid";
				}
				if (this.prefix == 18)
				{
					text = "Hasty";
				}
				if (this.prefix == 19)
				{
					text = "Intimidating";
				}
				if (this.prefix == 20)
				{
					text = "Deadly";
				}
				if (this.prefix == 21)
				{
					text = "Staunch";
				}
				if (this.prefix == 22)
				{
					text = "Awful";
				}
				if (this.prefix == 23)
				{
					text = "Lethargic";
				}
				if (this.prefix == 24)
				{
					text = "Awkward";
				}
				if (this.prefix == 25)
				{
					text = "Powerful";
				}
				if (this.prefix == 58)
				{
					text = "Frenzying";
				}
				if (this.prefix == 26)
				{
					text = "Mystic";
				}
				if (this.prefix == 27)
				{
					text = "Adept";
				}
				if (this.prefix == 28)
				{
					text = "Masterful";
				}
				if (this.prefix == 29)
				{
					text = "Inept";
				}
				if (this.prefix == 30)
				{
					text = "Ignorant";
				}
				if (this.prefix == 31)
				{
					text = "Deranged";
				}
				if (this.prefix == 32)
				{
					text = "Intense";
				}
				if (this.prefix == 33)
				{
					text = "Taboo";
				}
				if (this.prefix == 34)
				{
					text = "Celestial";
				}
				if (this.prefix == 35)
				{
					text = "Furious";
				}
				if (this.prefix == 52)
				{
					text = "Manic";
				}
				if (this.prefix == 36)
				{
					text = "Keen";
				}
				if (this.prefix == 37)
				{
					text = "Superior";
				}
				if (this.prefix == 38)
				{
					text = "Forceful";
				}
				if (this.prefix == 53)
				{
					text = "Hurtful";
				}
				if (this.prefix == 54)
				{
					text = "Strong";
				}
				if (this.prefix == 55)
				{
					text = "Unpleasant";
				}
				if (this.prefix == 39)
				{
					text = "Broken";
				}
				if (this.prefix == 40)
				{
					text = "Damaged";
				}
				if (this.prefix == 56)
				{
					text = "Weak";
				}
				if (this.prefix == 41)
				{
					text = "Shoddy";
				}
				if (this.prefix == 57)
				{
					text = "Ruthless";
				}
				if (this.prefix == 42)
				{
					text = "Quick";
				}
				if (this.prefix == 43)
				{
					text = "Deadly";
				}
				if (this.prefix == 44)
				{
					text = "Agile";
				}
				if (this.prefix == 45)
				{
					text = "Nimble";
				}
				if (this.prefix == 46)
				{
					text = "Murderous";
				}
				if (this.prefix == 47)
				{
					text = "Slow";
				}
				if (this.prefix == 48)
				{
					text = "Sluggish";
				}
				if (this.prefix == 49)
				{
					text = "Lazy";
				}
				if (this.prefix == 50)
				{
					text = "Annoying";
				}
				if (this.prefix == 51)
				{
					text = "Nasty";
				}
				if (this.prefix == 59)
				{
					text = "Godly";
				}
				if (this.prefix == 60)
				{
					text = "Demonic";
				}
				if (this.prefix == 61)
				{
					text = "Zealous";
				}
				if (this.prefix == 62)
				{
					text = "Hard";
				}
				if (this.prefix == 63)
				{
					text = "Guarding";
				}
				if (this.prefix == 64)
				{
					text = "Armored";
				}
				if (this.prefix == 65)
				{
					text = "Warding";
				}
				if (this.prefix == 66)
				{
					text = "Arcane";
				}
				if (this.prefix == 67)
				{
					text = "Precise";
				}
				if (this.prefix == 68)
				{
					text = "Lucky";
				}
				if (this.prefix == 69)
				{
					text = "Jagged";
				}
				if (this.prefix == 70)
				{
					text = "Spiked";
				}
				if (this.prefix == 71)
				{
					text = "Angry";
				}
				if (this.prefix == 72)
				{
					text = "Menacing";
				}
				if (this.prefix == 73)
				{
					text = "Brisk";
				}
				if (this.prefix == 74)
				{
					text = "Fleeting";
				}
				if (this.prefix == 75)
				{
					text = "Hasty";
				}
				if (this.prefix == 76)
				{
					text = "Quick";
				}
				if (this.prefix == 77)
				{
					text = "Wild";
				}
				if (this.prefix == 78)
				{
					text = "Rash";
				}
				if (this.prefix == 79)
				{
					text = "Intrepid";
				}
				if (this.prefix == 80)
				{
					text = "Violent";
				}
				if (this.prefix == 81)
				{
					text = "Legendary";
				}
				if (this.prefix == 82)
				{
					text = "Unreal";
				}
				if (this.prefix == 83)
				{
					text = "Mythical";
				}
			}
			else
			{
				if (Lang.lang == 2)
				{
					if (this.prefix == 1)
					{
						text = "Gross";
					}
					if (this.prefix == 2)
					{
						text = "Massiv";
					}
					if (this.prefix == 3)
					{
						text = "Gefährlich";
					}
					if (this.prefix == 4)
					{
						text = "Barbarisch";
					}
					if (this.prefix == 5)
					{
						text = "Scharf";
					}
					if (this.prefix == 6)
					{
						text = "Spitze";
					}
					if (this.prefix == 7)
					{
						text = "Winzig";
					}
					if (this.prefix == 8)
					{
						text = "Schrecklicher";
					}
					if (this.prefix == 9)
					{
						text = "Klein";
					}
					if (this.prefix == 10)
					{
						text = "Stumpf";
					}
					if (this.prefix == 11)
					{
						text = "Unglücklich";
					}
					if (this.prefix == 12)
					{
						text = "Sperrig";
					}
					if (this.prefix == 13)
					{
						text = "Beschämend";
					}
					if (this.prefix == 14)
					{
						text = "Schwer";
					}
					if (this.prefix == 15)
					{
						text = "Locker";
					}
					if (this.prefix == 16)
					{
						text = "Gesichtet";
					}
					if (this.prefix == 17)
					{
						text = "Schnell";
					}
					if (this.prefix == 18)
					{
						text = "Hastig";
					}
					if (this.prefix == 19)
					{
						text = "Einschüchternd";
					}
					if (this.prefix == 20)
					{
						text = "Tödlich";
					}
					if (this.prefix == 21)
					{
						text = "Stillen";
					}
					if (this.prefix == 22)
					{
						text = "Schrecklich";
					}
					if (this.prefix == 23)
					{
						text = "Lethargisch";
					}
					if (this.prefix == 24)
					{
						text = "Unbeholfen";
					}
					if (this.prefix == 25)
					{
						text = "Mächtig";
					}
					if (this.prefix == 26)
					{
						text = "Mystisch";
					}
					if (this.prefix == 27)
					{
						text = "Geschickt";
					}
					if (this.prefix == 28)
					{
						text = "Meisterhaft";
					}
					if (this.prefix == 29)
					{
						text = "Ungeschickt";
					}
					if (this.prefix == 30)
					{
						text = "Unwissend";
					}
					if (this.prefix == 31)
					{
						text = "Gestört";
					}
					if (this.prefix == 32)
					{
						text = "Intensiv";
					}
					if (this.prefix == 33)
					{
						text = "Tabu";
					}
					if (this.prefix == 34)
					{
						text = "Himmlisch";
					}
					if (this.prefix == 35)
					{
						text = "Wütend";
					}
					if (this.prefix == 36)
					{
						text = "Scharf";
					}
					if (this.prefix == 37)
					{
						text = "Überlegen";
					}
					if (this.prefix == 38)
					{
						text = "Kraftvoll";
					}
					if (this.prefix == 39)
					{
						text = "Gebrochen";
					}
					if (this.prefix == 40)
					{
						text = "Beschädigt";
					}
					if (this.prefix == 41)
					{
						text = "Schäbig";
					}
					if (this.prefix == 42)
					{
						text = "Rasch";
					}
					if (this.prefix == 43)
					{
						text = "Tödlich";
					}
					if (this.prefix == 44)
					{
						text = "Agil";
					}
					if (this.prefix == 45)
					{
						text = "Wendig";
					}
					if (this.prefix == 46)
					{
						text = "Mörderisch";
					}
					if (this.prefix == 47)
					{
						text = "Langsam";
					}
					if (this.prefix == 48)
					{
						text = "Träge";
					}
					if (this.prefix == 49)
					{
						text = "Faul";
					}
					if (this.prefix == 50)
					{
						text = "Lästig";
					}
					if (this.prefix == 51)
					{
						text = "Böse";
					}
					if (this.prefix == 52)
					{
						text = "Manisch";
					}
					if (this.prefix == 53)
					{
						text = "Verletzend";
					}
					if (this.prefix == 54)
					{
						text = "Stark";
					}
					if (this.prefix == 55)
					{
						text = "Unangenehm";
					}
					if (this.prefix == 56)
					{
						text = "Schwach";
					}
					if (this.prefix == 57)
					{
						text = "Rücksichtslos";
					}
					if (this.prefix == 58)
					{
						text = "Rasend";
					}
					if (this.prefix == 59)
					{
						text = "Fromm";
					}
					if (this.prefix == 60)
					{
						text = "Dämonisch";
					}
					if (this.prefix == 61)
					{
						text = "Eifrig";
					}
					if (this.prefix == 62)
					{
						text = "Schwer";
					}
					if (this.prefix == 63)
					{
						text = "Schutz-";
					}
					if (this.prefix == 64)
					{
						text = "Gepanzert";
					}
					if (this.prefix == 65)
					{
						text = "Defensiv";
					}
					if (this.prefix == 66)
					{
						text = "Geheimnisvoll";
					}
					if (this.prefix == 67)
					{
						text = "Präzise";
					}
					if (this.prefix == 68)
					{
						text = "Glücklich";
					}
					if (this.prefix == 69)
					{
						text = "Gezackt";
					}
					if (this.prefix == 70)
					{
						text = "Spike";
					}
					if (this.prefix == 71)
					{
						text = "Wütend";
					}
					if (this.prefix == 72)
					{
						text = "Bedrohlich";
					}
					if (this.prefix == 73)
					{
						text = "Rege";
					}
					if (this.prefix == 74)
					{
						text = "Flüchtig";
					}
					if (this.prefix == 75)
					{
						text = "Hastig";
					}
					if (this.prefix == 76)
					{
						text = "Rasch";
					}
					if (this.prefix == 77)
					{
						text = "Wild";
					}
					if (this.prefix == 78)
					{
						text = "Voreilig";
					}
					if (this.prefix == 79)
					{
						text = "Unerschrocken";
					}
					if (this.prefix == 80)
					{
						text = "Gewalttätig";
					}
					if (this.prefix == 81)
					{
						text = "Legendär";
					}
					if (this.prefix == 82)
					{
						text = "Unwirklich";
					}
					if (this.prefix == 83)
					{
						text = "Mythisch";
					}
				}
				else
				{
					if (Lang.lang == 3)
					{
						if (this.prefix == 1)
						{
							text = "Grande";
						}
						if (this.prefix == 2)
						{
							text = "Massiccio";
						}
						if (this.prefix == 3)
						{
							text = "Pericoloso";
						}
						if (this.prefix == 4)
						{
							text = "Selvaggio";
						}
						if (this.prefix == 5)
						{
							text = "Appuntito";
						}
						if (this.prefix == 6)
						{
							text = "Tagliente";
						}
						if (this.prefix == 7)
						{
							text = "Minuto";
						}
						if (this.prefix == 8)
						{
							text = "Terribile";
						}
						if (this.prefix == 9)
						{
							text = "Piccolo";
						}
						if (this.prefix == 10)
						{
							text = "Opaco";
						}
						if (this.prefix == 11)
						{
							text = "Infelice";
						}
						if (this.prefix == 12)
						{
							text = "Ingombrante";
						}
						if (this.prefix == 13)
						{
							text = "Vergognoso";
						}
						if (this.prefix == 14)
						{
							text = "Pesante";
						}
						if (this.prefix == 15)
						{
							text = "Luce";
						}
						if (this.prefix == 16)
						{
							text = "Avvistato";
						}
						if (this.prefix == 17)
						{
							text = "Rapido";
						}
						if (this.prefix == 18)
						{
							text = "Frettoloso";
						}
						if (this.prefix == 19)
						{
							text = "Intimidatorio";
						}
						if (this.prefix == 20)
						{
							text = "Mortale";
						}
						if (this.prefix == 21)
						{
							text = "Convinto";
						}
						if (this.prefix == 22)
						{
							text = "Orribile";
						}
						if (this.prefix == 23)
						{
							text = "Letargico";
						}
						if (this.prefix == 24)
						{
							text = "Scomodo";
						}
						if (this.prefix == 25)
						{
							text = "Potente";
						}
						if (this.prefix == 26)
						{
							text = "Mistico";
						}
						if (this.prefix == 27)
						{
							text = "Esperto";
						}
						if (this.prefix == 28)
						{
							text = "Magistrale";
						}
						if (this.prefix == 29)
						{
							text = "Inetto";
						}
						if (this.prefix == 30)
						{
							text = "Ignorante";
						}
						if (this.prefix == 31)
						{
							text = "Squilibrato";
						}
						if (this.prefix == 32)
						{
							text = "Intenso";
						}
						if (this.prefix == 33)
						{
							text = "Tabù";
						}
						if (this.prefix == 34)
						{
							text = "Celeste";
						}
						if (this.prefix == 35)
						{
							text = "Furioso";
						}
						if (this.prefix == 36)
						{
							text = "Appassionato";
						}
						if (this.prefix == 37)
						{
							text = "Superiore";
						}
						if (this.prefix == 38)
						{
							text = "Forte";
						}
						if (this.prefix == 39)
						{
							text = "Rotto";
						}
						if (this.prefix == 40)
						{
							text = "Danneggiato";
						}
						if (this.prefix == 41)
						{
							text = "Scadente";
						}
						if (this.prefix == 42)
						{
							text = "Veloce";
						}
						if (this.prefix == 43)
						{
							text = "Mortale";
						}
						if (this.prefix == 44)
						{
							text = "Agile";
						}
						if (this.prefix == 45)
						{
							text = "Lesto";
						}
						if (this.prefix == 46)
						{
							text = "Omicida";
						}
						if (this.prefix == 47)
						{
							text = "Lento";
						}
						if (this.prefix == 48)
						{
							text = "Pigro";
						}
						if (this.prefix == 49)
						{
							text = "Indolente";
						}
						if (this.prefix == 50)
						{
							text = "Fastidioso";
						}
						if (this.prefix == 51)
						{
							text = "Brutto";
						}
						if (this.prefix == 52)
						{
							text = "Maniaco";
						}
						if (this.prefix == 53)
						{
							text = "Offensivo";
						}
						if (this.prefix == 54)
						{
							text = "Robusto";
						}
						if (this.prefix == 55)
						{
							text = "Sgradevole";
						}
						if (this.prefix == 56)
						{
							text = "Debole";
						}
						if (this.prefix == 57)
						{
							text = "Spietato";
						}
						if (this.prefix == 58)
						{
							text = "Frenetico";
						}
						if (this.prefix == 59)
						{
							text = "Devoto";
						}
						if (this.prefix == 60)
						{
							text = "Demonico";
						}
						if (this.prefix == 61)
						{
							text = "Zelante";
						}
						if (this.prefix == 62)
						{
							text = "Duro";
						}
						if (this.prefix == 63)
						{
							text = "Protettivo";
						}
						if (this.prefix == 64)
						{
							text = "Corazzato";
						}
						if (this.prefix == 65)
						{
							text = "Difensivo";
						}
						if (this.prefix == 66)
						{
							text = "Arcano";
						}
						if (this.prefix == 67)
						{
							text = "Preciso";
						}
						if (this.prefix == 68)
						{
							text = "Fortunato";
						}
						if (this.prefix == 69)
						{
							text = "Frastagliato";
						}
						if (this.prefix == 70)
						{
							text = "Spillo";
						}
						if (this.prefix == 71)
						{
							text = "Arrabbiato";
						}
						if (this.prefix == 72)
						{
							text = "Minaccioso";
						}
						if (this.prefix == 73)
						{
							text = "Vivace";
						}
						if (this.prefix == 74)
						{
							text = "Fugace";
						}
						if (this.prefix == 75)
						{
							text = "Frettoloso";
						}
						if (this.prefix == 76)
						{
							text = "Veloce";
						}
						if (this.prefix == 77)
						{
							text = "Selvaggio";
						}
						if (this.prefix == 78)
						{
							text = "Temerario";
						}
						if (this.prefix == 79)
						{
							text = "Intrepido";
						}
						if (this.prefix == 80)
						{
							text = "Violento";
						}
						if (this.prefix == 81)
						{
							text = "Leggendario";
						}
						if (this.prefix == 82)
						{
							text = "Irreale";
						}
						if (this.prefix == 83)
						{
							text = "Mitico";
						}
					}
					else
					{
						if (Lang.lang == 4)
						{
							if (this.prefix == 1)
							{
								text = "Grand";
							}
							if (this.prefix == 2)
							{
								text = "Massif";
							}
							if (this.prefix == 3)
							{
								text = "Dangereuses";
							}
							if (this.prefix == 4)
							{
								text = "Sauvages";
							}
							if (this.prefix == 5)
							{
								text = "Coupante";
							}
							if (this.prefix == 6)
							{
								text = "Pointues";
							}
							if (this.prefix == 7)
							{
								text = "Minuscules";
							}
							if (this.prefix == 8)
							{
								text = "Terrible";
							}
							if (this.prefix == 9)
							{
								text = "Petit";
							}
							if (this.prefix == 10)
							{
								text = "Terne";
							}
							if (this.prefix == 11)
							{
								text = "Malheureux";
							}
							if (this.prefix == 12)
							{
								text = "Volumineux";
							}
							if (this.prefix == 13)
							{
								text = "Honteux";
							}
							if (this.prefix == 14)
							{
								text = "Lourds";
							}
							if (this.prefix == 15)
							{
								text = "Léger";
							}
							if (this.prefix == 16)
							{
								text = "Voyants";
							}
							if (this.prefix == 17)
							{
								text = "Rapide";
							}
							if (this.prefix == 18)
							{
								text = "Hâtif";
							}
							if (this.prefix == 19)
							{
								text = "Intimidant";
							}
							if (this.prefix == 20)
							{
								text = "Mortelle";
							}
							if (this.prefix == 21)
							{
								text = "Dévoué";
							}
							if (this.prefix == 22)
							{
								text = "Affreux";
							}
							if (this.prefix == 23)
							{
								text = "Léthargique";
							}
							if (this.prefix == 24)
							{
								text = "Scomodo";
							}
							if (this.prefix == 25)
							{
								text = "Puissante";
							}
							if (this.prefix == 26)
							{
								text = "Mystique";
							}
							if (this.prefix == 27)
							{
								text = "Expert";
							}
							if (this.prefix == 28)
							{
								text = "Magistrale";
							}
							if (this.prefix == 29)
							{
								text = "Inepte";
							}
							if (this.prefix == 30)
							{
								text = "Ignorants";
							}
							if (this.prefix == 31)
							{
								text = "Dérangé";
							}
							if (this.prefix == 32)
							{
								text = "Intenses";
							}
							if (this.prefix == 33)
							{
								text = "Tabou";
							}
							if (this.prefix == 34)
							{
								text = "Célestes";
							}
							if (this.prefix == 35)
							{
								text = "Furieux";
							}
							if (this.prefix == 36)
							{
								text = "Vif";
							}
							if (this.prefix == 37)
							{
								text = "Supérieure";
							}
							if (this.prefix == 38)
							{
								text = "Énergique";
							}
							if (this.prefix == 39)
							{
								text = "Rompu";
							}
							if (this.prefix == 40)
							{
								text = "Endommagés";
							}
							if (this.prefix == 41)
							{
								text = "Mesquin";
							}
							if (this.prefix == 42)
							{
								text = "Prompt";
							}
							if (this.prefix == 43)
							{
								text = "Mortelle";
							}
							if (this.prefix == 44)
							{
								text = "Agile";
							}
							if (this.prefix == 45)
							{
								text = "Leste";
							}
							if (this.prefix == 46)
							{
								text = "Meurtrier";
							}
							if (this.prefix == 47)
							{
								text = "Lente";
							}
							if (this.prefix == 48)
							{
								text = "Paresseux";
							}
							if (this.prefix == 49)
							{
								text = "Fainéant";
							}
							if (this.prefix == 50)
							{
								text = "Ennuyeux";
							}
							if (this.prefix == 51)
							{
								text = "Méchant";
							}
							if (this.prefix == 52)
							{
								text = "Maniaco";
							}
							if (this.prefix == 53)
							{
								text = "Blessant";
							}
							if (this.prefix == 54)
							{
								text = "Robuste";
							}
							if (this.prefix == 55)
							{
								text = "Désagréables";
							}
							if (this.prefix == 56)
							{
								text = "Faibles";
							}
							if (this.prefix == 57)
							{
								text = "Impitoyable";
							}
							if (this.prefix == 58)
							{
								text = "Frénétique";
							}
							if (this.prefix == 59)
							{
								text = "Pieux";
							}
							if (this.prefix == 60)
							{
								text = "Démoniaque";
							}
							if (this.prefix == 61)
							{
								text = "Zélé";
							}
							if (this.prefix == 62)
							{
								text = "Durs";
							}
							if (this.prefix == 63)
							{
								text = "Protecteur";
							}
							if (this.prefix == 64)
							{
								text = "Blindés";
							}
							if (this.prefix == 65)
							{
								text = "Défensif";
							}
							if (this.prefix == 66)
							{
								text = "Ésotérique";
							}
							if (this.prefix == 67)
							{
								text = "Précise";
							}
							if (this.prefix == 68)
							{
								text = "Chanceux";
							}
							if (this.prefix == 69)
							{
								text = "Déchiqueté";
							}
							if (this.prefix == 70)
							{
								text = "Pointes";
							}
							if (this.prefix == 71)
							{
								text = "Fâché";
							}
							if (this.prefix == 72)
							{
								text = "Menaçant";
							}
							if (this.prefix == 73)
							{
								text = "Brusque";
							}
							if (this.prefix == 74)
							{
								text = "Fugace";
							}
							if (this.prefix == 75)
							{
								text = "Hâtif";
							}
							if (this.prefix == 76)
							{
								text = "Prompt";
							}
							if (this.prefix == 77)
							{
								text = "Sauvages";
							}
							if (this.prefix == 78)
							{
								text = "Téméraire";
							}
							if (this.prefix == 79)
							{
								text = "Intrépide";
							}
							if (this.prefix == 80)
							{
								text = "Violent";
							}
							if (this.prefix == 81)
							{
								text = "Légendaire";
							}
							if (this.prefix == 82)
							{
								text = "Irréel";
							}
							if (this.prefix == 83)
							{
								text = "Mythique";
							}
						}
						else
						{
							if (Lang.lang == 5)
							{
								if (this.prefix == 1)
								{
									text = "Grande";
								}
								if (this.prefix == 2)
								{
									text = "Masivo";
								}
								if (this.prefix == 3)
								{
									text = "Peligroso";
								}
								if (this.prefix == 4)
								{
									text = "Salvaje";
								}
								if (this.prefix == 5)
								{
									text = "Puntiagudo";
								}
								if (this.prefix == 6)
								{
									text = "Agudo";
								}
								if (this.prefix == 7)
								{
									text = "Diminuto";
								}
								if (this.prefix == 8)
								{
									text = "Mala ";
								}
								if (this.prefix == 9)
								{
									text = "Pequeño";
								}
								if (this.prefix == 10)
								{
									text = "Aburrido";
								}
								if (this.prefix == 11)
								{
									text = "Infeliz";
								}
								if (this.prefix == 12)
								{
									text = "Voluminoso";
								}
								if (this.prefix == 13)
								{
									text = "Vergonzoso";
								}
								if (this.prefix == 14)
								{
									text = "Pesado";
								}
								if (this.prefix == 15)
								{
									text = "Ligero";
								}
								if (this.prefix == 16)
								{
									text = "Ámbito";
								}
								if (this.prefix == 17)
								{
									text = "Rápido";
								}
								if (this.prefix == 18)
								{
									text = "Precipitado";
								}
								if (this.prefix == 19)
								{
									text = "Intimidante";
								}
								if (this.prefix == 20)
								{
									text = "Mortal";
								}
								if (this.prefix == 21)
								{
									text = "Firme";
								}
								if (this.prefix == 22)
								{
									text = "Atroz";
								}
								if (this.prefix == 23)
								{
									text = "Letárgico";
								}
								if (this.prefix == 24)
								{
									text = "Torpe";
								}
								if (this.prefix == 25)
								{
									text = "Poderoso";
								}
								if (this.prefix == 26)
								{
									text = "Místico";
								}
								if (this.prefix == 27)
								{
									text = "Experto";
								}
								if (this.prefix == 28)
								{
									text = "Maestro";
								}
								if (this.prefix == 29)
								{
									text = "Inepto";
								}
								if (this.prefix == 30)
								{
									text = "Ignorante";
								}
								if (this.prefix == 31)
								{
									text = "Trastornado";
								}
								if (this.prefix == 32)
								{
									text = "Intenso";
								}
								if (this.prefix == 33)
								{
									text = "Tabú";
								}
								if (this.prefix == 34)
								{
									text = "Celeste";
								}
								if (this.prefix == 35)
								{
									text = "Furioso";
								}
								if (this.prefix == 36)
								{
									text = "Afilado";
								}
								if (this.prefix == 37)
								{
									text = "Superior";
								}
								if (this.prefix == 38)
								{
									text = "Fuerte";
								}
								if (this.prefix == 39)
								{
									text = "Roto";
								}
								if (this.prefix == 40)
								{
									text = "Estropeado";
								}
								if (this.prefix == 41)
								{
									text = "Regenerado";
								}
								if (this.prefix == 42)
								{
									text = "Pronto";
								}
								if (this.prefix == 43)
								{
									text = "Mortal";
								}
								if (this.prefix == 44)
								{
									text = "Ágil";
								}
								if (this.prefix == 45)
								{
									text = "Listo";
								}
								if (this.prefix == 46)
								{
									text = "Asesino";
								}
								if (this.prefix == 47)
								{
									text = "Lento";
								}
								if (this.prefix == 48)
								{
									text = "Perezoso";
								}
								if (this.prefix == 49)
								{
									text = "Gandul";
								}
								if (this.prefix == 50)
								{
									text = "Molesto";
								}
								if (this.prefix == 51)
								{
									text = "Feo";
								}
								if (this.prefix == 52)
								{
									text = "Maníacos";
								}
								if (this.prefix == 53)
								{
									text = "Hiriente";
								}
								if (this.prefix == 54)
								{
									text = "Vigoroso";
								}
								if (this.prefix == 55)
								{
									text = "Desagradable";
								}
								if (this.prefix == 56)
								{
									text = "Débil";
								}
								if (this.prefix == 57)
								{
									text = "Despiadado";
								}
								if (this.prefix == 58)
								{
									text = "Frenético";
								}
								if (this.prefix == 59)
								{
									text = "Piadoso";
								}
								if (this.prefix == 60)
								{
									text = "Demoníaco";
								}
								if (this.prefix == 61)
								{
									text = "Celoso";
								}
								if (this.prefix == 62)
								{
									text = "Duro";
								}
								if (this.prefix == 63)
								{
									text = "Protector";
								}
								if (this.prefix == 64)
								{
									text = "Blindado";
								}
								if (this.prefix == 65)
								{
									text = "Defensivo";
								}
								if (this.prefix == 66)
								{
									text = "Arcano";
								}
								if (this.prefix == 67)
								{
									text = "Preciso";
								}
								if (this.prefix == 68)
								{
									text = "Afortunado";
								}
								if (this.prefix == 69)
								{
									text = "Dentado";
								}
								if (this.prefix == 70)
								{
									text = "Claveteado";
								}
								if (this.prefix == 71)
								{
									text = "Enojado";
								}
								if (this.prefix == 72)
								{
									text = "Amenazador";
								}
								if (this.prefix == 73)
								{
									text = "Enérgico";
								}
								if (this.prefix == 74)
								{
									text = "Fugaz";
								}
								if (this.prefix == 75)
								{
									text = "Precipitado";
								}
								if (this.prefix == 76)
								{
									text = "Pronto";
								}
								if (this.prefix == 77)
								{
									text = "Salvaje";
								}
								if (this.prefix == 78)
								{
									text = "Temerario";
								}
								if (this.prefix == 79)
								{
									text = "Intrépido";
								}
								if (this.prefix == 80)
								{
									text = "Violento";
								}
								if (this.prefix == 81)
								{
									text = "Legendario";
								}
								if (this.prefix == 82)
								{
									text = "Irreal";
								}
								if (this.prefix == 83)
								{
									text = "Mítico";
								}
							}
						}
					}
				}
			}
			if (Lang.lang <= 1)
			{
				string result = this.name;
				if (text != "")
				{
					result = text + " " + this.name;
				}
				return result;
			}
			if (Lang.lang == 2)
			{
				string result2 = this.name;
				if (text != "")
				{
					result2 = this.name + " (" + text + ")";
				}
				return result2;
			}
			if (Lang.lang == 3)
			{
				string result3 = this.name;
				if (text != "")
				{
					result3 = this.name + " (" + text + ")";
				}
				return result3;
			}
			if (Lang.lang == 4)
			{
				string result4 = this.name;
				if (text != "")
				{
					result4 = this.name + " (" + text + ")";
				}
				return result4;
			}
			string result5 = this.name;
			if (text != "")
			{
				result5 = this.name + " (" + text + ")";
			}
			return result5;
		}
		public void CheckTip()
		{
			if (this.toolTip != "")
			{
				this.toolTip = Lang.toolTip(this.netID, false);
			}
			if (this.toolTip2 != "")
			{
				this.toolTip2 = Lang.toolTip2(this.netID, false);
			}
		}
		public void SetDefaults(string ItemName)
		{
			this.name = "";
			bool flag = false;
			if (ItemName == "Gold Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(210, 190, 0, 100);
				this.useTime = 17;
				this.pick = 55;
				this.useAnimation = 20;
				this.scale = 1.05f;
				this.damage = 6;
				this.value = 10000;
				this.toolTip = "Can mine Meteorite";
				this.netID = -1;
				goto IL_1367;
			}
			if (ItemName == "Gold Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(210, 190, 0, 100);
				this.useAnimation = 20;
				this.damage = 13;
				this.scale = 1.05f;
				this.value = 9000;
				this.netID = -2;
				goto IL_1367;
			}
			if (ItemName == "Gold Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(210, 190, 0, 100);
				this.damage = 11;
				this.useAnimation = 11;
				this.scale = 0.95f;
				this.value = 7000;
				this.netID = -3;
				goto IL_1367;
			}
			if (ItemName == "Gold Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(210, 190, 0, 100);
				this.useTime = 18;
				this.axe = 11;
				this.useAnimation = 26;
				this.scale = 1.15f;
				this.damage = 7;
				this.value = 8000;
				this.netID = -4;
				goto IL_1367;
			}
			if (ItemName == "Gold Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(210, 190, 0, 100);
				this.useAnimation = 28;
				this.useTime = 23;
				this.scale = 1.25f;
				this.damage = 9;
				this.hammer = 55;
				this.value = 8000;
				this.netID = -5;
				goto IL_1367;
			}
			if (ItemName == "Gold Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 26;
				this.useTime = 26;
				this.color = new Color(210, 190, 0, 100);
				this.damage = 11;
				this.value = 7000;
				this.netID = -6;
				goto IL_1367;
			}
			if (ItemName == "Silver Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(180, 180, 180, 100);
				this.useTime = 11;
				this.pick = 45;
				this.useAnimation = 19;
				this.scale = 1.05f;
				this.damage = 6;
				this.value = 5000;
				this.netID = -7;
				goto IL_1367;
			}
			if (ItemName == "Silver Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(180, 180, 180, 100);
				this.useAnimation = 21;
				this.damage = 11;
				this.value = 4500;
				this.netID = -8;
				goto IL_1367;
			}
			if (ItemName == "Silver Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(180, 180, 180, 100);
				this.damage = 9;
				this.useAnimation = 12;
				this.scale = 0.95f;
				this.value = 3500;
				this.netID = -9;
				goto IL_1367;
			}
			if (ItemName == "Silver Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(180, 180, 180, 100);
				this.useTime = 18;
				this.axe = 10;
				this.useAnimation = 26;
				this.scale = 1.15f;
				this.damage = 6;
				this.value = 4000;
				this.netID = -10;
				goto IL_1367;
			}
			if (ItemName == "Silver Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(180, 180, 180, 100);
				this.useAnimation = 29;
				this.useTime = 19;
				this.scale = 1.25f;
				this.damage = 9;
				this.hammer = 45;
				this.value = 4000;
				this.netID = -11;
				goto IL_1367;
			}
			if (ItemName == "Silver Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 27;
				this.useTime = 27;
				this.color = new Color(180, 180, 180, 100);
				this.damage = 9;
				this.value = 3500;
				this.netID = -12;
				goto IL_1367;
			}
			if (ItemName == "Copper Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(180, 100, 45, 80);
				this.useTime = 15;
				this.pick = 35;
				this.useAnimation = 23;
				this.damage = 4;
				this.scale = 0.9f;
				this.tileBoost = -1;
				this.value = 500;
				this.netID = -13;
				goto IL_1367;
			}
			if (ItemName == "Copper Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(180, 100, 45, 80);
				this.useAnimation = 23;
				this.damage = 8;
				this.value = 450;
				this.netID = -14;
				goto IL_1367;
			}
			if (ItemName == "Copper Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(180, 100, 45, 80);
				this.damage = 5;
				this.useAnimation = 13;
				this.scale = 0.8f;
				this.value = 350;
				this.netID = -15;
				goto IL_1367;
			}
			if (ItemName == "Copper Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(180, 100, 45, 80);
				this.useTime = 21;
				this.axe = 7;
				this.useAnimation = 30;
				this.scale = 1f;
				this.damage = 3;
				this.tileBoost = -1;
				this.value = 400;
				this.netID = -16;
				goto IL_1367;
			}
			if (ItemName == "Copper Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(180, 100, 45, 80);
				this.useAnimation = 33;
				this.useTime = 23;
				this.scale = 1.1f;
				this.damage = 4;
				this.hammer = 35;
				this.tileBoost = -1;
				this.value = 400;
				this.netID = -17;
				goto IL_1367;
			}
			if (ItemName == "Copper Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 29;
				this.useTime = 29;
				this.color = new Color(180, 100, 45, 80);
				this.damage = 6;
				this.value = 350;
				this.netID = -18;
				goto IL_1367;
			}
			if (ItemName == "Blue Phasesaber")
			{
				this.SetDefaults(198, false);
				this.damage = 41;
				this.scale = 1.15f;
				flag = true;
				this.autoReuse = true;
				this.useTurn = true;
				this.rare = 4;
				this.netID = -19;
				goto IL_1367;
			}
			if (ItemName == "Red Phasesaber")
			{
				this.SetDefaults(199, false);
				this.damage = 41;
				this.scale = 1.15f;
				flag = true;
				this.autoReuse = true;
				this.useTurn = true;
				this.rare = 4;
				this.netID = -20;
				goto IL_1367;
			}
			if (ItemName == "Green Phasesaber")
			{
				this.SetDefaults(200, false);
				this.damage = 41;
				this.scale = 1.15f;
				flag = true;
				this.autoReuse = true;
				this.useTurn = true;
				this.rare = 4;
				this.netID = -21;
				goto IL_1367;
			}
			if (ItemName == "Purple Phasesaber")
			{
				this.SetDefaults(201, false);
				this.damage = 41;
				this.scale = 1.15f;
				flag = true;
				this.autoReuse = true;
				this.useTurn = true;
				this.rare = 4;
				this.netID = -22;
				goto IL_1367;
			}
			if (ItemName == "White Phasesaber")
			{
				this.SetDefaults(202, false);
				this.damage = 41;
				this.scale = 1.15f;
				flag = true;
				this.autoReuse = true;
				this.useTurn = true;
				this.rare = 4;
				this.netID = -23;
				goto IL_1367;
			}
			if (ItemName == "Yellow Phasesaber")
			{
				this.SetDefaults(203, false);
				this.damage = 41;
				this.scale = 1.15f;
				flag = true;
				this.autoReuse = true;
				this.useTurn = true;
				this.rare = 4;
				this.netID = -24;
				goto IL_1367;
			}
			if (ItemName == "Tin Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(170, 150, 80, 110);
				this.useTime = 14;
				this.pick = 35;
				this.useAnimation = 21;
				this.damage = 5;
				this.scale = 0.95f;
				this.value = 750;
				this.netID = -25;
				goto IL_1367;
			}
			if (ItemName == "Tin Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(170, 150, 80, 110);
				this.useAnimation = 22;
				this.damage = 9;
				this.value = 675;
				this.netID = -26;
				goto IL_1367;
			}
			if (ItemName == "Tin Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(170, 150, 80, 110);
				this.damage = 7;
				this.useAnimation = 12;
				this.scale = 0.85f;
				this.value = 525;
				this.netID = -27;
				goto IL_1367;
			}
			if (ItemName == "Tin Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(170, 150, 80, 110);
				this.useTime = 20;
				this.axe = 8;
				this.useAnimation = 28;
				this.scale = 1.05f;
				this.damage = 4;
				this.value = 600;
				this.netID = -28;
				goto IL_1367;
			}
			if (ItemName == "Tin Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(170, 150, 80, 110);
				this.useAnimation = 31;
				this.useTime = 21;
				this.scale = 1.15f;
				this.damage = 6;
				this.hammer = 38;
				this.value = 600;
				this.netID = -29;
				goto IL_1367;
			}
			if (ItemName == "Tin Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 28;
				this.useTime = 28;
				this.color = new Color(170, 150, 80, 110);
				this.damage = 7;
				this.value = 525;
				this.netID = -30;
				goto IL_1367;
			}
			if (ItemName == "Lead Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(90, 100, 110, 170);
				this.useTime = 12;
				this.pick = 43;
				this.useAnimation = 19;
				this.damage = 6;
				this.scale = 1.025f;
				this.value = 3000;
				this.netID = -31;
				goto IL_1367;
			}
			if (ItemName == "Lead Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(80, 90, 170, 160);
				this.useAnimation = 21;
				this.damage = 11;
				this.value = 2700;
				this.netID = -32;
				goto IL_1367;
			}
			if (ItemName == "Lead Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(90, 100, 110, 170);
				this.damage = 9;
				this.useAnimation = 12;
				this.scale = 0.925f;
				this.value = 2100;
				this.netID = -33;
				goto IL_1367;
			}
			if (ItemName == "Lead Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(90, 100, 110, 170);
				this.useTime = 19;
				this.axe = 10;
				this.useAnimation = 28;
				this.scale = 1.125f;
				this.damage = 6;
				this.value = 2400;
				this.netID = -34;
				goto IL_1367;
			}
			if (ItemName == "Lead Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(90, 100, 110, 170);
				this.useAnimation = 29;
				this.useTime = 19;
				this.scale = 1.225f;
				this.damage = 8;
				this.hammer = 43;
				this.value = 2400;
				this.netID = -35;
				goto IL_1367;
			}
			if (ItemName == "Lead Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 27;
				this.useTime = 27;
				this.color = new Color(90, 100, 110, 170);
				this.damage = 9;
				this.value = 2100;
				this.netID = -36;
				goto IL_1367;
			}
			if (ItemName == "Tungsten Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(130, 180, 130, 100);
				this.useTime = 19;
				this.pick = 50;
				this.useAnimation = 21;
				this.scale = 1.05f;
				this.damage = 6;
				this.value = 7500;
				this.netID = -37;
				this.toolTip = "Can mine Meteorite";
				goto IL_1367;
			}
			if (ItemName == "Tungsten Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(130, 180, 130, 100);
				this.useAnimation = 20;
				this.damage = 12;
				this.scale *= 1.025f;
				this.value = 6750;
				this.netID = -38;
				goto IL_1367;
			}
			if (ItemName == "Tungsten Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(130, 180, 130, 100);
				this.damage = 10;
				this.useAnimation = 11;
				this.scale = 0.95f;
				this.value = 5250;
				this.netID = -39;
				goto IL_1367;
			}
			if (ItemName == "Tungsten Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(130, 180, 130, 100);
				this.useTime = 18;
				this.axe = 11;
				this.useAnimation = 26;
				this.scale = 1.15f;
				this.damage = 7;
				this.value = 4000;
				this.netID = -40;
				goto IL_1367;
			}
			if (ItemName == "Tungsten Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(130, 180, 130, 100);
				this.useAnimation = 28;
				this.useTime = 25;
				this.scale = 1.25f;
				this.damage = 9;
				this.hammer = 50;
				this.value = 6000;
				this.netID = -41;
				goto IL_1367;
			}
			if (ItemName == "Tungsten Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 26;
				this.useTime = 26;
				this.color = new Color(130, 180, 130, 100);
				this.damage = 10;
				this.value = 5250;
				this.netID = -42;
				goto IL_1367;
			}
			if (ItemName == "Platinum Pickaxe")
			{
				this.SetDefaults(1, false);
				this.color = new Color(110, 140, 200, 80);
				this.useTime = 15;
				this.pick = 59;
				this.useAnimation = 19;
				this.scale = 1.05f;
				this.damage = 7;
				this.value = 15000;
				this.toolTip = "Can mine Meteorite";
				this.netID = -43;
				goto IL_1367;
			}
			if (ItemName == "Platinum Broadsword")
			{
				this.SetDefaults(4, false);
				this.color = new Color(110, 140, 200, 80);
				this.useAnimation = 19;
				this.damage = 15;
				this.scale = 1.075f;
				this.value = 13500;
				this.netID = -44;
				goto IL_1367;
			}
			if (ItemName == "Platinum Shortsword")
			{
				this.SetDefaults(6, false);
				this.color = new Color(110, 140, 200, 80);
				this.damage = 13;
				this.useAnimation = 10;
				this.scale = 0.975f;
				this.value = 10500;
				this.netID = -45;
				goto IL_1367;
			}
			if (ItemName == "Platinum Axe")
			{
				this.SetDefaults(10, false);
				this.color = new Color(110, 140, 200, 80);
				this.useTime = 17;
				this.axe = 12;
				this.useAnimation = 25;
				this.scale = 1.175f;
				this.damage = 8;
				this.value = 12000;
				this.netID = -46;
				goto IL_1367;
			}
			if (ItemName == "Platinum Hammer")
			{
				this.SetDefaults(7, false);
				this.color = new Color(110, 140, 200, 80);
				this.useAnimation = 27;
				this.useTime = 21;
				this.scale = 1.275f;
				this.damage = 10;
				this.hammer = 59;
				this.value = 12000;
				this.netID = -47;
				goto IL_1367;
			}
			if (ItemName == "Platinum Bow")
			{
				this.SetDefaults(99, false);
				this.useAnimation = 25;
				this.useTime = 25;
				this.color = new Color(110, 140, 200, 80);
				this.damage = 13;
				this.value = 10500;
				this.netID = -48;
				goto IL_1367;
			}
			if (ItemName != "")
			{
				for (int i = 0; i < 1725; i++)
				{
					if (Main.itemName[i] == ItemName)
					{
						this.SetDefaults(i, false);
						this.checkMat();
						return;
					}
				}
				this.name = "";
				this.stack = 0;
				this.type = 0;
			}
			IL_1367:
			if (this.type != 0)
			{
				if (flag)
				{
					this.material = false;
					goto IL_1382;
				}
				this.checkMat();
				IL_1382:
				this.name = ItemName;
				this.name = Lang.itemName(this.netID, false);
				this.CheckTip();
			}
		}
		public Rectangle getRect()
		{
			return new Rectangle((int)this.position.X, (int)this.position.Y, this.width, this.height);
		}
		public bool checkMat()
		{
			if (this.type >= 71 && this.type <= 74)
			{
				this.material = false;
				return false;
			}
			for (int i = 0; i < Recipe.numRecipes; i++)
			{
				int num = 0;
				while (Main.recipe[i].requiredItem[num].type > 0)
				{
					if (this.netID == Main.recipe[i].requiredItem[num].netID)
					{
						this.material = true;
						return true;
					}
					num++;
				}
			}
			this.material = false;
			return false;
		}
		public void netDefaults(int type)
		{
			if (type < 0)
			{
				if (type == -1)
				{
					this.SetDefaults("Gold Pickaxe");
					return;
				}
				if (type == -2)
				{
					this.SetDefaults("Gold Broadsword");
					return;
				}
				if (type == -3)
				{
					this.SetDefaults("Gold Shortsword");
					return;
				}
				if (type == -4)
				{
					this.SetDefaults("Gold Axe");
					return;
				}
				if (type == -5)
				{
					this.SetDefaults("Gold Hammer");
					return;
				}
				if (type == -6)
				{
					this.SetDefaults("Gold Bow");
					return;
				}
				if (type == -7)
				{
					this.SetDefaults("Silver Pickaxe");
					return;
				}
				if (type == -8)
				{
					this.SetDefaults("Silver Broadsword");
					return;
				}
				if (type == -9)
				{
					this.SetDefaults("Silver Shortsword");
					return;
				}
				if (type == -10)
				{
					this.SetDefaults("Silver Axe");
					return;
				}
				if (type == -11)
				{
					this.SetDefaults("Silver Hammer");
					return;
				}
				if (type == -12)
				{
					this.SetDefaults("Silver Bow");
					return;
				}
				if (type == -13)
				{
					this.SetDefaults("Copper Pickaxe");
					return;
				}
				if (type == -14)
				{
					this.SetDefaults("Copper Broadsword");
					return;
				}
				if (type == -15)
				{
					this.SetDefaults("Copper Shortsword");
					return;
				}
				if (type == -16)
				{
					this.SetDefaults("Copper Axe");
					return;
				}
				if (type == -17)
				{
					this.SetDefaults("Copper Hammer");
					return;
				}
				if (type == -18)
				{
					this.SetDefaults("Copper Bow");
					return;
				}
				if (type == -19)
				{
					this.SetDefaults("Blue Phasesaber");
					return;
				}
				if (type == -20)
				{
					this.SetDefaults("Red Phasesaber");
					return;
				}
				if (type == -21)
				{
					this.SetDefaults("Green Phasesaber");
					return;
				}
				if (type == -22)
				{
					this.SetDefaults("Purple Phasesaber");
					return;
				}
				if (type == -23)
				{
					this.SetDefaults("White Phasesaber");
					return;
				}
				if (type == -24)
				{
					this.SetDefaults("Yellow Phasesaber");
					return;
				}
				if (type == -25)
				{
					this.SetDefaults("Tin Pickaxe");
					return;
				}
				if (type == -26)
				{
					this.SetDefaults("Tin Broadsword");
					return;
				}
				if (type == -27)
				{
					this.SetDefaults("Tin Shortsword");
					return;
				}
				if (type == -28)
				{
					this.SetDefaults("Tin Axe");
					return;
				}
				if (type == -29)
				{
					this.SetDefaults("Tin Hammer");
					return;
				}
				if (type == -30)
				{
					this.SetDefaults("Tin Bow");
					return;
				}
				if (type == -31)
				{
					this.SetDefaults("Lead Pickaxe");
					return;
				}
				if (type == -32)
				{
					this.SetDefaults("Lead Broadsword");
					return;
				}
				if (type == -33)
				{
					this.SetDefaults("Lead Shortsword");
					return;
				}
				if (type == -34)
				{
					this.SetDefaults("Lead Axe");
					return;
				}
				if (type == -35)
				{
					this.SetDefaults("Lead Hammer");
					return;
				}
				if (type == -36)
				{
					this.SetDefaults("Lead Bow");
					return;
				}
				if (type == -37)
				{
					this.SetDefaults("Tungsten Pickaxe");
					return;
				}
				if (type == -38)
				{
					this.SetDefaults("Tungsten Broadsword");
					return;
				}
				if (type == -39)
				{
					this.SetDefaults("Tungsten Shortsword");
					return;
				}
				if (type == -40)
				{
					this.SetDefaults("Tungsten Axe");
					return;
				}
				if (type == -41)
				{
					this.SetDefaults("Tungsten Hammer");
					return;
				}
				if (type == -42)
				{
					this.SetDefaults("Tungsten Bow");
					return;
				}
				if (type == -43)
				{
					this.SetDefaults("Platinum Pickaxe");
					return;
				}
				if (type == -44)
				{
					this.SetDefaults("Platinum Broadsword");
					return;
				}
				if (type == -45)
				{
					this.SetDefaults("Platinum Shortsword");
					return;
				}
				if (type == -46)
				{
					this.SetDefaults("Platinum Axe");
					return;
				}
				if (type == -47)
				{
					this.SetDefaults("Platinum Hammer");
					return;
				}
				if (type == -48)
				{
					this.SetDefaults("Platinum Bow");
					return;
				}
				return;
			}
			this.SetDefaults(type, false);
		}
		public static int NPCtoBanner(int i)
		{
			switch (i)
			{
			case 1:
			case 147:
			case 184:
				return 69;
			case 2:
			case 133:
			case 190:
			case 191:
			case 192:
			case 193:
			case 194:
				return 25;
			case 3:
			case 132:
			case 186:
			case 187:
			case 188:
			case 189:
			case 200:
				return 87;
			case 6:
				return 27;
			case 10:
			case 11:
			case 12:
			case 95:
			case 96:
			case 97:
				return 84;
			case 21:
			case 201:
			case 202:
			case 203:
				return 67;
			case 23:
				return 55;
			case 24:
				return 50;
			case 27:
				return 41;
			case 28:
				return 42;
			case 29:
				return 39;
			case 32:
				return 68;
			case 39:
			case 40:
			case 41:
				return 13;
			case 42:
			case 176:
			case 231:
			case 232:
			case 233:
			case 234:
			case 235:
				return 47;
			case 43:
				return 54;
			case 46:
				return 14;
			case 47:
				return 18;
			case 48:
				return 44;
			case 49:
			case 93:
				return 7;
			case 55:
			case 230:
				return 43;
			case 57:
				return 19;
			case 58:
				return 61;
			case 60:
			case 151:
				return 45;
			case 61:
				return 79;
			case 62:
			case 66:
			case 156:
				return 24;
			case 63:
			case 64:
			case 103:
				return 51;
			case 65:
				return 66;
			case 67:
				return 20;
			case 69:
				return 4;
			case 73:
				return 40;
			case 74:
				return 8;
			case 75:
				return 63;
			case 77:
				return 6;
			case 78:
			case 79:
			case 80:
				return 57;
			case 82:
				return 85;
			case 83:
				return 23;
			case 84:
				return 28;
			case 85:
				return 16;
			case 86:
				return 77;
			case 87:
			case 88:
			case 89:
			case 90:
			case 91:
			case 92:
				return 86;
			case 98:
			case 99:
			case 100:
				return 83;
			case 102:
				return 1;
			case 104:
				return 81;
			case 109:
				return 17;
			case 111:
				return 38;
			case 120:
				return 15;
			case 122:
				return 37;
			case 141:
				return 75;
			case 153:
			case 154:
				return 74;
			case 155:
				return 82;
			case 157:
				return 5;
			case 158:
			case 159:
				return 78;
			case 161:
				return 29;
			case 162:
				return 34;
			case 163:
			case 238:
				return 9;
			case 164:
			case 165:
				return 71;
			case 166:
				return 73;
			case 169:
				return 48;
			case 170:
			case 171:
			case 180:
				return 60;
			case 173:
				return 21;
			case 174:
				return 46;
			case 177:
				return 26;
			case 179:
				return 22;
			case 181:
				return 30;
			case 182:
				return 31;
			case 185:
				return 70;
			case 195:
			case 196:
				return 80;
			case 198:
			case 199:
				return 53;
			case 205:
				return 56;
			case 206:
				return 49;
			case 212:
			case 213:
			case 214:
			case 215:
			case 216:
				return 62;
			case 223:
				return 64;
			case 224:
				return 32;
			case 225:
				return 76;
			case 226:
				return 33;
			case 236:
			case 237:
				return 52;
			case 239:
				return 12;
			case 241:
				return 10;
			case 242:
				return 11;
			case 250:
				return 2;
			case 252:
				return 59;
			case 253:
				return 65;
			case 254:
			case 255:
				return 72;
			case 256:
				return 36;
			case 257:
				return 3;
			case 258:
				return 58;
			case 259:
			case 260:
				return 35;
			}
			return -1;
		}
		public static int BannerToNPC(int i)
		{
			switch (i)
			{
			case 1:
				return 102;
			case 2:
				return 250;
			case 3:
				return 257;
			case 4:
				return 69;
			case 5:
				return 157;
			case 6:
				return 77;
			case 7:
				return 49;
			case 8:
				return 74;
			case 9:
				return 163;
			case 10:
				return 241;
			case 11:
				return 242;
			case 12:
				return 239;
			case 13:
				return 39;
			case 14:
				return 46;
			case 15:
				return 120;
			case 16:
				return 85;
			case 17:
				return 109;
			case 18:
				return 47;
			case 19:
				return 57;
			case 20:
				return 67;
			case 21:
				return 173;
			case 22:
				return 179;
			case 23:
				return 83;
			case 24:
				return 62;
			case 25:
				return 2;
			case 26:
				return 177;
			case 27:
				return 6;
			case 28:
				return 84;
			case 29:
				return 161;
			case 30:
				return 181;
			case 31:
				return 182;
			case 32:
				return 224;
			case 33:
				return 226;
			case 34:
				return 162;
			case 35:
				return 259;
			case 36:
				return 256;
			case 37:
				return 122;
			case 38:
				return 111;
			case 39:
				return 29;
			case 40:
				return 73;
			case 41:
				return 27;
			case 42:
				return 28;
			case 43:
				return 55;
			case 44:
				return 48;
			case 45:
				return 60;
			case 46:
				return 174;
			case 47:
				return 42;
			case 48:
				return 169;
			case 49:
				return 206;
			case 50:
				return 24;
			case 51:
				return 63;
			case 52:
				return 236;
			case 53:
				return 199;
			case 54:
				return 43;
			case 55:
				return 23;
			case 56:
				return 205;
			case 57:
				return 78;
			case 58:
				return 258;
			case 59:
				return 252;
			case 60:
				return 170;
			case 61:
				return 58;
			case 62:
				return 212;
			case 63:
				return 75;
			case 64:
				return 223;
			case 65:
				return 253;
			case 66:
				return 65;
			case 67:
				return 21;
			case 68:
				return 32;
			case 69:
				return 1;
			case 70:
				return 185;
			case 71:
				return 164;
			case 72:
				return 254;
			case 73:
				return 166;
			case 74:
				return 153;
			case 75:
				return 141;
			case 76:
				return 225;
			case 77:
				return 86;
			case 78:
				return 158;
			case 79:
				return 61;
			case 80:
				return 196;
			case 81:
				return 104;
			case 82:
				return 155;
			case 83:
				return 98;
			case 84:
				return 10;
			case 85:
				return 82;
			case 86:
				return 87;
			case 87:
				return 3;
			default:
				return -1;
			}
		}
		public void SetDefaults(int Type, bool noMatCheck = false)
		{
			if (Main.netMode == 1 || Main.netMode == 2)
			{
				this.owner = 255;
				goto IL_28;
			}
			this.owner = Main.myPlayer;
			IL_28:
			this.dye = 0;
			this.paint = 0;
			this.tileWand = -1;
			this.notAmmo = false;
			this.netID = 0;
			this.prefix = 0;
			this.crit = 0;
			this.mech = false;
			this.flame = false;
			this.reuseDelay = 0;
			this.melee = false;
			this.magic = false;
			this.ranged = false;
			this.summon = false;
			this.placeStyle = 0;
			this.buffTime = 0;
			this.buffType = 0;
			this.material = false;
			this.noWet = false;
			this.vanity = false;
			this.mana = 0;
			this.wet = false;
			this.wetCount = 0;
			this.lavaWet = false;
			this.channel = false;
			this.manaIncrease = 0;
			this.release = 0;
			this.noMelee = false;
			this.noUseGraphic = false;
			this.lifeRegen = 0;
			this.shootSpeed = 0f;
			this.active = true;
			this.alpha = 0;
			this.ammo = 0;
			this.useAmmo = 0;
			this.autoReuse = false;
			this.accessory = false;
			this.axe = 0;
			this.healMana = 0;
			this.bodySlot = -1;
			this.legSlot = -1;
			this.headSlot = -1;
			this.potion = false;
			this.color = default(Color);
			this.consumable = false;
			this.createTile = -1;
			this.createWall = -1;
			this.damage = -1;
			this.defense = 0;
			this.hammer = 0;
			this.healLife = 0;
			this.holdStyle = 0;
			this.knockBack = 0f;
			this.maxStack = 1;
			this.pick = 0;
			this.rare = 0;
			this.scale = 1f;
			this.shoot = 0;
			this.stack = 1;
			this.toolTip = null;
			this.toolTip2 = null;
			this.tileBoost = 0;
			this.type = Type;
			this.useStyle = 0;
			this.useSound = 0;
			this.useTime = 100;
			this.useAnimation = 100;
			this.value = 0;
			this.useTurn = false;
			this.buy = false;
			if (this.type == 0)
			{
				this.netID = 0;
				this.name = "";
				this.stack = 0;
				goto IL_381A;
			}
			if (this.type == 1)
			{
				this.name = "Iron Pickaxe";
				this.color = new Color(160, 145, 130, 110);
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 20;
				this.useTime = 13;
				this.autoReuse = true;
				this.width = 24;
				this.height = 28;
				this.damage = 5;
				this.pick = 40;
				this.useSound = 1;
				this.knockBack = 2f;
				this.value = 2000;
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 2)
			{
				this.name = "Dirt Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 0;
				this.width = 12;
				this.height = 12;
				goto IL_381A;
			}
			if (this.type == 3)
			{
				this.name = "Stone Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 1;
				this.width = 12;
				this.height = 12;
				goto IL_381A;
			}
			if (this.type == 4)
			{
				this.name = "Iron Broadsword";
				this.color = new Color(160, 145, 130, 110);
				this.useStyle = 1;
				this.useTurn = false;
				this.useAnimation = 21;
				this.useTime = 21;
				this.width = 24;
				this.height = 28;
				this.damage = 10;
				this.knockBack = 5f;
				this.useSound = 1;
				this.scale = 1f;
				this.value = 1800;
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 5)
			{
				this.name = "Mushroom";
				this.useStyle = 2;
				this.useSound = 2;
				this.useTurn = false;
				this.useAnimation = 17;
				this.useTime = 17;
				this.width = 16;
				this.height = 18;
				this.healLife = 15;
				this.maxStack = 99;
				this.consumable = true;
				this.potion = true;
				this.value = 25;
				goto IL_381A;
			}
			if (this.type == 6)
			{
				this.name = "Iron Shortsword";
				this.color = new Color(160, 145, 130, 110);
				this.useStyle = 3;
				this.useTurn = false;
				this.useAnimation = 12;
				this.useTime = 12;
				this.width = 24;
				this.height = 28;
				this.damage = 8;
				this.knockBack = 4f;
				this.scale = 0.9f;
				this.useSound = 1;
				this.useTurn = true;
				this.value = 1400;
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 7)
			{
				this.name = "Iron Hammer";
				this.color = new Color(160, 145, 130, 110);
				this.autoReuse = true;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 30;
				this.useTime = 20;
				this.hammer = 40;
				this.width = 24;
				this.height = 28;
				this.damage = 7;
				this.knockBack = 5.5f;
				this.scale = 1.2f;
				this.useSound = 1;
				this.value = 1600;
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 8)
			{
				this.flame = true;
				this.noWet = true;
				this.name = "Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.holdStyle = 1;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 4;
				this.width = 10;
				this.height = 12;
				this.toolTip = "Provides light";
				this.value = 50;
				goto IL_381A;
			}
			if (this.type == 9)
			{
				this.name = "Wood";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 30;
				this.width = 8;
				this.height = 10;
				goto IL_381A;
			}
			if (this.type == 10)
			{
				this.name = "Iron Axe";
				this.color = new Color(160, 145, 130, 110);
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 27;
				this.knockBack = 4.5f;
				this.useTime = 19;
				this.autoReuse = true;
				this.width = 24;
				this.height = 28;
				this.damage = 5;
				this.axe = 9;
				this.scale = 1.1f;
				this.useSound = 1;
				this.value = 1600;
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 11)
			{
				this.name = "Iron Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 6;
				this.width = 12;
				this.height = 12;
				this.value = 500;
				goto IL_381A;
			}
			if (this.type == 12)
			{
				this.name = "Copper Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 7;
				this.width = 12;
				this.height = 12;
				this.value = 250;
				goto IL_381A;
			}
			if (this.type == 13)
			{
				this.name = "Gold Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 8;
				this.width = 12;
				this.height = 12;
				this.value = 2000;
				goto IL_381A;
			}
			if (this.type == 14)
			{
				this.name = "Silver Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 9;
				this.width = 12;
				this.height = 12;
				this.value = 1000;
				goto IL_381A;
			}
			if (this.type == 15)
			{
				this.name = "Copper Watch";
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.toolTip = "Tells the time";
				this.value = 1000;
				goto IL_381A;
			}
			if (this.type == 16)
			{
				this.name = "Silver Watch";
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.toolTip = "Tells the time";
				this.value = 5000;
				goto IL_381A;
			}
			if (this.type == 17)
			{
				this.name = "Gold Watch";
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "Tells the time";
				this.value = 10000;
				goto IL_381A;
			}
			if (this.type == 18)
			{
				this.name = "Depth Meter";
				this.width = 24;
				this.height = 18;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "Shows depth";
				this.value = 10000;
				goto IL_381A;
			}
			if (this.type == 19)
			{
				this.name = "Gold Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 6000;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 6;
				goto IL_381A;
			}
			if (this.type == 20)
			{
				this.name = "Copper Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 750;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 0;
				goto IL_381A;
			}
			if (this.type == 21)
			{
				this.name = "Silver Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 3000;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 4;
				goto IL_381A;
			}
			if (this.type == 22)
			{
				this.name = "Iron Bar";
				this.color = new Color(160, 145, 130, 110);
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 1500;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 2;
				goto IL_381A;
			}
			if (this.type == 23)
			{
				this.name = "Gel";
				this.width = 10;
				this.height = 12;
				this.maxStack = 999;
				this.alpha = 175;
				this.ammo = 23;
				this.color = new Color(0, 80, 255, 100);
				this.toolTip = "'Both tasty and flammable'";
				this.value = 5;
				goto IL_381A;
			}
			if (this.type == 24)
			{
				this.name = "Wooden Sword";
				this.useStyle = 1;
				this.useTurn = false;
				this.useAnimation = 25;
				this.width = 24;
				this.height = 28;
				this.damage = 7;
				this.knockBack = 4f;
				this.scale = 0.95f;
				this.useSound = 1;
				this.value = 100;
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 25)
			{
				this.name = "Wooden Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_381A;
			}
			if (this.type == 26)
			{
				this.name = "Stone Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 1;
				this.width = 12;
				this.height = 12;
				goto IL_381A;
			}
			if (this.type == 27)
			{
				this.name = "Acorn";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 20;
				this.width = 18;
				this.height = 18;
				this.value = 10;
				goto IL_381A;
			}
			if (this.type == 28)
			{
				this.name = "Lesser Healing Potion";
				this.useSound = 3;
				this.healLife = 50;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.potion = true;
				this.value = 300;
				goto IL_381A;
			}
			if (this.type == 29)
			{
				this.name = "Life Crystal";
				this.maxStack = 99;
				this.consumable = true;
				this.width = 18;
				this.height = 18;
				this.useStyle = 4;
				this.useTime = 30;
				this.useSound = 4;
				this.useAnimation = 30;
				this.toolTip = "Permanently increases maximum life by 20";
				this.rare = 2;
				this.value = 75000;
				goto IL_381A;
			}
			if (this.type == 30)
			{
				this.name = "Dirt Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 16;
				this.width = 12;
				this.height = 12;
				goto IL_381A;
			}
			if (this.type == 31)
			{
				this.name = "Bottle";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 13;
				this.width = 16;
				this.height = 24;
				this.value = 20;
				goto IL_381A;
			}
			if (this.type == 32)
			{
				this.name = "Wooden Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_381A;
			}
			if (this.type == 33)
			{
				this.name = "Furnace";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 17;
				this.width = 26;
				this.height = 24;
				this.value = 300;
				this.toolTip = "Used for smelting ore";
				goto IL_381A;
			}
			if (this.type == 34)
			{
				this.name = "Wooden Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.width = 12;
				this.height = 30;
				this.value = 150;
				goto IL_381A;
			}
			if (this.type == 35)
			{
				this.name = "Iron Anvil";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 16;
				this.width = 28;
				this.height = 14;
				this.value = 5000;
				this.toolTip = "Used to craft items from metal bars";
				goto IL_381A;
			}
			if (this.type == 36)
			{
				this.name = "Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				this.toolTip = "Used for basic crafting";
				goto IL_381A;
			}
			if (this.type == 37)
			{
				this.name = "Goggles";
				this.width = 28;
				this.height = 12;
				this.defense = 1;
				this.headSlot = 10;
				this.rare = 1;
				this.value = 1000;
				goto IL_381A;
			}
			if (this.type == 38)
			{
				this.name = "Lens";
				this.width = 12;
				this.height = 20;
				this.maxStack = 99;
				this.value = 500;
				goto IL_381A;
			}
			if (this.type == 39)
			{
				this.useStyle = 5;
				this.useAnimation = 30;
				this.useTime = 30;
				this.name = "Wooden Bow";
				this.width = 12;
				this.height = 28;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 4;
				this.shootSpeed = 6.1f;
				this.noMelee = true;
				this.value = 100;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 40)
			{
				this.name = "Wooden Arrow";
				this.shootSpeed = 3f;
				this.shoot = 1;
				this.damage = 4;
				this.width = 10;
				this.height = 28;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 1;
				this.knockBack = 2f;
				this.value = 10;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 41)
			{
				this.name = "Flaming Arrow";
				this.shootSpeed = 3.5f;
				this.shoot = 2;
				this.damage = 6;
				this.width = 10;
				this.height = 28;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 1;
				this.knockBack = 2f;
				this.value = 15;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 42)
			{
				this.useStyle = 1;
				this.name = "Shuriken";
				this.shootSpeed = 9f;
				this.shoot = 3;
				this.damage = 10;
				this.width = 18;
				this.height = 20;
				this.maxStack = 999;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 20;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 43)
			{
				this.useStyle = 4;
				this.name = "Suspicious Looking Eye";
				this.width = 22;
				this.height = 14;
				this.consumable = true;
				this.useAnimation = 45;
				this.useTime = 45;
				this.maxStack = 20;
				this.toolTip = "Summons the Eye of Cthulhu";
				goto IL_381A;
			}
			if (this.type == 44)
			{
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 25;
				this.name = "Demon Bow";
				this.width = 12;
				this.height = 28;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 14;
				this.shootSpeed = 6.7f;
				this.knockBack = 1f;
				this.alpha = 30;
				this.rare = 1;
				this.noMelee = true;
				this.value = 18000;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 45)
			{
				this.name = "War Axe of the Night";
				this.autoReuse = true;
				this.useStyle = 1;
				this.useAnimation = 30;
				this.knockBack = 6f;
				this.useTime = 15;
				this.width = 24;
				this.height = 28;
				this.damage = 20;
				this.axe = 15;
				this.scale = 1.2f;
				this.useSound = 1;
				this.rare = 1;
				this.value = 13500;
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 46)
			{
				this.name = "Light's Bane";
				this.useStyle = 1;
				this.useAnimation = 20;
				this.knockBack = 5f;
				this.width = 24;
				this.height = 28;
				this.damage = 17;
				this.scale = 1.1f;
				this.useSound = 1;
				this.rare = 1;
				this.value = 13500;
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 47)
			{
				this.name = "Unholy Arrow";
				this.shootSpeed = 3.4f;
				this.shoot = 4;
				this.damage = 8;
				this.width = 10;
				this.height = 28;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 1;
				this.knockBack = 3f;
				this.alpha = 30;
				this.rare = 1;
				this.value = 40;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 48)
			{
				this.name = "Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.width = 26;
				this.height = 22;
				this.value = 500;
				goto IL_381A;
			}
			if (this.type == 49)
			{
				this.name = "Band of Regeneration";
				this.width = 22;
				this.height = 22;
				this.accessory = true;
				this.lifeRegen = 1;
				this.rare = 1;
				this.toolTip = "Slowly regenerates life";
				this.value = 50000;
				goto IL_381A;
			}
			if (this.type == 50)
			{
				this.name = "Magic Mirror";
				this.useTurn = true;
				this.width = 20;
				this.height = 20;
				this.useStyle = 4;
				this.useTime = 90;
				this.useSound = 6;
				this.useAnimation = 90;
				this.toolTip = "Gaze in the mirror to return home";
				this.rare = 1;
				this.value = 50000;
				goto IL_381A;
			}
			if (this.type == 51)
			{
				this.name = "Jester's Arrow";
				this.shootSpeed = 0.5f;
				this.shoot = 5;
				this.damage = 9;
				this.width = 10;
				this.height = 28;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 1;
				this.knockBack = 4f;
				this.rare = 1;
				this.value = 100;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 52 || this.type == 673 || this.type == 677 || this.type == 678 || this.type == 858)
			{
				this.type = 52;
				this.name = "Angel Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 1;
				goto IL_381A;
			}
			if (this.type == 53)
			{
				this.name = "Cloud in a Bottle";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "Allows the holder to double jump";
				this.value = 50000;
				goto IL_381A;
			}
			if (this.type == 54)
			{
				this.name = "Hermes Boots";
				this.width = 28;
				this.height = 24;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "The wearer can run super fast";
				this.value = 50000;
				goto IL_381A;
			}
			if (this.type == 55)
			{
				this.noMelee = true;
				this.useStyle = 1;
				this.name = "Enchanted Boomerang";
				this.shootSpeed = 10f;
				this.shoot = 6;
				this.damage = 13;
				this.knockBack = 8f;
				this.width = 14;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.rare = 1;
				this.value = 50000;
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 56)
			{
				this.name = "Demonite Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 22;
				this.width = 12;
				this.height = 12;
				this.rare = 1;
				this.toolTip = "'Pulsing with dark energy'";
				this.value = 4000;
				goto IL_381A;
			}
			if (this.type == 57)
			{
				this.name = "Demonite Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.rare = 1;
				this.toolTip = "'Pulsing with dark energy'";
				this.value = 16000;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 8;
				goto IL_381A;
			}
			if (this.type == 58)
			{
				this.name = "Heart";
				this.width = 12;
				this.height = 12;
				goto IL_381A;
			}
			if (this.type == 59)
			{
				this.name = "Corrupt Seeds";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 23;
				this.width = 14;
				this.height = 14;
				this.value = 500;
				goto IL_381A;
			}
			if (this.type == 60)
			{
				this.name = "Vile Mushroom";
				this.width = 16;
				this.height = 18;
				this.maxStack = 99;
				this.value = 50;
				goto IL_381A;
			}
			if (this.type == 61)
			{
				this.name = "Ebonstone Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 25;
				this.width = 12;
				this.height = 12;
				goto IL_381A;
			}
			if (this.type == 62)
			{
				this.name = "Grass Seeds";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 2;
				this.width = 14;
				this.height = 14;
				this.value = 20;
				goto IL_381A;
			}
			if (this.type == 63)
			{
				this.name = "Sunflower";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 27;
				this.width = 26;
				this.height = 26;
				this.value = 200;
				goto IL_381A;
			}
			if (this.type == 64)
			{
				this.mana = 10;
				this.damage = 10;
				this.useStyle = 1;
				this.name = "Vilethorn";
				this.shootSpeed = 32f;
				this.shoot = 7;
				this.width = 26;
				this.height = 28;
				this.useSound = 8;
				this.useAnimation = 28;
				this.useTime = 28;
				this.rare = 1;
				this.noMelee = true;
				this.knockBack = 1f;
				this.toolTip = "Summons a vile thorn";
				this.value = 10000;
				this.magic = true;
				goto IL_381A;
			}
			if (this.type == 65)
			{
				this.knockBack = 5f;
				this.alpha = 100;
				this.color = new Color(150, 150, 150, 0);
				this.damage = 22;
				this.useStyle = 1;
				this.scale = 1.25f;
				this.name = "Starfury";
				this.shootSpeed = 20f;
				this.shoot = 9;
				this.width = 14;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 21;
				this.useTime = 60;
				this.rare = 2;
				this.toolTip = "Causes stars to rain from the sky";
				this.toolTip2 = "'Forged with the fury of heaven'";
				this.value = 50000;
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 66)
			{
				this.useStyle = 1;
				this.name = "Purification Powder";
				this.shootSpeed = 4f;
				this.shoot = 10;
				this.width = 16;
				this.height = 24;
				this.maxStack = 99;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noMelee = true;
				this.toolTip = "Cleanses the corruption";
				this.value = 75;
				goto IL_381A;
			}
			if (this.type == 67)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Vile Powder";
				this.shootSpeed = 4f;
				this.shoot = 11;
				this.width = 16;
				this.height = 24;
				this.maxStack = 99;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noMelee = true;
				this.value = 100;
				this.toolTip = "Removes the Hallow";
				goto IL_381A;
			}
			if (this.type == 68)
			{
				this.name = "Rotten Chunk";
				this.width = 18;
				this.height = 20;
				this.maxStack = 99;
				this.toolTip = "'Looks tasty!'";
				this.value = 10;
				goto IL_381A;
			}
			if (this.type == 69)
			{
				this.name = "Worm Tooth";
				this.width = 8;
				this.height = 20;
				this.maxStack = 99;
				this.value = 100;
				goto IL_381A;
			}
			if (this.type == 70)
			{
				this.useStyle = 4;
				this.consumable = true;
				this.useAnimation = 45;
				this.useTime = 45;
				this.name = "Worm Food";
				this.width = 28;
				this.height = 28;
				this.maxStack = 20;
				this.toolTip = "Summons the Eater of Worlds";
				goto IL_381A;
			}
			if (this.type == 71)
			{
				this.name = "Copper Coin";
				this.width = 10;
				this.height = 12;
				this.maxStack = 100;
				this.value = 5;
				this.ammo = 71;
				this.shoot = 158;
				this.notAmmo = true;
				this.damage = 25;
				this.shootSpeed = 1f;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 72)
			{
				this.name = "Silver Coin";
				this.width = 10;
				this.height = 12;
				this.maxStack = 100;
				this.value = 500;
				this.ammo = 71;
				this.notAmmo = true;
				this.damage = 50;
				this.shoot = 159;
				this.shootSpeed = 2f;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 73)
			{
				this.name = "Gold Coin";
				this.width = 10;
				this.height = 12;
				this.maxStack = 100;
				this.value = 50000;
				this.ammo = 71;
				this.notAmmo = true;
				this.damage = 100;
				this.shoot = 160;
				this.shootSpeed = 3f;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 74)
			{
				this.name = "Platinum Coin";
				this.width = 10;
				this.height = 12;
				this.maxStack = 100;
				this.value = 5000000;
				this.ammo = 71;
				this.notAmmo = true;
				this.damage = 200;
				this.shoot = 161;
				this.shootSpeed = 4f;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 75)
			{
				this.name = "Fallen Star";
				this.width = 18;
				this.height = 20;
				this.maxStack = 100;
				this.alpha = 75;
				this.ammo = 15;
				this.toolTip = "Disappears after the sunrise";
				this.value = 500;
				this.useStyle = 4;
				this.useSound = 4;
				this.useTurn = false;
				this.useAnimation = 17;
				this.useTime = 17;
				this.consumable = true;
				this.rare = 1;
				goto IL_381A;
			}
			if (this.type == 76)
			{
				this.name = "Copper Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.legSlot = 1;
				this.value = 750;
				goto IL_381A;
			}
			if (this.type == 77)
			{
				this.name = "Iron Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.legSlot = 2;
				this.value = 3000;
				goto IL_381A;
			}
			if (this.type == 78)
			{
				this.name = "Silver Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 3;
				this.legSlot = 3;
				this.value = 7500;
				goto IL_381A;
			}
			if (this.type == 79)
			{
				this.name = "Gold Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 4;
				this.legSlot = 4;
				this.value = 15000;
				goto IL_381A;
			}
			if (this.type == 80)
			{
				this.name = "Copper Chainmail";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.bodySlot = 1;
				this.value = 1000;
				goto IL_381A;
			}
			if (this.type == 81)
			{
				this.name = "Iron Chainmail";
				this.width = 18;
				this.height = 18;
				this.defense = 3;
				this.bodySlot = 2;
				this.value = 4000;
				goto IL_381A;
			}
			if (this.type == 82)
			{
				this.name = "Silver Chainmail";
				this.width = 18;
				this.height = 18;
				this.defense = 4;
				this.bodySlot = 3;
				this.value = 10000;
				goto IL_381A;
			}
			if (this.type == 83)
			{
				this.name = "Gold Chainmail";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.bodySlot = 4;
				this.value = 20000;
				goto IL_381A;
			}
			if (this.type == 84)
			{
				this.noUseGraphic = true;
				this.damage = 0;
				this.knockBack = 7f;
				this.useStyle = 5;
				this.name = "Grappling Hook";
				this.shootSpeed = 11.5f;
				this.shoot = 13;
				this.width = 18;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 1;
				this.noMelee = true;
				this.value = 20000;
				this.toolTip = "'Get over here!'";
				goto IL_381A;
			}
			if (this.type == 85)
			{
				this.name = "Chain";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 8;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 214;
				this.width = 12;
				this.height = 12;
				this.value = 1000;
				this.tileBoost += 2;
				this.toolTip = "Can be climbed on";
				goto IL_381A;
			}
			if (this.type == 86)
			{
				this.name = "Shadow Scale";
				this.width = 14;
				this.height = 18;
				this.maxStack = 99;
				this.rare = 1;
				this.value = 500;
				goto IL_381A;
			}
			if (this.type == 87)
			{
				this.name = "Piggy Bank";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 29;
				this.width = 20;
				this.height = 12;
				this.value = 10000;
				goto IL_381A;
			}
			if (this.type == 88)
			{
				this.name = "Mining Helmet";
				this.width = 22;
				this.height = 16;
				this.defense = 1;
				this.headSlot = 11;
				this.rare = 1;
				this.value = 80000;
				this.toolTip = "Provides light when worn";
				goto IL_381A;
			}
			if (this.type == 89)
			{
				this.name = "Copper Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.headSlot = 1;
				this.value = 1250;
				goto IL_381A;
			}
			if (this.type == 90)
			{
				this.name = "Iron Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.headSlot = 2;
				this.value = 5000;
				goto IL_381A;
			}
			if (this.type == 91)
			{
				this.name = "Silver Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 3;
				this.headSlot = 3;
				this.value = 12500;
				goto IL_381A;
			}
			if (this.type == 92)
			{
				this.name = "Gold Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 4;
				this.headSlot = 4;
				this.value = 25000;
				goto IL_381A;
			}
			if (this.type == 93)
			{
				this.name = "Wood Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 4;
				this.width = 12;
				this.height = 12;
				goto IL_381A;
			}
			if (this.type == 94)
			{
				this.name = "Wood Platform";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.width = 8;
				this.height = 10;
				goto IL_381A;
			}
			if (this.type == 95)
			{
				this.useStyle = 5;
				this.useAnimation = 16;
				this.useTime = 16;
				this.name = "Flintlock Pistol";
				this.width = 24;
				this.height = 28;
				this.shoot = 14;
				this.useAmmo = 14;
				this.useSound = 11;
				this.damage = 10;
				this.shootSpeed = 5f;
				this.noMelee = true;
				this.value = 50000;
				this.scale = 0.9f;
				this.rare = 1;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 96)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 41;
				this.useTime = 41;
				this.name = "Musket";
				this.width = 44;
				this.height = 14;
				this.shoot = 10;
				this.useAmmo = 14;
				this.useSound = 11;
				this.damage = 25;
				this.shootSpeed = 8.5f;
				this.noMelee = true;
				this.value = 100000;
				this.knockBack = 4.5f;
				this.rare = 1;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 97)
			{
				this.name = "Musket Ball";
				this.shootSpeed = 4f;
				this.shoot = 14;
				this.damage = 7;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 2f;
				this.value = 7;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 98)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 8;
				this.useTime = 8;
				this.name = "Minishark";
				this.width = 50;
				this.height = 18;
				this.shoot = 10;
				this.useAmmo = 14;
				this.useSound = 11;
				this.damage = 6;
				this.shootSpeed = 7f;
				this.noMelee = true;
				this.value = 350000;
				this.rare = 2;
				this.toolTip = "33% chance to not consume ammo";
				this.toolTip2 = "'Half shark, half gun, completely awesome.'";
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 99)
			{
				this.useStyle = 5;
				this.useAnimation = 28;
				this.useTime = 28;
				this.name = "Iron Bow";
				this.color = new Color(160, 145, 130, 110);
				this.width = 12;
				this.height = 28;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 8;
				this.shootSpeed = 6.6f;
				this.noMelee = true;
				this.value = 1400;
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 100)
			{
				this.name = "Shadow Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 6;
				this.legSlot = 5;
				this.rare = 1;
				this.value = 22500;
				this.toolTip = "7% increased melee speed";
				goto IL_381A;
			}
			if (this.type == 101)
			{
				this.name = "Shadow Scalemail";
				this.width = 18;
				this.height = 18;
				this.defense = 7;
				this.bodySlot = 5;
				this.rare = 1;
				this.value = 30000;
				this.toolTip = "7% increased melee speed";
				goto IL_381A;
			}
			if (this.type == 102)
			{
				this.name = "Shadow Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 6;
				this.headSlot = 5;
				this.rare = 1;
				this.value = 37500;
				this.toolTip = "7% increased melee speed";
				goto IL_381A;
			}
			if (this.type == 103)
			{
				this.name = "Nightmare Pickaxe";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 20;
				this.useTime = 15;
				this.autoReuse = true;
				this.width = 24;
				this.height = 28;
				this.damage = 9;
				this.pick = 65;
				this.useSound = 1;
				this.knockBack = 3f;
				this.rare = 1;
				this.value = 18000;
				this.scale = 1.15f;
				this.toolTip = "Able to mine Hellstone";
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 104)
			{
				this.name = "The Breaker";
				this.autoReuse = true;
				this.useStyle = 1;
				this.useAnimation = 45;
				this.useTime = 19;
				this.hammer = 55;
				this.width = 24;
				this.height = 28;
				this.damage = 24;
				this.knockBack = 6f;
				this.scale = 1.3f;
				this.useSound = 1;
				this.rare = 1;
				this.value = 15000;
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 105)
			{
				this.flame = true;
				this.noWet = true;
				this.name = "Candle";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 33;
				this.width = 8;
				this.height = 18;
				this.holdStyle = 1;
				goto IL_381A;
			}
			if (this.type == 106)
			{
				this.name = "Copper Chandelier";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 34;
				this.width = 26;
				this.height = 26;
				this.value = 3000;
				goto IL_381A;
			}
			if (this.type == 107)
			{
				this.name = "Silver Chandelier";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 35;
				this.width = 26;
				this.height = 26;
				this.value = 12000;
				goto IL_381A;
			}
			if (this.type == 108)
			{
				this.name = "Gold Chandelier";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 36;
				this.width = 26;
				this.height = 26;
				this.value = 24000;
				goto IL_381A;
			}
			if (this.type == 109)
			{
				this.name = "Mana Crystal";
				this.maxStack = 99;
				this.consumable = true;
				this.width = 18;
				this.height = 18;
				this.useStyle = 4;
				this.useTime = 30;
				this.useSound = 29;
				this.useAnimation = 30;
				this.toolTip = "Permanently increases maximum mana by 20";
				this.rare = 2;
				goto IL_381A;
			}
			if (this.type == 110)
			{
				this.name = "Lesser Mana Potion";
				this.useSound = 3;
				this.healMana = 50;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 15;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.value = 200;
				goto IL_381A;
			}
			if (this.type == 111)
			{
				this.name = "Band of Starpower";
				this.width = 22;
				this.height = 22;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "Increases maximum mana by 20";
				this.value = 50000;
				goto IL_381A;
			}
			if (this.type == 112)
			{
				this.mana = 17;
				this.damage = 44;
				this.useStyle = 1;
				this.name = "Flower of Fire";
				this.shootSpeed = 6f;
				this.shoot = 15;
				this.width = 26;
				this.height = 28;
				this.useSound = 20;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.knockBack = 5.5f;
				this.toolTip = "Throws balls of fire";
				this.value = 10000;
				this.magic = true;
				goto IL_381A;
			}
			if (this.type == 113)
			{
				this.mana = 10;
				this.channel = true;
				this.damage = 22;
				this.useStyle = 1;
				this.name = "Magic Missile";
				this.shootSpeed = 6f;
				this.shoot = 16;
				this.width = 26;
				this.height = 28;
				this.useSound = 9;
				this.useAnimation = 17;
				this.useTime = 17;
				this.rare = 2;
				this.noMelee = true;
				this.knockBack = 5f;
				this.toolTip = "Casts a controllable missile";
				this.value = 10000;
				this.magic = true;
				goto IL_381A;
			}
			if (this.type == 114)
			{
				this.channel = true;
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Dirt Rod";
				this.shoot = 17;
				this.width = 26;
				this.height = 28;
				this.useSound = 8;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 1;
				this.noMelee = true;
				this.knockBack = 5f;
				this.toolTip = "Magically moves dirt";
				this.value = 200000;
				goto IL_381A;
			}
			if (this.type == 115)
			{
				this.channel = true;
				this.damage = 0;
				this.useStyle = 4;
				this.name = "Shadow Orb";
				this.shoot = 18;
				this.width = 24;
				this.height = 24;
				this.useSound = 8;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 1;
				this.noMelee = true;
				this.toolTip = "Creates a magical shadow orb";
				this.value = 10000;
				this.buffType = 19;
				goto IL_381A;
			}
			if (this.type == 116)
			{
				this.name = "Meteorite";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 37;
				this.width = 12;
				this.height = 12;
				this.value = 1000;
				goto IL_381A;
			}
			if (this.type == 117)
			{
				this.name = "Meteorite Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.rare = 1;
				this.toolTip = "'Warm to the touch'";
				this.value = 7000;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 9;
				goto IL_381A;
			}
			if (this.type == 118)
			{
				this.name = "Hook";
				this.maxStack = 99;
				this.width = 18;
				this.height = 18;
				this.value = 1000;
				this.toolTip = "Sometimes dropped by Skeletons and Piranha";
				goto IL_381A;
			}
			if (this.type == 119)
			{
				this.noMelee = true;
				this.useStyle = 1;
				this.name = "Flamarang";
				this.shootSpeed = 11f;
				this.shoot = 19;
				this.damage = 32;
				this.knockBack = 8f;
				this.width = 14;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.rare = 3;
				this.value = 100000;
				this.melee = true;
				goto IL_381A;
			}
			if (this.type == 120)
			{
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 25;
				this.name = "Molten Fury";
				this.width = 14;
				this.height = 32;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 29;
				this.shootSpeed = 8f;
				this.knockBack = 2f;
				this.alpha = 30;
				this.rare = 3;
				this.noMelee = true;
				this.scale = 1.1f;
				this.value = 27000;
				this.toolTip = "Lights wooden arrows ablaze";
				this.ranged = true;
				goto IL_381A;
			}
			if (this.type == 121)
			{
				this.name = "Fiery Greatsword";
				this.useStyle = 1;
				this.useAnimation = 34;
				this.knockBack = 6.5f;
				this.width = 24;
				this.height = 28;
				this.damage = 36;
				this.scale = 1.3f;
				this.useSound = 1;
				this.rare = 3;
				this.value = 27000;
				this.toolTip = "'It's made out of fire!'";
				this.melee = true;
			}
			IL_381A:
			if (this.type == 122)
			{
				this.name = "Molten Pickaxe";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 25;
				this.useTime = 25;
				this.autoReuse = true;
				this.width = 24;
				this.height = 28;
				this.damage = 12;
				this.pick = 100;
				this.scale = 1.15f;
				this.useSound = 1;
				this.knockBack = 2f;
				this.rare = 3;
				this.value = 27000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 123)
			{
				this.name = "Meteor Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.headSlot = 6;
				this.rare = 1;
				this.value = 45000;
				this.toolTip = "7% increased magic damage";
				goto IL_2B846;
			}
			if (this.type == 124)
			{
				this.name = "Meteor Suit";
				this.width = 18;
				this.height = 18;
				this.defense = 6;
				this.bodySlot = 6;
				this.rare = 1;
				this.value = 30000;
				this.toolTip = "7% increased magic damage";
				goto IL_2B846;
			}
			if (this.type == 125)
			{
				this.name = "Meteor Leggings";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.legSlot = 6;
				this.rare = 1;
				this.value = 30000;
				this.toolTip = "7% increased magic damage";
				goto IL_2B846;
			}
			if (this.type == 126)
			{
				this.name = "Bottled Water";
				this.useSound = 3;
				this.healLife = 20;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.potion = true;
				this.value = 20;
				goto IL_2B846;
			}
			if (this.type == 127)
			{
				this.autoReuse = true;
				this.useStyle = 5;
				this.useAnimation = 18;
				this.useTime = 18;
				this.name = "Space Gun";
				this.width = 24;
				this.height = 28;
				this.shoot = 20;
				this.mana = 8;
				this.useSound = 12;
				this.knockBack = 0.5f;
				this.damage = 18;
				this.shootSpeed = 10f;
				this.noMelee = true;
				this.scale = 0.8f;
				this.rare = 1;
				this.magic = true;
				this.value = 20000;
				goto IL_2B846;
			}
			if (this.type == 128)
			{
				this.name = "Rocket Boots";
				this.width = 28;
				this.height = 24;
				this.accessory = true;
				this.rare = 3;
				this.toolTip = "Allows flight";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 129)
			{
				this.name = "Gray Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 38;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 130)
			{
				this.name = "Gray Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 5;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 131)
			{
				this.name = "Red Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 39;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 132)
			{
				this.name = "Red Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 6;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 133)
			{
				this.name = "Clay Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 40;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 134)
			{
				this.name = "Blue Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 41;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 135)
			{
				this.name = "Blue Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 17;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 136)
			{
				this.name = "Chain Lantern";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 42;
				this.width = 12;
				this.height = 28;
				goto IL_2B846;
			}
			if (this.type == 137)
			{
				this.name = "Green Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 43;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 138)
			{
				this.name = "Green Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 18;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 139)
			{
				this.name = "Pink Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 44;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 140)
			{
				this.name = "Pink Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 19;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 141)
			{
				this.name = "Gold Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 45;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 142)
			{
				this.name = "Gold Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 10;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 143)
			{
				this.name = "Silver Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 46;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 144)
			{
				this.name = "Silver Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 11;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 145)
			{
				this.name = "Copper Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 47;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 146)
			{
				this.name = "Copper Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 12;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 147)
			{
				this.name = "Spike";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 48;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 148)
			{
				this.flame = true;
				this.noWet = true;
				this.name = "Water Candle";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 49;
				this.width = 8;
				this.height = 18;
				this.holdStyle = 1;
				this.toolTip = "Holding this may attract unwanted attention";
				goto IL_2B846;
			}
			if (this.type == 149)
			{
				this.name = "Book";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 50;
				this.width = 24;
				this.height = 28;
				this.toolTip = "'It contains strange symbols'";
				goto IL_2B846;
			}
			if (this.type == 150)
			{
				this.name = "Cobweb";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 51;
				this.width = 20;
				this.height = 24;
				this.alpha = 100;
				goto IL_2B846;
			}
			if (this.type == 151)
			{
				this.name = "Necro Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.headSlot = 7;
				this.rare = 2;
				this.value = 45000;
				this.toolTip = "4% increased ranged damage.";
				goto IL_2B846;
			}
			if (this.type == 152)
			{
				this.name = "Necro Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 6;
				this.bodySlot = 7;
				this.rare = 2;
				this.value = 30000;
				this.toolTip = "4% increased ranged damage.";
				goto IL_2B846;
			}
			if (this.type == 153)
			{
				this.name = "Necro Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.legSlot = 7;
				this.rare = 2;
				this.value = 30000;
				this.toolTip = "4% increased ranged damage.";
				goto IL_2B846;
			}
			if (this.type == 154)
			{
				this.name = "Bone";
				this.maxStack = 99;
				this.consumable = true;
				this.width = 12;
				this.height = 14;
				this.value = 50;
				this.useAnimation = 12;
				this.useTime = 12;
				this.useStyle = 1;
				this.useSound = 1;
				this.shootSpeed = 8f;
				this.noUseGraphic = true;
				this.damage = 22;
				this.knockBack = 4f;
				this.shoot = 21;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 155)
			{
				this.autoReuse = true;
				this.useTurn = true;
				this.name = "Muramasa";
				this.useStyle = 1;
				this.useAnimation = 20;
				this.width = 40;
				this.height = 40;
				this.damage = 18;
				this.scale = 1.1f;
				this.useSound = 1;
				this.rare = 2;
				this.value = 27000;
				this.knockBack = 1f;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 156)
			{
				this.name = "Cobalt Shield";
				this.width = 24;
				this.height = 28;
				this.rare = 2;
				this.value = 27000;
				this.accessory = true;
				this.defense = 1;
				this.toolTip = "Grants immunity to knockback";
				goto IL_2B846;
			}
			if (this.type == 157)
			{
				this.mana = 4;
				this.autoReuse = true;
				this.name = "Aqua Scepter";
				this.useStyle = 5;
				this.useAnimation = 16;
				this.useTime = 8;
				this.knockBack = 5f;
				this.width = 38;
				this.height = 10;
				this.damage = 15;
				this.scale = 1f;
				this.shoot = 22;
				this.shootSpeed = 11f;
				this.useSound = 13;
				this.rare = 2;
				this.value = 27000;
				this.toolTip = "Sprays out a shower of water";
				this.magic = true;
				goto IL_2B846;
			}
			if (this.type == 158)
			{
				this.name = "Lucky Horseshoe";
				this.width = 20;
				this.height = 22;
				this.rare = 1;
				this.value = 27000;
				this.accessory = true;
				this.toolTip = "Negates fall damage";
				goto IL_2B846;
			}
			if (this.type == 159)
			{
				this.name = "Shiny Red Balloon";
				this.width = 14;
				this.height = 28;
				this.rare = 1;
				this.value = 27000;
				this.accessory = true;
				this.toolTip = "Increases jump height";
				goto IL_2B846;
			}
			if (this.type == 160)
			{
				this.autoReuse = true;
				this.name = "Harpoon";
				this.useStyle = 5;
				this.useAnimation = 30;
				this.useTime = 30;
				this.knockBack = 6f;
				this.width = 30;
				this.height = 10;
				this.damage = 25;
				this.scale = 1.1f;
				this.shoot = 23;
				this.shootSpeed = 11f;
				this.useSound = 10;
				this.rare = 2;
				this.value = 27000;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 161)
			{
				this.useStyle = 1;
				this.name = "Spiky Ball";
				this.shootSpeed = 5f;
				this.shoot = 24;
				this.knockBack = 1f;
				this.damage = 15;
				this.width = 10;
				this.height = 10;
				this.maxStack = 999;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 80;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 162)
			{
				this.name = "Ball O' Hurt";
				this.useStyle = 5;
				this.useAnimation = 45;
				this.useTime = 45;
				this.knockBack = 6.5f;
				this.width = 30;
				this.height = 10;
				this.damage = 15;
				this.scale = 1.1f;
				this.noUseGraphic = true;
				this.shoot = 25;
				this.shootSpeed = 12f;
				this.useSound = 1;
				this.rare = 1;
				this.value = 27000;
				this.melee = true;
				this.channel = true;
				this.noMelee = true;
				goto IL_2B846;
			}
			if (this.type == 163)
			{
				this.name = "Blue Moon";
				this.useStyle = 5;
				this.useAnimation = 45;
				this.useTime = 45;
				this.knockBack = 7f;
				this.width = 30;
				this.height = 10;
				this.damage = 23;
				this.scale = 1.1f;
				this.noUseGraphic = true;
				this.shoot = 26;
				this.shootSpeed = 12f;
				this.useSound = 1;
				this.rare = 2;
				this.value = 27000;
				this.melee = true;
				this.channel = true;
				goto IL_2B846;
			}
			if (this.type == 164)
			{
				this.autoReuse = false;
				this.useStyle = 5;
				this.useAnimation = 12;
				this.useTime = 12;
				this.name = "Handgun";
				this.width = 24;
				this.height = 24;
				this.shoot = 14;
				this.knockBack = 3f;
				this.useAmmo = 14;
				this.useSound = 41;
				this.damage = 15;
				this.shootSpeed = 10f;
				this.noMelee = true;
				this.value = 50000;
				this.scale = 0.85f;
				this.rare = 2;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 165)
			{
				this.autoReuse = true;
				this.rare = 2;
				this.mana = 10;
				this.useSound = 21;
				this.name = "Water Bolt";
				this.useStyle = 5;
				this.damage = 17;
				this.useAnimation = 17;
				this.useTime = 17;
				this.width = 24;
				this.height = 28;
				this.shoot = 27;
				this.scale = 0.9f;
				this.shootSpeed = 4.5f;
				this.knockBack = 5f;
				this.toolTip = "Casts a slow moving bolt of water";
				this.magic = true;
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 166)
			{
				this.useStyle = 1;
				this.name = "Bomb";
				this.shootSpeed = 5f;
				this.shoot = 28;
				this.width = 20;
				this.height = 20;
				this.maxStack = 100;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 25;
				this.useTime = 25;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = Item.buyPrice(0, 0, 3, 0);
				this.damage = 0;
				this.toolTip = "A small explosion that will destroy some tiles";
				goto IL_2B846;
			}
			if (this.type == 167)
			{
				this.useStyle = 1;
				this.name = "Dynamite";
				this.shootSpeed = 4f;
				this.shoot = 29;
				this.width = 8;
				this.height = 28;
				this.maxStack = 30;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 40;
				this.useTime = 40;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = Item.sellPrice(0, 0, 30, 0);
				this.rare = 1;
				this.toolTip = "A large explosion that will destroy most tiles";
				goto IL_2B846;
			}
			if (this.type == 168)
			{
				this.useStyle = 5;
				this.name = "Grenade";
				this.shootSpeed = 5.5f;
				this.shoot = 30;
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 45;
				this.useTime = 45;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 75;
				this.damage = 60;
				this.knockBack = 8f;
				this.toolTip = "A small explosion that will not destroy tiles";
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 169)
			{
				this.name = "Sand Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 53;
				this.width = 12;
				this.height = 12;
				this.ammo = 42;
				goto IL_2B846;
			}
			if (this.type == 170)
			{
				this.name = "Glass";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 54;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 171)
			{
				this.name = "Sign";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 55;
				this.width = 28;
				this.height = 28;
				goto IL_2B846;
			}
			if (this.type == 172)
			{
				this.name = "Ash Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 57;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 173)
			{
				this.name = "Obsidian";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 56;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 174)
			{
				this.name = "Hellstone";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 58;
				this.width = 12;
				this.height = 12;
				this.rare = 2;
				goto IL_2B846;
			}
			if (this.type == 175)
			{
				this.name = "Hellstone Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.rare = 2;
				this.toolTip = "'Hot to the touch'";
				this.value = 20000;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 10;
				goto IL_2B846;
			}
			if (this.type == 176)
			{
				this.name = "Mud Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 59;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 181)
			{
				this.name = "Amethyst";
				this.createTile = 178;
				this.placeStyle = 0;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.alpha = 50;
				this.width = 10;
				this.height = 14;
				this.value = 1875;
				goto IL_2B846;
			}
			if (this.type == 180)
			{
				this.name = "Topaz";
				this.createTile = 178;
				this.placeStyle = 1;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.alpha = 50;
				this.width = 10;
				this.height = 14;
				this.value = 3750;
				goto IL_2B846;
			}
			if (this.type == 177)
			{
				this.name = "Sapphire";
				this.createTile = 178;
				this.placeStyle = 2;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.alpha = 50;
				this.width = 10;
				this.height = 14;
				this.value = 5625;
				goto IL_2B846;
			}
			if (this.type == 179)
			{
				this.name = "Emerald";
				this.createTile = 178;
				this.placeStyle = 3;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.alpha = 50;
				this.width = 10;
				this.height = 14;
				this.value = 7500;
				goto IL_2B846;
			}
			if (this.type == 178)
			{
				this.name = "Ruby";
				this.createTile = 178;
				this.placeStyle = 4;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.alpha = 50;
				this.width = 10;
				this.height = 14;
				this.value = 11250;
				goto IL_2B846;
			}
			if (this.type == 182)
			{
				this.name = "Diamond";
				this.createTile = 178;
				this.placeStyle = 5;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.alpha = 50;
				this.width = 10;
				this.height = 14;
				this.value = 15000;
				goto IL_2B846;
			}
			if (this.type == 183)
			{
				this.name = "Glowing Mushroom";
				this.width = 16;
				this.height = 18;
				this.value = 50;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 190;
				goto IL_2B846;
			}
			if (this.type == 184)
			{
				this.name = "Star";
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 185)
			{
				this.noUseGraphic = true;
				this.damage = 0;
				this.knockBack = 7f;
				this.useStyle = 5;
				this.name = "Ivy Whip";
				this.shootSpeed = 13f;
				this.shoot = 32;
				this.width = 18;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.value = 20000;
				goto IL_2B846;
			}
			if (this.type == 186)
			{
				this.name = "Breathing Reed";
				this.width = 44;
				this.height = 44;
				this.rare = 1;
				this.value = 10000;
				this.holdStyle = 2;
				this.toolTip = "'Because not drowning is kinda nice'";
				goto IL_2B846;
			}
			if (this.type == 187)
			{
				this.name = "Flipper";
				this.width = 28;
				this.height = 28;
				this.rare = 1;
				this.value = 10000;
				this.accessory = true;
				this.toolTip = "Grants the ability to swim";
				goto IL_2B846;
			}
			if (this.type == 188)
			{
				this.name = "Healing Potion";
				this.useSound = 3;
				this.healLife = 100;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.rare = 1;
				this.potion = true;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 189)
			{
				this.name = "Mana Potion";
				this.useSound = 3;
				this.healMana = 100;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 25;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.rare = 1;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 190)
			{
				this.name = "Blade of Grass";
				this.useStyle = 1;
				this.useAnimation = 30;
				this.knockBack = 3f;
				this.width = 40;
				this.height = 40;
				this.damage = 28;
				this.scale = 1.4f;
				this.useSound = 1;
				this.rare = 3;
				this.value = 27000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 191)
			{
				this.noMelee = true;
				this.useStyle = 1;
				this.name = "Thorn Chakram";
				this.shootSpeed = 11f;
				this.shoot = 33;
				this.damage = 25;
				this.knockBack = 8f;
				this.width = 14;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.rare = 3;
				this.value = 50000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 192)
			{
				this.name = "Obsidian Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 75;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 193)
			{
				this.name = "Obsidian Skull";
				this.width = 20;
				this.height = 22;
				this.rare = 2;
				this.value = 27000;
				this.accessory = true;
				this.defense = 1;
				this.toolTip = "Grants immunity to fire blocks";
				goto IL_2B846;
			}
			if (this.type == 194)
			{
				this.name = "Mushroom Grass Seeds";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 70;
				this.width = 14;
				this.height = 14;
				this.value = 150;
				goto IL_2B846;
			}
			if (this.type == 195)
			{
				this.name = "Jungle Grass Seeds";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 60;
				this.width = 14;
				this.height = 14;
				this.value = 150;
				goto IL_2B846;
			}
			if (this.type == 196)
			{
				this.name = "Wooden Hammer";
				this.autoReuse = true;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 37;
				this.useTime = 25;
				this.hammer = 25;
				this.width = 24;
				this.height = 28;
				this.damage = 2;
				this.knockBack = 5.5f;
				this.scale = 1.2f;
				this.useSound = 1;
				this.tileBoost = -1;
				this.value = 50;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 197)
			{
				this.autoReuse = true;
				this.useStyle = 5;
				this.useAnimation = 12;
				this.useTime = 12;
				this.name = "Star Cannon";
				this.width = 50;
				this.height = 18;
				this.shoot = 12;
				this.useAmmo = 15;
				this.useSound = 9;
				this.damage = 55;
				this.shootSpeed = 14f;
				this.noMelee = true;
				this.value = 500000;
				this.rare = 2;
				this.toolTip = "Shoots fallen stars";
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 198)
			{
				this.name = "Blue Phaseblade";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.knockBack = 3f;
				this.width = 40;
				this.height = 40;
				this.damage = 21;
				this.scale = 1f;
				this.useSound = 15;
				this.rare = 1;
				this.value = 27000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 199)
			{
				this.name = "Red Phaseblade";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.knockBack = 3f;
				this.width = 40;
				this.height = 40;
				this.damage = 21;
				this.scale = 1f;
				this.useSound = 15;
				this.rare = 1;
				this.value = 27000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 200)
			{
				this.name = "Green Phaseblade";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.knockBack = 3f;
				this.width = 40;
				this.height = 40;
				this.damage = 21;
				this.scale = 1f;
				this.useSound = 15;
				this.rare = 1;
				this.value = 27000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 201)
			{
				this.name = "Purple Phaseblade";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.knockBack = 3f;
				this.width = 40;
				this.height = 40;
				this.damage = 21;
				this.scale = 1f;
				this.useSound = 15;
				this.rare = 1;
				this.value = 27000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 202)
			{
				this.name = "White Phaseblade";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.knockBack = 3f;
				this.width = 40;
				this.height = 40;
				this.damage = 21;
				this.scale = 1f;
				this.useSound = 15;
				this.rare = 1;
				this.value = 27000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 203)
			{
				this.name = "Yellow Phaseblade";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.knockBack = 3f;
				this.width = 40;
				this.height = 40;
				this.damage = 21;
				this.scale = 1f;
				this.useSound = 15;
				this.rare = 1;
				this.value = 27000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 204)
			{
				this.name = "Meteor Hamaxe";
				this.useTurn = true;
				this.autoReuse = true;
				this.useStyle = 1;
				this.useAnimation = 30;
				this.useTime = 16;
				this.hammer = 60;
				this.axe = 20;
				this.width = 24;
				this.height = 28;
				this.damage = 20;
				this.knockBack = 7f;
				this.scale = 1.2f;
				this.useSound = 1;
				this.rare = 1;
				this.value = 15000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 205)
			{
				this.name = "Empty Bucket";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.width = 20;
				this.height = 20;
				this.headSlot = 13;
				this.defense = 1;
				goto IL_2B846;
			}
			if (this.type == 206)
			{
				this.name = "Water Bucket";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.width = 20;
				this.height = 20;
				goto IL_2B846;
			}
			if (this.type == 207)
			{
				this.name = "Lava Bucket";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.width = 20;
				this.height = 20;
				goto IL_2B846;
			}
			if (this.type == 208)
			{
				this.name = "Jungle Rose";
				this.width = 20;
				this.height = 20;
				this.value = 100;
				this.headSlot = 23;
				this.toolTip = "'It's pretty, oh so pretty'";
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 209)
			{
				this.name = "Stinger";
				this.width = 16;
				this.height = 18;
				this.maxStack = 99;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 210)
			{
				this.name = "Vine";
				this.width = 14;
				this.height = 20;
				this.maxStack = 99;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 211)
			{
				this.name = "Feral Claws";
				this.width = 20;
				this.height = 20;
				this.accessory = true;
				this.rare = 3;
				this.toolTip = "12% increased melee speed";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 212)
			{
				this.name = "Anklet of the Wind";
				this.width = 20;
				this.height = 20;
				this.accessory = true;
				this.rare = 3;
				this.toolTip = "10% increased movement speed";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 213)
			{
				this.name = "Staff of Regrowth";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 25;
				this.useTime = 13;
				this.autoReuse = true;
				this.width = 24;
				this.height = 28;
				this.damage = 7;
				this.createTile = 2;
				this.scale = 1.2f;
				this.useSound = 1;
				this.knockBack = 3f;
				this.rare = 3;
				this.value = 2000;
				this.toolTip = "Creates grass on dirt";
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 214)
			{
				this.name = "Hellstone Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 76;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 215)
			{
				this.name = "Whoopie Cushion";
				this.width = 18;
				this.height = 18;
				this.useTurn = true;
				this.useTime = 30;
				this.useAnimation = 30;
				this.noUseGraphic = true;
				this.useStyle = 10;
				this.useSound = 16;
				this.rare = 2;
				this.toolTip = "'May annoy others'";
				this.value = 100;
				goto IL_2B846;
			}
			if (this.type == 216)
			{
				this.name = "Shackle";
				this.width = 20;
				this.height = 20;
				this.rare = 1;
				this.value = 1500;
				this.accessory = true;
				this.defense = 1;
				goto IL_2B846;
			}
			if (this.type == 217)
			{
				this.name = "Molten Hamaxe";
				this.useTurn = true;
				this.autoReuse = true;
				this.useStyle = 1;
				this.useAnimation = 27;
				this.useTime = 14;
				this.hammer = 70;
				this.axe = 30;
				this.width = 24;
				this.height = 28;
				this.damage = 20;
				this.knockBack = 7f;
				this.scale = 1.4f;
				this.useSound = 1;
				this.rare = 3;
				this.value = 15000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 218)
			{
				this.mana = 16;
				this.channel = true;
				this.damage = 34;
				this.useStyle = 1;
				this.name = "Flamelash";
				this.shootSpeed = 6f;
				this.shoot = 34;
				this.width = 26;
				this.height = 28;
				this.useSound = 20;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.knockBack = 6.5f;
				this.toolTip = "Summons a controllable ball of fire";
				this.value = 10000;
				this.magic = true;
				goto IL_2B846;
			}
			if (this.type == 219)
			{
				this.autoReuse = false;
				this.useStyle = 5;
				this.useAnimation = 11;
				this.useTime = 11;
				this.name = "Phoenix Blaster";
				this.width = 24;
				this.height = 22;
				this.shoot = 14;
				this.knockBack = 2f;
				this.useAmmo = 14;
				this.useSound = 41;
				this.damage = 23;
				this.shootSpeed = 13f;
				this.noMelee = true;
				this.value = 50000;
				this.scale = 0.85f;
				this.rare = 3;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 220)
			{
				this.name = "Sunfury";
				this.noMelee = true;
				this.useStyle = 5;
				this.useAnimation = 45;
				this.useTime = 45;
				this.knockBack = 7f;
				this.width = 30;
				this.height = 10;
				this.damage = 33;
				this.scale = 1.1f;
				this.noUseGraphic = true;
				this.shoot = 35;
				this.shootSpeed = 12f;
				this.useSound = 1;
				this.rare = 3;
				this.value = 27000;
				this.melee = true;
				this.channel = true;
				goto IL_2B846;
			}
			if (this.type == 221)
			{
				this.name = "Hellforge";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 77;
				this.width = 26;
				this.height = 24;
				this.value = 3000;
				goto IL_2B846;
			}
			if (this.type == 222)
			{
				this.name = "Clay Pot";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 78;
				this.width = 14;
				this.height = 14;
				this.value = 100;
				this.toolTip = "Grows plants";
				goto IL_2B846;
			}
			if (this.type == 223)
			{
				this.name = "Nature's Gift";
				this.width = 20;
				this.height = 22;
				this.rare = 3;
				this.value = 27000;
				this.accessory = true;
				this.toolTip = "6% reduced mana usage";
				goto IL_2B846;
			}
			if (this.type == 224)
			{
				this.name = "Bed";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 79;
				this.width = 28;
				this.height = 20;
				this.value = 2000;
				goto IL_2B846;
			}
			if (this.type == 225)
			{
				this.name = "Silk";
				this.maxStack = 99;
				this.width = 22;
				this.height = 22;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 226)
			{
				this.name = "Lesser Restoration Potion";
				this.useSound = 3;
				this.healMana = 50;
				this.healLife = 50;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 20;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.potion = true;
				this.value = 2000;
				goto IL_2B846;
			}
			if (this.type == 227)
			{
				this.name = "Restoration Potion";
				this.useSound = 3;
				this.healMana = 100;
				this.healLife = 100;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 20;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.potion = true;
				this.value = 4000;
				goto IL_2B846;
			}
			if (this.type == 228)
			{
				this.name = "Jungle Hat";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.headSlot = 8;
				this.rare = 3;
				this.value = 45000;
				this.toolTip = "Increases maximum mana by 20";
				this.toolTip2 = "3% increased magic critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 229)
			{
				this.name = "Jungle Shirt";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.bodySlot = 8;
				this.rare = 3;
				this.value = 30000;
				this.toolTip = "Increases maximum mana by 20";
				this.toolTip2 = "3% increased magic critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 230)
			{
				this.name = "Jungle Pants";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.legSlot = 8;
				this.rare = 3;
				this.value = 30000;
				this.toolTip = "Increases maximum mana by 20";
				this.toolTip2 = "3% increased magic critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 231)
			{
				this.name = "Molten Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 8;
				this.headSlot = 9;
				this.rare = 3;
				this.value = 45000;
				goto IL_2B846;
			}
			if (this.type == 232)
			{
				this.name = "Molten Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 9;
				this.bodySlot = 9;
				this.rare = 3;
				this.value = 30000;
				goto IL_2B846;
			}
			if (this.type == 233)
			{
				this.name = "Molten Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 8;
				this.legSlot = 9;
				this.rare = 3;
				this.value = 30000;
				goto IL_2B846;
			}
			if (this.type == 234)
			{
				this.name = "Meteor Shot";
				this.shootSpeed = 3f;
				this.shoot = 36;
				this.damage = 9;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 1f;
				this.value = 8;
				this.rare = 1;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 235)
			{
				this.useStyle = 1;
				this.name = "Sticky Bomb";
				this.shootSpeed = 5f;
				this.shoot = 37;
				this.width = 20;
				this.height = 20;
				this.maxStack = 50;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 25;
				this.useTime = 25;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 500;
				this.damage = 0;
				this.toolTip = "'Tossing may be difficult.'";
				goto IL_2B846;
			}
			if (this.type == 236)
			{
				this.name = "Black Lens";
				this.width = 12;
				this.height = 20;
				this.maxStack = 99;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 237)
			{
				this.name = "Sunglasses";
				this.width = 28;
				this.height = 12;
				this.headSlot = 12;
				this.rare = 2;
				this.value = 10000;
				this.toolTip = "'Makes you look cool!'";
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 238)
			{
				this.name = "Wizard Hat";
				this.width = 28;
				this.height = 20;
				this.headSlot = 14;
				this.rare = 2;
				this.value = 10000;
				this.defense = 2;
				this.toolTip = "15% increased magic damage";
				goto IL_2B846;
			}
			if (this.type == 239)
			{
				this.name = "Top Hat";
				this.width = 18;
				this.height = 18;
				this.headSlot = 15;
				this.value = 10000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 240)
			{
				this.name = "Tuxedo Shirt";
				this.width = 18;
				this.height = 18;
				this.bodySlot = 10;
				this.value = 5000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 241)
			{
				this.name = "Tuxedo Pants";
				this.width = 18;
				this.height = 18;
				this.legSlot = 10;
				this.value = 5000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 242)
			{
				this.name = "Summer Hat";
				this.width = 18;
				this.height = 18;
				this.headSlot = 16;
				this.value = 10000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 243)
			{
				this.name = "Bunny Hood";
				this.width = 18;
				this.height = 18;
				this.headSlot = 17;
				this.value = 20000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 244)
			{
				this.name = "Plumber's Hat";
				this.width = 18;
				this.height = 12;
				this.headSlot = 18;
				this.value = 10000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 245)
			{
				this.name = "Plumber's Shirt";
				this.width = 18;
				this.height = 18;
				this.bodySlot = 11;
				this.value = 250000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 246)
			{
				this.name = "Plumber's Pants";
				this.width = 18;
				this.height = 18;
				this.legSlot = 11;
				this.value = 250000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 247)
			{
				this.name = "Hero's Hat";
				this.width = 18;
				this.height = 12;
				this.headSlot = 19;
				this.value = 10000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 248)
			{
				this.name = "Hero's Shirt";
				this.width = 18;
				this.height = 18;
				this.bodySlot = 12;
				this.value = 5000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 249)
			{
				this.name = "Hero's Pants";
				this.width = 18;
				this.height = 18;
				this.legSlot = 12;
				this.value = 5000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 250)
			{
				this.name = "Fish Bowl";
				this.width = 18;
				this.height = 18;
				this.headSlot = 20;
				this.value = 10000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 251)
			{
				this.name = "Archaeologist's Hat";
				this.width = 18;
				this.height = 12;
				this.headSlot = 21;
				this.value = 10000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 252)
			{
				this.name = "Archaeologist's Jacket";
				this.width = 18;
				this.height = 18;
				this.bodySlot = 13;
				this.value = 5000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 253)
			{
				this.name = "Archaeologist's Pants";
				this.width = 18;
				this.height = 18;
				this.legSlot = 13;
				this.value = 5000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 254)
			{
				this.name = "Black Thread";
				this.maxStack = 99;
				this.width = 12;
				this.height = 20;
				this.value = 10000;
				goto IL_2B846;
			}
			if (this.type == 255)
			{
				this.name = "Green Thread";
				this.maxStack = 99;
				this.width = 12;
				this.height = 20;
				this.value = 2000;
				goto IL_2B846;
			}
			if (this.type == 256)
			{
				this.name = "Ninja Hood";
				this.width = 18;
				this.height = 12;
				this.headSlot = 22;
				this.value = 10000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 257)
			{
				this.name = "Ninja Shirt";
				this.width = 18;
				this.height = 18;
				this.bodySlot = 14;
				this.value = 5000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 258)
			{
				this.name = "Ninja Pants";
				this.width = 18;
				this.height = 18;
				this.legSlot = 14;
				this.value = 5000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 259)
			{
				this.name = "Leather";
				this.width = 18;
				this.height = 20;
				this.maxStack = 99;
				this.value = 50;
				goto IL_2B846;
			}
			if (this.type == 260)
			{
				this.name = "Red Hat";
				this.width = 18;
				this.height = 14;
				this.headSlot = 24;
				this.value = 1000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 261)
			{
				this.name = "Goldfish";
				this.useStyle = 2;
				this.useSound = 2;
				this.useTurn = false;
				this.useAnimation = 17;
				this.useTime = 17;
				this.width = 20;
				this.height = 10;
				this.maxStack = 99;
				this.healLife = 20;
				this.consumable = true;
				this.value = Item.sellPrice(0, 0, 1, 0);
				this.potion = true;
				this.toolTip = "'It's smiling, might be a good snack'";
				goto IL_2B846;
			}
			if (this.type == 262)
			{
				this.name = "Robe";
				this.width = 18;
				this.height = 14;
				this.bodySlot = 15;
				this.value = 2000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 263)
			{
				this.name = "Robot Hat";
				this.width = 18;
				this.height = 18;
				this.headSlot = 25;
				this.value = 10000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 264)
			{
				this.name = "Gold Crown";
				this.width = 18;
				this.height = 18;
				this.headSlot = 26;
				this.value = 10000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 265)
			{
				this.name = "Hellfire Arrow";
				this.shootSpeed = 6.5f;
				this.shoot = 41;
				this.damage = 10;
				this.width = 10;
				this.height = 28;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 1;
				this.knockBack = 8f;
				this.value = 100;
				this.rare = 2;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 266)
			{
				this.useStyle = 5;
				this.useAnimation = 16;
				this.useTime = 16;
				this.autoReuse = true;
				this.name = "Sandgun";
				this.width = 40;
				this.height = 20;
				this.shoot = 42;
				this.useAmmo = 42;
				this.useSound = 11;
				this.damage = 30;
				this.shootSpeed = 12f;
				this.noMelee = true;
				this.knockBack = 5f;
				this.value = 10000;
				this.rare = 2;
				this.toolTip = "'This is a good idea!'";
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 267)
			{
				this.accessory = true;
				this.name = "Guide Voodoo Doll";
				this.width = 14;
				this.height = 26;
				this.value = 1000;
				this.toolTip = "'You are a terrible person.'";
				goto IL_2B846;
			}
			if (this.type == 268)
			{
				this.headSlot = 27;
				this.defense = 2;
				this.name = "Diving Helmet";
				this.width = 20;
				this.height = 20;
				this.value = 1000;
				this.rare = 2;
				this.toolTip = "Greatly extends underwater breathing";
				goto IL_2B846;
			}
			if (this.type == 269)
			{
				this.name = "Familiar Shirt";
				this.bodySlot = 0;
				this.width = 20;
				this.height = 20;
				this.value = 10000;
				this.color = Main.player[Main.myPlayer].shirtColor;
				goto IL_2B846;
			}
			if (this.type == 270)
			{
				this.name = "Familiar Pants";
				this.legSlot = 0;
				this.width = 20;
				this.height = 20;
				this.value = 10000;
				this.color = Main.player[Main.myPlayer].pantsColor;
				goto IL_2B846;
			}
			if (this.type == 271)
			{
				this.name = "Familiar Wig";
				this.headSlot = 0;
				this.width = 20;
				this.height = 20;
				this.value = 10000;
				this.color = Main.player[Main.myPlayer].hairColor;
				goto IL_2B846;
			}
			if (this.type == 272)
			{
				this.mana = 14;
				this.damage = 35;
				this.useStyle = 5;
				this.name = "Demon Scythe";
				this.shootSpeed = 0.2f;
				this.shoot = 45;
				this.width = 26;
				this.height = 28;
				this.useSound = 8;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.knockBack = 5f;
				this.scale = 0.9f;
				this.toolTip = "Casts a demon scythe";
				this.value = 10000;
				this.magic = true;
				goto IL_2B846;
			}
			if (this.type == 273)
			{
				this.name = "Night's Edge";
				this.useStyle = 1;
				this.useAnimation = 27;
				this.useTime = 27;
				this.knockBack = 4.5f;
				this.width = 40;
				this.height = 40;
				this.damage = 42;
				this.scale = 1.15f;
				this.useSound = 1;
				this.rare = 3;
				this.value = 54000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 274)
			{
				this.name = "Dark Lance";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 25;
				this.shootSpeed = 5f;
				this.knockBack = 4f;
				this.width = 40;
				this.height = 40;
				this.damage = 27;
				this.scale = 1.1f;
				this.useSound = 1;
				this.shoot = 46;
				this.rare = 3;
				this.value = 27000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 275)
			{
				this.name = "Coral";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 81;
				this.width = 20;
				this.height = 22;
				this.value = 400;
				goto IL_2B846;
			}
			if (this.type == 276)
			{
				this.name = "Cactus";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 188;
				this.width = 12;
				this.height = 12;
				this.value = 10;
				goto IL_2B846;
			}
			if (this.type == 277)
			{
				this.name = "Trident";
				this.useStyle = 5;
				this.useAnimation = 31;
				this.useTime = 31;
				this.shootSpeed = 4f;
				this.knockBack = 5f;
				this.width = 40;
				this.height = 40;
				this.damage = 10;
				this.scale = 1.1f;
				this.useSound = 1;
				this.shoot = 47;
				this.rare = 1;
				this.value = 10000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 278)
			{
				this.name = "Silver Bullet";
				this.shootSpeed = 4.5f;
				this.shoot = 14;
				this.damage = 9;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 3f;
				this.value = 15;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 279)
			{
				this.useStyle = 1;
				this.name = "Throwing Knife";
				this.shootSpeed = 10f;
				this.shoot = 48;
				this.damage = 12;
				this.width = 18;
				this.height = 20;
				this.maxStack = 999;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 50;
				this.knockBack = 2f;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 280)
			{
				this.name = "Spear";
				this.useStyle = 5;
				this.useAnimation = 31;
				this.useTime = 31;
				this.shootSpeed = 3.7f;
				this.knockBack = 6.5f;
				this.width = 32;
				this.height = 32;
				this.damage = 8;
				this.scale = 1f;
				this.useSound = 1;
				this.shoot = 49;
				this.value = 1000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 281)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 45;
				this.useTime = 45;
				this.name = "Blowpipe";
				this.width = 38;
				this.height = 6;
				this.shoot = 10;
				this.useAmmo = 51;
				this.useSound = 5;
				this.damage = 9;
				this.shootSpeed = 11f;
				this.noMelee = true;
				this.value = 10000;
				this.knockBack = 3.5f;
				this.useAmmo = 51;
				this.toolTip = "Allows the collection of seeds for ammo";
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 282)
			{
				this.useStyle = 1;
				this.name = "Glowstick";
				this.shootSpeed = 6f;
				this.shoot = 50;
				this.width = 12;
				this.height = 12;
				this.maxStack = 99;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noMelee = true;
				this.value = 10;
				this.holdStyle = 1;
				this.toolTip = "Works when wet";
				goto IL_2B846;
			}
			if (this.type == 283)
			{
				this.name = "Seed";
				this.shoot = 51;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.ammo = 51;
				this.toolTip = "For use with Blowpipe";
				this.damage = 1;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 284)
			{
				this.noMelee = true;
				this.useStyle = 1;
				this.name = "Wooden Boomerang";
				this.shootSpeed = 6.5f;
				this.shoot = 52;
				this.damage = 7;
				this.knockBack = 5f;
				this.width = 14;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 16;
				this.useTime = 16;
				this.noUseGraphic = true;
				this.value = 5000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 285)
			{
				this.name = "Aglet";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "5% increased movement speed";
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 286)
			{
				this.useStyle = 1;
				this.name = "Sticky Glowstick";
				this.shootSpeed = 6f;
				this.shoot = 53;
				this.width = 12;
				this.height = 12;
				this.maxStack = 99;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noMelee = true;
				this.value = 20;
				this.holdStyle = 1;
				goto IL_2B846;
			}
			if (this.type == 287)
			{
				this.useStyle = 1;
				this.name = "Poisoned Knife";
				this.shootSpeed = 11f;
				this.shoot = 54;
				this.damage = 13;
				this.width = 18;
				this.height = 20;
				this.maxStack = 999;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 60;
				this.knockBack = 2f;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 288)
			{
				this.name = "Obsidian Skin Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 1;
				this.buffTime = 14400;
				this.toolTip = "Provides immunity to lava";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 289)
			{
				this.name = "Regeneration Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 2;
				this.buffTime = 18000;
				this.toolTip = "Provides life regeneration";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 290)
			{
				this.name = "Swiftness Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 3;
				this.buffTime = 14400;
				this.toolTip = "25% increased movement speed";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 291)
			{
				this.name = "Gills Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 4;
				this.buffTime = 7200;
				this.toolTip = "Breathe water instead of air";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 292)
			{
				this.name = "Ironskin Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 5;
				this.buffTime = 18000;
				this.toolTip = "Increase defense by 8";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 293)
			{
				this.name = "Mana Regeneration Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 6;
				this.buffTime = 7200;
				this.toolTip = "Increased mana regeneration";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 294)
			{
				this.name = "Magic Power Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 7;
				this.buffTime = 7200;
				this.toolTip = "20% increased magic damage";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 295)
			{
				this.name = "Featherfall Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 8;
				this.buffTime = 18000;
				this.toolTip = "Slows falling speed";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 296)
			{
				this.name = "Spelunker Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 9;
				this.buffTime = 18000;
				this.toolTip = "Shows the location of treasure and ore";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 297)
			{
				this.name = "Invisibility Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 10;
				this.buffTime = 7200;
				this.toolTip = "Grants invisibility";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 298)
			{
				this.name = "Shine Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 11;
				this.buffTime = 18000;
				this.toolTip = "Emits an aura of light";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 299)
			{
				this.name = "Night Owl Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 12;
				this.buffTime = 14400;
				this.toolTip = "Increases night vision";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 300)
			{
				this.name = "Battle Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 13;
				this.buffTime = 25200;
				this.toolTip = "Increases enemy spawn rate";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 301)
			{
				this.name = "Thorns Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 14;
				this.buffTime = 7200;
				this.toolTip = "Attackers also take damage";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 302)
			{
				this.name = "Water Walking Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 15;
				this.buffTime = 18000;
				this.toolTip = "Allows the ability to walk on water";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 303)
			{
				this.name = "Archery Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 16;
				this.buffTime = 14400;
				this.toolTip = "20% increased arrow speed and damage";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 304)
			{
				this.name = "Hunter Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 17;
				this.buffTime = 18000;
				this.toolTip = "Shows the location of enemies";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 305)
			{
				this.name = "Gravitation Potion";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 18;
				this.buffTime = 10800;
				this.toolTip = "Allows the control of gravity";
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 306)
			{
				this.name = "Gold Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 1;
				this.width = 26;
				this.height = 22;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 307)
			{
				this.name = "Daybloom Seeds";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 82;
				this.placeStyle = 0;
				this.width = 12;
				this.height = 14;
				this.value = 80;
				goto IL_2B846;
			}
			if (this.type == 308)
			{
				this.name = "Moonglow Seeds";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 82;
				this.placeStyle = 1;
				this.width = 12;
				this.height = 14;
				this.value = 80;
				goto IL_2B846;
			}
			if (this.type == 309)
			{
				this.name = "Blinkroot Seeds";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 82;
				this.placeStyle = 2;
				this.width = 12;
				this.height = 14;
				this.value = 80;
				goto IL_2B846;
			}
			if (this.type == 310)
			{
				this.name = "Deathweed Seeds";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 82;
				this.placeStyle = 3;
				this.width = 12;
				this.height = 14;
				this.value = 80;
				goto IL_2B846;
			}
			if (this.type == 311)
			{
				this.name = "Waterleaf Seeds";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 82;
				this.placeStyle = 4;
				this.width = 12;
				this.height = 14;
				this.value = 80;
				goto IL_2B846;
			}
			if (this.type == 312)
			{
				this.name = "Fireblossom Seeds";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 82;
				this.placeStyle = 5;
				this.width = 12;
				this.height = 14;
				this.value = 80;
				goto IL_2B846;
			}
			if (this.type == 313)
			{
				this.name = "Daybloom";
				this.maxStack = 99;
				this.width = 12;
				this.height = 14;
				this.value = 100;
				goto IL_2B846;
			}
			if (this.type == 314)
			{
				this.name = "Moonglow";
				this.maxStack = 99;
				this.width = 12;
				this.height = 14;
				this.value = 100;
				goto IL_2B846;
			}
			if (this.type == 315)
			{
				this.name = "Blinkroot";
				this.maxStack = 99;
				this.width = 12;
				this.height = 14;
				this.value = 100;
				goto IL_2B846;
			}
			if (this.type == 316)
			{
				this.name = "Deathweed";
				this.maxStack = 99;
				this.width = 12;
				this.height = 14;
				this.value = 100;
				goto IL_2B846;
			}
			if (this.type == 317)
			{
				this.name = "Waterleaf";
				this.maxStack = 99;
				this.width = 12;
				this.height = 14;
				this.value = 100;
				goto IL_2B846;
			}
			if (this.type == 318)
			{
				this.name = "Fireblossom";
				this.maxStack = 99;
				this.width = 12;
				this.height = 14;
				this.value = 100;
				goto IL_2B846;
			}
			if (this.type == 319)
			{
				this.name = "Shark Fin";
				this.maxStack = 99;
				this.width = 16;
				this.height = 14;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 320)
			{
				this.name = "Feather";
				this.maxStack = 99;
				this.width = 16;
				this.height = 14;
				this.value = 50;
				goto IL_2B846;
			}
			if (this.type == 321)
			{
				this.name = "Tombstone";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 85;
				this.width = 20;
				this.height = 20;
				goto IL_2B846;
			}
			if (this.type == 322)
			{
				this.name = "Mime Mask";
				this.headSlot = 28;
				this.width = 20;
				this.height = 20;
				this.value = 20000;
				goto IL_2B846;
			}
			if (this.type == 323)
			{
				this.name = "Antlion Mandible";
				this.width = 10;
				this.height = 20;
				this.maxStack = 99;
				this.value = 50;
				goto IL_2B846;
			}
			if (this.type == 324)
			{
				this.name = "Illegal Gun Parts";
				this.width = 10;
				this.height = 20;
				this.maxStack = 99;
				this.value = 250000;
				this.toolTip = "'Banned in most places'";
				goto IL_2B846;
			}
			if (this.type == 325)
			{
				this.name = "The Doctor's Shirt";
				this.width = 18;
				this.height = 18;
				this.bodySlot = 16;
				this.value = 200000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 326)
			{
				this.name = "The Doctor's Pants";
				this.width = 18;
				this.height = 18;
				this.legSlot = 15;
				this.value = 200000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 327)
			{
				this.name = "Golden Key";
				this.width = 14;
				this.height = 20;
				this.maxStack = 99;
				this.toolTip = "Opens one Gold Chest";
				goto IL_2B846;
			}
			if (this.type == 328)
			{
				this.name = "Shadow Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 3;
				this.width = 26;
				this.height = 22;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 329)
			{
				this.name = "Shadow Key";
				this.width = 14;
				this.height = 20;
				this.maxStack = 1;
				this.toolTip = "Opens all Shadow Chests";
				this.value = 75000;
				goto IL_2B846;
			}
			if (this.type == 330)
			{
				this.name = "Obsidian Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 20;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 331)
			{
				this.name = "Jungle Spores";
				this.width = 18;
				this.height = 16;
				this.maxStack = 99;
				this.value = 100;
				goto IL_2B846;
			}
			if (this.type == 332)
			{
				this.name = "Loom";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 86;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.toolTip = "Used for crafting cloth";
				goto IL_2B846;
			}
			if (this.type == 333)
			{
				this.name = "Piano";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 87;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 334)
			{
				this.name = "Dresser";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 88;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 335)
			{
				this.name = "Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 89;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 336)
			{
				this.name = "Bathtub";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 90;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 337)
			{
				this.name = "Red Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 0;
				this.width = 10;
				this.height = 24;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 338)
			{
				this.name = "Green Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 1;
				this.width = 10;
				this.height = 24;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 339)
			{
				this.name = "Blue Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 2;
				this.width = 10;
				this.height = 24;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 340)
			{
				this.name = "Yellow Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 3;
				this.width = 10;
				this.height = 24;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 341)
			{
				this.name = "Lamp Post";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 92;
				this.width = 10;
				this.height = 24;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 342)
			{
				this.name = "Tiki Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 93;
				this.width = 10;
				this.height = 24;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 343)
			{
				this.name = "Barrel";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 5;
				this.width = 20;
				this.height = 20;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 344)
			{
				this.name = "Chinese Lantern";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 95;
				this.width = 20;
				this.height = 20;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 345)
			{
				this.name = "Cooking Pot";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 96;
				this.width = 20;
				this.height = 20;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 346)
			{
				this.name = "Safe";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 97;
				this.width = 20;
				this.height = 20;
				this.value = 200000;
				goto IL_2B846;
			}
			if (this.type == 347)
			{
				this.name = "Skull Lantern";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 98;
				this.width = 20;
				this.height = 20;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 348)
			{
				this.name = "Trash Can";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 6;
				this.width = 20;
				this.height = 20;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 349)
			{
				this.name = "Candelabra";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 100;
				this.width = 20;
				this.height = 20;
				this.value = 1500;
				goto IL_2B846;
			}
			if (this.type == 350)
			{
				this.name = "Pink Vase";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 13;
				this.placeStyle = 3;
				this.width = 16;
				this.height = 24;
				this.value = 70;
				goto IL_2B846;
			}
			if (this.type == 351)
			{
				this.name = "Mug";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 13;
				this.placeStyle = 4;
				this.width = 16;
				this.height = 24;
				this.value = 20;
				goto IL_2B846;
			}
			if (this.type == 352)
			{
				this.name = "Keg";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 94;
				this.width = 24;
				this.height = 24;
				this.value = 600;
				this.toolTip = "Used for brewing ale";
				goto IL_2B846;
			}
			if (this.type == 353)
			{
				this.name = "Ale";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 10;
				this.height = 10;
				this.buffType = 25;
				this.buffTime = 7200;
				this.value = 100;
				goto IL_2B846;
			}
			if (this.type == 354)
			{
				this.name = "Bookcase";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 101;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 355)
			{
				this.name = "Throne";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 102;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 356)
			{
				this.name = "Bowl";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 103;
				this.width = 16;
				this.height = 24;
				this.value = 20;
				goto IL_2B846;
			}
			if (this.type == 357)
			{
				this.name = "Bowl of Soup";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 10;
				this.height = 10;
				this.buffType = 26;
				this.buffTime = 36000;
				this.rare = 1;
				this.toolTip = "Minor improvements to all stats";
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 358)
			{
				this.name = "Toilet";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 1;
				this.width = 12;
				this.height = 30;
				this.value = 150;
				goto IL_2B846;
			}
			if (this.type == 359)
			{
				this.name = "Grandfather Clock";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 104;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 360)
			{
				this.name = "Armor Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 361)
			{
				this.useStyle = 4;
				this.consumable = true;
				this.useAnimation = 45;
				this.useTime = 45;
				this.name = "Goblin Battle Standard";
				this.width = 28;
				this.height = 28;
				this.toolTip = "Summons a Goblin Army";
				goto IL_2B846;
			}
			if (this.type == 362)
			{
				this.name = "Tattered Cloth";
				this.maxStack = 99;
				this.width = 24;
				this.height = 24;
				this.value = 30;
				goto IL_2B846;
			}
			if (this.type == 363)
			{
				this.name = "Sawmill";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 106;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.toolTip = "Used for advanced wood crafting";
				goto IL_2B846;
			}
			if (this.type == 364)
			{
				this.name = "Cobalt Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 107;
				this.width = 12;
				this.height = 12;
				this.value = 3500;
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 365)
			{
				this.name = "Mythril Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 108;
				this.width = 12;
				this.height = 12;
				this.value = 5500;
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 366)
			{
				this.name = "Adamantite Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 111;
				this.width = 12;
				this.height = 12;
				this.value = 7500;
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 367)
			{
				this.name = "Pwnhammer";
				this.useTurn = true;
				this.autoReuse = true;
				this.useStyle = 1;
				this.useAnimation = 27;
				this.useTime = 14;
				this.hammer = 80;
				this.width = 24;
				this.height = 28;
				this.damage = 26;
				this.knockBack = 7.5f;
				this.scale = 1.2f;
				this.useSound = 1;
				this.rare = 4;
				this.value = 39000;
				this.melee = true;
				this.toolTip = "Strong enough to destroy Demon Altars";
				goto IL_2B846;
			}
			if (this.type == 368)
			{
				this.autoReuse = true;
				this.name = "Excalibur";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.useTime = 25;
				this.knockBack = 4.5f;
				this.width = 40;
				this.height = 40;
				this.damage = 47;
				this.scale = 1.15f;
				this.useSound = 1;
				this.rare = 5;
				this.value = 230000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 369)
			{
				this.name = "Hallowed Seeds";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 109;
				this.width = 14;
				this.height = 14;
				this.value = 2000;
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 370)
			{
				this.name = "Ebonsand Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 112;
				this.width = 12;
				this.height = 12;
				this.ammo = 42;
				goto IL_2B846;
			}
			if (this.type == 371)
			{
				this.name = "Cobalt Hat";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.headSlot = 29;
				this.rare = 4;
				this.value = 75000;
				this.toolTip = "Increases maximum mana by 40";
				this.toolTip2 = "9% increased magic critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 372)
			{
				this.name = "Cobalt Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 11;
				this.headSlot = 30;
				this.rare = 4;
				this.value = 75000;
				this.toolTip = "7% increased movement speed";
				this.toolTip2 = "12% increased melee speed";
				goto IL_2B846;
			}
			if (this.type == 373)
			{
				this.name = "Cobalt Mask";
				this.width = 18;
				this.height = 18;
				this.defense = 4;
				this.headSlot = 31;
				this.rare = 4;
				this.value = 75000;
				this.toolTip = "10% increased ranged damage";
				this.toolTip2 = "6% increased ranged critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 374)
			{
				this.name = "Cobalt Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 8;
				this.bodySlot = 17;
				this.rare = 4;
				this.value = 60000;
				this.toolTip2 = "3% increased critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 375)
			{
				this.name = "Cobalt Leggings";
				this.width = 18;
				this.height = 18;
				this.defense = 7;
				this.legSlot = 16;
				this.rare = 4;
				this.value = 45000;
				this.toolTip2 = "10% increased movement speed";
				goto IL_2B846;
			}
			if (this.type == 376)
			{
				this.name = "Mythril Hood";
				this.width = 18;
				this.height = 18;
				this.defense = 3;
				this.headSlot = 32;
				this.rare = 4;
				this.value = 112500;
				this.toolTip = "Increases maximum mana by 60";
				this.toolTip2 = "15% increased magic damage";
				goto IL_2B846;
			}
			if (this.type == 377)
			{
				this.name = "Mythril Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 16;
				this.headSlot = 33;
				this.rare = 4;
				this.value = 112500;
				this.toolTip = "5% increased melee critical strike chance";
				this.toolTip2 = "10% increased melee damage";
				goto IL_2B846;
			}
			if (this.type == 378)
			{
				this.name = "Mythril Hat";
				this.width = 18;
				this.height = 18;
				this.defense = 6;
				this.headSlot = 34;
				this.rare = 4;
				this.value = 112500;
				this.toolTip = "12% increased ranged damage";
				this.toolTip2 = "7% increased ranged critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 379)
			{
				this.name = "Mythril Chainmail";
				this.width = 18;
				this.height = 18;
				this.defense = 12;
				this.bodySlot = 18;
				this.rare = 4;
				this.value = 90000;
				this.toolTip2 = "5% increased damage";
				goto IL_2B846;
			}
			if (this.type == 380)
			{
				this.name = "Mythril Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 9;
				this.legSlot = 17;
				this.rare = 4;
				this.value = 67500;
				this.toolTip2 = "3% increased critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 381)
			{
				this.name = "Cobalt Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10500;
				this.rare = 3;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 11;
				goto IL_2B846;
			}
			if (this.type == 382)
			{
				this.name = "Mythril Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 22000;
				this.rare = 3;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 13;
				goto IL_2B846;
			}
			if (this.type == 383)
			{
				this.name = "Cobalt Chainsaw";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 8;
				this.shootSpeed = 40f;
				this.knockBack = 2.75f;
				this.width = 20;
				this.height = 12;
				this.damage = 23;
				this.axe = 14;
				this.useSound = 23;
				this.shoot = 57;
				this.rare = 4;
				this.value = 54000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				goto IL_2B846;
			}
			if (this.type == 384)
			{
				this.name = "Mythril Chainsaw";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 8;
				this.shootSpeed = 40f;
				this.knockBack = 3f;
				this.width = 20;
				this.height = 12;
				this.damage = 29;
				this.axe = 17;
				this.useSound = 23;
				this.shoot = 58;
				this.rare = 4;
				this.value = 81000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				goto IL_2B846;
			}
			if (this.type == 385)
			{
				this.name = "Cobalt Drill";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 13;
				this.shootSpeed = 32f;
				this.knockBack = 0f;
				this.width = 20;
				this.height = 12;
				this.damage = 10;
				this.pick = 110;
				this.useSound = 23;
				this.shoot = 59;
				this.rare = 4;
				this.value = 54000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				this.toolTip = "Can mine Mythril and Orichalcum";
				goto IL_2B846;
			}
			if (this.type == 386)
			{
				this.name = "Mythril Drill";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 10;
				this.shootSpeed = 32f;
				this.knockBack = 0f;
				this.width = 20;
				this.height = 12;
				this.damage = 15;
				this.pick = 150;
				this.useSound = 23;
				this.shoot = 60;
				this.rare = 4;
				this.value = 81000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				this.toolTip = "Can mine Adamantite and Titanium";
				goto IL_2B846;
			}
			if (this.type == 387)
			{
				this.name = "Adamantite Chainsaw";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 6;
				this.shootSpeed = 40f;
				this.knockBack = 4.5f;
				this.width = 20;
				this.height = 12;
				this.damage = 33;
				this.axe = 20;
				this.useSound = 23;
				this.shoot = 61;
				this.rare = 4;
				this.value = 108000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				goto IL_2B846;
			}
			if (this.type == 388)
			{
				this.name = "Adamantite Drill";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 7;
				this.shootSpeed = 32f;
				this.knockBack = 0f;
				this.width = 20;
				this.height = 12;
				this.damage = 20;
				this.pick = 180;
				this.useSound = 23;
				this.shoot = 62;
				this.rare = 4;
				this.value = 108000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				goto IL_2B846;
			}
			if (this.type == 389)
			{
				this.name = "Dao of Pow";
				this.noMelee = true;
				this.useStyle = 5;
				this.useAnimation = 45;
				this.useTime = 45;
				this.knockBack = 7f;
				this.width = 30;
				this.height = 10;
				this.damage = 49;
				this.scale = 1.1f;
				this.noUseGraphic = true;
				this.shoot = 63;
				this.shootSpeed = 15f;
				this.useSound = 1;
				this.rare = 5;
				this.value = 144000;
				this.melee = true;
				this.channel = true;
				this.toolTip = "Has a chance to confuse";
				this.toolTip2 = "'Find your inner pieces'";
				goto IL_2B846;
			}
			if (this.type == 390)
			{
				this.name = "Mythril Halberd";
				this.useStyle = 5;
				this.useAnimation = 26;
				this.useTime = 26;
				this.shootSpeed = 4.5f;
				this.knockBack = 5f;
				this.width = 40;
				this.height = 40;
				this.damage = 35;
				this.scale = 1.1f;
				this.useSound = 1;
				this.shoot = 64;
				this.rare = 4;
				this.value = 67500;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 391)
			{
				this.name = "Adamantite Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 37500;
				this.rare = 3;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 15;
				goto IL_2B846;
			}
			if (this.type == 392)
			{
				this.name = "Glass Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 21;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 393)
			{
				this.name = "Compass";
				this.width = 24;
				this.height = 28;
				this.rare = 3;
				this.value = 100000;
				this.accessory = true;
				this.toolTip = "Shows horizontal position";
				goto IL_2B846;
			}
			if (this.type == 394)
			{
				this.name = "Diving Gear";
				this.width = 24;
				this.height = 28;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				this.toolTip = "Grants the ability to swim";
				this.toolTip2 = "Greatly extends underwater breathing";
				goto IL_2B846;
			}
			if (this.type == 395)
			{
				this.name = "GPS";
				this.width = 24;
				this.height = 28;
				this.rare = 4;
				this.value = 150000;
				this.accessory = true;
				this.toolTip = "Shows position";
				this.toolTip2 = "Tells the time";
				goto IL_2B846;
			}
			if (this.type == 396)
			{
				this.name = "Obsidian Horseshoe";
				this.width = 24;
				this.height = 28;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				this.toolTip = "Negates fall damage";
				this.toolTip2 = "Grants immunity to fire blocks";
				goto IL_2B846;
			}
			if (this.type == 397)
			{
				this.name = "Obsidian Shield";
				this.width = 24;
				this.height = 28;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				this.defense = 2;
				this.toolTip = "Grants immunity to knockback";
				this.toolTip2 = "Grants immunity to fire blocks";
				goto IL_2B846;
			}
			if (this.type == 398)
			{
				this.name = "Tinkerer's Workshop";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 114;
				this.width = 26;
				this.height = 20;
				this.value = 100000;
				this.toolTip = "Allows the combining of some accessories";
				goto IL_2B846;
			}
			if (this.type == 399)
			{
				this.name = "Cloud in a Balloon";
				this.width = 14;
				this.height = 28;
				this.rare = 4;
				this.value = 150000;
				this.accessory = true;
				this.toolTip = "Allows the holder to double jump";
				this.toolTip2 = "Increases jump height";
				goto IL_2B846;
			}
			if (this.type == 400)
			{
				this.name = "Adamantite Headgear";
				this.width = 18;
				this.height = 18;
				this.defense = 4;
				this.headSlot = 35;
				this.rare = 4;
				this.value = 150000;
				this.toolTip = "Increases maximum mana by 80";
				this.toolTip2 = "11% increased magic damage and critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 401)
			{
				this.name = "Adamantite Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 22;
				this.headSlot = 36;
				this.rare = 4;
				this.value = 150000;
				this.toolTip = "7% increased melee critical strike chance";
				this.toolTip2 = "14% increased melee damage";
				goto IL_2B846;
			}
			if (this.type == 402)
			{
				this.name = "Adamantite Mask";
				this.width = 18;
				this.height = 18;
				this.defense = 8;
				this.headSlot = 37;
				this.rare = 4;
				this.value = 150000;
				this.toolTip = "14% increased ranged damage";
				this.toolTip2 = "8% increased ranged critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 403)
			{
				this.name = "Adamantite Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 14;
				this.bodySlot = 19;
				this.rare = 4;
				this.value = 120000;
				this.toolTip = "6% increased damage";
				goto IL_2B846;
			}
			if (this.type == 404)
			{
				this.name = "Adamantite Leggings";
				this.width = 18;
				this.height = 18;
				this.defense = 10;
				this.legSlot = 18;
				this.rare = 4;
				this.value = 90000;
				this.toolTip = "4% increased critical strike chance";
				this.toolTip2 = "5% increased movement speed";
				goto IL_2B846;
			}
			if (this.type == 405)
			{
				this.name = "Spectre Boots";
				this.width = 28;
				this.height = 24;
				this.accessory = true;
				this.rare = 4;
				this.toolTip = "Allows flight";
				this.toolTip2 = "The wearer can run super fast";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 406)
			{
				this.name = "Adamantite Glaive";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 25;
				this.shootSpeed = 5f;
				this.knockBack = 6f;
				this.width = 40;
				this.height = 40;
				this.damage = 38;
				this.scale = 1.1f;
				this.useSound = 1;
				this.shoot = 66;
				this.rare = 4;
				this.value = 90000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 407)
			{
				this.name = "Toolbelt";
				this.width = 28;
				this.height = 24;
				this.accessory = true;
				this.rare = 3;
				this.toolTip = "Increases block placement range";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 408)
			{
				this.name = "Pearlsand Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 116;
				this.width = 12;
				this.height = 12;
				this.ammo = 42;
				goto IL_2B846;
			}
			if (this.type == 409)
			{
				this.name = "Pearlstone Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 117;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 410)
			{
				this.name = "Mining Shirt";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.bodySlot = 20;
				this.value = 5000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 411)
			{
				this.name = "Mining Pants";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.legSlot = 19;
				this.value = 5000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 412)
			{
				this.name = "Pearlstone Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 118;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 413)
			{
				this.name = "Iridescent Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 119;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 414)
			{
				this.name = "Mudstone Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 120;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 415)
			{
				this.name = "Cobalt Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 121;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 416)
			{
				this.name = "Mythril Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 122;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 417)
			{
				this.name = "Pearlstone Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 22;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 418)
			{
				this.name = "Iridescent Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 23;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 419)
			{
				this.name = "Mudstone Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 24;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 420)
			{
				this.name = "Cobalt Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 25;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 421)
			{
				this.name = "Mythril Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 26;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 422)
			{
				this.useStyle = 1;
				this.name = "Holy Water";
				this.shootSpeed = 9f;
				this.rare = 3;
				this.damage = 20;
				this.shoot = 69;
				this.width = 18;
				this.height = 20;
				this.maxStack = 999;
				this.consumable = true;
				this.knockBack = 3f;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 200;
				this.toolTip = "Spreads the Hallow to some blocks";
				goto IL_2B846;
			}
			if (this.type == 423)
			{
				this.useStyle = 1;
				this.name = "Unholy Water";
				this.shootSpeed = 9f;
				this.rare = 3;
				this.damage = 20;
				this.shoot = 70;
				this.width = 18;
				this.height = 20;
				this.maxStack = 999;
				this.consumable = true;
				this.knockBack = 3f;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 200;
				this.toolTip = "Spreads the corruption to some blocks";
				goto IL_2B846;
			}
			if (this.type == 424)
			{
				this.name = "Silt Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 123;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 425)
			{
				this.channel = true;
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Fairy Bell";
				this.shoot = 72;
				this.width = 24;
				this.height = 24;
				this.useSound = 25;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 5;
				this.noMelee = true;
				this.toolTip = "Summons a magical fairy";
				this.value = (this.value = 250000);
				this.buffType = 27;
				goto IL_2B846;
			}
			if (this.type == 426)
			{
				this.name = "Breaker Blade";
				this.useStyle = 1;
				this.useAnimation = 30;
				this.knockBack = 8f;
				this.width = 60;
				this.height = 70;
				this.damage = 39;
				this.scale = 1.05f;
				this.useSound = 1;
				this.rare = 4;
				this.value = 150000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 427)
			{
				this.flame = true;
				this.noWet = true;
				this.name = "Blue Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.holdStyle = 1;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 4;
				this.placeStyle = 1;
				this.width = 10;
				this.height = 12;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 428)
			{
				this.flame = true;
				this.noWet = true;
				this.name = "Red Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.holdStyle = 1;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 4;
				this.placeStyle = 2;
				this.width = 10;
				this.height = 12;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 429)
			{
				this.flame = true;
				this.noWet = true;
				this.name = "Green Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.holdStyle = 1;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 4;
				this.placeStyle = 3;
				this.width = 10;
				this.height = 12;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 430)
			{
				this.flame = true;
				this.noWet = true;
				this.name = "Purple Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.holdStyle = 1;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 4;
				this.placeStyle = 4;
				this.width = 10;
				this.height = 12;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 431)
			{
				this.flame = true;
				this.noWet = true;
				this.name = "White Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.holdStyle = 1;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 4;
				this.placeStyle = 5;
				this.width = 10;
				this.height = 12;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 432)
			{
				this.flame = true;
				this.noWet = true;
				this.name = "Yellow Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.holdStyle = 1;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 4;
				this.placeStyle = 6;
				this.width = 10;
				this.height = 12;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 433)
			{
				this.flame = true;
				this.noWet = true;
				this.name = "Demon Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.holdStyle = 1;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 4;
				this.placeStyle = 7;
				this.width = 10;
				this.height = 12;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 434)
			{
				this.autoReuse = true;
				this.useStyle = 5;
				this.useAnimation = 12;
				this.useTime = 4;
				this.reuseDelay = 14;
				this.name = "Clockwork Assault Rifle";
				this.width = 50;
				this.height = 18;
				this.shoot = 10;
				this.useAmmo = 14;
				this.useSound = 31;
				this.damage = 19;
				this.shootSpeed = 7.75f;
				this.noMelee = true;
				this.value = 150000;
				this.rare = 4;
				this.ranged = true;
				this.toolTip = "Three round burst";
				this.toolTip2 = "Only the first shot consumes ammo";
				goto IL_2B846;
			}
			if (this.type == 435)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 25;
				this.useTime = 25;
				this.name = "Cobalt Repeater";
				this.width = 50;
				this.height = 18;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 30;
				this.shootSpeed = 9f;
				this.noMelee = true;
				this.value = 60000;
				this.ranged = true;
				this.rare = 4;
				this.knockBack = 1.5f;
				goto IL_2B846;
			}
			if (this.type == 436)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 23;
				this.useTime = 23;
				this.name = "Mythril Repeater";
				this.width = 50;
				this.height = 18;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 34;
				this.shootSpeed = 9.5f;
				this.noMelee = true;
				this.value = 90000;
				this.ranged = true;
				this.rare = 4;
				this.knockBack = 2f;
				goto IL_2B846;
			}
			if (this.type == 437)
			{
				this.noUseGraphic = true;
				this.damage = 0;
				this.knockBack = 7f;
				this.useStyle = 5;
				this.name = "Dual Hook";
				this.shootSpeed = 14f;
				this.shoot = 73;
				this.width = 18;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 4;
				this.noMelee = true;
				this.value = 200000;
				goto IL_2B846;
			}
			if (this.type == 438)
			{
				this.name = "Star Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 2;
				goto IL_2B846;
			}
			if (this.type == 439)
			{
				this.name = "Sword Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 3;
				goto IL_2B846;
			}
			if (this.type == 440)
			{
				this.name = "Slime Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 4;
				goto IL_2B846;
			}
			if (this.type == 441)
			{
				this.name = "Goblin Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 5;
				goto IL_2B846;
			}
			if (this.type == 442)
			{
				this.name = "Shield Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 6;
				goto IL_2B846;
			}
			if (this.type == 443)
			{
				this.name = "Bat Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 7;
				goto IL_2B846;
			}
			if (this.type == 444)
			{
				this.name = "Fish Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 8;
				goto IL_2B846;
			}
			if (this.type == 445)
			{
				this.name = "Bunny Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 9;
				goto IL_2B846;
			}
			if (this.type == 446)
			{
				this.name = "Skeleton Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 10;
				goto IL_2B846;
			}
			if (this.type == 447)
			{
				this.name = "Reaper Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 11;
				goto IL_2B846;
			}
			if (this.type == 448)
			{
				this.name = "Woman Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 12;
				goto IL_2B846;
			}
			if (this.type == 449)
			{
				this.name = "Imp Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 13;
				goto IL_2B846;
			}
			if (this.type == 450)
			{
				this.name = "Gargoyle Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 14;
				goto IL_2B846;
			}
			if (this.type == 451)
			{
				this.name = "Gloom Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 15;
				goto IL_2B846;
			}
			if (this.type == 452)
			{
				this.name = "Hornet Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 16;
				goto IL_2B846;
			}
			if (this.type == 453)
			{
				this.name = "Bomb Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 17;
				goto IL_2B846;
			}
			if (this.type == 454)
			{
				this.name = "Crab Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 18;
				goto IL_2B846;
			}
			if (this.type == 455)
			{
				this.name = "Hammer Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 19;
				goto IL_2B846;
			}
			if (this.type == 456)
			{
				this.name = "Potion Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 20;
				goto IL_2B846;
			}
			if (this.type == 457)
			{
				this.name = "Spear Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 21;
				goto IL_2B846;
			}
			if (this.type == 458)
			{
				this.name = "Cross Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 22;
				goto IL_2B846;
			}
			if (this.type == 459)
			{
				this.name = "Jellyfish Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 23;
				goto IL_2B846;
			}
			if (this.type == 460)
			{
				this.name = "Bow Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 24;
				goto IL_2B846;
			}
			if (this.type == 461)
			{
				this.name = "Boomerang Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 25;
				goto IL_2B846;
			}
			if (this.type == 462)
			{
				this.name = "Boot Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 26;
				goto IL_2B846;
			}
			if (this.type == 463)
			{
				this.name = "Chest Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 27;
				goto IL_2B846;
			}
			if (this.type == 464)
			{
				this.name = "Bird Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 28;
				goto IL_2B846;
			}
			if (this.type == 465)
			{
				this.name = "Axe Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 29;
				goto IL_2B846;
			}
			if (this.type == 466)
			{
				this.name = "Corrupt Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 30;
				goto IL_2B846;
			}
			if (this.type == 467)
			{
				this.name = "Tree Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 31;
				goto IL_2B846;
			}
			if (this.type == 468)
			{
				this.name = "Anvil Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 32;
				goto IL_2B846;
			}
			if (this.type == 469)
			{
				this.name = "Pickaxe Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 33;
				goto IL_2B846;
			}
			if (this.type == 470)
			{
				this.name = "Mushroom Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 34;
				goto IL_2B846;
			}
			if (this.type == 471)
			{
				this.name = "Eyeball Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 35;
				goto IL_2B846;
			}
			if (this.type == 472)
			{
				this.name = "Pillar Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 36;
				goto IL_2B846;
			}
			if (this.type == 473)
			{
				this.name = "Heart Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 37;
				goto IL_2B846;
			}
			if (this.type == 474)
			{
				this.name = "Pot Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 38;
				goto IL_2B846;
			}
			if (this.type == 475)
			{
				this.name = "Sunflower Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 39;
				goto IL_2B846;
			}
			if (this.type == 476)
			{
				this.name = "King Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 40;
				goto IL_2B846;
			}
			if (this.type == 477)
			{
				this.name = "Queen Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 41;
				goto IL_2B846;
			}
			if (this.type == 478)
			{
				this.name = "Pirahna Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 42;
				goto IL_2B846;
			}
			if (this.type == 479)
			{
				this.name = "Planked Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 27;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 480)
			{
				this.name = "Wooden Beam";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 124;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 481)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 20;
				this.useTime = 20;
				this.name = "Adamantite Repeater";
				this.width = 50;
				this.height = 18;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 37;
				this.shootSpeed = 10f;
				this.noMelee = true;
				this.value = 120000;
				this.ranged = true;
				this.rare = 4;
				this.knockBack = 2.5f;
				goto IL_2B846;
			}
			if (this.type == 482)
			{
				this.name = "Adamantite Sword";
				this.useStyle = 1;
				this.useAnimation = 27;
				this.useTime = 27;
				this.knockBack = 6f;
				this.width = 40;
				this.height = 40;
				this.damage = 44;
				this.scale = 1.2f;
				this.useSound = 1;
				this.rare = 4;
				this.value = 138000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 483)
			{
				this.useTurn = true;
				this.autoReuse = true;
				this.name = "Cobalt Sword";
				this.useStyle = 1;
				this.useAnimation = 23;
				this.useTime = 23;
				this.knockBack = 3.85f;
				this.width = 40;
				this.height = 40;
				this.damage = 34;
				this.scale = 1.1f;
				this.useSound = 1;
				this.rare = 4;
				this.value = 69000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 484)
			{
				this.name = "Mythril Sword";
				this.useStyle = 1;
				this.useAnimation = 26;
				this.useTime = 26;
				this.knockBack = 6f;
				this.width = 40;
				this.height = 40;
				this.damage = 39;
				this.scale = 1.15f;
				this.useSound = 1;
				this.rare = 4;
				this.value = 103500;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 485)
			{
				this.rare = 4;
				this.name = "Moon Charm";
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.toolTip = "Turns the holder into a werewolf on full moons";
				this.value = 150000;
				goto IL_2B846;
			}
			if (this.type == 486)
			{
				this.name = "Ruler";
				this.width = 10;
				this.height = 26;
				this.accessory = true;
				this.toolTip = "Creates a grid on screen for block placement";
				this.value = 10000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 487)
			{
				this.name = "Crystal Ball";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 125;
				this.width = 22;
				this.height = 22;
				this.value = 100000;
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 488)
			{
				this.name = "Disco Ball";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 126;
				this.width = 22;
				this.height = 26;
				this.value = 10000;
				goto IL_2B846;
			}
			if (this.type == 489)
			{
				this.name = "Sorcerer Emblem";
				this.width = 24;
				this.height = 24;
				this.accessory = true;
				this.toolTip = "15% increased magic damage";
				this.value = 100000;
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 491)
			{
				this.name = "Ranger Emblem";
				this.width = 24;
				this.height = 24;
				this.accessory = true;
				this.toolTip = "15% increased ranged damage";
				this.value = 100000;
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 490)
			{
				this.name = "Warrior Emblem";
				this.width = 24;
				this.height = 24;
				this.accessory = true;
				this.toolTip = "15% increased melee damage";
				this.value = 100000;
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 492)
			{
				this.name = "Demon Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = 400000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 493)
			{
				this.name = "Angel Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = 400000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 494)
			{
				this.rare = 5;
				this.useStyle = 5;
				this.useAnimation = 12;
				this.useTime = 12;
				this.name = "Magical Harp";
				this.width = 12;
				this.height = 28;
				this.shoot = 76;
				this.holdStyle = 3;
				this.autoReuse = true;
				this.damage = 30;
				this.shootSpeed = 4.5f;
				this.noMelee = true;
				this.value = 200000;
				this.mana = 4;
				this.magic = true;
				goto IL_2B846;
			}
			if (this.type == 495)
			{
				this.rare = 5;
				this.mana = 10;
				this.channel = true;
				this.damage = 53;
				this.useStyle = 1;
				this.name = "Rainbow Rod";
				this.shootSpeed = 6f;
				this.shoot = 79;
				this.width = 26;
				this.height = 28;
				this.useSound = 28;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noMelee = true;
				this.knockBack = 5f;
				this.toolTip = "Casts a controllable rainbow";
				this.value = 200000;
				this.magic = true;
				goto IL_2B846;
			}
			if (this.type == 496)
			{
				this.rare = 4;
				this.mana = 7;
				this.damage = 26;
				this.useStyle = 1;
				this.name = "Ice Rod";
				this.shootSpeed = 12f;
				this.shoot = 80;
				this.width = 26;
				this.height = 28;
				this.useSound = 28;
				this.useAnimation = 17;
				this.useTime = 17;
				this.rare = 4;
				this.autoReuse = true;
				this.noMelee = true;
				this.knockBack = 0f;
				this.toolTip = "Summons a block of ice";
				this.value = 1000000;
				this.magic = true;
				this.knockBack = 2f;
				goto IL_2B846;
			}
			if (this.type == 497)
			{
				this.name = "Neptune's Shell";
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.toolTip = "Transforms the holder into merfolk when entering water";
				this.value = 150000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 498)
			{
				this.name = "Mannequin";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 128;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 499)
			{
				this.name = "Greater Healing Potion";
				this.useSound = 3;
				this.healLife = 150;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.rare = 3;
				this.potion = true;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 500)
			{
				this.name = "Greater Mana Potion";
				this.useSound = 3;
				this.healMana = 200;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 50;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.rare = 3;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 501)
			{
				this.name = "Pixie Dust";
				this.width = 16;
				this.height = 14;
				this.maxStack = 99;
				this.value = 500;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 502)
			{
				this.name = "Crystal Shard";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 129;
				this.width = 24;
				this.height = 24;
				this.value = 8000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 503)
			{
				this.name = "Clown Hat";
				this.width = 18;
				this.height = 18;
				this.headSlot = 40;
				this.value = 20000;
				this.vanity = true;
				this.rare = 2;
				goto IL_2B846;
			}
			if (this.type == 504)
			{
				this.name = "Clown Shirt";
				this.width = 18;
				this.height = 18;
				this.bodySlot = 23;
				this.value = 10000;
				this.vanity = true;
				this.rare = 2;
				goto IL_2B846;
			}
			if (this.type == 505)
			{
				this.name = "Clown Pants";
				this.width = 18;
				this.height = 18;
				this.legSlot = 22;
				this.value = 10000;
				this.vanity = true;
				this.rare = 2;
				goto IL_2B846;
			}
			if (this.type == 506)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 30;
				this.useTime = 6;
				this.name = "Flamethrower";
				this.width = 50;
				this.height = 18;
				this.shoot = 85;
				this.useAmmo = 23;
				this.useSound = 34;
				this.damage = 27;
				this.knockBack = 0.3f;
				this.shootSpeed = 7f;
				this.noMelee = true;
				this.value = 500000;
				this.rare = 5;
				this.ranged = true;
				this.toolTip = "Uses gel for ammo";
				goto IL_2B846;
			}
			if (this.type == 507)
			{
				this.rare = 3;
				this.useStyle = 1;
				this.useAnimation = 12;
				this.useTime = 12;
				this.name = "Bell";
				this.width = 12;
				this.height = 28;
				this.autoReuse = true;
				this.noMelee = true;
				this.value = 10000;
				goto IL_2B846;
			}
			if (this.type == 508)
			{
				this.rare = 3;
				this.useStyle = 5;
				this.useAnimation = 12;
				this.useTime = 12;
				this.name = "Harp";
				this.width = 12;
				this.height = 28;
				this.autoReuse = true;
				this.noMelee = true;
				this.value = 10000;
				goto IL_2B846;
			}
			if (this.type == 509)
			{
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.name = "Wrench";
				this.width = 24;
				this.height = 28;
				this.rare = 1;
				this.toolTip = "Places red wire";
				this.value = 20000;
				this.mech = true;
				this.tileBoost = 3;
				goto IL_2B846;
			}
			if (this.type == 510)
			{
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.name = "Wire Cutter";
				this.width = 24;
				this.height = 28;
				this.rare = 1;
				this.toolTip = "Removes wire";
				this.value = 20000;
				this.mech = true;
				this.tileBoost = 3;
				goto IL_2B846;
			}
			if (this.type == 511)
			{
				this.name = "Active Stone Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 130;
				this.width = 12;
				this.height = 12;
				this.value = 1000;
				this.mech = true;
				goto IL_2B846;
			}
			if (this.type == 512)
			{
				this.name = "Inactive Stone Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 131;
				this.width = 12;
				this.height = 12;
				this.value = 1000;
				this.mech = true;
				goto IL_2B846;
			}
			if (this.type == 513)
			{
				this.name = "Lever";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 132;
				this.width = 24;
				this.height = 24;
				this.value = 3000;
				this.mech = true;
				goto IL_2B846;
			}
			if (this.type == 514)
			{
				this.autoReuse = true;
				this.useStyle = 5;
				this.useAnimation = 12;
				this.useTime = 12;
				this.name = "Laser Rifle";
				this.width = 36;
				this.height = 22;
				this.shoot = 88;
				this.mana = 8;
				this.useSound = 12;
				this.knockBack = 2.5f;
				this.damage = 29;
				this.shootSpeed = 17f;
				this.noMelee = true;
				this.rare = 4;
				this.magic = true;
				this.value = 150000;
				goto IL_2B846;
			}
			if (this.type == 515)
			{
				this.name = "Crystal Bullet";
				this.shootSpeed = 5f;
				this.shoot = 89;
				this.damage = 8;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 1f;
				this.value = 30;
				this.ranged = true;
				this.rare = 3;
				this.toolTip = "Creates several crystal shards on impact";
				goto IL_2B846;
			}
			if (this.type == 516)
			{
				this.name = "Holy Arrow";
				this.shootSpeed = 3.5f;
				this.shoot = 91;
				this.damage = 6;
				this.width = 10;
				this.height = 28;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 1;
				this.knockBack = 2f;
				this.value = 80;
				this.ranged = true;
				this.rare = 3;
				this.toolTip = "Summons falling stars on impact";
				goto IL_2B846;
			}
			if (this.type == 517)
			{
				this.useStyle = 1;
				this.name = "Magic Dagger";
				this.shootSpeed = 12f;
				this.shoot = 93;
				this.damage = 40;
				this.width = 18;
				this.height = 20;
				this.mana = 6;
				this.useSound = 1;
				this.useAnimation = 8;
				this.useTime = 8;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 1000000;
				this.knockBack = 3.75f;
				this.magic = true;
				this.rare = 4;
				this.toolTip = "A magical returning dagger";
				goto IL_2B846;
			}
			if (this.type == 518)
			{
				this.autoReuse = true;
				this.rare = 4;
				this.mana = 5;
				this.useSound = 9;
				this.name = "Crystal Storm";
				this.useStyle = 5;
				this.damage = 26;
				this.useAnimation = 7;
				this.useTime = 7;
				this.width = 24;
				this.height = 28;
				this.shoot = 94;
				this.scale = 0.9f;
				this.shootSpeed = 16f;
				this.knockBack = 5f;
				this.toolTip = "Summons rapid fire crystal shards";
				this.magic = true;
				this.value = 500000;
				goto IL_2B846;
			}
			if (this.type == 519)
			{
				this.autoReuse = true;
				this.rare = 4;
				this.mana = 14;
				this.useSound = 20;
				this.name = "Cursed Flames";
				this.useStyle = 5;
				this.damage = 35;
				this.useAnimation = 20;
				this.useTime = 20;
				this.width = 24;
				this.height = 28;
				this.shoot = 95;
				this.scale = 0.9f;
				this.shootSpeed = 10f;
				this.knockBack = 6.5f;
				this.toolTip = "Summons unholy fire balls";
				this.magic = true;
				this.value = 500000;
				goto IL_2B846;
			}
			if (this.type == 520)
			{
				this.name = "Soul of Light";
				this.width = 18;
				this.height = 18;
				this.maxStack = 999;
				this.value = 1000;
				this.rare = 3;
				this.toolTip = "'The essence of light creatures'";
				goto IL_2B846;
			}
			if (this.type == 521)
			{
				this.name = "Soul of Night";
				this.width = 18;
				this.height = 18;
				this.maxStack = 999;
				this.value = 1000;
				this.rare = 3;
				this.toolTip = "'The essence of dark creatures'";
				goto IL_2B846;
			}
			if (this.type == 522)
			{
				this.name = "Cursed Flame";
				this.width = 12;
				this.height = 14;
				this.maxStack = 99;
				this.value = 4000;
				this.rare = 3;
				this.toolTip = "'Not even water can put the flame out'";
				goto IL_2B846;
			}
			if (this.type == 523)
			{
				this.flame = true;
				this.name = "Cursed Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.holdStyle = 1;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 4;
				this.placeStyle = 8;
				this.width = 10;
				this.height = 12;
				this.value = 300;
				this.rare = 1;
				this.toolTip = "Can be placed in water";
				goto IL_2B846;
			}
			if (this.type == 524)
			{
				this.name = "Adamantite Forge";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 133;
				this.width = 44;
				this.height = 30;
				this.value = 50000;
				this.toolTip = "Used to smelt adamantite ore";
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 525)
			{
				this.name = "Mythril Anvil";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 134;
				this.width = 28;
				this.height = 14;
				this.value = 25000;
				this.toolTip = "Used to craft items from mythril and adamantite bars";
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 526)
			{
				this.name = "Unicorn Horn";
				this.width = 14;
				this.height = 14;
				this.maxStack = 99;
				this.value = 15000;
				this.rare = 1;
				this.toolTip = "'Sharp and magical!'";
				goto IL_2B846;
			}
			if (this.type == 527)
			{
				this.name = "Dark Shard";
				this.width = 14;
				this.height = 14;
				this.maxStack = 99;
				this.value = 4500;
				this.rare = 2;
				this.toolTip = "'Sometimes carried by creatures in corrupt deserts'";
				goto IL_2B846;
			}
			if (this.type == 528)
			{
				this.name = "Light Shard";
				this.width = 14;
				this.height = 14;
				this.maxStack = 99;
				this.value = 4500;
				this.rare = 2;
				this.toolTip = "'Sometimes carried by creatures in light deserts'";
				goto IL_2B846;
			}
			if (this.type == 529)
			{
				this.name = "Red Pressure Plate";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 135;
				this.width = 12;
				this.height = 12;
				this.placeStyle = 0;
				this.mech = true;
				this.value = 5000;
				this.mech = true;
				this.toolTip = "Activates when stepped on";
				goto IL_2B846;
			}
			if (this.type == 530)
			{
				this.name = "Wire";
				this.width = 12;
				this.height = 18;
				this.maxStack = 999;
				this.value = 500;
				this.mech = true;
				goto IL_2B846;
			}
			if (this.type == 531)
			{
				this.name = "Spell Tome";
				this.width = 12;
				this.height = 18;
				this.maxStack = 99;
				this.value = 50000;
				this.rare = 1;
				this.toolTip = "Can be enchanted";
				goto IL_2B846;
			}
			if (this.type == 532)
			{
				this.name = "Star Cloak";
				this.width = 20;
				this.height = 24;
				this.value = 100000;
				this.toolTip = "Causes stars to fall when injured";
				this.accessory = true;
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 533)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 7;
				this.useTime = 7;
				this.name = "Megashark";
				this.width = 50;
				this.height = 18;
				this.shoot = 10;
				this.useAmmo = 14;
				this.useSound = 11;
				this.damage = 23;
				this.shootSpeed = 10f;
				this.noMelee = true;
				this.value = 300000;
				this.rare = 5;
				this.toolTip = "50% chance to not consume ammo";
				this.toolTip2 = "'Minishark's older brother'";
				this.knockBack = 1f;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 534)
			{
				this.knockBack = 6.5f;
				this.useStyle = 5;
				this.useAnimation = 45;
				this.useTime = 45;
				this.name = "Shotgun";
				this.width = 50;
				this.height = 14;
				this.shoot = 10;
				this.useAmmo = 14;
				this.useSound = 36;
				this.damage = 21;
				this.shootSpeed = 6f;
				this.noMelee = true;
				this.value = 250000;
				this.rare = 4;
				this.ranged = true;
				this.toolTip = "Fires a spread of bullets";
				goto IL_2B846;
			}
			if (this.type == 535)
			{
				this.name = "Philosopher's Stone";
				this.width = 12;
				this.height = 18;
				this.value = 100000;
				this.toolTip = "Reduces the cooldown of healing potions";
				this.accessory = true;
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 536)
			{
				this.name = "Titan Glove";
				this.width = 12;
				this.height = 18;
				this.value = 100000;
				this.toolTip = "Increases melee knockback";
				this.rare = 4;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 537)
			{
				this.name = "Cobalt Naginata";
				this.useStyle = 5;
				this.useAnimation = 28;
				this.useTime = 28;
				this.shootSpeed = 4.3f;
				this.knockBack = 4f;
				this.width = 40;
				this.height = 40;
				this.damage = 29;
				this.scale = 1.1f;
				this.useSound = 1;
				this.shoot = 97;
				this.rare = 4;
				this.value = 45000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 538)
			{
				this.name = "Switch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 136;
				this.width = 12;
				this.height = 12;
				this.value = 2000;
				this.mech = true;
				goto IL_2B846;
			}
			if (this.type == 539)
			{
				this.name = "Dart Trap";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 137;
				this.width = 12;
				this.height = 12;
				this.value = 10000;
				this.mech = true;
				goto IL_2B846;
			}
			if (this.type == 540)
			{
				this.name = "Boulder";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 138;
				this.width = 12;
				this.height = 12;
				this.mech = true;
				goto IL_2B846;
			}
			if (this.type == 541)
			{
				this.name = "Green Pressure Plate";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 135;
				this.width = 12;
				this.height = 12;
				this.placeStyle = 1;
				this.mech = true;
				this.value = 5000;
				this.toolTip = "Activates when stepped on";
				goto IL_2B846;
			}
			if (this.type == 542)
			{
				this.name = "Gray Pressure Plate";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 135;
				this.width = 12;
				this.height = 12;
				this.placeStyle = 2;
				this.mech = true;
				this.value = 5000;
				this.toolTip = "Activates when a player steps on it on";
				goto IL_2B846;
			}
			if (this.type == 543)
			{
				this.name = "Brown Pressure Plate";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 135;
				this.width = 12;
				this.height = 12;
				this.placeStyle = 3;
				this.mech = true;
				this.value = 5000;
				this.toolTip = "Activates when a player steps on it on";
				goto IL_2B846;
			}
			if (this.type == 544)
			{
				this.useStyle = 4;
				this.name = "Mechanical Eye";
				this.width = 22;
				this.height = 14;
				this.consumable = true;
				this.useAnimation = 45;
				this.useTime = 45;
				this.maxStack = 20;
				this.toolTip = "Summons The Twins";
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 545)
			{
				this.name = "Cursed Arrow";
				this.shootSpeed = 4f;
				this.shoot = 103;
				this.damage = 14;
				this.width = 10;
				this.height = 28;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 1;
				this.knockBack = 3f;
				this.value = 80;
				this.ranged = true;
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 546)
			{
				this.name = "Cursed Bullet";
				this.shootSpeed = 5f;
				this.shoot = 104;
				this.damage = 12;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 4f;
				this.value = 30;
				this.rare = 1;
				this.ranged = true;
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 547)
			{
				this.name = "Soul of Fright";
				this.width = 18;
				this.height = 18;
				this.maxStack = 999;
				this.value = 100000;
				this.rare = 5;
				this.toolTip = "'The essence of pure terror'";
				goto IL_2B846;
			}
			if (this.type == 548)
			{
				this.name = "Soul of Might";
				this.width = 18;
				this.height = 18;
				this.maxStack = 999;
				this.value = 100000;
				this.rare = 5;
				this.toolTip = "'The essence of the destroyer'";
				goto IL_2B846;
			}
			if (this.type == 549)
			{
				this.name = "Soul of Sight";
				this.width = 18;
				this.height = 18;
				this.maxStack = 999;
				this.value = 100000;
				this.rare = 5;
				this.toolTip = "'The essence of omniscient watchers'";
				goto IL_2B846;
			}
			if (this.type == 550)
			{
				this.name = "Gungnir";
				this.useStyle = 5;
				this.useAnimation = 22;
				this.useTime = 22;
				this.shootSpeed = 5.6f;
				this.knockBack = 6.4f;
				this.width = 40;
				this.height = 40;
				this.damage = 42;
				this.scale = 1.1f;
				this.useSound = 1;
				this.shoot = 105;
				this.rare = 5;
				this.value = 1500000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 551)
			{
				this.name = "Hallowed Plate Mail";
				this.width = 18;
				this.height = 18;
				this.defense = 15;
				this.bodySlot = 24;
				this.rare = 5;
				this.value = 200000;
				this.toolTip = "7% increased critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 552)
			{
				this.name = "Hallowed Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 11;
				this.legSlot = 23;
				this.rare = 5;
				this.value = 150000;
				this.toolTip = "7% increased damage";
				this.toolTip2 = "8% increased movement speed";
				goto IL_2B846;
			}
			if (this.type == 553)
			{
				this.name = "Hallowed Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 9;
				this.headSlot = 41;
				this.rare = 5;
				this.value = 250000;
				this.toolTip = "15% increased ranged damage";
				this.toolTip2 = "8% increased ranged critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 558)
			{
				this.name = "Hallowed Headgear";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.headSlot = 42;
				this.rare = 5;
				this.value = 250000;
				this.toolTip = "Increases maximum mana by 100";
				this.toolTip2 = "12% increased magic damage and critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 559)
			{
				this.name = "Hallowed Mask";
				this.width = 18;
				this.height = 18;
				this.defense = 24;
				this.headSlot = 43;
				this.rare = 5;
				this.value = 250000;
				this.toolTip = "10% increased melee damage and critical strike chance";
				this.toolTip2 = "10% increased melee haste";
				goto IL_2B846;
			}
			if (this.type == 554)
			{
				this.name = "Cross Necklace";
				this.width = 20;
				this.height = 24;
				this.value = 1500;
				this.toolTip = "Increases length of invincibility after taking damage";
				this.accessory = true;
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 555)
			{
				this.name = "Mana Flower";
				this.width = 20;
				this.height = 24;
				this.value = 50000;
				this.toolTip = "8% reduced mana usage";
				this.toolTip2 = "Automatically use mana potions when needed";
				this.accessory = true;
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 556)
			{
				this.useStyle = 4;
				this.name = "Mechanical Worm";
				this.width = 22;
				this.height = 14;
				this.consumable = true;
				this.useAnimation = 45;
				this.useTime = 45;
				this.maxStack = 20;
				this.toolTip = "Summons Destroyer";
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 557)
			{
				this.useStyle = 4;
				this.name = "Mechanical Skull";
				this.width = 22;
				this.height = 14;
				this.consumable = true;
				this.useAnimation = 45;
				this.useTime = 45;
				this.maxStack = 20;
				this.toolTip = "Summons Skeletron Prime";
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 560)
			{
				this.useStyle = 4;
				this.name = "Slime Crown";
				this.width = 22;
				this.height = 14;
				this.consumable = true;
				this.useAnimation = 45;
				this.useTime = 45;
				this.maxStack = 20;
				this.toolTip = "Summons King Slime";
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 561)
			{
				this.melee = true;
				this.autoReuse = true;
				this.noMelee = true;
				this.useStyle = 1;
				this.name = "Light Disc";
				this.shootSpeed = 13f;
				this.shoot = 106;
				this.damage = 35;
				this.knockBack = 8f;
				this.width = 24;
				this.height = 24;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.rare = 5;
				this.maxStack = 5;
				this.value = 500000;
				this.toolTip = "Stacks up to 5";
				goto IL_2B846;
			}
			if (this.type == 562)
			{
				this.name = "Music Box (Overworld Day)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 0;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 563)
			{
				this.name = "Music Box (Eerie)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 1;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 564)
			{
				this.name = "Music Box (Night)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 2;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 565)
			{
				this.name = "Music Box (Title)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 3;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 566)
			{
				this.name = "Music Box (Underground)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 4;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 567)
			{
				this.name = "Music Box (Boss 1)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 5;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 568)
			{
				this.name = "Music Box (Jungle)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 6;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 569)
			{
				this.name = "Music Box (Corruption)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 7;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 570)
			{
				this.name = "Music Box (Underground Corruption)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 8;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 571)
			{
				this.name = "Music Box (The Hallow)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 9;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 572)
			{
				this.name = "Music Box (Boss 2)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 10;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 573)
			{
				this.name = "Music Box (Underground Hallow)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 11;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 574)
			{
				this.name = "Music Box (Boss 3)";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = 12;
				this.width = 24;
				this.height = 24;
				this.rare = 3;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 575)
			{
				this.name = "Soul of Flight";
				this.width = 18;
				this.height = 18;
				this.maxStack = 999;
				this.value = 1000;
				this.rare = 3;
				this.toolTip = "'The essence of powerful flying creatures'";
				goto IL_2B846;
			}
			if (this.type == 576)
			{
				this.name = "Music Box";
				this.width = 24;
				this.height = 24;
				this.rare = 3;
				this.toolTip = "Has a chance to record songs";
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 577)
			{
				this.name = "Demonite Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 140;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 578)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 19;
				this.useTime = 19;
				this.name = "Hallowed Repeater";
				this.width = 50;
				this.height = 18;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 39;
				this.shootSpeed = 11f;
				this.noMelee = true;
				this.value = 200000;
				this.ranged = true;
				this.rare = 4;
				this.knockBack = 2.5f;
				goto IL_2B846;
			}
			if (this.type == 579)
			{
				this.name = "Drax";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 7;
				this.shootSpeed = 36f;
				this.knockBack = 4.75f;
				this.width = 20;
				this.height = 12;
				this.damage = 35;
				this.pick = 200;
				this.axe = 22;
				this.useSound = 23;
				this.shoot = 107;
				this.rare = 4;
				this.value = 220000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				this.toolTip = "'Not to be confused with a picksaw'";
				goto IL_2B846;
			}
			if (this.type == 580)
			{
				this.mech = true;
				this.name = "Explosives";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 141;
				this.width = 12;
				this.height = 12;
				this.toolTip = "Explodes when activated";
				goto IL_2B846;
			}
			if (this.type == 581)
			{
				this.mech = true;
				this.name = "Inlet Pump";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 142;
				this.width = 12;
				this.height = 12;
				this.toolTip = "Sends water to outlet pumps";
				goto IL_2B846;
			}
			if (this.type == 582)
			{
				this.mech = true;
				this.name = "Outlet Pump";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 143;
				this.width = 12;
				this.height = 12;
				this.toolTip = "Receives water from inlet pumps";
				goto IL_2B846;
			}
			if (this.type == 583)
			{
				this.mech = true;
				this.noWet = true;
				this.name = "1 Second Timer";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 144;
				this.placeStyle = 0;
				this.width = 10;
				this.height = 12;
				this.value = 50;
				this.toolTip = "Activates every second";
				goto IL_2B846;
			}
			if (this.type == 584)
			{
				this.mech = true;
				this.noWet = true;
				this.name = "3 Second Timer";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 144;
				this.placeStyle = 1;
				this.width = 10;
				this.height = 12;
				this.value = 50;
				this.toolTip = "Activates every 3 seconds";
				goto IL_2B846;
			}
			if (this.type == 585)
			{
				this.mech = true;
				this.noWet = true;
				this.name = "5 Second Timer";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 144;
				this.placeStyle = 2;
				this.width = 10;
				this.height = 12;
				this.value = 50;
				this.toolTip = "Activates every 5 seconds";
				goto IL_2B846;
			}
			if (this.type == 586)
			{
				this.name = "Candy Cane Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 145;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 587)
			{
				this.name = "Candy Cane Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 29;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 588)
			{
				this.name = "Santa Hat";
				this.width = 18;
				this.height = 12;
				this.headSlot = 44;
				this.value = 150000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 589)
			{
				this.name = "Santa Shirt";
				this.width = 18;
				this.height = 18;
				this.bodySlot = 25;
				this.value = 150000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 590)
			{
				this.name = "Santa Pants";
				this.width = 18;
				this.height = 18;
				this.legSlot = 24;
				this.value = 150000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 591)
			{
				this.name = "Green Candy Cane Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 146;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 592)
			{
				this.name = "Green Candy Cane Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 30;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 593)
			{
				this.name = "Snow Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 147;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 594)
			{
				this.name = "Snow Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 148;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 595)
			{
				this.name = "Snow Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 31;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 596)
			{
				this.name = "Blue Light";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 149;
				this.placeStyle = 0;
				this.width = 12;
				this.height = 12;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 597)
			{
				this.name = "Red Light";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 149;
				this.placeStyle = 1;
				this.width = 12;
				this.height = 12;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 598)
			{
				this.name = "Green Light";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 149;
				this.placeStyle = 2;
				this.width = 12;
				this.height = 12;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 599)
			{
				this.name = "Blue Present";
				this.width = 12;
				this.height = 12;
				this.rare = 1;
				this.toolTip = "Right click to open";
				goto IL_2B846;
			}
			if (this.type == 600)
			{
				this.name = "Green Present";
				this.width = 12;
				this.height = 12;
				this.rare = 1;
				this.toolTip = "Right click to open";
				goto IL_2B846;
			}
			if (this.type == 601)
			{
				this.name = "Yellow Present";
				this.width = 12;
				this.height = 12;
				this.rare = 1;
				this.toolTip = "Right click to open";
				goto IL_2B846;
			}
			if (this.type == 602)
			{
				this.name = "Snow Globe";
				this.useStyle = 4;
				this.consumable = true;
				this.useAnimation = 45;
				this.useTime = 45;
				this.width = 28;
				this.height = 28;
				this.toolTip = "Summons the Frost Legion";
				this.rare = 2;
				goto IL_2B846;
			}
			if (this.type == 603)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Carrot";
				this.shoot = 111;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.toolTip = "Summons a pet bunny";
				this.value = 0;
				this.buffType = 40;
				goto IL_2B846;
			}
			if (this.type == 604)
			{
				this.name = "Adamantite Beam";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 150;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 605)
			{
				this.name = "Adamantite Beam Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 32;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 606)
			{
				this.name = "Demonite Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 33;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 607)
			{
				this.name = "Sandstone Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 151;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 608)
			{
				this.name = "Sandstone Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 34;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 609)
			{
				this.name = "Ebonstone Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 152;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 610)
			{
				this.name = "Ebonstone Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 35;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 611)
			{
				this.name = "Red Stucco";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 153;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 612)
			{
				this.name = "Yellow Stucco";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 154;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 613)
			{
				this.name = "Green Stucco";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 155;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 614)
			{
				this.name = "Gray Stucco";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 156;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 615)
			{
				this.name = "Red Stucco Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 36;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 616)
			{
				this.name = "Yellow Stucco Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 37;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 617)
			{
				this.name = "Green Stucco Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 38;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 618)
			{
				this.name = "Gray Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 39;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 619)
			{
				this.name = "Ebonwood";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 157;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 620)
			{
				this.name = "Rich Mahogany";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 158;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 621)
			{
				this.name = "Pearlwood";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 159;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 622)
			{
				this.name = "Ebonwood Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 41;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 623)
			{
				this.name = "Rich Mahogany Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 42;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 624)
			{
				this.name = "Pearlwood Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 43;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 625)
			{
				this.name = "Ebonwood Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 7;
				this.width = 26;
				this.height = 22;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 626)
			{
				this.name = "Rich Mahogany Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 8;
				this.width = 26;
				this.height = 22;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 627)
			{
				this.name = "Pearlwood Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 9;
				this.width = 26;
				this.height = 22;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 628)
			{
				this.name = "Ebonwood Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 2;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 629)
			{
				this.name = "Rich Mahogany Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 3;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 630)
			{
				this.name = "Pearlwood Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 4;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 631)
			{
				this.name = "Ebonwood Platform";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 1;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 632)
			{
				this.name = "Rich Mahogany Platform";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 2;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 633)
			{
				this.name = "Pearlwood Platform";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 3;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 634)
			{
				this.name = "Bone Platform";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 4;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 635)
			{
				this.name = "Ebonwood Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 1;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				this.toolTip = "Used for basic crafting";
				goto IL_2B846;
			}
			if (this.type == 636)
			{
				this.name = "Rich Mahogany Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 2;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				this.toolTip = "Used for basic crafting";
				goto IL_2B846;
			}
			if (this.type == 637)
			{
				this.name = "Pearlwood Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 3;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				this.toolTip = "Used for basic crafting";
				goto IL_2B846;
			}
			if (this.type == 638)
			{
				this.name = "Ebonwood Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 1;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 639)
			{
				this.name = "Rich Mahogany Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 2;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 640)
			{
				this.name = "Pearlwood Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 3;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 641)
			{
				this.name = "Ebonwood Piano";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 87;
				this.placeStyle = 1;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 642)
			{
				this.name = "Rich Mahogany Piano";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 87;
				this.placeStyle = 2;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 643)
			{
				this.name = "Pearlwood Piano";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 87;
				this.placeStyle = 3;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 644)
			{
				this.name = "Ebonwood Bed";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 79;
				this.placeStyle = 1;
				this.width = 28;
				this.height = 20;
				this.value = 2000;
				goto IL_2B846;
			}
			if (this.type == 645)
			{
				this.name = "Rich Mahogany Bed";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 79;
				this.placeStyle = 2;
				this.width = 28;
				this.height = 20;
				this.value = 2000;
				goto IL_2B846;
			}
			if (this.type == 646)
			{
				this.name = "Pearlwood Bed";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 79;
				this.placeStyle = 3;
				this.width = 28;
				this.height = 20;
				this.value = 2000;
				goto IL_2B846;
			}
			if (this.type == 647)
			{
				this.name = "Ebonwood Dresser";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 88;
				this.placeStyle = 1;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 648)
			{
				this.name = "Rich Mahogany Dresser";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 88;
				this.placeStyle = 2;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 649)
			{
				this.name = "Pearlwood Dresser";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 88;
				this.placeStyle = 3;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 650)
			{
				this.name = "Ebonwood Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 1;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 651)
			{
				this.name = "Rich Mahogany Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 2;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 652)
			{
				this.name = "Pearlwood Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 3;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 653)
			{
				this.name = "Ebonwood Sword";
				this.useStyle = 1;
				this.useTurn = false;
				this.useAnimation = 21;
				this.useTime = 21;
				this.width = 24;
				this.height = 28;
				this.damage = 10;
				this.knockBack = 5f;
				this.useSound = 1;
				this.scale = 1f;
				this.value = 100;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 654)
			{
				this.name = "Ebonwood Hammer";
				this.autoReuse = true;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 30;
				this.useTime = 20;
				this.hammer = 40;
				this.width = 24;
				this.height = 28;
				this.damage = 7;
				this.knockBack = 5.5f;
				this.scale = 1.2f;
				this.useSound = 1;
				this.value = 50;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 655)
			{
				this.name = "Ebonwood Bow";
				this.useStyle = 5;
				this.useAnimation = 28;
				this.useTime = 28;
				this.width = 12;
				this.height = 28;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 8;
				this.shootSpeed = 6.6f;
				this.noMelee = true;
				this.value = 100;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 656)
			{
				this.name = "Rich Mahogany Sword";
				this.useStyle = 1;
				this.useTurn = false;
				this.useAnimation = 23;
				this.useTime = 23;
				this.width = 24;
				this.height = 28;
				this.damage = 8;
				this.knockBack = 5f;
				this.useSound = 1;
				this.scale = 1f;
				this.value = 100;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 657)
			{
				this.name = "Rich Mahogany Hammer";
				this.autoReuse = true;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 33;
				this.useTime = 23;
				this.hammer = 35;
				this.width = 24;
				this.height = 28;
				this.damage = 4;
				this.knockBack = 5.5f;
				this.scale = 1.1f;
				this.useSound = 1;
				this.value = 50;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 658)
			{
				this.name = "Rich Mahogany Bow";
				this.useStyle = 5;
				this.useAnimation = 29;
				this.useTime = 29;
				this.width = 12;
				this.height = 28;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 6;
				this.shootSpeed = 6.6f;
				this.noMelee = true;
				this.value = 100;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 659)
			{
				this.name = "Pearlwood Sword";
				this.useStyle = 1;
				this.useTurn = false;
				this.useAnimation = 21;
				this.useTime = 21;
				this.width = 24;
				this.height = 28;
				this.damage = 11;
				this.knockBack = 5f;
				this.useSound = 1;
				this.scale = 1f;
				this.value = 100;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 660)
			{
				this.name = "Pearlwood Hammer";
				this.autoReuse = true;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 29;
				this.useTime = 19;
				this.hammer = 45;
				this.width = 24;
				this.height = 28;
				this.damage = 9;
				this.knockBack = 5.5f;
				this.scale = 1.25f;
				this.useSound = 1;
				this.value = 50;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 661)
			{
				this.name = "Pearlwood Bow";
				this.useStyle = 5;
				this.useAnimation = 27;
				this.useTime = 27;
				this.width = 12;
				this.height = 28;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 9;
				this.shootSpeed = 6.6f;
				this.noMelee = true;
				this.value = 100;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 662)
			{
				this.name = "Rainbow Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 160;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 663)
			{
				this.name = "Rainbow Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 44;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 664)
			{
				this.name = "Ice Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 161;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 665)
			{
				this.name = "Red's Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "You shouldn't have this";
				this.rare = 9;
				goto IL_2B846;
			}
			if (this.type == 666)
			{
				this.name = "Red's Helmet";
				this.width = 18;
				this.height = 18;
				this.headSlot = 45;
				this.rare = 9;
				this.toolTip = "You shouldn't have this";
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 667)
			{
				this.name = "Red's Breastplate";
				this.width = 18;
				this.height = 18;
				this.bodySlot = 26;
				this.rare = 9;
				this.toolTip = "You shouldn't have this";
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 668)
			{
				this.name = "Red's Leggings";
				this.width = 18;
				this.height = 18;
				this.legSlot = 25;
				this.rare = 9;
				this.toolTip = "You shouldn't have this";
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 669)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Fish";
				this.shoot = 112;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.toolTip = "Summons a baby penguin";
				this.buffType = 41;
				this.value = Item.sellPrice(0, 2, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 670)
			{
				this.noMelee = true;
				this.useStyle = 1;
				this.name = "Ice Boomerang";
				this.shootSpeed = 11.5f;
				this.shoot = 113;
				this.damage = 14;
				this.knockBack = 8.5f;
				this.width = 14;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.rare = 1;
				this.value = 50000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 671)
			{
				this.name = "Lockblade";
				this.useStyle = 1;
				this.useAnimation = 22;
				this.useTime = 22;
				this.knockBack = 6f;
				this.width = 40;
				this.height = 40;
				this.damage = 55;
				this.scale = 1.2f;
				this.useSound = 1;
				this.rare = 8;
				this.value = 138000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 672)
			{
				this.name = "Cutlass";
				this.useStyle = 1;
				this.useAnimation = 17;
				this.knockBack = 4f;
				this.width = 24;
				this.height = 28;
				this.damage = 51;
				this.scale = 1.1f;
				this.useSound = 1;
				this.rare = 4;
				this.value = 180000;
				this.melee = true;
				this.autoReuse = true;
				this.useTurn = true;
				goto IL_2B846;
			}
			if (this.type == 673)
			{
				this.name = "Icemourne";
				this.useStyle = 1;
				this.useAnimation = 32;
				this.knockBack = 8f;
				this.width = 60;
				this.height = 70;
				this.damage = 44;
				this.scale = 1.05f;
				this.useSound = 1;
				this.rare = 4;
				this.value = 150000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 674)
			{
				this.name = "True Excalibur";
				this.useStyle = 1;
				this.useAnimation = 16;
				this.useTime = 30;
				this.shoot = 156;
				this.shootSpeed = 11f;
				this.knockBack = 4.5f;
				this.width = 40;
				this.height = 40;
				this.damage = 55;
				this.scale = 1.05f;
				this.useSound = 1;
				this.rare = 8;
				this.value = Item.sellPrice(0, 10, 0, 0);
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 675)
			{
				this.name = "True Night's Edge";
				this.useStyle = 1;
				this.useAnimation = 24;
				this.useTime = 45;
				this.shoot = 157;
				this.shootSpeed = 10f;
				this.knockBack = 4.75f;
				this.width = 40;
				this.height = 40;
				this.damage = 70;
				this.scale = 1.15f;
				this.useSound = 1;
				this.rare = 8;
				this.value = Item.sellPrice(0, 10, 0, 0);
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 676)
			{
				this.name = "Frostbrand";
				this.useStyle = 1;
				this.useAnimation = 23;
				this.useTime = 59;
				this.knockBack = 4.5f;
				this.width = 24;
				this.height = 28;
				this.damage = 49;
				this.scale = 1.15f;
				this.useSound = 1;
				this.rare = 5;
				this.shoot = 119;
				this.shootSpeed = 12f;
				this.value = 250000;
				this.toolTip = "Shoots an icy bolt";
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 677)
			{
				this.name = "Scythe";
				this.useStyle = 1;
				this.useAnimation = 26;
				this.useTime = 26;
				this.knockBack = 6f;
				this.width = 40;
				this.height = 40;
				this.damage = 39;
				this.scale = 1.15f;
				this.useSound = 1;
				this.rare = 4;
				this.value = 103500;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 678)
			{
				this.name = "Soul Scythe";
				this.useStyle = 1;
				this.useAnimation = 37;
				this.knockBack = 8.75f;
				this.width = 60;
				this.height = 70;
				this.damage = 55;
				this.scale = 1.2f;
				this.useSound = 1;
				this.rare = 4;
				this.value = 150000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 679)
			{
				this.autoReuse = true;
				this.knockBack = 7f;
				this.useStyle = 5;
				this.useAnimation = 34;
				this.useTime = 34;
				this.name = "Tactical Shotgun";
				this.width = 50;
				this.height = 14;
				this.shoot = 10;
				this.useAmmo = 14;
				this.useSound = 38;
				this.damage = 29;
				this.shootSpeed = 6f;
				this.noMelee = true;
				this.value = 700000;
				this.rare = 8;
				this.ranged = true;
				this.toolTip = "Fires a spread of bullets";
				goto IL_2B846;
			}
			if (this.type == 680)
			{
				this.name = "Bamboo Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 10;
				this.width = 26;
				this.height = 22;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 681)
			{
				this.name = "Ice Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 11;
				this.width = 26;
				this.height = 22;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 682)
			{
				this.useStyle = 5;
				this.useAnimation = 20;
				this.useTime = 20;
				this.name = "Marrow";
				this.width = 14;
				this.height = 32;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 36;
				this.shootSpeed = 11f;
				this.knockBack = 4.7f;
				this.rare = 5;
				this.noMelee = true;
				this.scale = 1.1f;
				this.value = 27000;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 683)
			{
				this.rare = 7;
				this.mana = 14;
				this.useSound = 20;
				this.name = "Unholy Trident";
				this.useStyle = 5;
				this.damage = 65;
				this.useAnimation = 40;
				this.useTime = 40;
				this.width = 30;
				this.height = 30;
				this.shoot = 114;
				this.shootSpeed = 13f;
				this.knockBack = 6.5f;
				this.toolTip = "Summons the Devil's trident";
				this.magic = true;
				this.value = 500000;
				goto IL_2B846;
			}
			if (this.type == 684)
			{
				this.name = "Frost Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 10;
				this.headSlot = 46;
				this.rare = 5;
				this.value = 250000;
				this.toolTip = "16% increased melee and ranged damage";
				goto IL_2B846;
			}
			if (this.type == 685)
			{
				this.name = "Frost Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 20;
				this.bodySlot = 27;
				this.rare = 5;
				this.value = 200000;
				this.toolTip = "11% increased melee and ranged critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 686)
			{
				this.name = "Frost Leggings";
				this.width = 18;
				this.height = 18;
				this.defense = 13;
				this.legSlot = 26;
				this.rare = 5;
				this.value = 150000;
				this.toolTip = "8% increased movement speed";
				this.toolTip = "7% increased melee attack speed";
				goto IL_2B846;
			}
			if (this.type == 687)
			{
				this.name = "Tin Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.headSlot = 47;
				this.value = 1875;
				goto IL_2B846;
			}
			if (this.type == 688)
			{
				this.name = "Tin Chainmail";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.bodySlot = 28;
				this.value = Item.sellPrice(0, 0, 0, 50);
				goto IL_2B846;
			}
			if (this.type == 689)
			{
				this.name = "Tin Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.legSlot = 27;
				this.value = 1125;
				goto IL_2B846;
			}
			if (this.type == 690)
			{
				this.name = "Lead Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 3;
				this.headSlot = 48;
				this.value = 7500;
				goto IL_2B846;
			}
			if (this.type == 691)
			{
				this.name = "Lead Chainmail";
				this.width = 18;
				this.height = 18;
				this.defense = 3;
				this.bodySlot = 29;
				this.value = 6000;
				goto IL_2B846;
			}
			if (this.type == 692)
			{
				this.name = "Lead Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.legSlot = 28;
				this.value = 4500;
				goto IL_2B846;
			}
			if (this.type == 693)
			{
				this.name = "Tungsten Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 4;
				this.headSlot = 49;
				this.value = 7500;
				goto IL_2B846;
			}
			if (this.type == 694)
			{
				this.name = "Tungsten Chainmail";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.bodySlot = 30;
				this.value = 6000;
				goto IL_2B846;
			}
			if (this.type == 695)
			{
				this.name = "Tungsten Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 3;
				this.legSlot = 29;
				this.value = 4500;
				goto IL_2B846;
			}
			if (this.type == 696)
			{
				this.name = "Platinum Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.headSlot = 50;
				this.value = 7500;
				goto IL_2B846;
			}
			if (this.type == 697)
			{
				this.name = "Platinum Chainmail";
				this.width = 18;
				this.height = 18;
				this.defense = 6;
				this.bodySlot = 31;
				this.value = 6000;
				goto IL_2B846;
			}
			if (this.type == 698)
			{
				this.name = "Platinum Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.legSlot = 30;
				this.value = 4500;
				goto IL_2B846;
			}
			if (this.type == 699)
			{
				this.name = "Tin Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 166;
				this.width = 12;
				this.height = 12;
				this.value = 375;
				goto IL_2B846;
			}
			if (this.type == 700)
			{
				this.name = "Lead Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 167;
				this.width = 12;
				this.height = 12;
				this.value = 750;
				goto IL_2B846;
			}
			if (this.type == 701)
			{
				this.name = "Tungsten Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 168;
				this.width = 12;
				this.height = 12;
				this.value = 1500;
				goto IL_2B846;
			}
			if (this.type == 702)
			{
				this.name = "Platinum Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 169;
				this.width = 12;
				this.height = 12;
				this.value = 3000;
				goto IL_2B846;
			}
			if (this.type == 703)
			{
				this.name = "Tin Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 1125;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 1;
				goto IL_2B846;
			}
			if (this.type == 704)
			{
				this.name = "Lead Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 2250;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 3;
				goto IL_2B846;
			}
			if (this.type == 705)
			{
				this.name = "Tungsten Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 4500;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 5;
				goto IL_2B846;
			}
			if (this.type == 706)
			{
				this.name = "Platinum Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 9000;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 7;
				goto IL_2B846;
			}
			if (this.type == 707)
			{
				this.name = "Tin Watch";
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.toolTip = "Tells the time";
				this.value = 1500;
				goto IL_2B846;
			}
			if (this.type == 708)
			{
				this.name = "Tungsten Watch";
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.toolTip = "Tells the time";
				this.value = 7500;
				goto IL_2B846;
			}
			if (this.type == 709)
			{
				this.name = "Platinum Watch";
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "Tells the time";
				this.value = 15000;
				goto IL_2B846;
			}
			if (this.type == 710)
			{
				this.name = "Tin Chandelier";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 170;
				this.width = 26;
				this.height = 26;
				this.value = 4500;
				goto IL_2B846;
			}
			if (this.type == 711)
			{
				this.name = "Tungsten Chandelier";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 171;
				this.width = 26;
				this.height = 26;
				this.value = 18000;
				goto IL_2B846;
			}
			if (this.type == 712)
			{
				this.name = "Platinum Chandelier";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 172;
				this.width = 26;
				this.height = 26;
				this.value = 36000;
				goto IL_2B846;
			}
			if (this.type == 713)
			{
				this.flame = true;
				this.name = "Platinum Candle";
				this.noWet = true;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 174;
				this.width = 8;
				this.height = 18;
				this.holdStyle = 1;
				goto IL_2B846;
			}
			if (this.type == 714)
			{
				this.name = "Platinum Candelabra";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 173;
				this.width = 20;
				this.height = 20;
				goto IL_2B846;
			}
			if (this.type == 715)
			{
				this.name = "Platinum Crown";
				this.width = 18;
				this.height = 18;
				this.headSlot = 51;
				this.value = 15000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 716)
			{
				this.name = "Lead Anvil";
				this.placeStyle = 1;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 16;
				this.width = 28;
				this.height = 14;
				this.value = 7500;
				this.toolTip = "Used to craft items from metal bars";
				goto IL_2B846;
			}
			if (this.type == 717)
			{
				this.name = "Tin Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 175;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 718)
			{
				this.name = "Tungsten Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 176;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 719)
			{
				this.name = "Platinum Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 177;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 720)
			{
				this.name = "Tin Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 45;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 721)
			{
				this.name = "Tungsten Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 46;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 722)
			{
				this.name = "Platinum Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 47;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 723)
			{
				this.rare = 4;
				this.useSound = 1;
				this.name = "Beam Sword";
				this.useStyle = 1;
				this.damage = 52;
				this.useAnimation = 15;
				this.useTime = 60;
				this.width = 30;
				this.height = 30;
				this.shoot = 116;
				this.shootSpeed = 11f;
				this.knockBack = 6.5f;
				this.toolTip = "Shoots a beam of light";
				this.melee = true;
				this.value = 500000;
				goto IL_2B846;
			}
			if (this.type == 724)
			{
				this.rare = 1;
				this.useSound = 1;
				this.name = "Ice Blade";
				this.useStyle = 1;
				this.damage = 13;
				this.useAnimation = 20;
				this.useTime = 70;
				this.width = 30;
				this.height = 30;
				this.shoot = 118;
				this.shootSpeed = 8f;
				this.knockBack = 4.75f;
				this.toolTip = "Shoots an icy bolt";
				this.melee = true;
				this.value = 20000;
				goto IL_2B846;
			}
			if (this.type == 725)
			{
				this.useStyle = 5;
				this.useAnimation = 22;
				this.useTime = 22;
				this.name = "Icy Bow";
				this.width = 12;
				this.height = 28;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 43;
				this.shootSpeed = 10f;
				this.knockBack = 4.5f;
				this.alpha = 30;
				this.rare = 5;
				this.noMelee = true;
				this.value = Item.sellPrice(0, 3, 50, 0);
				this.toolTip = "Shoots frost arrows";
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 726)
			{
				this.autoReuse = true;
				this.rare = 5;
				this.mana = 10;
				this.useSound = 20;
				this.name = "Frost Staff";
				this.useStyle = 5;
				this.damage = 53;
				this.useAnimation = 20;
				this.useTime = 20;
				this.width = 30;
				this.height = 30;
				this.shoot = 119;
				this.shootSpeed = 16f;
				this.knockBack = 5f;
				this.toolTip = "Shoots a stream of frost";
				this.magic = true;
				this.value = 500000;
				this.noMelee = true;
				goto IL_2B846;
			}
			if (this.type == 727)
			{
				this.name = "Wood Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.headSlot = 52;
				goto IL_2B846;
			}
			if (this.type == 728)
			{
				this.name = "Wood Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.bodySlot = 32;
				goto IL_2B846;
			}
			if (this.type == 729)
			{
				this.name = "Wood Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 0;
				this.legSlot = 31;
				goto IL_2B846;
			}
			if (this.type == 730)
			{
				this.name = "Ebonwood Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.headSlot = 53;
				goto IL_2B846;
			}
			if (this.type == 731)
			{
				this.name = "Ebonwood Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.bodySlot = 33;
				goto IL_2B846;
			}
			if (this.type == 732)
			{
				this.name = "Ebonwood Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.legSlot = 32;
				goto IL_2B846;
			}
			if (this.type == 733)
			{
				this.name = "Rich Mahogany Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.headSlot = 54;
				goto IL_2B846;
			}
			if (this.type == 734)
			{
				this.name = "Rich Mahogany Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.bodySlot = 34;
				goto IL_2B846;
			}
			if (this.type == 735)
			{
				this.name = "Rich Mahogany Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.legSlot = 33;
				goto IL_2B846;
			}
			if (this.type == 736)
			{
				this.name = "Pearlwood Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.headSlot = 55;
				goto IL_2B846;
			}
			if (this.type == 737)
			{
				this.name = "Pearlwood Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 3;
				this.bodySlot = 35;
				goto IL_2B846;
			}
			if (this.type == 738)
			{
				this.name = "Pearlwood Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.legSlot = 34;
				goto IL_2B846;
			}
			if (this.type == 739)
			{
				this.name = "Amethyst Staff";
				this.mana = 3;
				this.useSound = 43;
				this.useStyle = 5;
				this.damage = 14;
				this.useAnimation = 40;
				this.useTime = 40;
				this.width = 40;
				this.height = 40;
				this.shoot = 121;
				this.shootSpeed = 6f;
				this.knockBack = 3.25f;
				this.value = 2000;
				this.magic = true;
				this.noMelee = true;
				goto IL_2B846;
			}
			if (this.type == 740)
			{
				this.name = "Topaz Staff";
				this.mana = 3;
				this.useSound = 43;
				this.useStyle = 5;
				this.damage = 16;
				this.useAnimation = 38;
				this.useTime = 38;
				this.width = 40;
				this.height = 40;
				this.shoot = 122;
				this.shootSpeed = 6.5f;
				this.knockBack = 3.5f;
				this.value = 3000;
				this.magic = true;
				this.noMelee = true;
				goto IL_2B846;
			}
			if (this.type == 741)
			{
				this.name = "Sapphire Staff";
				this.mana = 4;
				this.useSound = 43;
				this.useStyle = 5;
				this.damage = 19;
				this.useAnimation = 34;
				this.useTime = 34;
				this.width = 40;
				this.height = 40;
				this.shoot = 123;
				this.shootSpeed = 7.5f;
				this.knockBack = 4f;
				this.value = 10000;
				this.magic = true;
				this.rare = 1;
				this.noMelee = true;
				goto IL_2B846;
			}
			if (this.type == 742)
			{
				this.name = "Emerald Staff";
				this.mana = 4;
				this.useSound = 43;
				this.useStyle = 5;
				this.damage = 21;
				this.useAnimation = 32;
				this.useTime = 32;
				this.width = 40;
				this.height = 40;
				this.shoot = 124;
				this.shootSpeed = 8f;
				this.knockBack = 4.25f;
				this.magic = true;
				this.autoReuse = true;
				this.value = 15000;
				this.rare = 1;
				this.noMelee = true;
				goto IL_2B846;
			}
			if (this.type == 743)
			{
				this.name = "Ruby Staff";
				this.mana = 5;
				this.useSound = 43;
				this.useStyle = 5;
				this.damage = 24;
				this.useAnimation = 28;
				this.useTime = 28;
				this.width = 40;
				this.height = 40;
				this.shoot = 125;
				this.shootSpeed = 9f;
				this.knockBack = 4.75f;
				this.magic = true;
				this.autoReuse = true;
				this.value = 20000;
				this.rare = 1;
				this.noMelee = true;
				goto IL_2B846;
			}
			if (this.type == 744)
			{
				this.name = "Diamond Staff";
				this.mana = 5;
				this.useSound = 43;
				this.useStyle = 5;
				this.damage = 26;
				this.useAnimation = 26;
				this.useTime = 26;
				this.width = 40;
				this.height = 40;
				this.shoot = 126;
				this.shootSpeed = 9.5f;
				this.knockBack = 5.5f;
				this.magic = true;
				this.autoReuse = true;
				this.value = 30000;
				this.rare = 2;
				this.noMelee = true;
				goto IL_2B846;
			}
			if (this.type == 745)
			{
				this.name = "Grass Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 66;
				this.width = 12;
				this.height = 12;
				this.value = 10;
				goto IL_2B846;
			}
			if (this.type == 746)
			{
				this.name = "Jungle Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 67;
				this.width = 12;
				this.height = 12;
				this.value = 10;
				goto IL_2B846;
			}
			if (this.type == 747)
			{
				this.name = "Flower Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 68;
				this.width = 12;
				this.height = 12;
				this.value = 10;
				goto IL_2B846;
			}
			if (this.type == 748)
			{
				this.name = "Jetpack";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.toolTip2 = "Hold up to rocket faster";
				this.value = 400000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 749)
			{
				this.name = "Butterfly Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = 400000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 750)
			{
				this.name = "Cactus Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 72;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 751)
			{
				this.name = "Cloud";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 189;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 752)
			{
				this.name = "Cloud Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 73;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 753)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Seaweed";
				this.shoot = 127;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.toolTip = "Summons a turtle";
				this.value = Item.sellPrice(0, 2, 0, 0);
				this.buffType = 42;
				goto IL_2B846;
			}
			if (this.type == 754)
			{
				this.name = "Rune Hat";
				this.width = 28;
				this.height = 20;
				this.headSlot = 56;
				this.rare = 5;
				this.value = 50000;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 755)
			{
				this.name = "Rune Robe";
				this.width = 18;
				this.height = 14;
				this.bodySlot = 36;
				this.value = 50000;
				this.vanity = true;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 756)
			{
				this.rare = 7;
				this.name = "Mushroom Spear";
				this.useStyle = 5;
				this.useAnimation = 40;
				this.useTime = 40;
				this.shootSpeed = 5.5f;
				this.knockBack = 6.8f;
				this.width = 32;
				this.height = 32;
				this.damage = 60;
				this.scale = 1f;
				this.useSound = 1;
				this.shoot = 130;
				this.value = Item.buyPrice(0, 30, 0, 0);
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 757)
			{
				this.rare = 8;
				this.useSound = 1;
				this.name = "Terra Blade";
				this.useStyle = 1;
				this.damage = 80;
				this.useAnimation = 16;
				this.useTime = 30;
				this.width = 30;
				this.height = 30;
				this.shoot = 132;
				this.scale = 1.1f;
				this.shootSpeed = 12f;
				this.knockBack = 6.5f;
				this.melee = true;
				this.value = Item.sellPrice(0, 20, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 758)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 30;
				this.useTime = 30;
				this.name = "Grenade Launcher";
				this.useAmmo = 771;
				this.width = 50;
				this.height = 20;
				this.shoot = 133;
				this.useSound = 11;
				this.damage = 55;
				this.shootSpeed = 10f;
				this.noMelee = true;
				this.value = 100000;
				this.knockBack = 4f;
				this.rare = 8;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 759)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 30;
				this.useTime = 30;
				this.name = "Rocket Launcher";
				this.useAmmo = 771;
				this.width = 50;
				this.height = 20;
				this.shoot = 134;
				this.useSound = 11;
				this.damage = 50;
				this.shootSpeed = 5f;
				this.noMelee = true;
				this.value = 100000;
				this.knockBack = 4f;
				this.rare = 8;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 760)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 30;
				this.useTime = 30;
				this.name = "Proximity Mine Launcher";
				this.useAmmo = 771;
				this.width = 50;
				this.height = 20;
				this.shoot = 135;
				this.useSound = 11;
				this.damage = 45;
				this.shootSpeed = 11f;
				this.noMelee = true;
				this.value = Item.buyPrice(0, 35, 0, 0);
				this.knockBack = 4f;
				this.rare = 8;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 761)
			{
				this.name = "Fairy Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = 400000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 762)
			{
				this.name = "Slime Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 193;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 763)
			{
				this.name = "Flesh Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 195;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 764)
			{
				this.name = "Mushroom Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 74;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 765)
			{
				this.name = "Rain Cloud";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 196;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 766)
			{
				this.name = "Bone Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 194;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 767)
			{
				this.name = "Frozen Slime Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 197;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 768)
			{
				this.name = "Bone Block Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 75;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 769)
			{
				this.name = "Slime Block Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 76;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 770)
			{
				this.name = "Flesh Block Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 77;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 771)
			{
				this.name = "Rocket I";
				this.shoot = 0;
				this.damage = 35;
				this.width = 20;
				this.height = 14;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 771;
				this.knockBack = 4f;
				this.value = Item.buyPrice(0, 0, 0, 50);
				this.ranged = true;
				this.toolTip = "Small blast radius. Will not destroy tiles";
				goto IL_2B846;
			}
			if (this.type == 772)
			{
				this.name = "Rocket II";
				this.shoot = 3;
				this.damage = 40;
				this.width = 20;
				this.height = 14;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 771;
				this.knockBack = 4f;
				this.value = Item.buyPrice(0, 0, 2, 50);
				this.ranged = true;
				this.toolTip = "Small blast radius. Will destroy tiles";
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 773)
			{
				this.name = "Rocket III";
				this.shoot = 6;
				this.damage = 55;
				this.width = 20;
				this.height = 14;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 771;
				this.knockBack = 6f;
				this.value = Item.buyPrice(0, 0, 1, 0);
				this.ranged = true;
				this.toolTip = "Large blast radius. Will not destroy tiles";
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 774)
			{
				this.name = "Rocket IV";
				this.shoot = 9;
				this.damage = 60;
				this.width = 20;
				this.height = 14;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 771;
				this.knockBack = 6f;
				this.value = (this.value = Item.buyPrice(0, 0, 5, 0));
				this.ranged = true;
				this.toolTip = "Large blast radius. Will destroy tiles";
				this.rare = 2;
				goto IL_2B846;
			}
			if (this.type == 775)
			{
				this.name = "Asphalt Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 198;
				this.width = 12;
				this.height = 12;
				this.toolTip = "Increases running speed";
				goto IL_2B846;
			}
			if (this.type == 776)
			{
				this.name = "Cobalt Pickaxe";
				this.useStyle = 1;
				this.useTurn = true;
				this.autoReuse = true;
				this.useAnimation = 25;
				this.useTime = 13;
				this.knockBack = 5f;
				this.width = 20;
				this.height = 12;
				this.damage = 10;
				this.pick = 110;
				this.useSound = 1;
				this.rare = 4;
				this.value = 54000;
				this.melee = true;
				this.toolTip = "Can mine Mythril and Orichalcum";
				this.scale = 1.15f;
				goto IL_2B846;
			}
			if (this.type == 777)
			{
				this.name = "Mythril Pickaxe";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.useTime = 10;
				this.knockBack = 5f;
				this.useTurn = true;
				this.autoReuse = true;
				this.width = 20;
				this.height = 12;
				this.damage = 15;
				this.pick = 150;
				this.useSound = 1;
				this.rare = 4;
				this.value = 81000;
				this.melee = true;
				this.toolTip = "Can mine Adamantite and Titanium";
				this.scale = 1.15f;
				goto IL_2B846;
			}
			if (this.type == 778)
			{
				this.name = "Adamantite Pickaxe";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.useTime = 7;
				this.knockBack = 5f;
				this.useTurn = true;
				this.autoReuse = true;
				this.width = 20;
				this.height = 12;
				this.damage = 20;
				this.pick = 180;
				this.useSound = 1;
				this.rare = 4;
				this.value = 108000;
				this.melee = true;
				this.scale = 1.15f;
				goto IL_2B846;
			}
			if (this.type == 779)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 30;
				this.useTime = 5;
				this.name = "Clentaminator";
				this.width = 50;
				this.height = 18;
				this.shoot = 145;
				this.useAmmo = 780;
				this.useSound = 34;
				this.knockBack = 0.3f;
				this.shootSpeed = 7f;
				this.noMelee = true;
				this.value = Item.buyPrice(2, 0, 0, 0);
				this.rare = 5;
				this.toolTip = "Creates and destroys biomes when sprayed";
				this.toolTip2 = "Uses colored solution";
				goto IL_2B846;
			}
			if (this.type == 780)
			{
				this.name = "Green Solutiuon";
				this.shoot = 0;
				this.ammo = 780;
				this.width = 10;
				this.height = 12;
				this.value = Item.buyPrice(0, 0, 25, 0);
				this.rare = 3;
				this.maxStack = 999;
				this.toolTip = "Used by the Clentaminator";
				this.toolTip2 = "Spreads the purity";
				goto IL_2B846;
			}
			if (this.type == 781)
			{
				this.name = "Blue Solutiuon";
				this.shoot = 1;
				this.ammo = 780;
				this.width = 10;
				this.height = 12;
				this.value = Item.buyPrice(0, 0, 25, 0);
				this.rare = 3;
				this.maxStack = 999;
				this.toolTip = "Used by the Clentaminator";
				this.toolTip2 = "Spreads the hallow";
				goto IL_2B846;
			}
			if (this.type == 782)
			{
				this.name = "Purple Solutiuon";
				this.shoot = 2;
				this.ammo = 780;
				this.width = 10;
				this.height = 12;
				this.value = Item.buyPrice(0, 0, 25, 0);
				this.rare = 3;
				this.maxStack = 999;
				this.toolTip = "Used by the Clentaminator";
				this.toolTip2 = "Spreads the corruption";
				goto IL_2B846;
			}
			if (this.type == 783)
			{
				this.name = "Dark Blue Solution";
				this.shoot = 3;
				this.ammo = 780;
				this.width = 10;
				this.height = 12;
				this.value = Item.buyPrice(0, 0, 25, 0);
				this.rare = 3;
				this.maxStack = 999;
				this.toolTip = "Used by the Clentaminator";
				this.toolTip2 = "Spreads glowing mushrooms";
				goto IL_2B846;
			}
			if (this.type == 784)
			{
				this.name = "Red Solution";
				this.shoot = 4;
				this.ammo = 780;
				this.width = 10;
				this.height = 12;
				this.value = Item.buyPrice(0, 0, 25, 0);
				this.rare = 3;
				this.maxStack = 999;
				this.toolTip = "Used by the Clentaminator";
				this.toolTip2 = "Spreads the crimson";
				goto IL_2B846;
			}
			if (this.type == 785)
			{
				this.name = "Harpy Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = 400000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 786)
			{
				this.name = "Bone Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = 400000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 787)
			{
				this.name = "Hammush";
				this.useTurn = true;
				this.autoReuse = true;
				this.useStyle = 1;
				this.useAnimation = 27;
				this.useTime = 14;
				this.hammer = 85;
				this.width = 24;
				this.height = 28;
				this.damage = 26;
				this.knockBack = 7.5f;
				this.scale = 1.1f;
				this.useSound = 1;
				this.rare = 7;
				this.value = Item.buyPrice(0, 40, 0, 0);
				this.melee = true;
				this.toolTip = "Strong enough to destroy Demon Altars";
				goto IL_2B846;
			}
			if (this.type == 788)
			{
				this.mana = 12;
				this.damage = 24;
				this.useStyle = 5;
				this.name = "Nettle Burst";
				this.shootSpeed = 32f;
				this.shoot = 150;
				this.width = 26;
				this.height = 28;
				this.useSound = 8;
				this.useAnimation = 25;
				this.useTime = 25;
				this.autoReuse = true;
				this.rare = 7;
				this.noMelee = true;
				this.knockBack = 1f;
				this.toolTip = "Summons a thorn spear";
				this.value = 200000;
				this.magic = true;
				goto IL_2B846;
			}
			if (this.type == 789)
			{
				this.name = "Ankh Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 4;
				this.width = 10;
				this.height = 24;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 790)
			{
				this.name = "Snake Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 5;
				this.width = 10;
				this.height = 24;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 791)
			{
				this.name = "Omega Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 6;
				this.width = 10;
				this.height = 24;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 792)
			{
				this.name = "Crimson Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 6;
				this.headSlot = 57;
				this.value = 50000;
				this.toolTip = "2% increased damage";
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 793)
			{
				this.name = "Crimson Scalemail";
				this.width = 18;
				this.height = 18;
				this.defense = 7;
				this.bodySlot = 37;
				this.value = 40000;
				this.toolTip = "2% increased damage";
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 794)
			{
				this.name = "Crimson Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 6;
				this.legSlot = 35;
				this.value = 30000;
				this.toolTip = "2% increased damage";
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 795)
			{
				this.name = "Blood Butcherer";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.knockBack = 5f;
				this.width = 24;
				this.height = 28;
				this.damage = 22;
				this.scale = 1.1f;
				this.useSound = 1;
				this.rare = 1;
				this.value = 13500;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 796)
			{
				this.useStyle = 5;
				this.useAnimation = 30;
				this.useTime = 30;
				this.name = "Tendon Bow";
				this.width = 12;
				this.height = 28;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 19;
				this.shootSpeed = 6.7f;
				this.knockBack = 1f;
				this.alpha = 30;
				this.rare = 1;
				this.noMelee = true;
				this.value = 18000;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 797)
			{
				this.name = "Flesh Grinder";
				this.autoReuse = true;
				this.useStyle = 1;
				this.useAnimation = 40;
				this.useTime = 19;
				this.hammer = 55;
				this.width = 24;
				this.height = 28;
				this.damage = 23;
				this.knockBack = 6f;
				this.scale = 1.2f;
				this.useSound = 1;
				this.rare = 1;
				this.value = 15000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 798)
			{
				this.name = "Deathbringer Pickaxe";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 22;
				this.useTime = 14;
				this.autoReuse = true;
				this.width = 24;
				this.height = 28;
				this.damage = 12;
				this.pick = 70;
				this.useSound = 1;
				this.knockBack = 3.5f;
				this.rare = 1;
				this.value = 18000;
				this.scale = 1.15f;
				this.toolTip = "Able to mine Hellstone";
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 799)
			{
				this.name = "Blood Lust Cluster";
				this.autoReuse = true;
				this.useStyle = 1;
				this.useAnimation = 32;
				this.knockBack = 6f;
				this.useTime = 15;
				this.width = 24;
				this.height = 28;
				this.damage = 22;
				this.axe = 15;
				this.scale = 1.2f;
				this.useSound = 1;
				this.rare = 1;
				this.value = 13500;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 800)
			{
				this.useStyle = 5;
				this.useAnimation = 24;
				this.useTime = 24;
				this.name = "The Undertaker";
				this.width = 24;
				this.height = 28;
				this.shoot = 14;
				this.useAmmo = 14;
				this.useSound = 11;
				this.damage = 15;
				this.shootSpeed = 5f;
				this.noMelee = true;
				this.value = 50000;
				this.scale = 0.9f;
				this.rare = 1;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 801)
			{
				this.name = "The Meatball";
				this.useStyle = 5;
				this.useAnimation = 45;
				this.useTime = 45;
				this.knockBack = 6.5f;
				this.width = 30;
				this.height = 10;
				this.damage = 16;
				this.scale = 1.1f;
				this.noUseGraphic = true;
				this.shoot = 154;
				this.shootSpeed = 12f;
				this.useSound = 1;
				this.rare = 1;
				this.value = 27000;
				this.melee = true;
				this.channel = true;
				this.noMelee = true;
				goto IL_2B846;
			}
			if (this.type == 802)
			{
				this.name = "The Rotted Fork";
				this.useStyle = 5;
				this.useAnimation = 31;
				this.useTime = 31;
				this.shootSpeed = 4f;
				this.knockBack = 5f;
				this.width = 40;
				this.height = 40;
				this.damage = 14;
				this.scale = 1.1f;
				this.useSound = 1;
				this.shoot = 153;
				this.rare = 1;
				this.value = 10000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 803)
			{
				this.name = "Eskimo Hood";
				this.width = 18;
				this.height = 18;
				this.headSlot = 58;
				this.value = 50000;
				this.defense = 1;
				goto IL_2B846;
			}
			if (this.type == 804)
			{
				this.name = "Eskimo Coat";
				this.width = 18;
				this.height = 18;
				this.bodySlot = 38;
				this.value = 40000;
				this.defense = 2;
				goto IL_2B846;
			}
			if (this.type == 805)
			{
				this.name = "Eskimo Pants";
				this.width = 18;
				this.height = 18;
				this.legSlot = 36;
				this.value = 30000;
				this.defense = 1;
				goto IL_2B846;
			}
			if (this.type == 806)
			{
				this.name = "Living Wood Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 5;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 807)
			{
				this.name = "Cactus Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 6;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 808)
			{
				this.name = "Bone Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 7;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 809)
			{
				this.name = "Flesh Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 8;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 810)
			{
				this.name = "Mushroom Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 9;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 811)
			{
				this.name = "Bone Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 4;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				this.toolTip = "Used for basic crafting";
				goto IL_2B846;
			}
			if (this.type == 812)
			{
				this.name = "Cactus Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 5;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				this.toolTip = "Used for basic crafting";
				goto IL_2B846;
			}
			if (this.type == 813)
			{
				this.name = "Flesh Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 6;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				this.toolTip = "Used for basic crafting";
				goto IL_2B846;
			}
			if (this.type == 814)
			{
				this.name = "Mushroom Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 7;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				this.toolTip = "Used for basic crafting";
				goto IL_2B846;
			}
			if (this.type == 815)
			{
				this.name = "Slime Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 8;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				this.toolTip = "Used for basic crafting";
				goto IL_2B846;
			}
			if (this.type == 816)
			{
				this.name = "Cactus Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 4;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 817)
			{
				this.name = "Flesh Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 5;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 818)
			{
				this.name = "Mushroom Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 6;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 819)
			{
				this.name = "Living Wood Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 7;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 820)
			{
				this.name = "Bone Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 8;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 821)
			{
				this.name = "Flame Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = 400000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 822)
			{
				this.name = "Frozen Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = 400000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 823)
			{
				this.name = "Ghost Wings";
				this.color = new Color(255, 255, 255, 0);
				this.alpha = 255;
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = 400000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 824)
			{
				this.name = "Sunplate Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 202;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 825)
			{
				this.name = "Disc Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 82;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 826)
			{
				this.name = "Skyware Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 10;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 827)
			{
				this.name = "Bone Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 4;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 828)
			{
				this.name = "Flesh Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 5;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 829)
			{
				this.name = "Living Wood Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 6;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 830)
			{
				this.name = "Skyware Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 7;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 831)
			{
				this.name = "Living Wood Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 12;
				this.width = 26;
				this.height = 22;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 832)
			{
				this.name = "Living Wood Wand";
				this.tileWand = 9;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.createTile = 191;
				this.width = 8;
				this.height = 10;
				this.rare = 1;
				this.toolTip = "Places living wood";
				goto IL_2B846;
			}
			if (this.type == 833)
			{
				this.name = "Purple Ice Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 163;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 834)
			{
				this.name = "Pink Ice Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 164;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 835)
			{
				this.name = "Red Ice Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 200;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 836)
			{
				this.name = "Crimstone";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 203;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 837)
			{
				this.name = "Skyware Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 9;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 838)
			{
				this.name = "Skyware Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 13;
				this.width = 26;
				this.height = 22;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 839)
			{
				this.name = "Steampunk Hat";
				this.width = 28;
				this.height = 20;
				this.headSlot = 59;
				this.rare = 2;
				this.vanity = true;
				this.value = Item.buyPrice(0, 1, 50, 0);
				goto IL_2B846;
			}
			if (this.type == 840)
			{
				this.name = "Steampunk Shirt";
				this.width = 18;
				this.height = 14;
				this.bodySlot = 39;
				this.rare = 2;
				this.vanity = true;
				this.value = Item.buyPrice(0, 1, 50, 0);
				goto IL_2B846;
			}
			if (this.type == 841)
			{
				this.name = "Steampunk Pants";
				this.width = 18;
				this.height = 14;
				this.legSlot = 37;
				this.rare = 2;
				this.vanity = true;
				this.value = Item.buyPrice(0, 1, 50, 0);
				goto IL_2B846;
			}
			if (this.type == 842)
			{
				this.name = "Bee Hat";
				this.width = 28;
				this.height = 20;
				this.headSlot = 60;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 843)
			{
				this.name = "Bee Shirt";
				this.width = 18;
				this.height = 14;
				this.bodySlot = 40;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 844)
			{
				this.name = "Bee Pants";
				this.width = 18;
				this.height = 14;
				this.legSlot = 38;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 845)
			{
				this.name = "World Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 7;
				this.width = 10;
				this.height = 24;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 846)
			{
				this.name = "Sun Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 8;
				this.width = 10;
				this.height = 24;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 847)
			{
				this.name = "Gravity Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 9;
				this.width = 10;
				this.height = 24;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 848)
			{
				this.name = "Pharaoh's Mask";
				this.width = 28;
				this.height = 20;
				this.headSlot = 61;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 849)
			{
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.name = "Actuator";
				this.width = 24;
				this.height = 28;
				this.toolTip = "Enables solid blocks to be toggled on and off";
				this.maxStack = 999;
				this.mech = true;
				this.value = Item.buyPrice(0, 0, 10, 0);
				goto IL_2B846;
			}
			if (this.type == 850)
			{
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.name = "Blue Wrench";
				this.width = 24;
				this.height = 28;
				this.rare = 1;
				this.toolTip = "Places blue wire";
				this.value = 20000;
				this.mech = true;
				this.tileBoost = 3;
				goto IL_2B846;
			}
			if (this.type == 851)
			{
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.name = "Green Wrench";
				this.width = 24;
				this.height = 28;
				this.rare = 1;
				this.toolTip = "Places green wire";
				this.value = 20000;
				this.mech = true;
				this.tileBoost = 3;
				goto IL_2B846;
			}
			if (this.type == 852)
			{
				this.name = "Blue Pressure Plate";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 135;
				this.width = 12;
				this.height = 12;
				this.placeStyle = 4;
				this.mech = true;
				this.value = 5000;
				this.toolTip = "Activates when a player steps on it on";
				goto IL_2B846;
			}
			if (this.type == 853)
			{
				this.name = "Yellow Pressure Plate";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 135;
				this.width = 12;
				this.height = 12;
				this.placeStyle = 5;
				this.mech = true;
				this.value = 5000;
				this.toolTip = "Activates when anything but a player steps on it on";
				goto IL_2B846;
			}
			if (this.type == 854)
			{
				this.name = "Discount Card";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 5;
				this.toolTip = "Shops have lower prices";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 855)
			{
				this.name = "Lucky Coin";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 5;
				this.toolTip = "Hitting enemies will sometimes drop extra coins";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 856)
			{
				this.noWet = true;
				this.name = "Stick Unicorn";
				this.holdStyle = 1;
				this.width = 30;
				this.height = 30;
				this.toolTip = "'Having a wonderful time!'";
				this.value = 500;
				this.rare = 2;
				goto IL_2B846;
			}
			if (this.type == 857)
			{
				this.name = "Sandstorm in a Bottle";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 2;
				this.toolTip = "Allows the holder to double jump";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 858)
			{
				this.name = "bl";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "Allows the holder to double jump";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 859)
			{
				this.useStyle = 1;
				this.name = "Beach Ball";
				this.shootSpeed = 6f;
				this.shoot = 155;
				this.width = 44;
				this.height = 44;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 20;
				goto IL_2B846;
			}
			if (this.type == 860)
			{
				this.name = "Charm of Myths";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 6;
				this.lifeRegen = 1;
				this.toolTip = "Provides life regeneration and reduces the cooldown of healing potions";
				this.value = 500000;
				goto IL_2B846;
			}
			if (this.type == 861)
			{
				this.name = "Moon Shell";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 6;
				this.toolTip = "Turns the holder into a werewolf on full moons and a merfolk when entering water";
				this.value = 500000;
				goto IL_2B846;
			}
			if (this.type == 862)
			{
				this.name = "Star Veil";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 6;
				this.toolTip = "Causes stars to fall and increases length of invincibility after taking damage";
				this.value = 500000;
				goto IL_2B846;
			}
			if (this.type == 863)
			{
				this.name = "Water Walking Boots";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 4;
				this.toolTip = "Provides the ability to walk on water";
				this.value = 200000;
				goto IL_2B846;
			}
			if (this.type == 864)
			{
				this.name = "Tiara";
				this.width = 28;
				this.height = 20;
				this.headSlot = 62;
				this.rare = 1;
				this.vanity = true;
				this.value = Item.buyPrice(0, 25, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 865)
			{
				this.name = "Princess Dress";
				this.width = 18;
				this.height = 14;
				this.bodySlot = 41;
				this.rare = 1;
				this.vanity = true;
				this.value = Item.buyPrice(0, 10, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 866)
			{
				this.name = "Pharaoh's Robe";
				this.width = 18;
				this.height = 14;
				this.bodySlot = 42;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 867)
			{
				this.name = "Green Cap";
				this.width = 28;
				this.height = 20;
				this.headSlot = 63;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 868)
			{
				this.name = "Mushroom Cap";
				this.width = 28;
				this.height = 20;
				this.headSlot = 64;
				this.rare = 1;
				this.vanity = true;
				this.value = Item.buyPrice(0, 2, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 869)
			{
				this.name = "Tam O' Shanter";
				this.width = 28;
				this.height = 20;
				this.headSlot = 65;
				this.rare = 1;
				this.vanity = true;
				this.value = Item.buyPrice(0, 2, 50, 0);
				goto IL_2B846;
			}
			if (this.type == 870)
			{
				this.name = "Mummy Mask";
				this.width = 28;
				this.height = 20;
				this.headSlot = 66;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 871)
			{
				this.name = "Mummy Shirt";
				this.width = 28;
				this.height = 20;
				this.bodySlot = 43;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 872)
			{
				this.name = "Mummy Pants";
				this.width = 28;
				this.height = 20;
				this.legSlot = 39;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 873)
			{
				this.name = "Cowboy Hat";
				this.width = 28;
				this.height = 20;
				this.headSlot = 67;
				this.rare = 1;
				this.vanity = true;
				this.value = Item.buyPrice(0, 5, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 874)
			{
				this.name = "Cowboy Jacket";
				this.width = 28;
				this.height = 20;
				this.bodySlot = 44;
				this.rare = 1;
				this.vanity = true;
				this.value = Item.buyPrice(0, 5, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 875)
			{
				this.name = "Cowboy Pants";
				this.width = 28;
				this.height = 20;
				this.legSlot = 40;
				this.rare = 1;
				this.vanity = true;
				this.value = Item.buyPrice(0, 5, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 876)
			{
				this.name = "Pirate Hat";
				this.width = 28;
				this.height = 20;
				this.headSlot = 68;
				this.rare = 1;
				this.vanity = true;
				this.value = Item.buyPrice(0, 5, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 877)
			{
				this.name = "Pirate Shirt";
				this.width = 28;
				this.height = 20;
				this.bodySlot = 45;
				this.rare = 1;
				this.vanity = true;
				this.value = Item.buyPrice(0, 5, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 878)
			{
				this.name = "Pirate Pants";
				this.width = 28;
				this.height = 20;
				this.legSlot = 41;
				this.rare = 1;
				this.vanity = true;
				this.value = Item.buyPrice(0, 5, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 879)
			{
				this.name = "Viking Helmet";
				this.width = 28;
				this.height = 20;
				this.headSlot = 69;
				this.rare = 1;
				this.defense = 4;
				this.value = Item.sellPrice(0, 0, 50, 0);
				goto IL_2B846;
			}
			if (this.type == 880)
			{
				this.name = "Crimtane";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 204;
				this.width = 12;
				this.height = 12;
				this.rare = 1;
				this.value = 4500;
				goto IL_2B846;
			}
			if (this.type == 881)
			{
				this.name = "Cactus Sword";
				this.useStyle = 1;
				this.useTurn = false;
				this.useAnimation = 25;
				this.useTime = 25;
				this.width = 24;
				this.height = 28;
				this.damage = 9;
				this.knockBack = 5f;
				this.useSound = 1;
				this.scale = 1f;
				this.value = 1800;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 882)
			{
				this.name = "Cactus Pickaxe";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 23;
				this.useTime = 15;
				this.autoReuse = true;
				this.width = 24;
				this.height = 28;
				this.damage = 5;
				this.pick = 35;
				this.useSound = 1;
				this.knockBack = 2f;
				this.value = 2000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 883)
			{
				this.name = "Ice Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 206;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 884)
			{
				this.name = "Ice Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 84;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 885)
			{
				this.name = "Adhesive Bandage";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 4;
				this.toolTip = "Immunity to Bleeding";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 886)
			{
				this.name = "Armor Polish";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 4;
				this.toolTip = "Immunity to Broken Armor";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 887)
			{
				this.name = "Bezoar";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 4;
				this.toolTip = "Immunity to Poison";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 888)
			{
				this.name = "Blindfold";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 4;
				this.toolTip = "Immunity to Darkness";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 889)
			{
				this.name = "Fast Clock";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 4;
				this.toolTip = "Immunity to Slow";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 890)
			{
				this.name = "Megaphone";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 4;
				this.toolTip = "Immunity to Silence";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 891)
			{
				this.name = "Nazar";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 2;
				this.toolTip = "Immunity to Curse";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 892)
			{
				this.name = "Vitamins";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 4;
				this.toolTip = "Immunity to Weakness";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 893)
			{
				this.name = "Trifold Map";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 4;
				this.toolTip = "Immunity to Confusion";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 894)
			{
				this.name = "Cactus Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.headSlot = 70;
				goto IL_2B846;
			}
			if (this.type == 895)
			{
				this.name = "Cactus Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.bodySlot = 46;
				goto IL_2B846;
			}
			if (this.type == 896)
			{
				this.name = "Cactus Leggings";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.legSlot = 42;
				goto IL_2B846;
			}
			if (this.type == 897)
			{
				this.name = "Power Glove";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 5;
				this.toolTip = "Increases melee knockback";
				this.toolTip = "12% increased melee speed";
				this.value = 300000;
				goto IL_2B846;
			}
			if (this.type == 898)
			{
				this.name = "Lightning Boots";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 5;
				this.toolTip = "Allows flight and super fast running";
				this.toolTip = "7% increased movement speed";
				this.value = 300000;
				goto IL_2B846;
			}
			if (this.type == 899)
			{
				this.name = "Sun Stone";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 7;
				this.toolTip = "Increases all stats if worn during the day";
				this.value = 300000;
				goto IL_2B846;
			}
			if (this.type == 900)
			{
				this.name = "Moon Stone";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 5;
				this.toolTip = "Increases all stats if worn during the night";
				this.value = 300000;
				goto IL_2B846;
			}
			if (this.type == 901)
			{
				this.name = "Armor Bracing";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 5;
				this.toolTip = "Immunity to Weakness and Broken Armor";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 902)
			{
				this.name = "Medicated Bandage";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 5;
				this.toolTip = "Immunity to Poison and Bleeding";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 903)
			{
				this.name = "The Plan";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 5;
				this.toolTip = "Immunity to Slow and Confusion";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 904)
			{
				this.name = "Countercurse Mantra";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 5;
				this.toolTip = "Immunity to Silence and Curse";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 905)
			{
				this.name = "Coin Gun";
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 8;
				this.useTime = 8;
				this.width = 50;
				this.height = 18;
				this.shoot = 158;
				this.useAmmo = 71;
				this.useSound = 11;
				this.damage = 0;
				this.shootSpeed = 10f;
				this.noMelee = true;
				this.value = 300000;
				this.rare = 6;
				this.toolTip = "Uses coins for ammo";
				this.toolTip2 = "Higher valued coins do more damage";
				this.knockBack = 2f;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 906)
			{
				this.name = "Lava Charm";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 3;
				this.toolTip = "Provides 7 seconds of immunity to lava";
				this.value = 300000;
				goto IL_2B846;
			}
			if (this.type == 907)
			{
				this.name = "Obsidian Water Walking Boots";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 4;
				this.toolTip = "Provides the ability to walk on water";
				this.toolTip = "Grants immunity to fire blocks";
				this.value = 500000;
				goto IL_2B846;
			}
			if (this.type == 908)
			{
				this.name = "Lava Waders";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 7;
				this.toolTip = "Provides the ability to walk on water and lava";
				this.toolTip = "Grants immunity to fire blocks and 7 seconds of immunity to lava";
				this.value = 500000;
				goto IL_2B846;
			}
			if (this.type == 909)
			{
				this.name = "Pure Water Fountain";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 207;
				this.placeStyle = 0;
				this.width = 26;
				this.height = 36;
				goto IL_2B846;
			}
			if (this.type == 910)
			{
				this.name = "Desert Water Fountain";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 207;
				this.placeStyle = 1;
				this.width = 26;
				this.height = 36;
				goto IL_2B846;
			}
			if (this.type == 911)
			{
				this.name = "Shadewood";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 208;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 912)
			{
				this.name = "Shadewood Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 10;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 913)
			{
				this.name = "Shadewood Platform";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 5;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 914)
			{
				this.name = "Shadewood Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 14;
				this.width = 26;
				this.height = 22;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 915)
			{
				this.name = "Shadewood Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 11;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 916)
			{
				this.name = "Shadewood Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 9;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				this.toolTip = "Used for basic crafting";
				goto IL_2B846;
			}
			if (this.type == 917)
			{
				this.name = "Shadewood Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 8;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 918)
			{
				this.name = "Shadewood Dresser";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 88;
				this.placeStyle = 4;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 919)
			{
				this.name = "Shadewood Piano";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 87;
				this.placeStyle = 4;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 920)
			{
				this.name = "Shadewood Bed";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 79;
				this.placeStyle = 4;
				this.width = 28;
				this.height = 20;
				this.value = 2000;
				goto IL_2B846;
			}
			if (this.type == 921)
			{
				this.name = "Shadewood Sword";
				this.useStyle = 1;
				this.useTurn = false;
				this.useAnimation = 21;
				this.useTime = 21;
				this.width = 24;
				this.height = 28;
				this.damage = 10;
				this.knockBack = 5f;
				this.useSound = 1;
				this.scale = 1f;
				this.value = 100;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 922)
			{
				this.name = "Shadewood Hammer";
				this.autoReuse = true;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 30;
				this.useTime = 20;
				this.hammer = 40;
				this.width = 24;
				this.height = 28;
				this.damage = 7;
				this.knockBack = 5.5f;
				this.scale = 1.2f;
				this.useSound = 1;
				this.value = 50;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 923)
			{
				this.name = "Shadewood Bow";
				this.useStyle = 5;
				this.useAnimation = 28;
				this.useTime = 28;
				this.width = 12;
				this.height = 28;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 8;
				this.shootSpeed = 6.6f;
				this.noMelee = true;
				this.value = 100;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 924)
			{
				this.name = "Shadewood Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.headSlot = 71;
				goto IL_2B846;
			}
			if (this.type == 925)
			{
				this.name = "Shadewood Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.bodySlot = 47;
				goto IL_2B846;
			}
			if (this.type == 926)
			{
				this.name = "Shadewood Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 1;
				this.legSlot = 43;
				goto IL_2B846;
			}
			if (this.type == 927)
			{
				this.name = "Shadewood Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 85;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 928)
			{
				this.name = "Cannon";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 209;
				this.width = 12;
				this.height = 12;
				this.rare = 3;
				this.value = Item.buyPrice(0, 25, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 929)
			{
				this.name = "Cannonball";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 20;
				this.useTime = 20;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.width = 12;
				this.height = 12;
				this.damage = 300;
				this.noMelee = true;
				this.value = Item.buyPrice(0, 0, 15, 0);
				goto IL_2B846;
			}
			if (this.type == 930)
			{
				this.useStyle = 5;
				this.useAnimation = 18;
				this.useTime = 18;
				this.name = "Flare Gun";
				this.width = 24;
				this.height = 28;
				this.shoot = 163;
				this.useAmmo = 931;
				this.useSound = 11;
				this.damage = 2;
				this.shootSpeed = 6f;
				this.noMelee = true;
				this.value = 50000;
				this.scale = 0.9f;
				this.rare = 1;
				this.holdStyle = 1;
				goto IL_2B846;
			}
			if (this.type == 931)
			{
				this.name = "Flare";
				this.shootSpeed = 6f;
				this.shoot = 163;
				this.damage = 1;
				this.width = 12;
				this.height = 12;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 931;
				this.knockBack = 1.5f;
				this.value = 7;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 932)
			{
				this.name = "Bone Wand";
				this.tileWand = 154;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.createTile = 194;
				this.width = 8;
				this.height = 10;
				this.rare = 1;
				this.toolTip = "Places bone";
				goto IL_2B846;
			}
			if (this.type == 933)
			{
				this.name = "Leaf Wand";
				this.tileWand = 9;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.createTile = 192;
				this.width = 8;
				this.height = 10;
				this.rare = 1;
				this.toolTip = "Places leaves";
				goto IL_2B846;
			}
			if (this.type == 934)
			{
				this.name = "Flying Carpet";
				this.width = 34;
				this.height = 12;
				this.accessory = true;
				this.rare = 2;
				this.toolTip = "Allows the owner to float for a few seconds";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 935)
			{
				this.name = "Avenger Emblem";
				this.width = 24;
				this.height = 24;
				this.accessory = true;
				this.toolTip = "12% increased damage";
				this.value = 300000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 936)
			{
				this.name = "Mechanical Glove";
				this.width = 24;
				this.height = 24;
				this.accessory = true;
				this.rare = 6;
				this.toolTip = "Increases melee knockback";
				this.toolTip = "10% increased damage and melee speed";
				this.value = 300000;
				goto IL_2B846;
			}
			if (this.type == 937)
			{
				this.name = "Land Mine";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 210;
				this.width = 12;
				this.height = 12;
				this.placeStyle = 0;
				this.mech = true;
				this.value = 50000;
				this.mech = true;
				this.toolTip = "Explodes when stepped on";
				goto IL_2B846;
			}
			if (this.type == 938)
			{
				this.name = "Paladin's Shield";
				this.width = 24;
				this.height = 24;
				this.accessory = true;
				this.rare = 8;
				this.defense = 6;
				this.toolTip = "Absorbs 25% of damage done to players on your team when above 25% life";
				this.toolTip = "Grants immunity to knockback";
				this.value = 300000;
				goto IL_2B846;
			}
			if (this.type == 939)
			{
				this.noUseGraphic = true;
				this.damage = 0;
				this.knockBack = 7f;
				this.useStyle = 5;
				this.name = "Web Slinger";
				this.shootSpeed = 10f;
				this.shoot = 165;
				this.width = 18;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 2;
				this.noMelee = true;
				this.value = 20000;
				goto IL_2B846;
			}
			if (this.type == 940)
			{
				this.name = "Jungle Water Fountain";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 207;
				this.placeStyle = 2;
				this.width = 26;
				this.height = 36;
				goto IL_2B846;
			}
			if (this.type == 941)
			{
				this.name = "Icy Water Fountain";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 207;
				this.placeStyle = 3;
				this.width = 26;
				this.height = 36;
				goto IL_2B846;
			}
			if (this.type == 942)
			{
				this.name = "Corrupt Water Fountain";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 207;
				this.placeStyle = 4;
				this.width = 26;
				this.height = 36;
				goto IL_2B846;
			}
			if (this.type == 943)
			{
				this.name = "Crimson Water Fountain";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 207;
				this.placeStyle = 5;
				this.width = 26;
				this.height = 36;
				goto IL_2B846;
			}
			if (this.type == 944)
			{
				this.name = "Hallowed Water Fountain";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 207;
				this.placeStyle = 6;
				this.width = 26;
				this.height = 36;
				goto IL_2B846;
			}
			if (this.type == 945)
			{
				this.name = "Blood Water Fountain";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 207;
				this.placeStyle = 7;
				this.width = 26;
				this.height = 36;
				goto IL_2B846;
			}
			if (this.type == 946)
			{
				this.name = "Umbrella";
				this.width = 44;
				this.height = 44;
				this.rare = 1;
				this.value = 10000;
				this.holdStyle = 2;
				this.toolTip = "You will fall slower while holding this";
				goto IL_2B846;
			}
			if (this.type == 947)
			{
				this.name = "Chlorophyte Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 211;
				this.width = 12;
				this.height = 12;
				this.rare = 7;
				this.value = 250;
				this.toolTip = "Reacts to the light";
				goto IL_2B846;
			}
			if (this.type == 948)
			{
				this.name = "Steampunk Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = 400000;
				this.rare = 8;
				goto IL_2B846;
			}
			if (this.type == 949)
			{
				this.useStyle = 1;
				this.name = "Snowball";
				this.shootSpeed = 7f;
				this.shoot = 166;
				this.ammo = 949;
				this.damage = 4;
				this.width = 18;
				this.height = 20;
				this.maxStack = 999;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 19;
				this.useTime = 19;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.ranged = true;
				this.knockBack = 4.5f;
				goto IL_2B846;
			}
			if (this.type == 950)
			{
				this.name = "Ice Skates";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "Provides extra mobility on ice";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 951)
			{
				this.name = "Snowball Launcher";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 212;
				this.width = 20;
				this.height = 20;
				this.value = 50000;
				this.rare = 2;
				this.toolTip = "Rapidly launches snowballs";
				goto IL_2B846;
			}
			if (this.type == 952)
			{
				this.name = "Web Covered Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 15;
				this.width = 26;
				this.height = 22;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 953)
			{
				this.name = "Climbing Claws";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "Allows the ability to slide down walls";
				this.toolTip = "Improved ability if combined with Shoe Spikes";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 954)
			{
				this.name = "Ancient Iron Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 2;
				this.headSlot = 72;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 955)
			{
				this.name = "Ancient Gold Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 4;
				this.headSlot = 73;
				this.value = 25000;
				goto IL_2B846;
			}
			if (this.type == 956)
			{
				this.name = "Ancient Shadow Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 6;
				this.headSlot = 74;
				this.rare = 1;
				this.value = 37500;
				this.toolTip = "7% increased melee speed";
				goto IL_2B846;
			}
			if (this.type == 957)
			{
				this.name = "Ancient Shadow Scalemail";
				this.width = 18;
				this.height = 18;
				this.defense = 7;
				this.bodySlot = 48;
				this.rare = 1;
				this.value = 30000;
				this.toolTip = "7% increased melee speed";
				goto IL_2B846;
			}
			if (this.type == 958)
			{
				this.name = "Ancient Shadow Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 6;
				this.legSlot = 44;
				this.rare = 1;
				this.value = 22500;
				this.toolTip = "7% increased melee speed";
				goto IL_2B846;
			}
			if (this.type == 959)
			{
				this.name = "Ancient Necro Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.headSlot = 75;
				this.rare = 2;
				this.value = 45000;
				this.toolTip = "4% increased ranged damage.";
				goto IL_2B846;
			}
			if (this.type == 960)
			{
				this.name = "Ancient Cobalt Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.headSlot = 76;
				this.rare = 3;
				this.value = 45000;
				this.toolTip = "Increases maximum mana by 20";
				this.toolTip2 = "3% increased magic critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 961)
			{
				this.name = "Ancient Cobalt Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.bodySlot = 49;
				this.rare = 3;
				this.value = 30000;
				this.toolTip = "Increases maximum mana by 20";
				this.toolTip2 = "3% increased magic critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 962)
			{
				this.name = "Ancient Cobalt Leggings";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.legSlot = 45;
				this.rare = 3;
				this.value = 30000;
				this.toolTip = "Increases maximum mana by 20";
				this.toolTip2 = "3% increased magic critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 963)
			{
				this.name = "Black Belt";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 7;
				this.toolTip = "Gives a chance to dodge attacks";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 964)
			{
				this.knockBack = 5.5f;
				this.useStyle = 5;
				this.useAnimation = 42;
				this.useTime = 42;
				this.name = "Boomstick";
				this.width = 50;
				this.height = 14;
				this.shoot = 10;
				this.useAmmo = 14;
				this.useSound = 36;
				this.damage = 12;
				this.shootSpeed = 5.25f;
				this.noMelee = true;
				this.value = Item.sellPrice(0, 2, 0, 0);
				this.rare = 2;
				this.ranged = true;
				this.toolTip = "Fires a spread of bullets";
				goto IL_2B846;
			}
			if (this.type == 965)
			{
				this.name = "Rope";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 8;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 213;
				this.width = 12;
				this.height = 12;
				this.value = 10;
				this.tileBoost += 2;
				this.toolTip = "Can be climbed on";
				goto IL_2B846;
			}
			if (this.type == 966)
			{
				this.name = "Campfire";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 215;
				this.width = 12;
				this.height = 12;
				this.toolTip = "Life regen is increased when near a campfire";
				goto IL_2B846;
			}
			if (this.type == 967)
			{
				this.name = "Marshmellow";
				this.width = 12;
				this.height = 12;
				this.maxStack = 99;
				this.value = 100;
				goto IL_2B846;
			}
			if (this.type == 968)
			{
				this.name = "Marshmellow on a Stick";
				this.holdStyle = 1;
				this.width = 12;
				this.height = 12;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 969)
			{
				this.name = "Cooked Marshmellow";
				this.useSound = 2;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 12;
				this.height = 12;
				this.buffType = 26;
				this.buffTime = 36000;
				this.rare = 1;
				this.toolTip = "Minor improvements to all stats";
				this.value = 1000;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 970)
			{
				this.name = "Red Rocket";
				this.createTile = 216;
				this.placeStyle = 0;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.width = 12;
				this.height = 30;
				this.value = 1500;
				goto IL_2B846;
			}
			if (this.type == 971)
			{
				this.name = "Green Rocket";
				this.createTile = 216;
				this.placeStyle = 1;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.width = 12;
				this.height = 30;
				this.value = 1500;
				goto IL_2B846;
			}
			if (this.type == 972)
			{
				this.name = "Blue Rocket";
				this.createTile = 216;
				this.placeStyle = 2;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.width = 12;
				this.height = 30;
				this.value = 1500;
				goto IL_2B846;
			}
			if (this.type == 973)
			{
				this.name = "Yellow Rocket";
				this.createTile = 216;
				this.placeStyle = 3;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.width = 12;
				this.height = 30;
				this.value = 1500;
				goto IL_2B846;
			}
			if (this.type == 974)
			{
				this.flame = true;
				this.name = "Ice Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.holdStyle = 1;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 4;
				this.placeStyle = 9;
				this.width = 10;
				this.height = 12;
				this.value = 60;
				this.noWet = true;
				goto IL_2B846;
			}
			if (this.type == 975)
			{
				this.name = "Shoe Spikes";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "Allows the ability to slide down walls";
				this.toolTip = "Improved ability if combined with Climbing Claws";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 976)
			{
				this.name = "Tiger Climbing Gear";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 2;
				this.toolTip = "Allows the ability to climb walls";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 977)
			{
				this.name = "Tabi";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 7;
				this.toolTip = "Allows the ability to dash";
				this.toolTip = "Double tap a direction";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 978)
			{
				this.name = "Pink Eskimo Hood";
				this.width = 18;
				this.height = 18;
				this.headSlot = 77;
				this.value = 50000;
				this.defense = 1;
				goto IL_2B846;
			}
			if (this.type == 979)
			{
				this.name = "Pink Eskimo Coat";
				this.width = 18;
				this.height = 18;
				this.bodySlot = 50;
				this.value = 40000;
				this.defense = 2;
				goto IL_2B846;
			}
			if (this.type == 980)
			{
				this.name = "Pink Eskimo Pants";
				this.width = 18;
				this.height = 18;
				this.legSlot = 46;
				this.value = 30000;
				this.defense = 1;
				goto IL_2B846;
			}
			if (this.type == 981)
			{
				this.name = "Pink Thread";
				this.maxStack = 99;
				this.width = 12;
				this.height = 20;
				this.value = 10000;
				goto IL_2B846;
			}
			if (this.type == 982)
			{
				this.name = "Mana Regeneration Band";
				this.width = 22;
				this.height = 22;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "Increases maximum mana by 20";
				this.toolTip2 = "Increases mana regeneration rate";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 983)
			{
				this.name = "Sandstorm in a Balloon";
				this.width = 14;
				this.height = 28;
				this.rare = 4;
				this.value = 150000;
				this.accessory = true;
				this.toolTip = "Allows the holder to double jump";
				this.toolTip2 = "Increases jump height";
				goto IL_2B846;
			}
			if (this.type == 984)
			{
				this.name = "Master Ninja Gear";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 8;
				this.toolTip = "Allows the ability to climb walls and dash";
				this.toolTip2 = "Gives a chance to dodge attacks";
				this.value = 500000;
				goto IL_2B846;
			}
			if (this.type == 985)
			{
				this.useStyle = 1;
				this.name = "Rope Coil";
				this.shootSpeed = 10f;
				this.shoot = 171;
				this.damage = 0;
				this.width = 18;
				this.height = 20;
				this.maxStack = 999;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 100;
				this.toolTip = "Throw to create a climbable line of rope";
				goto IL_2B846;
			}
			if (this.type == 986)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 35;
				this.useTime = 35;
				this.name = "Blowgun";
				this.width = 38;
				this.height = 6;
				this.shoot = 10;
				this.useAmmo = 51;
				this.useSound = 5;
				this.damage = 25;
				this.shootSpeed = 13f;
				this.noMelee = true;
				this.value = Item.buyPrice(0, 5, 0, 0);
				this.knockBack = 4f;
				this.useAmmo = 51;
				this.toolTip = "Allows the collection of seeds for ammo";
				this.ranged = true;
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 987)
			{
				this.name = "Blizzard in a Bottle";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "Allows the holder to double jump";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 988)
			{
				this.name = "Frostburn Arrow";
				this.shootSpeed = 3.75f;
				this.shoot = 172;
				this.damage = 7;
				this.width = 10;
				this.height = 28;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 1;
				this.knockBack = 2.2f;
				this.value = 15;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 989)
			{
				this.rare = 2;
				this.useSound = 1;
				this.name = "Enchanted Sword";
				this.useStyle = 1;
				this.damage = 18;
				this.useAnimation = 19;
				this.useTime = 60;
				this.scale = 1.1f;
				this.width = 30;
				this.height = 30;
				this.shoot = 173;
				this.shootSpeed = 9f;
				this.knockBack = 5f;
				this.toolTip = "Shoots an echanted beam";
				this.melee = true;
				this.value = 20000;
				goto IL_2B846;
			}
			if (this.type == 990)
			{
				this.useTurn = true;
				this.autoReuse = true;
				this.name = "Pickaxe Axe";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.useTime = 7;
				this.knockBack = 4.75f;
				this.width = 20;
				this.height = 12;
				this.damage = 35;
				this.pick = 200;
				this.axe = 22;
				this.useSound = 1;
				this.rare = 4;
				this.value = 220000;
				this.melee = true;
				this.scale = 1.1f;
				this.toolTip = "'Not to be confused with a hamdrill'";
				goto IL_2B846;
			}
			if (this.type == 991)
			{
				this.useTurn = true;
				this.autoReuse = true;
				this.name = "Cobalt Waraxe";
				this.useStyle = 1;
				this.useAnimation = 35;
				this.useTime = 8;
				this.knockBack = 5f;
				this.width = 20;
				this.height = 12;
				this.damage = 33;
				this.axe = 14;
				this.useSound = 1;
				this.rare = 4;
				this.value = 54000;
				this.melee = true;
				this.scale = 1.1f;
				goto IL_2B846;
			}
			if (this.type == 992)
			{
				this.useTurn = true;
				this.autoReuse = true;
				this.name = "Mythril Waraxe";
				this.useStyle = 1;
				this.useAnimation = 35;
				this.useTime = 8;
				this.knockBack = 6f;
				this.width = 20;
				this.height = 12;
				this.damage = 39;
				this.axe = 17;
				this.useSound = 1;
				this.rare = 4;
				this.value = 81000;
				this.melee = true;
				this.scale = 1.1f;
				goto IL_2B846;
			}
			if (this.type == 993)
			{
				this.useTurn = true;
				this.autoReuse = true;
				this.name = "Adamantite Waraxe";
				this.useStyle = 1;
				this.useAnimation = 35;
				this.useTime = 6;
				this.knockBack = 7f;
				this.width = 20;
				this.height = 12;
				this.damage = 43;
				this.axe = 20;
				this.useSound = 1;
				this.rare = 4;
				this.value = 108000;
				this.melee = true;
				this.scale = 1.1f;
				goto IL_2B846;
			}
			if (this.type == 994)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Eater's Bone";
				this.shoot = 175;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.toolTip = "Summons a Baby Eater of Souls";
				this.value = 0;
				this.buffType = 45;
				goto IL_2B846;
			}
			if (this.type == 995)
			{
				this.name = "Blend-O-Matic";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 217;
				this.width = 26;
				this.height = 20;
				this.value = 100000;
				this.toolTip = "Used to craft objects";
				goto IL_2B846;
			}
			if (this.type == 996)
			{
				this.name = "Meat Grinder";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 218;
				this.width = 26;
				this.height = 20;
				this.value = 100000;
				this.toolTip = "Used to craft objects";
				goto IL_2B846;
			}
			if (this.type == 997)
			{
				this.name = "Silt Extractinator";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 219;
				this.width = 26;
				this.height = 20;
				this.value = 100000;
				this.toolTip = "Turns silt into something more useful";
				this.toolTip2 = "'To use: Place silt in the extractinator'";
				goto IL_2B846;
			}
			if (this.type == 998)
			{
				this.name = "Solidifier";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 220;
				this.width = 26;
				this.height = 20;
				this.value = 100000;
				this.toolTip = "Used to craft objects";
				goto IL_2B846;
			}
			if (this.type == 999)
			{
				this.name = "Amber";
				this.createTile = 178;
				this.placeStyle = 6;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.alpha = 50;
				this.width = 10;
				this.height = 14;
				this.value = 15000;
				goto IL_2B846;
			}
			if (this.type == 1000)
			{
				this.useStyle = 5;
				this.name = "Confetti Gun";
				this.shootSpeed = 10f;
				this.shoot = 178;
				this.damage = 0;
				this.width = 18;
				this.height = 20;
				this.maxStack = 999;
				this.consumable = true;
				this.useSound = 11;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noMelee = true;
				this.value = 100;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 1001)
			{
				this.name = "Chlorophyte Mask";
				this.width = 18;
				this.height = 18;
				this.defense = 25;
				this.headSlot = 78;
				this.rare = 7;
				this.value = 300000;
				this.toolTip = "16% increased melee damage";
				this.toolTip2 = "6% increased melee critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1002)
			{
				this.name = "Chlorophyte Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 13;
				this.headSlot = 79;
				this.rare = 7;
				this.value = 300000;
				this.toolTip = "16% increased ranged damage";
				this.toolTip2 = "20% chance to not consume ammo";
				goto IL_2B846;
			}
			if (this.type == 1003)
			{
				this.name = "Chlorophyte Headgear";
				this.width = 18;
				this.height = 18;
				this.defense = 7;
				this.headSlot = 80;
				this.rare = 7;
				this.value = 300000;
				this.toolTip = "Increases maximum mana by 80 and reduces mana usage by 17%";
				this.toolTip2 = "16% increased magic damage";
				goto IL_2B846;
			}
			if (this.type == 1004)
			{
				this.name = "Chlorophyte Plate Mail";
				this.width = 18;
				this.height = 18;
				this.defense = 18;
				this.bodySlot = 51;
				this.rare = 7;
				this.value = 240000;
				this.toolTip = "5% increased damage";
				this.toolTip = "7% increased critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1005)
			{
				this.name = "Chlorophyte Greaves";
				this.width = 18;
				this.height = 18;
				this.defense = 13;
				this.legSlot = 47;
				this.rare = 7;
				this.value = 180000;
				this.toolTip = "8% increased critical strike chance";
				this.toolTip = "5% increased movement speed";
				goto IL_2B846;
			}
			if (this.type == 1006)
			{
				this.name = "Chlorophyte Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = Item.sellPrice(0, 0, 90, 0);
				this.rare = 7;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 17;
				goto IL_2B846;
			}
			if (this.type == 1007)
			{
				this.name = "Red Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 1;
				goto IL_2B846;
			}
			if (this.type == 1008)
			{
				this.name = "Orange Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 2;
				goto IL_2B846;
			}
			if (this.type == 1009)
			{
				this.name = "Yellow Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 3;
				goto IL_2B846;
			}
			if (this.type == 1010)
			{
				this.name = "Lime Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 4;
				goto IL_2B846;
			}
			if (this.type == 1011)
			{
				this.name = "Green Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 5;
				goto IL_2B846;
			}
			if (this.type == 1012)
			{
				this.name = "Teal Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 6;
				goto IL_2B846;
			}
			if (this.type == 1013)
			{
				this.name = "Cyan Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 7;
				goto IL_2B846;
			}
			if (this.type == 1014)
			{
				this.name = "Sky Blue Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 8;
				goto IL_2B846;
			}
			if (this.type == 1015)
			{
				this.name = "Blue Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 9;
				goto IL_2B846;
			}
			if (this.type == 1016)
			{
				this.name = "Purple Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 10;
				goto IL_2B846;
			}
			if (this.type == 1017)
			{
				this.name = "Violet Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 11;
				goto IL_2B846;
			}
			if (this.type == 1018)
			{
				this.name = "Pink Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 12;
				goto IL_2B846;
			}
			if (this.type == 1019)
			{
				this.name = "Red and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 13;
				goto IL_2B846;
			}
			if (this.type == 1020)
			{
				this.name = "Orange and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 14;
				goto IL_2B846;
			}
			if (this.type == 1021)
			{
				this.name = "Yellow and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 15;
				goto IL_2B846;
			}
			if (this.type == 1022)
			{
				this.name = "Lime and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 16;
				goto IL_2B846;
			}
			if (this.type == 1023)
			{
				this.name = "Green and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 17;
				goto IL_2B846;
			}
			if (this.type == 1024)
			{
				this.name = "Teal and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 18;
				goto IL_2B846;
			}
			if (this.type == 1025)
			{
				this.name = "Cyan and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 19;
				goto IL_2B846;
			}
			if (this.type == 1026)
			{
				this.name = "Sky Blue and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 20;
				goto IL_2B846;
			}
			if (this.type == 1027)
			{
				this.name = "Blue and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 21;
				goto IL_2B846;
			}
			if (this.type == 1028)
			{
				this.name = "Purple and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 22;
				goto IL_2B846;
			}
			if (this.type == 1029)
			{
				this.name = "Violet and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 23;
				goto IL_2B846;
			}
			if (this.type == 1030)
			{
				this.name = "Pink and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 24;
				goto IL_2B846;
			}
			if (this.type == 1031)
			{
				this.name = "Flame Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 25;
				goto IL_2B846;
			}
			if (this.type == 1032)
			{
				this.name = "Flame and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 26;
				goto IL_2B846;
			}
			if (this.type == 1033)
			{
				this.name = "Green Flame Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 27;
				goto IL_2B846;
			}
			if (this.type == 1034)
			{
				this.name = "Green Flame and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 28;
				goto IL_2B846;
			}
			if (this.type == 1035)
			{
				this.name = "Blue Flame Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 29;
				goto IL_2B846;
			}
			if (this.type == 1036)
			{
				this.name = "Blue Flame and Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 30;
				goto IL_2B846;
			}
			if (this.type == 1037)
			{
				this.name = "Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 31;
				goto IL_2B846;
			}
			if (this.type == 1038)
			{
				this.name = "Bright Red Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 32;
				goto IL_2B846;
			}
			if (this.type == 1039)
			{
				this.name = "Bright Orange Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 33;
				goto IL_2B846;
			}
			if (this.type == 1040)
			{
				this.name = "Bright Yellow Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 34;
				goto IL_2B846;
			}
			if (this.type == 1041)
			{
				this.name = "Bright Lime Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 35;
				goto IL_2B846;
			}
			if (this.type == 1042)
			{
				this.name = "Bright Green Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 36;
				goto IL_2B846;
			}
			if (this.type == 1043)
			{
				this.name = "Bright Teal Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 37;
				goto IL_2B846;
			}
			if (this.type == 1044)
			{
				this.name = "Bright Cyan Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 38;
				goto IL_2B846;
			}
			if (this.type == 1045)
			{
				this.name = "Bright Sky Blue Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 39;
				goto IL_2B846;
			}
			if (this.type == 1046)
			{
				this.name = "Bright Blue Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 40;
				goto IL_2B846;
			}
			if (this.type == 1047)
			{
				this.name = "Bright Purple Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 41;
				goto IL_2B846;
			}
			if (this.type == 1048)
			{
				this.name = "Bright Violet Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 42;
				goto IL_2B846;
			}
			if (this.type == 1049)
			{
				this.name = "Bright Pink Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 43;
				goto IL_2B846;
			}
			if (this.type == 1050)
			{
				this.name = "Black Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 44;
				goto IL_2B846;
			}
			if (this.type == 1051)
			{
				this.name = "Red and Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 45;
				goto IL_2B846;
			}
			if (this.type == 1052)
			{
				this.name = "Orange and Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 46;
				goto IL_2B846;
			}
			if (this.type == 1053)
			{
				this.name = "Yellow and Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 47;
				goto IL_2B846;
			}
			if (this.type == 1054)
			{
				this.name = "Lime and Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 48;
				goto IL_2B846;
			}
			if (this.type == 1055)
			{
				this.name = "Green and Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 49;
				goto IL_2B846;
			}
			if (this.type == 1056)
			{
				this.name = "Teal and Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 50;
				goto IL_2B846;
			}
			if (this.type == 1057)
			{
				this.name = "Cyan and Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 51;
				goto IL_2B846;
			}
			if (this.type == 1058)
			{
				this.name = "Sky Blue and Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 52;
				goto IL_2B846;
			}
			if (this.type == 1059)
			{
				this.name = "Blue and Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 53;
				goto IL_2B846;
			}
			if (this.type == 1060)
			{
				this.name = "Purple and Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 54;
				goto IL_2B846;
			}
			if (this.type == 1061)
			{
				this.name = "Violet and Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 55;
				goto IL_2B846;
			}
			if (this.type == 1062)
			{
				this.name = "Pink and Silver Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 56;
				goto IL_2B846;
			}
			if (this.type == 1063)
			{
				this.name = "Intense Flame Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 57;
				goto IL_2B846;
			}
			if (this.type == 1064)
			{
				this.name = "Intense Green Flame Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 58;
				goto IL_2B846;
			}
			if (this.type == 1065)
			{
				this.name = "Intense Blue Flame Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 59;
				goto IL_2B846;
			}
			if (this.type == 1066)
			{
				this.name = "Rainbow Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 60;
				goto IL_2B846;
			}
			if (this.type == 1067)
			{
				this.name = "Intense Rainbow Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 61;
				goto IL_2B846;
			}
			if (this.type == 1068)
			{
				this.name = "Yellow Gradient Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 62;
				goto IL_2B846;
			}
			if (this.type == 1069)
			{
				this.name = "Cyan Gradient Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 63;
				goto IL_2B846;
			}
			if (this.type == 1070)
			{
				this.name = "Violet Gradient Dye";
				this.width = 20;
				this.height = 20;
				this.maxStack = 1;
				this.value = 10000;
				this.rare = 1;
				this.dye = 64;
				goto IL_2B846;
			}
			if (this.type == 1071)
			{
				this.name = "Paintbrush";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.width = 24;
				this.height = 24;
				this.toolTip = "Used with paint to color blocks";
				this.value = 10000;
				goto IL_2B846;
			}
			if (this.type == 1072)
			{
				this.name = "Paint Roller";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.width = 24;
				this.height = 24;
				this.toolTip = "Used with paint to color walls";
				this.value = 10000;
				goto IL_2B846;
			}
			if (this.type == 1073)
			{
				this.name = "Red Paint";
				this.paint = 1;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1074)
			{
				this.name = "Orange Paint";
				this.paint = 2;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1075)
			{
				this.name = "Yellow Paint";
				this.paint = 3;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1076)
			{
				this.name = "Lime Paint";
				this.paint = 4;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1077)
			{
				this.name = "Green Paint";
				this.paint = 5;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1078)
			{
				this.name = "Teal Paint";
				this.paint = 6;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1079)
			{
				this.name = "Cyan Paint";
				this.paint = 7;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1080)
			{
				this.name = "Sky Blue Paint";
				this.paint = 8;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1081)
			{
				this.name = "Blue Paint";
				this.paint = 9;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1082)
			{
				this.name = "Purple Paint";
				this.paint = 10;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1083)
			{
				this.name = "Violet Paint";
				this.paint = 11;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1084)
			{
				this.name = "Pink Paint";
				this.paint = 12;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1085)
			{
				this.name = "Deep Red Paint";
				this.paint = 13;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1086)
			{
				this.name = "Deep Orange Paint";
				this.paint = 14;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1087)
			{
				this.name = "Deep Yellow Paint";
				this.paint = 15;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1088)
			{
				this.name = "Deep Lime Paint";
				this.paint = 16;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1089)
			{
				this.name = "Deep Green Paint";
				this.paint = 17;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1090)
			{
				this.name = "Deep Teal Paint";
				this.paint = 18;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1091)
			{
				this.name = "Deep Cyan Paint";
				this.paint = 19;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1092)
			{
				this.name = "Deep Sky Blue Paint";
				this.paint = 20;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1093)
			{
				this.name = "Deep Blue Paint";
				this.paint = 21;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1094)
			{
				this.name = "Deep Purple Paint";
				this.paint = 22;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1095)
			{
				this.name = "Deep Violet Paint";
				this.paint = 23;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1096)
			{
				this.name = "Deep Pink Paint";
				this.paint = 24;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1097)
			{
				this.name = "Black Paint";
				this.paint = 25;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1098)
			{
				this.name = "White Paint";
				this.paint = 26;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1099)
			{
				this.name = "Grey Paint";
				this.paint = 27;
				this.width = 24;
				this.height = 24;
				this.value = 25;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1100)
			{
				this.name = "Paint Scraper";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.width = 24;
				this.height = 24;
				this.toolTip = "Used to remove paint";
				this.value = 10000;
				goto IL_2B846;
			}
			if (this.type == 1101)
			{
				this.name = "Lihzahrd Brick";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 226;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1102)
			{
				this.name = "Lihzahrd Brick Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 112;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1103)
			{
				this.name = "Slush Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 224;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1104)
			{
				this.name = "Palladium Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 221;
				this.width = 12;
				this.height = 12;
				this.value = 4500;
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 1105)
			{
				this.name = "Orichalcum Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 222;
				this.width = 12;
				this.height = 12;
				this.value = 6500;
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 1106)
			{
				this.name = "Titanium Ore";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 223;
				this.width = 12;
				this.height = 12;
				this.value = 8500;
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 1107)
			{
				this.name = "Teal Mushroom";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Teal Dye";
				this.placeStyle = 0;
				this.createTile = 227;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				goto IL_2B846;
			}
			if (this.type == 1108)
			{
				this.name = "Green Mushroom";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Green Dye";
				this.placeStyle = 1;
				this.createTile = 227;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				goto IL_2B846;
			}
			if (this.type == 1109)
			{
				this.name = "Sky Blue Flower";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Sky Blue Dye";
				this.placeStyle = 2;
				this.createTile = 227;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				goto IL_2B846;
			}
			if (this.type == 1110)
			{
				this.name = "Yellow Marigold";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Yellow Dye";
				this.placeStyle = 3;
				this.createTile = 227;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				goto IL_2B846;
			}
			if (this.type == 1111)
			{
				this.name = "Blue Berries";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Blue Dye";
				this.placeStyle = 4;
				this.createTile = 227;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				goto IL_2B846;
			}
			if (this.type == 1112)
			{
				this.name = "Lime Kelp";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Lime Dye";
				this.placeStyle = 5;
				this.createTile = 227;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				goto IL_2B846;
			}
			if (this.type == 1113)
			{
				this.name = "Pink Prickly Pear";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Pink Dye";
				this.placeStyle = 6;
				this.createTile = 227;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				goto IL_2B846;
			}
			if (this.type == 1114)
			{
				this.name = "Orange Bloodroot";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Orange Dye";
				this.placeStyle = 7;
				this.createTile = 227;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				goto IL_2B846;
			}
			if (this.type == 1115)
			{
				this.name = "Red Husk";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Red Dye";
				goto IL_2B846;
			}
			if (this.type == 1116)
			{
				this.name = "Cyan Husk";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Cyan Dye";
				goto IL_2B846;
			}
			if (this.type == 1117)
			{
				this.name = "Violet Husk";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Violet Dye";
				goto IL_2B846;
			}
			if (this.type == 1118)
			{
				this.name = "Purple Mucus";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Purple Dye";
				goto IL_2B846;
			}
			if (this.type == 1119)
			{
				this.name = "Black Ink";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 10000;
				this.rare = 1;
				this.toolTip = "Used to make Black Dye";
				goto IL_2B846;
			}
			if (this.type == 1120)
			{
				this.name = "Dye Vat";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 228;
				this.width = 26;
				this.height = 20;
				this.value = Item.buyPrice(0, 5, 0, 0);
				this.toolTip = "Used to craft dyes";
				goto IL_2B846;
			}
			if (this.type == 1121)
			{
				this.name = "Beegun";
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 12;
				this.useTime = 12;
				this.mana = 5;
				this.width = 50;
				this.height = 18;
				this.shoot = 181;
				this.useSound = 11;
				this.damage = 7;
				this.shootSpeed = 8f;
				this.noMelee = true;
				this.value = 350000;
				this.rare = 2;
				this.magic = true;
				this.scale = 0.8f;
				goto IL_2B846;
			}
			if (this.type == 1122)
			{
				this.useStyle = 1;
				this.name = "Possessed Hatchet";
				this.shootSpeed = 12f;
				this.shoot = 182;
				this.damage = 90;
				this.width = 18;
				this.height = 20;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 500000;
				this.knockBack = 5f;
				this.melee = true;
				this.rare = 7;
				this.toolTip = "A magical returning hatchet";
				goto IL_2B846;
			}
			if (this.type == 1123)
			{
				this.name = "Bee Keeper";
				this.useStyle = 1;
				this.useAnimation = 22;
				this.knockBack = 5.2f;
				this.width = 40;
				this.height = 40;
				this.damage = 22;
				this.scale = 1.1f;
				this.useSound = 1;
				this.rare = 3;
				this.value = 27000;
				this.melee = true;
				this.toolTip = "Summons killer bees after striking your foe";
				this.toolTip2 = "Small chance to cause confusion";
				goto IL_2B846;
			}
			if (this.type == 1124)
			{
				this.name = "Hive";
				this.width = 12;
				this.height = 12;
				this.maxStack = 999;
				goto IL_2B846;
			}
			if (this.type == 1125)
			{
				this.name = "Honey Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 229;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1126)
			{
				this.name = "Hive Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 108;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1127)
			{
				this.name = "Crispy Honey Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 230;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1128)
			{
				this.name = "Honey Bucket";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.width = 20;
				this.height = 20;
				goto IL_2B846;
			}
			if (this.type == 1129)
			{
				this.name = "Hive Wand";
				this.tileWand = 1124;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.createTile = 225;
				this.width = 8;
				this.height = 10;
				this.rare = 1;
				this.toolTip = "Places hives";
				goto IL_2B846;
			}
			if (this.type == 1130)
			{
				this.useStyle = 1;
				this.name = "Beenade";
				this.shootSpeed = 6f;
				this.shoot = 183;
				this.knockBack = 1f;
				this.damage = 14;
				this.width = 10;
				this.height = 10;
				this.maxStack = 999;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 200;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 1131)
			{
				this.name = "Gravity Globe";
				this.width = 22;
				this.height = 22;
				this.accessory = true;
				this.rare = 8;
				this.toolTip = "Allows the holder to reverse gravity";
				this.toolTip2 = "Press UP to change gravity";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 1132)
			{
				this.name = "Honey Comb";
				this.width = 22;
				this.height = 22;
				this.accessory = true;
				this.rare = 2;
				this.toolTip = "Releases bees when damaged";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type == 1133)
			{
				this.useStyle = 4;
				this.consumable = true;
				this.useAnimation = 45;
				this.useTime = 45;
				this.name = "Abeemination";
				this.width = 28;
				this.height = 28;
				this.maxStack = 20;
				this.toolTip = "Summons the Queen Bee";
				goto IL_2B846;
			}
			if (this.type == 1134)
			{
				this.name = "Bottled Honey";
				this.useSound = 3;
				this.healLife = 80;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.potion = true;
				this.value = 40;
				goto IL_2B846;
			}
			if (this.type == 1135)
			{
				this.name = "Rain Hat";
				this.width = 18;
				this.height = 18;
				this.headSlot = 81;
				this.value = 1000;
				this.vanity = true;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1136)
			{
				this.name = "Rain Coat";
				this.width = 18;
				this.height = 18;
				this.bodySlot = 52;
				this.value = 1000;
				this.vanity = true;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1137)
			{
				this.name = "Lihzahrd Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 12;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 1138)
			{
				this.name = "Dungeon Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 13;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 1139)
			{
				this.name = "Lead Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 14;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 1140)
			{
				this.name = "Iron Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 15;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 1141)
			{
				this.name = "Temple Key";
				this.width = 14;
				this.height = 20;
				this.maxStack = 99;
				this.toolTip = "Opens the jungle temple door";
				this.rare = 7;
				goto IL_2B846;
			}
			if (this.type == 1142)
			{
				this.name = "Lihzahrd Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 16;
				this.width = 26;
				this.height = 22;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 1143)
			{
				this.name = "Lihzahrd Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 12;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 1144)
			{
				this.name = "Lihzahrd Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 9;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 1145)
			{
				this.name = "Lihzahrd Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 10;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				this.toolTip = "Used for basic crafting";
				goto IL_2B846;
			}
			if (this.type == 1146)
			{
				this.name = "Super Dart Trap";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 137;
				this.placeStyle = 1;
				this.width = 12;
				this.height = 12;
				this.value = 10000;
				this.mech = true;
				goto IL_2B846;
			}
			if (this.type == 1147)
			{
				this.name = "Flame Trap";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 137;
				this.placeStyle = 2;
				this.width = 12;
				this.height = 12;
				this.value = 10000;
				this.mech = true;
				goto IL_2B846;
			}
			if (this.type == 1148)
			{
				this.name = "Spiky Ball Trap";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 137;
				this.placeStyle = 3;
				this.width = 12;
				this.height = 12;
				this.value = 10000;
				this.mech = true;
				goto IL_2B846;
			}
			if (this.type == 1149)
			{
				this.name = "Spear Trap";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 137;
				this.placeStyle = 4;
				this.width = 12;
				this.height = 12;
				this.value = 10000;
				this.mech = true;
				goto IL_2B846;
			}
			if (this.type == 1150)
			{
				this.name = "Wooden Spike";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 232;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1151)
			{
				this.name = "Lihzahrd Pressure Plate";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 135;
				this.width = 12;
				this.height = 12;
				this.placeStyle = 6;
				this.mech = true;
				this.value = 5000;
				this.toolTip = "Activates when a player steps on it on";
				goto IL_2B846;
			}
			if (this.type == 1152)
			{
				this.name = "Lihzahrd Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 43;
				goto IL_2B846;
			}
			if (this.type == 1153)
			{
				this.name = "Lihzahrd Watcher Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 44;
				goto IL_2B846;
			}
			if (this.type == 1154)
			{
				this.name = "Lihzahrd Guardian Statue";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 45;
				goto IL_2B846;
			}
			if (this.type == 1155)
			{
				this.name = "Wasp Gun";
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 11;
				this.useTime = 11;
				this.mana = 6;
				this.width = 50;
				this.height = 18;
				this.shoot = 189;
				this.useSound = 11;
				this.damage = 14;
				this.shootSpeed = 9f;
				this.noMelee = true;
				this.value = 500000;
				this.rare = 8;
				this.magic = true;
				goto IL_2B846;
			}
			if (this.type == 1156)
			{
				this.channel = true;
				this.name = "Piranha Gun";
				this.useStyle = 5;
				this.useAnimation = 30;
				this.useTime = 30;
				this.knockBack = 1f;
				this.width = 30;
				this.height = 10;
				this.damage = 33;
				this.scale = 1.1f;
				this.shoot = 190;
				this.shootSpeed = 14f;
				this.useSound = 10;
				this.rare = 8;
				this.value = Item.sellPrice(0, 5, 50, 0);
				this.ranged = true;
				this.noMelee = true;
				goto IL_2B846;
			}
			if (this.type == 1157)
			{
				this.mana = 10;
				this.damage = 25;
				this.useStyle = 1;
				this.name = "Pygmy Staff";
				this.shootSpeed = 10f;
				this.shoot = 191;
				this.width = 26;
				this.height = 28;
				this.useSound = 44;
				this.useAnimation = 28;
				this.useTime = 28;
				this.rare = 7;
				this.noMelee = true;
				this.knockBack = 3f;
				this.toolTip = "Summons a pygmy to fight for you";
				this.buffType = 49;
				this.value = 100000;
				this.summon = true;
				goto IL_2B846;
			}
			if (this.type == 1158)
			{
				this.name = "Pygmy Necklace";
				this.rare = 7;
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.toolTip = "Increases your max number of minions";
				this.value = Item.buyPrice(0, 40, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 1159)
			{
				this.name = "Tiki Mask";
				this.width = 18;
				this.height = 18;
				this.defense = 6;
				this.headSlot = 82;
				this.rare = 7;
				this.value = Item.buyPrice(0, 50, 0, 0);
				this.toolTip = "Increases your max number of minions";
				this.toolTip2 = "Increases minion damage by 10%";
				goto IL_2B846;
			}
			if (this.type == 1160)
			{
				this.name = "Tiki Shirt";
				this.width = 18;
				this.height = 18;
				this.defense = 17;
				this.bodySlot = 53;
				this.rare = 7;
				this.value = Item.buyPrice(0, 50, 0, 0);
				this.toolTip = "Increases your max number of minions";
				this.toolTip2 = "Increases minion damage by 10%";
				goto IL_2B846;
			}
			if (this.type == 1161)
			{
				this.name = "Tiki Pants";
				this.width = 18;
				this.height = 18;
				this.defense = 12;
				this.legSlot = 48;
				this.rare = 7;
				this.value = Item.buyPrice(0, 50, 0, 0);
				this.toolTip = "Increases your max number of minions";
				this.toolTip2 = "Increases minion damage by 10%";
				goto IL_2B846;
			}
			if (this.type == 1162)
			{
				this.name = "Leaf Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = Item.buyPrice(1, 0, 0, 0);
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 1163)
			{
				this.name = "Blizzard in a Balloon";
				this.width = 14;
				this.height = 28;
				this.rare = 4;
				this.value = 150000;
				this.accessory = true;
				this.toolTip = "Allows the holder to double jump";
				this.toolTip2 = "Increases jump height";
				goto IL_2B846;
			}
			if (this.type == 1164)
			{
				this.name = "Bundle of Balloons";
				this.width = 14;
				this.height = 28;
				this.rare = 8;
				this.value = 150000;
				this.accessory = true;
				this.toolTip = "Allows the holder to quadruple jump";
				this.toolTip2 = "Increases jump height";
				goto IL_2B846;
			}
			if (this.type == 1165)
			{
				this.name = "Bat Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = 400000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 1166)
			{
				this.name = "Bone Sword";
				this.useStyle = 1;
				this.useAnimation = 22;
				this.knockBack = 4.5f;
				this.width = 24;
				this.height = 28;
				this.damage = 16;
				this.scale = 1.05f;
				this.useSound = 1;
				this.rare = 3;
				this.value = 9000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1167)
			{
				this.name = "Hercules Beetle";
				this.rare = 7;
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.toolTip = "Increases the damage and knockback of your minions";
				this.value = Item.buyPrice(0, 40, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 1168)
			{
				this.useStyle = 1;
				this.name = "Smoke Bomb";
				this.shootSpeed = 6f;
				this.shoot = 196;
				this.width = 18;
				this.height = 20;
				this.maxStack = 999;
				this.consumable = true;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = 20;
				goto IL_2B846;
			}
			if (this.type == 1169)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Bone Key";
				this.shoot = 197;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.toolTip = "Summons a Baby Skeletron Head";
				this.value = Item.sellPrice(0, 5, 0, 0);
				this.buffType = 50;
				goto IL_2B846;
			}
			if (this.type == 1170)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Nectar";
				this.shoot = 198;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.toolTip = "Summons a Baby Hornet";
				this.value = Item.sellPrice(0, 3, 0, 0);
				this.buffType = 51;
				goto IL_2B846;
			}
			if (this.type == 1171)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Tiki Totem";
				this.shoot = 199;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.toolTip = "Summons a Tiki Spirit";
				this.buffType = 52;
				this.value = Item.buyPrice(2, 0, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 1172)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Lizard Egg";
				this.shoot = 200;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.toolTip = "Summons a Pet Lizard";
				this.value = Item.sellPrice(0, 2, 0, 0);
				this.buffType = 53;
				goto IL_2B846;
			}
			if (this.type == 1173)
			{
				this.name = "Grave Marker";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 85;
				this.placeStyle = 1;
				this.width = 20;
				this.height = 20;
				goto IL_2B846;
			}
			if (this.type == 1174)
			{
				this.name = "Cross Grave Marker";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 85;
				this.placeStyle = 2;
				this.width = 20;
				this.height = 20;
				goto IL_2B846;
			}
			if (this.type == 1175)
			{
				this.name = "Headstone";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 85;
				this.placeStyle = 3;
				this.width = 20;
				this.height = 20;
				goto IL_2B846;
			}
			if (this.type == 1176)
			{
				this.name = "Gravestone";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 85;
				this.placeStyle = 4;
				this.width = 20;
				this.height = 20;
				goto IL_2B846;
			}
			if (this.type == 1177)
			{
				this.name = "Obelisk";
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 85;
				this.placeStyle = 5;
				this.width = 20;
				this.height = 20;
				goto IL_2B846;
			}
			if (this.type == 1178)
			{
				this.useStyle = 5;
				this.mana = 4;
				this.autoReuse = true;
				this.useAnimation = 8;
				this.useTime = 8;
				this.name = "Leaf Blower";
				this.width = 24;
				this.height = 18;
				this.shoot = 206;
				this.useSound = 7;
				this.damage = 42;
				this.shootSpeed = 11f;
				this.noMelee = true;
				this.value = 350000;
				this.knockBack = 3f;
				this.rare = 7;
				this.toolTip = "Rapidly shoots razor sharp leaves";
				this.magic = true;
				goto IL_2B846;
			}
			if (this.type == 1179)
			{
				this.name = "Chlorophyte Bullet";
				this.shootSpeed = 5f;
				this.shoot = 207;
				this.damage = 15;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 4.5f;
				this.value = 50;
				this.ranged = true;
				this.rare = 7;
				goto IL_2B846;
			}
			if (this.type == 1180)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Parrot Cracker";
				this.shoot = 208;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.toolTip = "Summons a Pet Parrot";
				this.buffType = 54;
				this.value = Item.sellPrice(0, 75, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 1181)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Strange Glowing Mushroom";
				this.shoot = 209;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.toolTip = "Summons a Baby Truffle";
				this.value = Item.buyPrice(0, 45, 0, 0);
				this.buffType = 55;
				goto IL_2B846;
			}
			if (this.type == 1182)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Seedling";
				this.shoot = 210;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.toolTip = "Summons a Pet Sapling";
				this.value = Item.sellPrice(0, 2, 0, 0);
				this.buffType = 56;
				goto IL_2B846;
			}
			if (this.type == 1183)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Wisp in a Bottle";
				this.shoot = 211;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 8;
				this.noMelee = true;
				this.toolTip = "Summons a Wisp to provide light";
				this.value = Item.sellPrice(0, 5, 50, 0);
				this.buffType = 57;
				goto IL_2B846;
			}
			if (this.type == 1184)
			{
				this.name = "Palladium Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 13500;
				this.rare = 3;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 12;
				goto IL_2B846;
			}
			if (this.type == 1185)
			{
				this.useTurn = true;
				this.autoReuse = true;
				this.name = "Palladium Sword";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.useTime = 25;
				this.knockBack = 4.75f;
				this.width = 40;
				this.height = 40;
				this.damage = 36;
				this.scale = 1.125f;
				this.useSound = 1;
				this.rare = 4;
				this.value = 92000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1186)
			{
				this.name = "Palladium Pike";
				this.useStyle = 5;
				this.useAnimation = 27;
				this.useTime = 27;
				this.shootSpeed = 4.4f;
				this.knockBack = 4.5f;
				this.width = 40;
				this.height = 40;
				this.damage = 32;
				this.scale = 1.1f;
				this.useSound = 1;
				this.shoot = 212;
				this.rare = 4;
				this.value = 60000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1187)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 24;
				this.useTime = 24;
				this.name = "Palladium Repeater";
				this.width = 50;
				this.height = 18;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 32;
				this.shootSpeed = 9.25f;
				this.noMelee = true;
				this.value = 80000;
				this.ranged = true;
				this.rare = 4;
				this.knockBack = 1.75f;
				goto IL_2B846;
			}
			if (this.type == 1188)
			{
				this.name = "Palladium Pickaxe";
				this.useStyle = 1;
				this.useTurn = true;
				this.autoReuse = true;
				this.useAnimation = 25;
				this.useTime = 11;
				this.knockBack = 5f;
				this.width = 20;
				this.height = 12;
				this.damage = 12;
				this.pick = 130;
				this.useSound = 1;
				this.rare = 4;
				this.value = 72000;
				this.melee = true;
				this.toolTip = "Can mine Mythril and Orichalcum";
				this.scale = 1.15f;
				goto IL_2B846;
			}
			if (this.type == 1189)
			{
				this.name = "Palladium Drill";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 11;
				this.shootSpeed = 32f;
				this.knockBack = 0f;
				this.width = 20;
				this.height = 12;
				this.damage = 12;
				this.pick = 130;
				this.useSound = 23;
				this.shoot = 213;
				this.rare = 4;
				this.value = 72000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				this.toolTip = "Can mine Mythril and Orichalcum";
				goto IL_2B846;
			}
			if (this.type == 1190)
			{
				this.name = "Palladium Chainsaw";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 8;
				this.shootSpeed = 40f;
				this.knockBack = 2.9f;
				this.width = 20;
				this.height = 12;
				this.damage = 26;
				this.axe = 15;
				this.useSound = 23;
				this.shoot = 214;
				this.rare = 4;
				this.value = 72000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				goto IL_2B846;
			}
			if (this.type == 1191)
			{
				this.name = "Orichalcum Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 22000;
				this.rare = 3;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 14;
				goto IL_2B846;
			}
			if (this.type == 1192)
			{
				this.name = "Orichalcum Sword";
				this.useStyle = 1;
				this.useAnimation = 26;
				this.useTime = 26;
				this.knockBack = 6f;
				this.width = 40;
				this.height = 40;
				this.damage = 41;
				this.scale = 1.17f;
				this.useSound = 1;
				this.rare = 4;
				this.value = 126500;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1193)
			{
				this.name = "Orichalcum Halberd";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 25;
				this.shootSpeed = 4.5f;
				this.knockBack = 5.5f;
				this.width = 40;
				this.height = 40;
				this.damage = 36;
				this.scale = 1.1f;
				this.useSound = 1;
				this.shoot = 215;
				this.rare = 4;
				this.value = 82500;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1194)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 22;
				this.useTime = 22;
				this.name = "Orichalcum Repeater";
				this.width = 50;
				this.height = 18;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 36;
				this.shootSpeed = 9.75f;
				this.noMelee = true;
				this.value = 110000;
				this.ranged = true;
				this.rare = 4;
				this.knockBack = 2f;
				goto IL_2B846;
			}
			if (this.type == 1195)
			{
				this.name = "Orichalcum Pickaxe";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.useTime = 8;
				this.knockBack = 5f;
				this.useTurn = true;
				this.autoReuse = true;
				this.width = 20;
				this.height = 12;
				this.damage = 17;
				this.pick = 165;
				this.useSound = 1;
				this.rare = 4;
				this.value = 99000;
				this.melee = true;
				this.toolTip = "Can mine Adamantite and Titanium";
				this.scale = 1.15f;
				goto IL_2B846;
			}
			if (this.type == 1196)
			{
				this.name = "Orichalcum Drill";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 10;
				this.shootSpeed = 32f;
				this.knockBack = 0f;
				this.width = 20;
				this.height = 12;
				this.damage = 17;
				this.pick = 165;
				this.useSound = 23;
				this.shoot = 216;
				this.rare = 4;
				this.value = 99000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				this.toolTip = "Can mine Adamantite and Titanium";
				goto IL_2B846;
			}
			if (this.type == 1197)
			{
				this.name = "Orichalcum Chainsaw";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 7;
				this.shootSpeed = 40f;
				this.knockBack = 3.75f;
				this.width = 20;
				this.height = 12;
				this.damage = 31;
				this.axe = 18;
				this.useSound = 23;
				this.shoot = 217;
				this.rare = 4;
				this.value = 99000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				goto IL_2B846;
			}
			if (this.type == 1198)
			{
				this.name = "Titanium Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = 37500;
				this.rare = 3;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 16;
				goto IL_2B846;
			}
			if (this.type == 1199)
			{
				this.name = "Titanium Sword";
				this.useStyle = 1;
				this.useAnimation = 26;
				this.useTime = 26;
				this.knockBack = 6f;
				this.width = 40;
				this.height = 40;
				this.damage = 46;
				this.scale = 1.2f;
				this.useSound = 1;
				this.rare = 4;
				this.value = 161000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1200)
			{
				this.name = "Titanium Trident";
				this.useStyle = 5;
				this.useAnimation = 23;
				this.useTime = 23;
				this.shootSpeed = 5f;
				this.knockBack = 6.2f;
				this.width = 40;
				this.height = 40;
				this.damage = 40;
				this.scale = 1.1f;
				this.useSound = 1;
				this.shoot = 218;
				this.rare = 4;
				this.value = 105000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1201)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 19;
				this.useTime = 19;
				this.name = "Titanium Repeater";
				this.width = 50;
				this.height = 18;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 38;
				this.shootSpeed = 10.5f;
				this.noMelee = true;
				this.value = 140000;
				this.ranged = true;
				this.rare = 4;
				this.knockBack = 2.5f;
				goto IL_2B846;
			}
			if (this.type == 1202)
			{
				this.name = "Titanium Pickaxe";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.useTime = 7;
				this.knockBack = 5f;
				this.useTurn = true;
				this.autoReuse = true;
				this.width = 20;
				this.height = 12;
				this.damage = 27;
				this.pick = 190;
				this.useSound = 1;
				this.rare = 4;
				this.value = 126000;
				this.melee = true;
				this.scale = 1.15f;
				goto IL_2B846;
			}
			if (this.type == 1203)
			{
				this.name = "Titanium Drill";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 7;
				this.shootSpeed = 32f;
				this.knockBack = 0f;
				this.width = 20;
				this.height = 12;
				this.damage = 27;
				this.pick = 190;
				this.useSound = 23;
				this.shoot = 219;
				this.rare = 4;
				this.value = 126000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				goto IL_2B846;
			}
			if (this.type == 1204)
			{
				this.name = "Titanium Chainsaw";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 6;
				this.shootSpeed = 40f;
				this.knockBack = 4.6f;
				this.width = 20;
				this.height = 12;
				this.damage = 34;
				this.axe = 21;
				this.useSound = 23;
				this.shoot = 220;
				this.rare = 4;
				this.value = 126000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				goto IL_2B846;
			}
			if (this.type == 1205)
			{
				this.name = "Palladium Mask";
				this.width = 18;
				this.height = 18;
				this.defense = 14;
				this.headSlot = 83;
				this.rare = 4;
				this.value = 75000;
				this.toolTip = "7% increased movement speed";
				this.toolTip2 = "12% increased melee speed";
				goto IL_2B846;
			}
			if (this.type == 1206)
			{
				this.name = "Palladium Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 5;
				this.headSlot = 84;
				this.rare = 4;
				this.value = 75000;
				this.toolTip = "10% increased ranged damage";
				this.toolTip2 = "6% increased ranged critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1207)
			{
				this.name = "Palladium Headgear";
				this.width = 18;
				this.height = 18;
				this.defense = 3;
				this.headSlot = 85;
				this.rare = 4;
				this.value = 75000;
				this.toolTip = "Increases maximum mana by 40";
				this.toolTip2 = "9% increased magic critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1208)
			{
				this.name = "Palladium Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 10;
				this.bodySlot = 54;
				this.rare = 4;
				this.value = 60000;
				this.toolTip2 = "3% increased critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1209)
			{
				this.name = "Palladium Leggings";
				this.width = 18;
				this.height = 18;
				this.defense = 8;
				this.legSlot = 49;
				this.rare = 4;
				this.value = 45000;
				this.toolTip2 = "10% increased movement speed";
				goto IL_2B846;
			}
			if (this.type == 1210)
			{
				this.name = "Orichalcum Mask";
				this.width = 18;
				this.height = 18;
				this.defense = 19;
				this.headSlot = 86;
				this.rare = 4;
				this.value = 112500;
				this.toolTip = "5% increased melee critical strike chance";
				this.toolTip2 = "10% increased melee damage";
				goto IL_2B846;
			}
			if (this.type == 1211)
			{
				this.name = "Orichalcum Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 7;
				this.headSlot = 87;
				this.rare = 4;
				this.value = 112500;
				this.toolTip = "12% increased ranged damage";
				this.toolTip2 = "7% increased ranged critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1212)
			{
				this.name = "Orichalcum Headgear";
				this.width = 18;
				this.height = 18;
				this.defense = 4;
				this.headSlot = 88;
				this.rare = 4;
				this.value = 112500;
				this.toolTip = "Increases maximum mana by 60";
				this.toolTip2 = "15% increased magic damage";
				goto IL_2B846;
			}
			if (this.type == 1213)
			{
				this.name = "Orichalcum Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 13;
				this.bodySlot = 55;
				this.rare = 4;
				this.value = 90000;
				this.toolTip2 = "5% increased damage";
				goto IL_2B846;
			}
			if (this.type == 1214)
			{
				this.name = "Orichalcum Leggings";
				this.width = 18;
				this.height = 18;
				this.defense = 10;
				this.legSlot = 50;
				this.rare = 4;
				this.value = 67500;
				this.toolTip2 = "3% increased critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1215)
			{
				this.name = "Titanium Mask";
				this.width = 18;
				this.height = 18;
				this.defense = 23;
				this.headSlot = 89;
				this.rare = 4;
				this.value = 150000;
				this.toolTip = "7% increased melee critical strike chance";
				this.toolTip2 = "14% increased melee damage";
				goto IL_2B846;
			}
			if (this.type == 1216)
			{
				this.name = "Titanium Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 8;
				this.headSlot = 90;
				this.rare = 4;
				this.value = 150000;
				this.toolTip = "14% increased ranged damage";
				this.toolTip2 = "8% increased ranged critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1217)
			{
				this.name = "Titanium Headgear";
				this.width = 18;
				this.height = 18;
				this.defense = 4;
				this.headSlot = 91;
				this.rare = 4;
				this.value = 150000;
				this.toolTip = "Increases maximum mana by 80";
				this.toolTip2 = "11% increased magic damage and critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1218)
			{
				this.name = "Titanium Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 15;
				this.bodySlot = 56;
				this.rare = 4;
				this.value = 120000;
				this.toolTip = "6% increased damage";
				goto IL_2B846;
			}
			if (this.type == 1219)
			{
				this.name = "Titanium Leggings";
				this.width = 18;
				this.height = 18;
				this.defense = 11;
				this.legSlot = 51;
				this.rare = 4;
				this.value = 90000;
				this.toolTip = "4% increased critical strike chance";
				this.toolTip2 = "5% increased movement speed";
				goto IL_2B846;
			}
			if (this.type == 1220)
			{
				this.name = "Mythril Anvil";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 134;
				this.placeStyle = 1;
				this.width = 28;
				this.height = 14;
				this.value = 25000;
				this.toolTip = "Used to craft items from mythril, orichalcum, adamantite, and titanium bars";
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 1221)
			{
				this.name = "Orichalcum Forge";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 133;
				this.placeStyle = 1;
				this.width = 44;
				this.height = 30;
				this.value = 50000;
				this.toolTip = "Used to smelt adamantite and titanium ore";
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 1222)
			{
				this.useTurn = true;
				this.autoReuse = true;
				this.name = "Palladium Waraxe";
				this.useStyle = 1;
				this.useAnimation = 35;
				this.useTime = 8;
				this.knockBack = 5.5f;
				this.width = 20;
				this.height = 12;
				this.damage = 36;
				this.axe = 15;
				this.useSound = 1;
				this.rare = 4;
				this.value = 72000;
				this.melee = true;
				this.scale = 1.1f;
				goto IL_2B846;
			}
			if (this.type == 1223)
			{
				this.useTurn = true;
				this.autoReuse = true;
				this.name = "Orichalcum Waraxe";
				this.useStyle = 1;
				this.useAnimation = 35;
				this.useTime = 7;
				this.knockBack = 6.5f;
				this.width = 20;
				this.height = 12;
				this.damage = 41;
				this.axe = 18;
				this.useSound = 1;
				this.rare = 4;
				this.value = 99000;
				this.melee = true;
				this.scale = 1.1f;
				goto IL_2B846;
			}
			if (this.type == 1224)
			{
				this.useTurn = true;
				this.autoReuse = true;
				this.name = "Titanium Waraxe";
				this.useStyle = 1;
				this.useAnimation = 35;
				this.useTime = 6;
				this.knockBack = 7.5f;
				this.width = 20;
				this.height = 12;
				this.damage = 44;
				this.axe = 21;
				this.useSound = 1;
				this.rare = 4;
				this.value = 108000;
				this.melee = true;
				this.scale = 1.1f;
				goto IL_2B846;
			}
			if (this.type == 1225)
			{
				this.name = "Hallowed Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.value = Item.sellPrice(0, 0, 80, 0);
				this.rare = 4;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 18;
				goto IL_2B846;
			}
			if (this.type == 1226)
			{
				this.name = "Chlorophyte Claymore";
				this.useStyle = 1;
				this.useAnimation = 28;
				this.useTime = 60;
				this.shoot = 229;
				this.shootSpeed = 8f;
				this.knockBack = 6f;
				this.width = 40;
				this.height = 40;
				this.damage = 65;
				this.useSound = 1;
				this.rare = 7;
				this.value = 276000;
				this.scale = 1.25f;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1227)
			{
				this.name = "Chlorophyte Saber";
				this.autoReuse = true;
				this.useTurn = true;
				this.useStyle = 1;
				this.useAnimation = 17;
				this.useTime = 42;
				this.shoot = 228;
				this.shootSpeed = 8f;
				this.knockBack = 4f;
				this.width = 40;
				this.height = 40;
				this.damage = 43;
				this.useSound = 1;
				this.rare = 7;
				this.value = 276000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1228)
			{
				this.name = "Chlorophyte Partisan";
				this.useStyle = 5;
				this.useAnimation = 23;
				this.useTime = 23;
				this.shootSpeed = 5f;
				this.knockBack = 6.2f;
				this.width = 40;
				this.height = 40;
				this.damage = 49;
				this.scale = 1.1f;
				this.useSound = 1;
				this.shoot = 222;
				this.rare = 7;
				this.value = 180000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1229)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 19;
				this.useTime = 19;
				this.name = "Chlorophyte Shotbow";
				this.width = 50;
				this.height = 18;
				this.shoot = 1;
				this.useAmmo = 1;
				this.useSound = 5;
				this.damage = 34;
				this.shootSpeed = 11.5f;
				this.noMelee = true;
				this.value = 240000;
				this.ranged = true;
				this.rare = 7;
				this.knockBack = 2.75f;
				goto IL_2B846;
			}
			if (this.type == 1230)
			{
				this.name = "Chlorophyte Pickaxe";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.useTime = 7;
				this.knockBack = 5f;
				this.useTurn = true;
				this.autoReuse = true;
				this.width = 20;
				this.height = 12;
				this.damage = 40;
				this.pick = 200;
				this.useSound = 1;
				this.rare = 7;
				this.value = 216000;
				this.melee = true;
				this.scale = 1.15f;
				this.tileBoost++;
				goto IL_2B846;
			}
			if (this.type == 1231)
			{
				this.name = "Chlorophyte Drill";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 7;
				this.shootSpeed = 40f;
				this.knockBack = 1f;
				this.width = 20;
				this.height = 12;
				this.damage = 35;
				this.pick = 200;
				this.useSound = 23;
				this.shoot = 223;
				this.rare = 7;
				this.value = 216000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				this.tileBoost++;
				goto IL_2B846;
			}
			if (this.type == 1232)
			{
				this.name = "Chlorophyte Chainsaw";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 7;
				this.shootSpeed = 46f;
				this.knockBack = 4.6f;
				this.width = 20;
				this.height = 12;
				this.damage = 50;
				this.axe = 23;
				this.useSound = 23;
				this.shoot = 224;
				this.rare = 7;
				this.value = 216000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				this.tileBoost++;
				goto IL_2B846;
			}
			if (this.type == 1233)
			{
				this.useTurn = true;
				this.autoReuse = true;
				this.name = "Chlorophyte Greataxe";
				this.useStyle = 1;
				this.useAnimation = 30;
				this.useTime = 6;
				this.knockBack = 7f;
				this.width = 20;
				this.height = 12;
				this.damage = 70;
				this.axe = 23;
				this.useSound = 1;
				this.rare = 7;
				this.value = 216000;
				this.melee = true;
				this.scale = 1.15f;
				this.tileBoost++;
				goto IL_2B846;
			}
			if (this.type == 1234)
			{
				this.name = "Chlorophyte Warhammer";
				this.useTurn = true;
				this.autoReuse = true;
				this.useStyle = 1;
				this.useAnimation = 35;
				this.useTime = 14;
				this.hammer = 90;
				this.width = 24;
				this.height = 28;
				this.damage = 80;
				this.knockBack = 8f;
				this.scale = 1.25f;
				this.useSound = 1;
				this.rare = 7;
				this.value = 216000;
				this.melee = true;
				this.tileBoost++;
				goto IL_2B846;
			}
			if (this.type == 1235)
			{
				this.name = "Chlorophyte Arrow";
				this.shootSpeed = 4.5f;
				this.shoot = 225;
				this.damage = 16;
				this.width = 10;
				this.height = 28;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 1;
				this.knockBack = 3.5f;
				this.value = 100;
				this.ranged = true;
				this.rare = 7;
				goto IL_2B846;
			}
			if (this.type == 1236)
			{
				this.noUseGraphic = true;
				this.damage = 0;
				this.knockBack = 7f;
				this.useStyle = 5;
				this.name = "Amethyst Hook";
				this.shootSpeed = 10f;
				this.shoot = 230;
				this.width = 18;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 1;
				this.noMelee = true;
				this.value = 20000;
				goto IL_2B846;
			}
			if (this.type == 1237)
			{
				this.noUseGraphic = true;
				this.damage = 0;
				this.knockBack = 7f;
				this.useStyle = 5;
				this.name = "Topaz Hook";
				this.shootSpeed = 10.5f;
				this.shoot = 231;
				this.width = 18;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 1;
				this.noMelee = true;
				this.value = 20000;
				goto IL_2B846;
			}
			if (this.type == 1238)
			{
				this.noUseGraphic = true;
				this.damage = 0;
				this.knockBack = 7f;
				this.useStyle = 5;
				this.name = "Sapphire Hook";
				this.shootSpeed = 11f;
				this.shoot = 232;
				this.width = 18;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 1;
				this.noMelee = true;
				this.value = 20000;
				goto IL_2B846;
			}
			if (this.type == 1239)
			{
				this.noUseGraphic = true;
				this.damage = 0;
				this.knockBack = 7f;
				this.useStyle = 5;
				this.name = "Emerald Hook";
				this.shootSpeed = 11.5f;
				this.shoot = 233;
				this.width = 18;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 1;
				this.noMelee = true;
				this.value = 20000;
				goto IL_2B846;
			}
			if (this.type == 1240)
			{
				this.noUseGraphic = true;
				this.damage = 0;
				this.knockBack = 7f;
				this.useStyle = 5;
				this.name = "Ruby Hook";
				this.shootSpeed = 12f;
				this.shoot = 234;
				this.width = 18;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 1;
				this.noMelee = true;
				this.value = 20000;
				goto IL_2B846;
			}
			if (this.type == 1241)
			{
				this.noUseGraphic = true;
				this.damage = 0;
				this.knockBack = 7f;
				this.useStyle = 5;
				this.name = "Diamond Hook";
				this.shootSpeed = 12.5f;
				this.shoot = 235;
				this.width = 18;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 1;
				this.noMelee = true;
				this.value = 20000;
				goto IL_2B846;
			}
			if (this.type == 1242)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Amber Mosquito";
				this.shoot = 236;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 3;
				this.noMelee = true;
				this.toolTip = "Summons a Baby Dinosaur";
				this.value = Item.sellPrice(0, 7, 50, 0);
				this.buffType = 61;
				goto IL_2B846;
			}
			if (this.type == 1243)
			{
				this.name = "Umbrella Hat";
				this.width = 28;
				this.height = 20;
				this.headSlot = 92;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 1244)
			{
				this.mana = 10;
				this.damage = 36;
				this.useStyle = 1;
				this.name = "Nimbus Rod";
				this.shootSpeed = 16f;
				this.shoot = 237;
				this.width = 26;
				this.height = 28;
				this.useSound = 8;
				this.useAnimation = 22;
				this.useTime = 22;
				this.rare = 6;
				this.noMelee = true;
				this.knockBack = 0f;
				this.toolTip = "Summons a cloud to rain down on your foes";
				this.value = Item.sellPrice(0, 3, 50, 0);
				this.magic = true;
				goto IL_2B846;
			}
			if (this.type == 1245)
			{
				this.name = "Orange Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.holdStyle = 1;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 4;
				this.placeStyle = 10;
				this.width = 10;
				this.height = 12;
				this.value = 60;
				this.noWet = true;
				goto IL_2B846;
			}
			if (this.type == 1246)
			{
				this.name = "Crimsand Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 234;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1247)
			{
				this.name = "Bee Cloak";
				this.width = 20;
				this.height = 24;
				this.value = 150000;
				this.toolTip = "Causes stars to fall and releases bees when injured";
				this.accessory = true;
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 1248)
			{
				this.name = "Eye of the Golem";
				this.width = 24;
				this.height = 24;
				this.accessory = true;
				this.toolTip = "10% increased critical strike chance";
				this.value = 100000;
				this.rare = 7;
				goto IL_2B846;
			}
			if (this.type == 1249)
			{
				this.name = "Honey Balloon";
				this.width = 14;
				this.height = 28;
				this.rare = 2;
				this.value = 54000;
				this.accessory = true;
				this.toolTip = "Increases jump height";
				this.toolTip2 = "Releases bees when damaged";
				goto IL_2B846;
			}
			if (this.type == 1250)
			{
				this.name = "Blue Horseshoe Balloon";
				this.width = 20;
				this.height = 22;
				this.rare = 4;
				this.value = 45000;
				this.accessory = true;
				this.toolTip = "Allows the holder to double jump";
				this.toolTip = "Increases jump height and negates fall damage";
				goto IL_2B846;
			}
			if (this.type == 1251)
			{
				this.name = "White Horseshoe Balloon";
				this.width = 20;
				this.height = 22;
				this.rare = 4;
				this.value = 45000;
				this.accessory = true;
				this.toolTip = "Allows the holder to double jump";
				this.toolTip = "Increases jump height and negates fall damage";
				goto IL_2B846;
			}
			if (this.type == 1252)
			{
				this.name = "Yellow Horseshoe Balloon";
				this.width = 20;
				this.height = 22;
				this.rare = 4;
				this.value = 45000;
				this.accessory = true;
				this.toolTip = "Allows the holder to double jump";
				this.toolTip = "Increases jump height and negates fall damage";
				goto IL_2B846;
			}
			if (this.type == 1253)
			{
				this.name = "Frozen Turtle Scale";
				this.width = 20;
				this.height = 24;
				this.value = 225000;
				this.toolTip = "Puts a shell around the owner when below 20% life";
				this.accessory = true;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 1254)
			{
				this.useStyle = 5;
				this.useAnimation = 60;
				this.useTime = 60;
				this.name = "Sniper Rifle";
				this.crit += 15;
				this.width = 44;
				this.height = 14;
				this.shoot = 10;
				this.useAmmo = 14;
				this.useSound = 40;
				this.damage = 125;
				this.shootSpeed = 16f;
				this.noMelee = true;
				this.value = 100000;
				this.knockBack = 8f;
				this.rare = 8;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 1255)
			{
				this.autoReuse = false;
				this.useStyle = 5;
				this.useAnimation = 9;
				this.useTime = 9;
				this.name = "Venus Magnum";
				this.width = 24;
				this.height = 22;
				this.shoot = 14;
				this.knockBack = 5.5f;
				this.useAmmo = 14;
				this.useSound = 41;
				this.damage = 36;
				this.shootSpeed = 13.5f;
				this.noMelee = true;
				this.value = Item.sellPrice(0, 5, 0, 0);
				this.scale = 0.85f;
				this.rare = 7;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 1256)
			{
				this.mana = 10;
				this.damage = 12;
				this.useStyle = 1;
				this.name = "Crimson Rod";
				this.shootSpeed = 12f;
				this.shoot = 243;
				this.width = 26;
				this.height = 28;
				this.useSound = 8;
				this.useAnimation = 24;
				this.useTime = 24;
				this.rare = 1;
				this.noMelee = true;
				this.knockBack = 0f;
				this.toolTip = "Summons a cloud to rain blood on your foes";
				this.value = 10000;
				this.magic = true;
				goto IL_2B846;
			}
			if (this.type == 1257)
			{
				this.name = "Crimtane Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.rare = 1;
				this.value = 20000;
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 19;
				goto IL_2B846;
			}
			if (this.type == 1258)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 22;
				this.useTime = 22;
				this.name = "Stynger";
				this.width = 50;
				this.height = 18;
				this.shoot = 246;
				this.useAmmo = 246;
				this.useSound = 11;
				this.damage = 43;
				this.knockBack = 5f;
				this.shootSpeed = 9f;
				this.noMelee = true;
				this.value = 350000;
				this.rare = 7;
				this.ranged = true;
				this.toolTip = "Shoots a bolt that explodes into deadly shrapnel";
				goto IL_2B846;
			}
			if (this.type == 1259)
			{
				this.name = "Flower Pow";
				this.noMelee = true;
				this.useStyle = 5;
				this.useAnimation = 40;
				this.useTime = 40;
				this.knockBack = 7.5f;
				this.width = 30;
				this.height = 10;
				this.damage = 52;
				this.scale = 1.1f;
				this.noUseGraphic = true;
				this.shoot = 247;
				this.shootSpeed = 15.9f;
				this.useSound = 1;
				this.rare = 7;
				this.value = Item.sellPrice(0, 6, 0, 0);
				this.melee = true;
				this.channel = true;
				goto IL_2B846;
			}
			if (this.type == 1260)
			{
				this.useStyle = 5;
				this.useAnimation = 40;
				this.useTime = 40;
				this.name = "Rainbow Gun";
				this.width = 50;
				this.height = 18;
				this.shoot = 250;
				this.useSound = 9;
				this.damage = 40;
				this.knockBack = 2f;
				this.shootSpeed = 16f;
				this.noMelee = true;
				this.value = 350000;
				this.rare = 8;
				this.magic = true;
				this.mana = 20;
				goto IL_2B846;
			}
			if (this.type == 1261)
			{
				this.name = "Stynger Bolt";
				this.shootSpeed = 2f;
				this.shoot = 246;
				this.damage = 15;
				this.width = 10;
				this.height = 28;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 246;
				this.knockBack = 1f;
				this.value = 75;
				this.rare = 5;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 1262)
			{
				this.name = "Chlorophyte Jackhammer";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 7;
				this.shootSpeed = 46f;
				this.knockBack = 5.2f;
				this.width = 20;
				this.height = 12;
				this.damage = 45;
				this.hammer = 90;
				this.useSound = 23;
				this.shoot = 252;
				this.rare = 7;
				this.value = 216000;
				this.noMelee = true;
				this.noUseGraphic = true;
				this.melee = true;
				this.channel = true;
				this.tileBoost++;
				goto IL_2B846;
			}
			if (this.type == 1263)
			{
				this.name = "Teleporter";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 235;
				this.width = 12;
				this.height = 12;
				this.value = Item.buyPrice(0, 2, 50, 0);
				this.mech = true;
				goto IL_2B846;
			}
			if (this.type == 1264)
			{
				this.mana = 17;
				this.damage = 50;
				this.useStyle = 1;
				this.name = "Flower of Frost";
				this.shootSpeed = 7f;
				this.shoot = 253;
				this.width = 26;
				this.height = 28;
				this.useSound = 20;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 6;
				this.noMelee = true;
				this.knockBack = 6.5f;
				this.toolTip = "Throws balls of frost";
				this.value = 10000;
				this.magic = true;
				goto IL_2B846;
			}
			if (this.type == 1265)
			{
				this.autoReuse = true;
				this.useStyle = 5;
				this.useAnimation = 9;
				this.useTime = 9;
				this.name = "Uzi";
				this.width = 24;
				this.height = 22;
				this.shoot = 14;
				this.knockBack = 3.5f;
				this.useAmmo = 14;
				this.useSound = 11;
				this.damage = 30;
				this.shootSpeed = 13f;
				this.noMelee = true;
				this.value = 50000;
				this.scale = 0.75f;
				this.rare = 7;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 1266)
			{
				this.rare = 8;
				this.mana = 14;
				this.useSound = 20;
				this.name = "Magnet Sphere";
				this.useStyle = 5;
				this.damage = 48;
				this.knockBack = 6f;
				this.useAnimation = 20;
				this.useTime = 20;
				this.width = 24;
				this.height = 28;
				this.shoot = 254;
				this.shootSpeed = 2f;
				this.toolTip = "Summons something to do stuff and things";
				this.magic = true;
				this.value = 500000;
				goto IL_2B846;
			}
			if (this.type == 1267)
			{
				this.name = "Purple Stained Glass";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 88;
				this.width = 12;
				this.height = 12;
				this.value = Item.sellPrice(0, 0, 5, 0);
				goto IL_2B846;
			}
			if (this.type == 1268)
			{
				this.name = "Yellow Stained Glass";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 89;
				this.width = 12;
				this.height = 12;
				this.value = Item.sellPrice(0, 0, 5, 0);
				goto IL_2B846;
			}
			if (this.type == 1269)
			{
				this.name = "Blue Stained Glass";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 90;
				this.width = 12;
				this.height = 12;
				this.value = Item.sellPrice(0, 0, 5, 0);
				goto IL_2B846;
			}
			if (this.type == 1270)
			{
				this.name = "Green Stained Glass";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 91;
				this.width = 12;
				this.height = 12;
				this.value = Item.sellPrice(0, 0, 5, 0);
				goto IL_2B846;
			}
			if (this.type == 1271)
			{
				this.name = "Red Stained Glass";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 92;
				this.width = 12;
				this.height = 12;
				this.value = Item.sellPrice(0, 0, 5, 0);
				goto IL_2B846;
			}
			if (this.type == 1272)
			{
				this.name = "Multicolored Stained Glass";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 93;
				this.width = 12;
				this.height = 12;
				this.value = Item.sellPrice(0, 0, 5, 0);
				goto IL_2B846;
			}
			if (this.type == 1273)
			{
				this.name = "Skeletron Hand";
				this.useStyle = 5;
				this.useAnimation = 25;
				this.useTime = 25;
				this.width = 30;
				this.height = 10;
				this.noUseGraphic = true;
				this.shoot = 256;
				this.shootSpeed = 15f;
				this.useSound = 1;
				this.rare = 2;
				this.value = 45000;
				goto IL_2B846;
			}
			if (this.type == 1274)
			{
				this.name = "Skull";
				this.width = 28;
				this.height = 20;
				this.headSlot = 93;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 1275)
			{
				this.name = "Balla Hat";
				this.width = 28;
				this.height = 20;
				this.headSlot = 94;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 1276)
			{
				this.name = "Gangsta Hat";
				this.width = 28;
				this.height = 20;
				this.headSlot = 95;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 1277)
			{
				this.name = "Sailor Hat";
				this.width = 28;
				this.height = 20;
				this.headSlot = 96;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 1278)
			{
				this.name = "Eye Patch";
				this.width = 28;
				this.height = 20;
				this.headSlot = 97;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 1279)
			{
				this.name = "Sailor Shirt";
				this.width = 28;
				this.height = 20;
				this.bodySlot = 57;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 1280)
			{
				this.name = "Sailor Pants";
				this.width = 28;
				this.height = 20;
				this.legSlot = 52;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 1281)
			{
				this.name = "Skeletron Mask";
				this.width = 28;
				this.height = 20;
				this.headSlot = 98;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 1282)
			{
				this.name = "Amethyst Robe";
				this.width = 18;
				this.height = 14;
				this.bodySlot = 58;
				this.value = Item.sellPrice(0, 0, 50, 0);
				this.toolTip = "Increases maximum mana by 20";
				this.toolTip = "Reduces mana usage by 5%";
				goto IL_2B846;
			}
			if (this.type == 1283)
			{
				this.name = "Topaz Robe";
				this.width = 18;
				this.height = 14;
				this.bodySlot = 59;
				this.defense = 1;
				this.value = Item.sellPrice(0, 0, 50, 0) * 2;
				this.toolTip = "Increases maximum mana by 40";
				this.toolTip2 = "Reduces mana usage by 7%";
				goto IL_2B846;
			}
			if (this.type == 1284)
			{
				this.name = "Sapphire Robe";
				this.width = 18;
				this.height = 14;
				this.bodySlot = 60;
				this.defense = 1;
				this.value = Item.sellPrice(0, 0, 50, 0) * 3;
				this.toolTip = "Increases maximum mana by 40";
				this.toolTip2 = "Reduces mana usage by 9%";
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1285)
			{
				this.name = "Emerald Robe";
				this.width = 18;
				this.height = 14;
				this.bodySlot = 61;
				this.defense = 2;
				this.value = Item.sellPrice(0, 0, 50, 0) * 4;
				this.toolTip = "Increases maximum mana by 60";
				this.toolTip2 = "Reduces mana usage by 11%";
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1286)
			{
				this.name = "Ruby Robe";
				this.width = 18;
				this.height = 14;
				this.bodySlot = 62;
				this.defense = 2;
				this.value = Item.sellPrice(0, 0, 50, 0) * 5;
				this.toolTip = "Increases maximum mana by 60";
				this.toolTip2 = "Reduces mana usage by 13%";
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1287)
			{
				this.name = "Diamond Robe";
				this.defense = 3;
				this.width = 18;
				this.height = 14;
				this.bodySlot = 63;
				this.value = Item.sellPrice(0, 0, 50, 0) * 6;
				this.toolTip = "Increases maximum mana by 80";
				this.toolTip2 = "Reduces mana usage by 15%";
				this.rare = 2;
				goto IL_2B846;
			}
			if (this.type == 1288)
			{
				this.name = "White Tuxedo Shirt";
				this.width = 28;
				this.height = 20;
				this.bodySlot = 64;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 1289)
			{
				this.name = "White Tuxedo Pants";
				this.width = 28;
				this.height = 20;
				this.legSlot = 53;
				this.rare = 1;
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 1290)
			{
				this.name = "Panic Necklace";
				this.width = 22;
				this.height = 22;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "Increases movement speed after being struck";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 1291)
			{
				this.name = "Heart Fruit";
				this.maxStack = 99;
				this.consumable = true;
				this.width = 18;
				this.height = 18;
				this.useStyle = 4;
				this.useTime = 30;
				this.useSound = 4;
				this.useAnimation = 30;
				this.toolTip = "Permanently increases maximum life by 5";
				this.rare = 7;
				this.value = Item.sellPrice(0, 2, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 1292)
			{
				this.name = "Lihzahrd Altar";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 237;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 1293)
			{
				this.name = "Lihzahrd Power Cell";
				this.maxStack = 99;
				this.consumable = true;
				this.width = 22;
				this.height = 10;
				this.value = Item.sellPrice(0, 1, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 1294)
			{
				this.name = "Picksaw";
				this.useStyle = 1;
				this.useAnimation = 16;
				this.useTime = 6;
				this.knockBack = 5.5f;
				this.useTurn = true;
				this.autoReuse = true;
				this.width = 20;
				this.height = 12;
				this.damage = 34;
				this.pick = 210;
				this.axe = 25;
				this.useSound = 1;
				this.rare = 7;
				this.value = 216000;
				this.melee = true;
				this.scale = 1.15f;
				this.tileBoost++;
				this.toolTip = "Capable of mining Lihzahrd Bricks";
				goto IL_2B846;
			}
			if (this.type == 1295)
			{
				this.mana = 8;
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 16;
				this.useTime = 16;
				this.name = "Heat Ray";
				this.width = 24;
				this.height = 18;
				this.shoot = 260;
				this.useSound = 12;
				this.damage = 55;
				this.shootSpeed = 15f;
				this.noMelee = true;
				this.value = 350000;
				this.knockBack = 3f;
				this.rare = 7;
				this.magic = true;
				this.toolTip = "Shoots a piercing beam of heat";
				goto IL_2B846;
			}
			if (this.type == 1296)
			{
				this.mana = 17;
				this.damage = 45;
				this.useStyle = 1;
				this.name = "Staff of Earth";
				this.shootSpeed = 11f;
				this.shoot = 261;
				this.width = 26;
				this.height = 28;
				this.useSound = 20;
				this.useAnimation = 40;
				this.useTime = 40;
				this.rare = 7;
				this.noMelee = true;
				this.knockBack = 7.5f;
				this.value = Item.sellPrice(0, 10, 0, 0);
				this.magic = true;
				this.toolTip = "Summons a powerful boulder";
				goto IL_2B846;
			}
			if (this.type == 1297)
			{
				this.autoReuse = true;
				this.name = "Golem Fist";
				this.useStyle = 5;
				this.useAnimation = 30;
				this.useTime = 30;
				this.knockBack = 8f;
				this.width = 30;
				this.height = 10;
				this.damage = 50;
				this.scale = 0.9f;
				this.shoot = 262;
				this.shootSpeed = 14f;
				this.useSound = 10;
				this.rare = 7;
				this.value = Item.sellPrice(0, 5, 0, 0);
				this.melee = true;
				this.noMelee = true;
				this.toolTip = "Punches with the force of a golem";
				goto IL_2B846;
			}
			if (this.type == 1298)
			{
				this.name = "Water Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 17;
				this.width = 26;
				this.height = 22;
				this.value = 500;
				goto IL_2B846;
			}
			if (this.type == 1299)
			{
				this.name = "Binoculars";
				this.width = 14;
				this.height = 28;
				this.rare = 4;
				this.value = 150000;
				this.toolTip = "Increases view range when held";
				goto IL_2B846;
			}
			if (this.type == 1300)
			{
				this.name = "Rifle Scope";
				this.width = 14;
				this.height = 28;
				this.rare = 4;
				this.value = 150000;
				this.accessory = true;
				this.toolTip = "Increases view range for guns";
				this.toolTip2 = "Right click to zoom out";
				goto IL_2B846;
			}
			if (this.type == 1301)
			{
				this.name = "Destroyer Emblem";
				this.width = 24;
				this.height = 24;
				this.accessory = true;
				this.toolTip = "10% increased damage";
				this.toolTip2 = "8% increased critical strike chance";
				this.value = 300000;
				this.rare = 7;
				goto IL_2B846;
			}
			if (this.type == 1302)
			{
				this.name = "High Velocity Bullet";
				this.shootSpeed = 4f;
				this.shoot = 242;
				this.damage = 10;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 4f;
				this.value = 40;
				this.ranged = true;
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 1303)
			{
				this.name = "Jellyfish Necklace";
				this.width = 24;
				this.height = 24;
				this.accessory = true;
				this.toolTip = "Provides light under water";
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.rare = 2;
				goto IL_2B846;
			}
			if (this.type == 1304)
			{
				this.name = "Zombie Arm";
				this.useStyle = 1;
				this.useTurn = false;
				this.useAnimation = 20;
				this.useTime = 20;
				this.width = 24;
				this.height = 28;
				this.damage = 12;
				this.knockBack = 4.5f;
				this.useSound = 1;
				this.scale = 1f;
				this.value = 2000;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1305)
			{
				this.name = "The Axe";
				this.autoReuse = true;
				this.useStyle = 1;
				this.useAnimation = 23;
				this.knockBack = 7.25f;
				this.useTime = 7;
				this.width = 24;
				this.height = 28;
				this.damage = 72;
				this.axe = 35;
				this.hammer = 100;
				this.tileBoost = 1;
				this.scale = 1.15f;
				this.useSound = 47;
				this.rare = 8;
				this.value = Item.sellPrice(0, 10, 0, 0);
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1306)
			{
				this.name = "Ice Sickle";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.useTime = 25;
				this.knockBack = 5.5f;
				this.width = 24;
				this.height = 28;
				this.damage = 40;
				this.scale = 1.15f;
				this.useSound = 1;
				this.rare = 5;
				this.shoot = 263;
				this.shootSpeed = 8f;
				this.value = 250000;
				this.toolTip = "Shoots an icy sickle";
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1307)
			{
				this.accessory = true;
				this.name = "Clothier Voodoo Doll";
				this.width = 14;
				this.height = 26;
				this.value = 1000;
				this.toolTip = "'You are a terrible person.'";
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1308)
			{
				this.name = "Poison Staff";
				this.mana = 12;
				this.useSound = 43;
				this.useStyle = 5;
				this.damage = 59;
				this.useAnimation = 35;
				this.useTime = 35;
				this.width = 40;
				this.height = 40;
				this.shoot = 265;
				this.shootSpeed = 13.5f;
				this.knockBack = 6f;
				this.magic = true;
				this.autoReuse = true;
				this.rare = 6;
				this.noMelee = true;
				this.value = Item.sellPrice(0, 4, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 1309)
			{
				this.mana = 10;
				this.damage = 8;
				this.useStyle = 1;
				this.name = "Slime Staff";
				this.shootSpeed = 10f;
				this.shoot = 266;
				this.width = 26;
				this.height = 28;
				this.useSound = 44;
				this.useAnimation = 28;
				this.useTime = 28;
				this.rare = 4;
				this.noMelee = true;
				this.knockBack = 2f;
				this.toolTip = "Summons a baby slime to fight for you";
				this.buffType = 64;
				this.value = 100000;
				this.summon = true;
				goto IL_2B846;
			}
			if (this.type == 1310)
			{
				this.name = "Poison Dart";
				this.shoot = 267;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.ammo = 51;
				this.toolTip = "Inflicts poison on enemies";
				this.toolTip2 = "For use with Blowpipe and Blowgun";
				this.damage = 8;
				this.knockBack = 2f;
				this.shootSpeed = 2f;
				this.ranged = true;
				this.rare = 2;
				goto IL_2B846;
			}
			if (this.type == 1311)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Eyespring";
				this.shoot = 268;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 6;
				this.noMelee = true;
				this.toolTip = "Summons an eye spring";
				this.value = Item.sellPrice(0, 3, 0, 0);
				this.buffType = 65;
				goto IL_2B846;
			}
			if (this.type == 1312)
			{
				this.damage = 0;
				this.useStyle = 1;
				this.name = "Toy Sled";
				this.shoot = 269;
				this.width = 16;
				this.height = 30;
				this.useSound = 2;
				this.useAnimation = 20;
				this.useTime = 20;
				this.rare = 6;
				this.noMelee = true;
				this.toolTip = "Summons a baby snowman";
				this.value = Item.sellPrice(0, 2, 50, 0);
				this.buffType = 66;
				goto IL_2B846;
			}
			if (this.type == 1313)
			{
				this.autoReuse = true;
				this.rare = 2;
				this.mana = 12;
				this.useSound = 8;
				this.name = "Book of Skulls";
				this.useStyle = 5;
				this.damage = 35;
				this.useAnimation = 25;
				this.useTime = 25;
				this.width = 24;
				this.height = 28;
				this.shoot = 270;
				this.scale = 0.9f;
				this.shootSpeed = 4f;
				this.knockBack = 6f;
				this.toolTip = "Shoots a skull";
				this.magic = true;
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 1314)
			{
				this.autoReuse = true;
				this.name = "KO Cannon";
				this.useStyle = 5;
				this.useAnimation = 28;
				this.useTime = 28;
				this.knockBack = 6.5f;
				this.width = 30;
				this.height = 10;
				this.damage = 35;
				this.scale = 0.9f;
				this.shoot = 271;
				this.shootSpeed = 15f;
				this.useSound = 10;
				this.rare = 4;
				this.value = 27000;
				this.melee = true;
				this.noMelee = true;
				this.toolTip = "Shoots a boxing glove";
				goto IL_2B846;
			}
			if (this.type == 1315)
			{
				this.useStyle = 4;
				this.consumable = true;
				this.useAnimation = 45;
				this.useTime = 45;
				this.name = "Pirate Map";
				this.width = 28;
				this.height = 28;
				this.toolTip = "Summons a Pirate Invasion";
				goto IL_2B846;
			}
			if (this.type == 1316)
			{
				this.name = "Turtle Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 21;
				this.headSlot = 99;
				this.rare = 8;
				this.value = 300000;
				this.toolTip = "5% increased melee damage";
				this.toolTip2 = "Enemies are more likely to target you";
				goto IL_2B846;
			}
			if (this.type == 1317)
			{
				this.name = "Turtle Scale Mail";
				this.width = 18;
				this.height = 18;
				this.defense = 27;
				this.bodySlot = 65;
				this.rare = 8;
				this.value = 240000;
				this.toolTip = "7% increased melee damage and critical strike chance";
				this.toolTip2 = "Enemies are more likely to target you";
				goto IL_2B846;
			}
			if (this.type == 1318)
			{
				this.name = "Turtle Leggings";
				this.width = 18;
				this.height = 18;
				this.defense = 17;
				this.legSlot = 54;
				this.rare = 8;
				this.value = 180000;
				this.toolTip = "3% increased melee critical strike chance";
				this.toolTip2 = "Enemies are more likely to target you";
				goto IL_2B846;
			}
			if (this.type == 1319)
			{
				this.name = "Snowball Cannon";
				this.autoReuse = true;
				this.useStyle = 5;
				this.useAnimation = 18;
				this.useTime = 18;
				this.width = 44;
				this.height = 14;
				this.shoot = 166;
				this.useAmmo = 14;
				this.useSound = 11;
				this.damage = 4;
				this.shootSpeed = 11f;
				this.noMelee = true;
				this.value = 100000;
				this.knockBack = 4.5f;
				this.rare = 1;
				this.ranged = true;
				this.useAmmo = 949;
				this.shoot = 166;
				goto IL_2B846;
			}
			if (this.type == 1320)
			{
				this.name = "Bone Pickaxe";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 19;
				this.useTime = 11;
				this.autoReuse = true;
				this.width = 24;
				this.height = 28;
				this.damage = 8;
				this.pick = 50;
				this.useSound = 1;
				this.knockBack = 3f;
				this.rare = 1;
				this.value = 18000;
				this.scale = 1.15f;
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1321)
			{
				this.name = "Magic Quiver";
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.toolTip = "Increase arrow speed and damage by 10%";
				this.toolTip2 = "20% chance to not consume arrow";
				this.value = Item.sellPrice(0, 5, 0, 0);
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 1322)
			{
				this.name = "Magma Stone";
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.toolTip = "Chance to inflict fire damage on attack";
				this.value = Item.sellPrice(0, 2, 0, 0);
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 1323)
			{
				this.name = "Lava Rose";
				this.width = 24;
				this.height = 28;
				this.accessory = true;
				this.toolTip = "Reduced damage from touching lava";
				this.value = Item.sellPrice(0, 2, 0, 0);
				this.rare = 3;
				goto IL_2B846;
			}
			if (this.type == 1324)
			{
				this.noMelee = true;
				this.useStyle = 1;
				this.name = "Bananarang";
				this.shootSpeed = 14f;
				this.shoot = 272;
				this.damage = 40;
				this.knockBack = 8.5f;
				this.width = 14;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 8;
				this.useTime = 8;
				this.noUseGraphic = true;
				this.rare = 5;
				this.value = 75000;
				this.melee = true;
				this.maxStack = 10;
				goto IL_2B846;
			}
			if (this.type == 1325)
			{
				this.autoReuse = false;
				this.name = "Chain Knife";
				this.useStyle = 5;
				this.useAnimation = 20;
				this.useTime = 20;
				this.knockBack = 3.5f;
				this.width = 30;
				this.height = 10;
				this.damage = 11;
				this.shoot = 273;
				this.shootSpeed = 12f;
				this.useSound = 1;
				this.rare = 2;
				this.value = 1000;
				this.melee = true;
				this.noUseGraphic = true;
				goto IL_2B846;
			}
			if (this.type == 1326)
			{
				this.autoReuse = false;
				this.name = "Rod of Discord";
				this.useStyle = 1;
				this.useAnimation = 20;
				this.useTime = 20;
				this.width = 20;
				this.height = 20;
				this.useSound = 8;
				this.rare = 7;
				this.value = Item.sellPrice(0, 10, 0, 0);
				this.toolTip = "Teleports to a new location";
				goto IL_2B846;
			}
			if (this.type == 1327)
			{
				this.autoReuse = true;
				this.name = "Death Sickle";
				this.useStyle = 1;
				this.useAnimation = 25;
				this.useTime = 25;
				this.knockBack = 7f;
				this.width = 24;
				this.height = 28;
				this.damage = 57;
				this.scale = 1.15f;
				this.useSound = 1;
				this.rare = 6;
				this.shoot = 274;
				this.shootSpeed = 9f;
				this.value = 250000;
				this.toolTip = "Shoots a deathly sickle";
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1328)
			{
				this.name = "Turtle Scale";
				this.width = 14;
				this.height = 18;
				this.maxStack = 99;
				this.rare = 7;
				this.value = 5000;
				goto IL_2B846;
			}
			if (this.type == 1329)
			{
				this.name = "Tissue Sample";
				this.width = 14;
				this.height = 18;
				this.maxStack = 99;
				this.rare = 1;
				this.value = 750;
				goto IL_2B846;
			}
			if (this.type == 1330)
			{
				this.name = "Vertebrae";
				this.width = 18;
				this.height = 20;
				this.maxStack = 99;
				this.value = 12;
				goto IL_2B846;
			}
			if (this.type == 1331)
			{
				this.useStyle = 4;
				this.consumable = true;
				this.useAnimation = 45;
				this.useTime = 45;
				this.name = "Bloody Spine";
				this.width = 28;
				this.height = 28;
				this.maxStack = 20;
				this.toolTip = "Summons the Brain of Cthulhu";
				goto IL_2B846;
			}
			if (this.type == 1332)
			{
				this.name = "Ichor";
				this.width = 12;
				this.height = 14;
				this.maxStack = 99;
				this.value = 4500;
				this.rare = 3;
				this.toolTip = "'The blood of gods'";
				goto IL_2B846;
			}
			if (this.type == 1333)
			{
				this.flame = true;
				this.name = "Ichor Torch";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.holdStyle = 1;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 4;
				this.placeStyle = 11;
				this.width = 10;
				this.height = 12;
				this.value = 330;
				this.rare = 1;
				this.toolTip = "Can be placed in water";
				goto IL_2B846;
			}
			if (this.type == 1334)
			{
				this.name = "Ichor Arrow";
				this.shootSpeed = 4.25f;
				this.shoot = 278;
				this.damage = 15;
				this.width = 10;
				this.height = 28;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 1;
				this.knockBack = 3f;
				this.value = 80;
				this.ranged = true;
				this.rare = 3;
				this.toolTip = "Decreases target's defense";
				goto IL_2B846;
			}
			if (this.type == 1335)
			{
				this.name = "Ichor Bullet";
				this.shootSpeed = 5.25f;
				this.shoot = 279;
				this.damage = 13;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 4f;
				this.value = 30;
				this.ranged = true;
				this.rare = 3;
				this.toolTip = "Decreases target's defense";
				goto IL_2B846;
			}
			if (this.type == 1336)
			{
				this.mana = 6;
				this.autoReuse = true;
				this.name = "Golden Shower";
				this.useStyle = 5;
				this.useAnimation = 18;
				this.useTime = 6;
				this.knockBack = 4f;
				this.width = 38;
				this.height = 10;
				this.damage = 28;
				this.shoot = 280;
				this.shootSpeed = 10f;
				this.useSound = 13;
				this.rare = 4;
				this.value = 500000;
				this.toolTip = "Sprays out a shower of ichor";
				this.magic = true;
				goto IL_2B846;
			}
			if (this.type == 1337)
			{
				this.name = "Bunny Cannon";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 209;
				this.placeStyle = 1;
				this.width = 12;
				this.height = 12;
				this.value = Item.buyPrice(0, 50, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 1338)
			{
				this.name = "Explosive Bunny";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 20;
				this.useTime = 20;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.width = 12;
				this.height = 12;
				this.damage = 350;
				this.noMelee = true;
				this.value = Item.buyPrice(0, 0, 35, 0);
				goto IL_2B846;
			}
			if (this.type == 1339)
			{
				this.name = "Vial of Venom";
				this.width = 12;
				this.height = 20;
				this.maxStack = 99;
				this.value = Item.buyPrice(0, 0, 10, 0);
				goto IL_2B846;
			}
			if (this.type == 1340)
			{
				this.name = "Flask of Venom";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 71;
				this.buffTime = 54000;
				this.toolTip = "Melee attacks inflict venom on enemies";
				this.value = Item.sellPrice(0, 0, 5, 0);
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 1341)
			{
				this.name = "Venom Arrow";
				this.shootSpeed = 4.3f;
				this.shoot = 282;
				this.damage = 17;
				this.width = 10;
				this.height = 28;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 1;
				this.knockBack = 4.2f;
				this.value = 90;
				this.ranged = true;
				this.rare = 3;
				this.toolTip = "Inflicts target with venom";
				goto IL_2B846;
			}
			if (this.type == 1342)
			{
				this.name = "Venom Bullet";
				this.shootSpeed = 5.3f;
				this.shoot = 283;
				this.damage = 14;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 4.1f;
				this.value = 40;
				this.ranged = true;
				this.rare = 3;
				this.toolTip = "Inflicts target with venom";
				goto IL_2B846;
			}
			if (this.type == 1343)
			{
				this.name = "Fire Gauntlet";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 7;
				this.toolTip = "Increases melee knockback and inflicts fire damage on attack";
				this.toolTip = "9% increased melee damage and speed";
				this.value = 300000;
				goto IL_2B846;
			}
			if (this.type == 1344)
			{
				this.name = "Cog";
				this.width = 12;
				this.height = 20;
				this.maxStack = 99;
				this.value = Item.buyPrice(0, 0, 7, 0);
				goto IL_2B846;
			}
			if (this.type == 1345)
			{
				this.name = "Confetti";
				this.width = 12;
				this.height = 20;
				this.maxStack = 99;
				this.value = Item.buyPrice(0, 0, 1, 0);
				goto IL_2B846;
			}
			if (this.type == 1346)
			{
				this.name = "Nanites";
				this.width = 12;
				this.height = 20;
				this.maxStack = 99;
				this.value = Item.buyPrice(0, 0, 10, 0);
				goto IL_2B846;
			}
			if (this.type == 1347)
			{
				this.name = "Explosive Powder";
				this.width = 12;
				this.height = 20;
				this.maxStack = 99;
				this.value = Item.buyPrice(0, 0, 12, 0);
				goto IL_2B846;
			}
			if (this.type == 1348)
			{
				this.name = "Gold Dust";
				this.width = 12;
				this.height = 20;
				this.maxStack = 99;
				this.value = Item.buyPrice(0, 0, 17, 0);
				goto IL_2B846;
			}
			if (this.type == 1349)
			{
				this.name = "Party Bullet";
				this.shootSpeed = 5.1f;
				this.shoot = 284;
				this.damage = 10;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 5f;
				this.value = 40;
				this.ranged = true;
				this.rare = 3;
				this.toolTip = "Explodes into confetti on impact";
				goto IL_2B846;
			}
			if (this.type == 1350)
			{
				this.name = "Nano Bullet";
				this.shootSpeed = 4.6f;
				this.shoot = 285;
				this.damage = 10;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 3.6f;
				this.value = 40;
				this.ranged = true;
				this.rare = 3;
				this.toolTip = "Causes confusion";
				goto IL_2B846;
			}
			if (this.type == 1351)
			{
				this.name = "Exploding Bullet";
				this.shootSpeed = 4.7f;
				this.shoot = 286;
				this.damage = 10;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 6.6f;
				this.value = 40;
				this.ranged = true;
				this.rare = 3;
				this.toolTip = "Explodes on impact";
				goto IL_2B846;
			}
			if (this.type == 1352)
			{
				this.name = "Golden Bullet";
				this.shootSpeed = 4.6f;
				this.shoot = 287;
				this.damage = 10;
				this.width = 8;
				this.height = 8;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 14;
				this.knockBack = 3.6f;
				this.value = 40;
				this.ranged = true;
				this.rare = 3;
				this.toolTip = "Enemies killed will drop more money";
				goto IL_2B846;
			}
			if (this.type == 1353)
			{
				this.name = "Flask of Cursed Flames";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 73;
				this.buffTime = 54000;
				this.value = Item.sellPrice(0, 0, 5, 0);
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 1354)
			{
				this.name = "Flask of Fire";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 74;
				this.buffTime = 54000;
				this.value = Item.sellPrice(0, 0, 5, 0);
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 1355)
			{
				this.name = "Flask of Gold";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 75;
				this.buffTime = 54000;
				this.value = Item.sellPrice(0, 0, 5, 0);
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 1356)
			{
				this.name = "Flask of Ichor";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 76;
				this.buffTime = 54000;
				this.value = Item.sellPrice(0, 0, 5, 0);
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 1357)
			{
				this.name = "Flask of Nanites";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 77;
				this.buffTime = 54000;
				this.value = Item.sellPrice(0, 0, 5, 0);
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 1358)
			{
				this.name = "Flask of Party";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 78;
				this.buffTime = 54000;
				this.value = Item.sellPrice(0, 0, 5, 0);
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 1359)
			{
				this.name = "Flask of Poison";
				this.useSound = 3;
				this.useStyle = 2;
				this.useTurn = true;
				this.useAnimation = 17;
				this.useTime = 17;
				this.maxStack = 30;
				this.consumable = true;
				this.width = 14;
				this.height = 24;
				this.buffType = 79;
				this.buffTime = 54000;
				this.value = Item.sellPrice(0, 0, 5, 0);
				this.rare = 4;
				goto IL_2B846;
			}
			if (this.type == 1360)
			{
				this.name = "Eye of Cthulhu Trophy";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.placeStyle = 0;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1361)
			{
				this.name = "Eater of Worlds Trophy";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.placeStyle = 1;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1362)
			{
				this.name = "Brain of Cthulhu Trophy";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.placeStyle = 2;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1363)
			{
				this.name = "Skeletron Trophy";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.placeStyle = 3;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1364)
			{
				this.name = "Queen Bee Trophy";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.placeStyle = 4;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1365)
			{
				this.name = "Wall of Flesh Trophy";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.placeStyle = 5;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1366)
			{
				this.name = "Destroyer Trophy";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.placeStyle = 6;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1367)
			{
				this.name = "Skeletron Prime Trophy";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.placeStyle = 7;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1368)
			{
				this.name = "Retinazer Trophy";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.placeStyle = 8;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1369)
			{
				this.name = "Spazmatism Trophy";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.placeStyle = 9;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1370)
			{
				this.name = "Plantera Trophy";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.placeStyle = 10;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1371)
			{
				this.name = "Golem Trophy";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.placeStyle = 11;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1372)
			{
				this.name = "Blood Moon Rising";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 12;
				goto IL_2B846;
			}
			if (this.type == 1373)
			{
				this.name = "The Hanged Man";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 13;
				goto IL_2B846;
			}
			if (this.type == 1374)
			{
				this.name = "Glory of the Fire";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 14;
				goto IL_2B846;
			}
			if (this.type == 1375)
			{
				this.name = "Bone Warp";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 15;
				goto IL_2B846;
			}
			if (this.type == 1376)
			{
				this.name = "Wall Skeleton";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.placeStyle = 16;
				goto IL_2B846;
			}
			if (this.type == 1377)
			{
				this.name = "Hanging Skeleton";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.placeStyle = 17;
				goto IL_2B846;
			}
			if (this.type == 1378)
			{
				this.name = "Blue Slab Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 100;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1379)
			{
				this.name = "Blue Tiled Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 101;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1380)
			{
				this.name = "Pink Slab Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 102;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1381)
			{
				this.name = "Pink Tiled Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 103;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1382)
			{
				this.name = "Green Slab Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 104;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1383)
			{
				this.name = "Green Tiled Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 105;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1384)
			{
				this.name = "Blue Brick Platform";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 6;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 1385)
			{
				this.name = "Pink Brick Platform";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 7;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 1386)
			{
				this.name = "Green Brick Platform";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 8;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 1387)
			{
				this.name = "Dungeon Shelf 1";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 9;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 1388)
			{
				this.name = "Dungeon Shelf 2";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 10;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 1389)
			{
				this.name = "Dungeon Shelf 3";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 11;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 1390)
			{
				this.name = "Lantern 1";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 42;
				this.width = 12;
				this.height = 28;
				this.placeStyle = 1;
				goto IL_2B846;
			}
			if (this.type == 1391)
			{
				this.name = "Lantern 2";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 42;
				this.width = 12;
				this.height = 28;
				this.placeStyle = 2;
				goto IL_2B846;
			}
			if (this.type == 1392)
			{
				this.name = "Lantern 3";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 42;
				this.width = 12;
				this.height = 28;
				this.placeStyle = 3;
				goto IL_2B846;
			}
			if (this.type == 1393)
			{
				this.name = "Lantern 4";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 42;
				this.width = 12;
				this.height = 28;
				this.placeStyle = 4;
				goto IL_2B846;
			}
			if (this.type == 1394)
			{
				this.name = "Lantern 5";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 42;
				this.width = 12;
				this.height = 28;
				this.placeStyle = 5;
				goto IL_2B846;
			}
			if (this.type == 1395)
			{
				this.name = "Lantern 6";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 42;
				this.width = 12;
				this.height = 28;
				this.placeStyle = 6;
				goto IL_2B846;
			}
			if (this.type == 1396)
			{
				this.name = "Blue Dungeon Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 13;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 1397)
			{
				this.name = "Blue Dungeon Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 10;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 1398)
			{
				this.name = "Blue Dungeon Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 11;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				goto IL_2B846;
			}
			if (this.type == 1399)
			{
				this.name = "Green Dungeon Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 14;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 1400)
			{
				this.name = "Green Dungeon Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 11;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 1401)
			{
				this.name = "Green Dungeon Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 12;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				goto IL_2B846;
			}
			if (this.type == 1402)
			{
				this.name = "Pink Dungeon Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 15;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 1403)
			{
				this.name = "Pink Dungeon Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 12;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 1404)
			{
				this.name = "Pink Dungeon Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 13;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				goto IL_2B846;
			}
			if (this.type == 1405)
			{
				this.noWet = true;
				this.name = "Blue Dungeon Candle";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 33;
				this.width = 8;
				this.height = 18;
				this.placeStyle = 1;
				goto IL_2B846;
			}
			if (this.type == 1406)
			{
				this.noWet = true;
				this.name = "Green Dungeon Candle";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 33;
				this.width = 8;
				this.height = 18;
				this.placeStyle = 2;
				goto IL_2B846;
			}
			if (this.type == 1407)
			{
				this.noWet = true;
				this.name = "Pink Dungeon Candle";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 33;
				this.width = 8;
				this.height = 18;
				this.placeStyle = 3;
				goto IL_2B846;
			}
			if (this.type == 1408)
			{
				this.name = "Blue Dungeon Vase";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 46;
				goto IL_2B846;
			}
			if (this.type == 1409)
			{
				this.name = "Green Dungeon Vase";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 47;
				goto IL_2B846;
			}
			if (this.type == 1410)
			{
				this.name = "Pink Dungeon Vase";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 48;
				goto IL_2B846;
			}
			if (this.type == 1411)
			{
				this.name = "Blue Dungeon Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 16;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 1412)
			{
				this.name = "Green Dungeon Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 17;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 1413)
			{
				this.name = "Pink Dungeon Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 18;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 1414)
			{
				this.name = "Blue Dungeon Bookcase";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 101;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 1;
				goto IL_2B846;
			}
			if (this.type == 1415)
			{
				this.name = "Green Dungeon Bookcase";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 101;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 2;
				goto IL_2B846;
			}
			if (this.type == 1416)
			{
				this.name = "Pink Dungeon Bookcase";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 101;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 3;
				goto IL_2B846;
			}
			if (this.type == 1417)
			{
				this.name = "Catacomb";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 241;
				this.placeStyle = 0;
				this.width = 30;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 1418)
			{
				this.name = "Dungeon Shelf 4";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 12;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 1419)
			{
				this.name = "Skellington J Skellingsworth";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 18;
				goto IL_2B846;
			}
			if (this.type == 1420)
			{
				this.name = "The Cursed Man";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 19;
				goto IL_2B846;
			}
			if (this.type == 1421)
			{
				this.name = "The Eye Sees the End";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 0;
				goto IL_2B846;
			}
			if (this.type == 1422)
			{
				this.name = "Something Evil is Watching You";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 1;
				goto IL_2B846;
			}
			if (this.type == 1423)
			{
				this.name = "The Twins Have Awoken";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 2;
				goto IL_2B846;
			}
			if (this.type == 1424)
			{
				this.name = "The Screamer";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 3;
				goto IL_2B846;
			}
			if (this.type == 1425)
			{
				this.name = "Goblins Playing Poker";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 4;
				goto IL_2B846;
			}
			if (this.type == 1426)
			{
				this.name = "Dryadisque";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 5;
				goto IL_2B846;
			}
			if (this.type == 1427)
			{
				this.name = "Sunflowers";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 20;
				goto IL_2B846;
			}
			if (this.type == 1428)
			{
				this.name = "Terrarian Gothic";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 21;
				goto IL_2B846;
			}
			if (this.type == 1429)
			{
				this.name = "Beanie";
				this.width = 18;
				this.height = 18;
				this.headSlot = 100;
				this.vanity = true;
				this.value = Item.buyPrice(0, 1, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 1430)
			{
				this.name = "Imbuing Station";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 243;
				this.width = 26;
				this.height = 20;
				this.value = Item.buyPrice(0, 7, 0, 0);
				this.rare = 2;
				goto IL_2B846;
			}
			if (this.type == 1431)
			{
				this.name = "Star in a Bottle";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 42;
				this.width = 12;
				this.height = 28;
				this.placeStyle = 7;
				goto IL_2B846;
			}
			if (this.type == 1432)
			{
				this.name = "Empty Bullet";
				this.width = 12;
				this.height = 20;
				this.maxStack = 999;
				this.value = Item.buyPrice(0, 0, 0, 3);
				goto IL_2B846;
			}
			if (this.type == 1433)
			{
				this.name = "Impact";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 6;
				goto IL_2B846;
			}
			if (this.type == 1434)
			{
				this.name = "Powered by Birds";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 7;
				goto IL_2B846;
			}
			if (this.type == 1435)
			{
				this.name = "The Destroyer";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 8;
				goto IL_2B846;
			}
			if (this.type == 1436)
			{
				this.name = "The Persistency of Eyes";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 9;
				goto IL_2B846;
			}
			if (this.type == 1437)
			{
				this.name = "Unicorn Crossing the Hallows";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 10;
				goto IL_2B846;
			}
			if (this.type == 1438)
			{
				this.name = "Great Wave";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 11;
				goto IL_2B846;
			}
			if (this.type == 1439)
			{
				this.name = "Starry Night";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 12;
				goto IL_2B846;
			}
			if (this.type == 1440)
			{
				this.name = "Guide Picasso";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 22;
				goto IL_2B846;
			}
			if (this.type == 1441)
			{
				this.name = "The Guardian's Gaze";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 23;
				goto IL_2B846;
			}
			if (this.type == 1442)
			{
				this.name = "Father of Someone";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 24;
				goto IL_2B846;
			}
			if (this.type == 1443)
			{
				this.name = "Nurse Lisa";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 25;
				goto IL_2B846;
			}
			if (this.type == 1444)
			{
				this.name = "Shadowbeam Staff";
				this.mana = 7;
				this.useSound = 8;
				this.useStyle = 5;
				this.damage = 53;
				this.useAnimation = 16;
				this.useTime = 16;
				this.autoReuse = true;
				this.width = 40;
				this.height = 40;
				this.shoot = 294;
				this.shootSpeed = 6f;
				this.knockBack = 3.25f;
				this.value = Item.sellPrice(0, 6, 0, 0);
				this.magic = true;
				this.rare = 8;
				this.noMelee = true;
				goto IL_2B846;
			}
			if (this.type == 1445)
			{
				this.name = "Inferno Fork";
				this.mana = 14;
				this.useSound = 45;
				this.useStyle = 5;
				this.damage = 65;
				this.useAnimation = 30;
				this.useTime = 30;
				this.width = 40;
				this.height = 40;
				this.shoot = 295;
				this.shootSpeed = 8f;
				this.knockBack = 8f;
				this.value = Item.sellPrice(0, 6, 0, 0);
				this.magic = true;
				this.noMelee = true;
				this.rare = 8;
				goto IL_2B846;
			}
			if (this.type == 1446)
			{
				this.name = "Spectre Staff";
				this.mana = 14;
				this.useSound = 43;
				this.useStyle = 5;
				this.damage = 68;
				this.autoReuse = true;
				this.useAnimation = 24;
				this.useTime = 24;
				this.width = 40;
				this.height = 40;
				this.shoot = 297;
				this.shootSpeed = 6f;
				this.knockBack = 6f;
				this.value = Item.sellPrice(0, 6, 0, 0);
				this.magic = true;
				this.noMelee = true;
				this.rare = 8;
				goto IL_2B846;
			}
			if (this.type == 1447)
			{
				this.name = "Wooden Fence";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 106;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1448)
			{
				this.name = "Metal Fence";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 107;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1449)
			{
				this.name = "Bubble Machine";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 244;
				this.width = 26;
				this.height = 20;
				this.value = Item.buyPrice(0, 4, 0, 0);
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1450)
			{
				this.name = "Bubble Wand";
				this.useStyle = 1;
				this.autoReuse = true;
				this.useTurn = false;
				this.useAnimation = 25;
				this.useTime = 25;
				this.width = 24;
				this.height = 28;
				this.scale = 1f;
				this.value = Item.buyPrice(0, 5, 0, 0);
				this.noMelee = true;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1451)
			{
				this.name = "Marching Bones Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 10;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 1452)
			{
				this.name = "Necromantic Sign";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 11;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 1453)
			{
				this.name = "Rusted Company Standard";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 12;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 1454)
			{
				this.name = "Ragged Brotherhood Sigil";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 13;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 1455)
			{
				this.name = "Molten Legion Flag";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 14;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 1456)
			{
				this.name = "Diabolic Sigil";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 15;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 1457)
			{
				this.name = "Obsidian Platform";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 13;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type == 1458)
			{
				this.name = "Obsidian Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 19;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type == 1459)
			{
				this.name = "Obsidian Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 16;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 1460)
			{
				this.name = "Obsidian Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 13;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 1461)
			{
				this.name = "Obsidian Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 14;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				goto IL_2B846;
			}
			if (this.type == 1462)
			{
				this.name = "Obsidian Vase";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 105;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 49;
				goto IL_2B846;
			}
			if (this.type == 1463)
			{
				this.name = "Obsidian Bookcase";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 101;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 4;
				goto IL_2B846;
			}
			if (this.type == 1464)
			{
				this.name = "Hellbound Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 16;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 1465)
			{
				this.name = "Hell Hammer Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 17;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 1466)
			{
				this.name = "Helltower Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 18;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 1467)
			{
				this.name = "Lost Hopes of Man Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 19;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 1468)
			{
				this.name = "Obsidian Watcher Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 20;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 1469)
			{
				this.name = "Lava Erupts Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 21;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				goto IL_2B846;
			}
			if (this.type == 1470)
			{
				this.name = "Blue Dungeon Bed";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 79;
				this.placeStyle = 5;
				this.width = 28;
				this.height = 20;
				this.value = 2000;
				goto IL_2B846;
			}
			if (this.type == 1471)
			{
				this.name = "Green Dungeon Bed";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 79;
				this.placeStyle = 6;
				this.width = 28;
				this.height = 20;
				this.value = 2000;
				goto IL_2B846;
			}
			if (this.type == 1472)
			{
				this.name = "Red Dungeon Bed";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 79;
				this.placeStyle = 7;
				this.width = 28;
				this.height = 20;
				this.value = 2000;
				goto IL_2B846;
			}
			if (this.type == 1473)
			{
				this.name = "Obsidian Bed";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 79;
				this.placeStyle = 8;
				this.width = 28;
				this.height = 20;
				this.value = 2000;
				goto IL_2B846;
			}
			if (this.type >= 1474 && this.type <= 1478)
			{
				this.name = "Picture";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 245;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = this.type - 1474;
				goto IL_2B846;
			}
			if (this.type >= 1479 && this.type <= 1494)
			{
				this.name = "Picture";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 246;
				this.width = 30;
				this.height = 30;
				if (this.type >= 1481 && this.type <= 1494)
				{
					this.value = Item.buyPrice(0, 1, 0, 0);
					goto IL_29567;
				}
				this.value = Item.sellPrice(0, 0, 10, 0);
				IL_29567:
				this.placeStyle = this.type - 1479;
				goto IL_2B846;
			}
			if (this.type == 1495)
			{
				this.name = "American Explosive";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 245;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 5;
				goto IL_2B846;
			}
			if (this.type >= 1496 && this.type <= 1499)
			{
				this.name = "Picture";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 26 + this.type - 1496;
				goto IL_2B846;
			}
			if (this.type >= 1500 && this.type <= 1502)
			{
				this.name = "Picture";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 13 + this.type - 1500;
				goto IL_2B846;
			}
			if (this.type == 1503)
			{
				this.name = "Spectre Hood";
				this.width = 18;
				this.height = 18;
				this.defense = 4;
				this.headSlot = 101;
				this.rare = 8;
				this.value = 375000;
				this.toolTip = "Increases maximum mana by 80 and reduces mana usage by 17%";
				this.toolTip2 = "10% increased magic damage and critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1504)
			{
				this.name = "Spectre Robe";
				this.width = 18;
				this.height = 18;
				this.defense = 12;
				this.bodySlot = 66;
				this.rare = 8;
				this.value = 300000;
				this.toolTip = "7% increased magic damage and critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1505)
			{
				this.name = "Spectre Pants";
				this.width = 18;
				this.height = 18;
				this.defense = 8;
				this.legSlot = 55;
				this.rare = 8;
				this.value = 225000;
				this.toolTip = "8% increased magic damage";
				this.toolTip2 = "8% increased movement speed";
				goto IL_2B846;
			}
			if (this.type == 1506)
			{
				this.name = "Spirit Pickaxe";
				this.useStyle = 1;
				this.useAnimation = 24;
				this.useTime = 10;
				this.knockBack = 5.25f;
				this.useTurn = true;
				this.autoReuse = true;
				this.width = 20;
				this.height = 12;
				this.damage = 32;
				this.pick = 200;
				this.useSound = 1;
				this.rare = 8;
				this.value = 216000;
				this.melee = true;
				this.scale = 1.15f;
				this.tileBoost += 3;
				goto IL_2B846;
			}
			if (this.type == 1507)
			{
				this.name = "Spirit Hamaxe";
				this.useTurn = true;
				this.autoReuse = true;
				this.useStyle = 1;
				this.useAnimation = 28;
				this.useTime = 8;
				this.knockBack = 7f;
				this.width = 20;
				this.height = 12;
				this.damage = 60;
				this.axe = 23;
				this.hammer = 90;
				this.useSound = 1;
				this.rare = 8;
				this.value = 216000;
				this.melee = true;
				this.scale = 1.05f;
				this.tileBoost += 3;
				goto IL_2B846;
			}
			if (this.type == 1508)
			{
				this.name = "Ectoplasm";
				this.maxStack = 99;
				this.width = 16;
				this.height = 14;
				this.value = Item.sellPrice(0, 0, 50, 0);
				this.rare = 8;
				goto IL_2B846;
			}
			if (this.type == 1509)
			{
				this.name = "Gothic Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 17;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type == 1510)
			{
				this.name = "Gothic Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 14;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type == 1511)
			{
				this.name = "Gothic Work Bench";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 18;
				this.placeStyle = 15;
				this.width = 28;
				this.height = 14;
				this.value = 150;
				goto IL_2B846;
			}
			if (this.type == 1512)
			{
				this.name = "Gothic Bookcase";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 101;
				this.width = 20;
				this.height = 20;
				this.value = 300;
				this.placeStyle = 5;
				goto IL_2B846;
			}
			if (this.type == 1513)
			{
				this.noMelee = true;
				this.useStyle = 1;
				this.name = "Paladin's Hammer";
				this.shootSpeed = 14f;
				this.shoot = 301;
				this.damage = 90;
				this.knockBack = 9f;
				this.width = 14;
				this.height = 28;
				this.useSound = 1;
				this.useAnimation = 15;
				this.useTime = 15;
				this.noUseGraphic = true;
				this.rare = 8;
				this.value = Item.sellPrice(0, 10, 0, 0);
				this.melee = true;
				goto IL_2B846;
			}
			if (this.type == 1514)
			{
				this.name = "SWAT Helmet";
				this.width = 18;
				this.height = 18;
				this.headSlot = 102;
				this.rare = 1;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.vanity = true;
				goto IL_2B846;
			}
			if (this.type == 1515)
			{
				this.name = "Bee Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.toolTip = "Allows flight and slow fall";
				this.value = 400000;
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type >= 1516 && this.type <= 1521)
			{
				this.name = "Feather";
				this.maxStack = 99;
				this.width = 16;
				this.height = 14;
				this.value = Item.sellPrice(0, 2, 50, 0);
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type >= 1522 && this.type <= 1527)
			{
				this.name = "Large Gem";
				this.width = 20;
				this.height = 20;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type >= 1528 && this.type <= 1532)
			{
				this.name = "Dungeon Chest";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 21;
				this.placeStyle = 18 + this.type - 1528;
				this.width = 26;
				this.height = 22;
				this.value = 2500;
				goto IL_2B846;
			}
			if (this.type >= 1533 && this.type <= 1537)
			{
				this.name = "Dungeon Key";
				this.width = 14;
				this.height = 20;
				this.maxStack = 99;
				this.rare = 8;
				goto IL_2B846;
			}
			if (this.type >= 1538 && this.type <= 1540)
			{
				this.name = "Picture";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 30 + this.type - 1538;
				goto IL_2B846;
			}
			if (this.type >= 1541 && this.type <= 1542)
			{
				this.name = "Picture";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 246;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 16 + this.type - 1541;
				goto IL_2B846;
			}
			if (this.type >= 1543 && this.type <= 1545)
			{
				this.name = "Spectre Paintbrush";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.width = 24;
				this.height = 24;
				this.value = 10000;
				this.tileBoost += 3;
				goto IL_2B846;
			}
			if (this.type == 1546)
			{
				this.name = "Shroomite Headgear";
				this.width = 18;
				this.height = 18;
				this.defense = 11;
				this.headSlot = 103;
				this.rare = 8;
				this.value = 375000;
				this.toolTip = "15% increased arrow damage";
				this.toolTip2 = "5% ranged critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1547)
			{
				this.name = "Shroomite Mask";
				this.width = 18;
				this.height = 18;
				this.defense = 11;
				this.headSlot = 104;
				this.rare = 8;
				this.value = 375000;
				this.toolTip = "15% increased bullet damage";
				this.toolTip2 = "5% ranged critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1548)
			{
				this.name = "Shroomite Helmet";
				this.width = 18;
				this.height = 18;
				this.defense = 11;
				this.headSlot = 105;
				this.rare = 8;
				this.value = 375000;
				this.toolTip = "15% increased rocket damage";
				this.toolTip2 = "5% ranged critical strike chance";
				goto IL_2B846;
			}
			if (this.type == 1549)
			{
				this.name = "Shroomite Breastplate";
				this.width = 18;
				this.height = 18;
				this.defense = 24;
				this.bodySlot = 67;
				this.rare = 8;
				this.value = 300000;
				this.toolTip = "13% increased ranged critical strike chance";
				this.toolTip2 = "20% chance to not consume ammo";
				goto IL_2B846;
			}
			if (this.type == 1550)
			{
				this.name = "Shroomite Leggings";
				this.width = 18;
				this.height = 18;
				this.defense = 16;
				this.legSlot = 56;
				this.rare = 8;
				this.value = 225000;
				this.toolTip = "7% increased ranged critical strike chance";
				this.toolTip2 = "12% increased movement speed";
				goto IL_2B846;
			}
			if (this.type == 1551)
			{
				this.name = "Autohammer";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 247;
				this.width = 26;
				this.height = 24;
				this.value = Item.buyPrice(1, 0, 0, 0);
				this.toolTip = "Converts Chlorophyte Bars into Shroomite Bars";
				goto IL_2B846;
			}
			if (this.type == 1552)
			{
				this.name = "Shroomite Bar";
				this.width = 20;
				this.height = 20;
				this.maxStack = 99;
				this.rare = 7;
				this.value = Item.sellPrice(0, 1, 0, 0);
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 239;
				this.placeStyle = 20;
				goto IL_2B846;
			}
			if (this.type == 1553)
			{
				this.useStyle = 5;
				this.autoReuse = true;
				this.useAnimation = 7;
				this.useTime = 6;
				this.name = "S.D.M.G.";
				this.crit += 5;
				this.width = 60;
				this.height = 26;
				this.shoot = 10;
				this.useAmmo = 14;
				this.useSound = 11;
				this.damage = 35;
				this.shootSpeed = 12f;
				this.noMelee = true;
				this.value = 750000;
				this.rare = 8;
				this.toolTip = "50% chance to not consume ammo";
				this.toolTip2 = "'Space Dolphin Machine Gun'";
				this.knockBack = 2.5f;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type == 1554)
			{
				this.name = "Cenx's Tiara";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.headSlot = 106;
				goto IL_2B846;
			}
			if (this.type == 1555)
			{
				this.name = "Cenx's Breastplate";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.bodySlot = 68;
				goto IL_2B846;
			}
			if (this.type == 1556)
			{
				this.name = "Cenx's Leggings";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.legSlot = 57;
				goto IL_2B846;
			}
			if (this.type == 1557)
			{
				this.name = "Crowno's Mask";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.headSlot = 107;
				goto IL_2B846;
			}
			if (this.type == 1558)
			{
				this.name = "Crowno's Breastplate";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.bodySlot = 69;
				goto IL_2B846;
			}
			if (this.type == 1559)
			{
				this.name = "Crowno's Leggings";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.legSlot = 58;
				goto IL_2B846;
			}
			if (this.type == 1560)
			{
				this.name = "Will's Helmet";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.headSlot = 108;
				goto IL_2B846;
			}
			if (this.type == 1561)
			{
				this.name = "Will's Breastplate";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.bodySlot = 70;
				goto IL_2B846;
			}
			if (this.type == 1562)
			{
				this.name = "Will's Leggings";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.legSlot = 59;
				goto IL_2B846;
			}
			if (this.type == 1563)
			{
				this.name = "Jim's Helmet";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.headSlot = 109;
				goto IL_2B846;
			}
			if (this.type == 1564)
			{
				this.name = "Jim's Breastplate";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.bodySlot = 71;
				goto IL_2B846;
			}
			if (this.type == 1565)
			{
				this.name = "Jim's Leggings";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.legSlot = 60;
				goto IL_2B846;
			}
			if (this.type == 1566)
			{
				this.name = "Aaron's Helmet";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.headSlot = 110;
				goto IL_2B846;
			}
			if (this.type == 1567)
			{
				this.name = "Aaron's Breastplate";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.bodySlot = 72;
				goto IL_2B846;
			}
			if (this.type == 1568)
			{
				this.name = "Aaron's Leggings";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.legSlot = 61;
				goto IL_2B846;
			}
			if (this.type == 1569)
			{
				this.autoReuse = true;
				this.useStyle = 1;
				this.name = "Vampire Knives";
				this.shootSpeed = 15f;
				this.shoot = 304;
				this.damage = 29;
				this.width = 18;
				this.height = 20;
				this.useSound = 39;
				this.useAnimation = 16;
				this.useTime = 16;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = Item.sellPrice(0, 20, 0, 0);
				this.knockBack = 2.75f;
				this.melee = true;
				this.rare = 8;
				this.toolTip = "Rapidly shoot life stealing daggers";
				goto IL_2B846;
			}
			if (this.type == 1570)
			{
				this.name = "Broken Hero Sword";
				this.width = 14;
				this.height = 18;
				this.maxStack = 99;
				this.rare = 8;
				this.value = Item.sellPrice(0, 2, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 1571)
			{
				this.autoReuse = true;
				this.useStyle = 5;
				this.name = "Eater's Bite";
				this.shootSpeed = 14f;
				this.shoot = 306;
				this.damage = 57;
				this.width = 18;
				this.height = 20;
				this.useSound = 39;
				this.useAnimation = 20;
				this.useTime = 20;
				this.noUseGraphic = true;
				this.noMelee = true;
				this.value = Item.sellPrice(0, 20, 0, 0);
				this.knockBack = 5f;
				this.melee = true;
				this.rare = 8;
				goto IL_2B846;
			}
			if (this.type == 1572)
			{
				this.name = "Hydra Staff";
				this.useStyle = 1;
				this.shootSpeed = 14f;
				this.shoot = 308;
				this.damage = 100;
				this.width = 18;
				this.height = 20;
				this.useSound = 1;
				this.useAnimation = 30;
				this.useTime = 30;
				this.noMelee = true;
				this.value = Item.sellPrice(0, 20, 0, 0);
				this.knockBack = 7.5f;
				this.rare = 8;
				this.summon = true;
				this.mana = 20;
				goto IL_2B846;
			}
			if (this.type == 1573)
			{
				this.name = "The Creation of the Guide";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 242;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 16;
				goto IL_2B846;
			}
			if (this.type >= 1574 && this.type <= 1576)
			{
				this.name = "Picture";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 240;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 33 + this.type - 1574;
				goto IL_2B846;
			}
			if (this.type == 1577)
			{
				this.name = "Glorious Night";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 245;
				this.width = 30;
				this.height = 30;
				this.value = Item.sellPrice(0, 0, 10, 0);
				this.placeStyle = 6;
				goto IL_2B846;
			}
			if (this.type == 1578)
			{
				this.name = "Sweetheart Necklace";
				this.width = 22;
				this.height = 22;
				this.accessory = true;
				this.rare = 3;
				this.toolTip = "Releases bees and increases movement speed when damaged";
				this.value = 200000;
				goto IL_2B846;
			}
			if (this.type == 1579)
			{
				this.name = "Flurry Boots";
				this.width = 28;
				this.height = 24;
				this.accessory = true;
				this.rare = 1;
				this.toolTip = "The wearer can run super fast";
				this.value = 50000;
				goto IL_2B846;
			}
			if (this.type == 1580)
			{
				this.name = "D-Town's Helmet";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.headSlot = 111;
				goto IL_2B846;
			}
			if (this.type == 1581)
			{
				this.name = "D-Town's Breastplate";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.bodySlot = 73;
				goto IL_2B846;
			}
			if (this.type == 1582)
			{
				this.name = "D-Town's Leggings";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.legSlot = 62;
				goto IL_2B846;
			}
			if (this.type == 1583)
			{
				this.name = "D-Town's Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.rare = 9;
				goto IL_2B846;
			}
			if (this.type == 1584)
			{
				this.name = "Will's Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.rare = 9;
				goto IL_2B846;
			}
			if (this.type == 1585)
			{
				this.name = "Crowno's Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.rare = 9;
				goto IL_2B846;
			}
			if (this.type == 1586)
			{
				this.name = "Cenx's Wings";
				this.width = 24;
				this.height = 8;
				this.accessory = true;
				this.rare = 9;
				goto IL_2B846;
			}
			if (this.type == 1587)
			{
				this.name = "Cenx's Dress";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.bodySlot = 74;
				goto IL_2B846;
			}
			if (this.type == 1588)
			{
				this.name = "Cenx's Dress Pants";
				this.width = 18;
				this.height = 18;
				this.rare = 9;
				this.vanity = true;
				this.legSlot = 63;
				goto IL_2B846;
			}
			if (this.type == 1589)
			{
				this.name = "Palladium Column";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 248;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1590)
			{
				this.name = "Palladium Column Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 109;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1591)
			{
				this.name = "Bubblegum Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 249;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1592)
			{
				this.name = "Bubblegum Block Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 110;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1593)
			{
				this.name = "Titanstone Block";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createTile = 250;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1594)
			{
				this.name = "Titanstone Block Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 111;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1595)
			{
				this.name = "Magic Cuffs";
				this.width = 22;
				this.height = 22;
				this.accessory = true;
				this.rare = 2;
				this.toolTip = "Increases maximum mana by 20";
				this.toolTip2 = "Restores mana when damaged";
				this.value = 100000;
				goto IL_2B846;
			}
			if (this.type >= 1596 && this.type <= 1610)
			{
				this.name = "Music Box";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.consumable = true;
				this.createTile = 139;
				this.placeStyle = this.type - 1596 + 13;
				this.width = 24;
				this.height = 24;
				this.rare = 4;
				this.value = 100000;
				this.accessory = true;
				goto IL_2B846;
			}
			if (this.type == 1611)
			{
				this.name = "Butterfly Dust";
				this.maxStack = 99;
				this.width = 16;
				this.height = 14;
				this.value = Item.sellPrice(0, 2, 50, 0);
				this.rare = 5;
				goto IL_2B846;
			}
			if (this.type == 1612)
			{
				this.name = "Ankh Charm";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 6;
				this.toolTip = "Grants immunity to most debuffs";
				this.value = Item.sellPrice(0, 3, 0, 0);
				goto IL_2B846;
			}
			if (this.type == 1613)
			{
				this.name = "Ankh Shield";
				this.width = 24;
				this.height = 28;
				this.rare = 7;
				this.value = Item.sellPrice(0, 5, 0, 0);
				this.accessory = true;
				this.defense = 4;
				this.toolTip = "Grants immunity to knockback and fire blocks";
				this.toolTip2 = "Grants immunity to most debuffs";
				goto IL_2B846;
			}
			if (this.type == 1614)
			{
				this.name = "Blue Flare";
				this.shootSpeed = 6f;
				this.shoot = 310;
				this.damage = 1;
				this.width = 12;
				this.height = 12;
				this.maxStack = 999;
				this.consumable = true;
				this.ammo = 931;
				this.knockBack = 1.5f;
				this.value = 7;
				this.ranged = true;
				goto IL_2B846;
			}
			if (this.type >= 1615 && this.type <= 1701)
			{
				this.name = "Monster Banner";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 91;
				this.placeStyle = 22 + this.type - 1615;
				this.width = 10;
				this.height = 24;
				this.value = 1000;
				this.rare = 1;
				goto IL_2B846;
			}
			if (this.type == 1702)
			{
				this.name = "Glass Platform";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 19;
				this.placeStyle = 14;
				this.width = 8;
				this.height = 10;
				goto IL_2B846;
			}
			if (this.type >= 1703 && this.type <= 1708)
			{
				this.name = "Chair";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 15;
				this.placeStyle = 18 + this.type - 1703;
				this.width = 12;
				this.height = 30;
				goto IL_2B846;
			}
			if (this.type >= 1709 && this.type <= 1712)
			{
				this.name = "Door";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 10;
				this.placeStyle = 20 + this.type - 1709;
				this.width = 14;
				this.height = 28;
				this.value = 200;
				goto IL_2B846;
			}
			if (this.type >= 1713 && this.type <= 1718)
			{
				this.name = "Table";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.autoReuse = true;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 14;
				this.placeStyle = 15 + this.type - 1713;
				this.width = 26;
				this.height = 20;
				this.value = 300;
				goto IL_2B846;
			}
			if (this.type >= 1719 && this.type <= 1722)
			{
				this.name = "Bed";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 10;
				this.maxStack = 99;
				this.consumable = true;
				this.createTile = 79;
				this.placeStyle = 9 + this.type - 1719;
				this.width = 28;
				this.height = 20;
				this.value = 2000;
				goto IL_2B846;
			}
			if (this.type == 1723)
			{
				this.name = "Living Wood Wall";
				this.useStyle = 1;
				this.useTurn = true;
				this.useAnimation = 15;
				this.useTime = 7;
				this.autoReuse = true;
				this.maxStack = 999;
				this.consumable = true;
				this.createWall = 78;
				this.width = 12;
				this.height = 12;
				goto IL_2B846;
			}
			if (this.type == 1724)
			{
				this.name = "Fart in a Jar";
				this.width = 16;
				this.height = 24;
				this.accessory = true;
				this.rare = 2;
				this.toolTip = "Allows the holder to double jump";
				this.value = 75000;
			}
			IL_2B846:
			this.netID = this.type;
			if (!noMatCheck)
			{
				this.checkMat();
			}
			this.name = Lang.itemName(this.netID, false);
			this.CheckTip();
		}
		public static string VersionName(string oldName, int release)
		{
			string result = oldName;
			if (release <= 4)
			{
				if (oldName == "Cobalt Helmet")
				{
					result = "Jungle Hat";
				}
				else
				{
					if (oldName == "Cobalt Breastplate")
					{
						result = "Jungle Shirt";
					}
					else
					{
						if (oldName == "Cobalt Greaves")
						{
							result = "Jungle Pants";
						}
					}
				}
			}
			if (release <= 13 && oldName == "Jungle Rose")
			{
				result = "Jungle Spores";
			}
			if (release <= 20)
			{
				if (oldName == "Gills potion")
				{
					result = "Gills Potion";
				}
				else
				{
					if (oldName == "Thorn Chakrum")
					{
						result = "Thorn Chakram";
					}
					else
					{
						if (oldName == "Ball 'O Hurt")
						{
							result = "Ball O' Hurt";
						}
					}
				}
			}
			if (release <= 41 && oldName == "Iron Chain")
			{
				result = "Chain";
			}
			if (release <= 44 && oldName == "Orb of Light")
			{
				result = "Shadow Orb";
			}
			if (release <= 46)
			{
				if (oldName == "Black Dye")
				{
					result = "Black Thread";
				}
				if (oldName == "Green Dye")
				{
					result = "Green Thread";
				}
			}
			return result;
		}
		public Color GetAlpha(Color newColor)
		{
			if (this.type == 75)
			{
				return new Color(255, 255, 255, (int)newColor.A - this.alpha);
			}
			if (this.type == 121 || this.type == 122 || this.type == 217 || this.type == 218 || this.type == 219 || this.type == 220 || this.type == 120 || this.type == 119)
			{
				return new Color(255, 255, 255, 255);
			}
			if (this.type == 501)
			{
				return new Color(200, 200, 200, 50);
			}
			if (this.type == 757)
			{
				return new Color(255, 255, 255, 200);
			}
			if (this.type == 1306)
			{
				return new Color(255, 255, 255, 200);
			}
			if (this.type == 520 || this.type == 521 || this.type == 522 || this.type == 547 || this.type == 548 || this.type == 549 || this.type == 575 || this.type == 1332)
			{
				return new Color(255, 255, 255, 50);
			}
			if (this.type == 58 || this.type == 184)
			{
				return new Color(200, 200, 200, 2000);
			}
			if (this.type == 1572)
			{
				return new Color(200, 200, 255, 125);
			}
			if (this.type == 787)
			{
				return new Color(255, 255, 255, 175);
			}
			if (this.type == 1508)
			{
				return new Color(200, 200, 200, 0);
			}
			if (this.type == 502)
			{
				return new Color(255, 255, 255, 150);
			}
			if (this.type == 51)
			{
				return new Color(255, 255, 255, 0);
			}
			if (this.type == 1260)
			{
				return new Color(255, 255, 255, 175);
			}
			if (this.type == 1508)
			{
				return new Color((int)newColor.R, (int)newColor.G, (int)newColor.B, (int)Main.gFade);
			}
			if (this.type == 1506 || this.type == 1507)
			{
				return new Color((int)newColor.R, (int)newColor.G, (int)newColor.B, (int)Main.gFade);
			}
			if (this.type == 1446 || (this.type >= 1543 && this.type <= 1545))
			{
				return new Color((int)newColor.R, (int)newColor.G, (int)newColor.B, (int)Main.gFade);
			}
			float num = (float)(255 - this.alpha) / 255f;
			int r = (int)((float)newColor.R * num);
			int g = (int)((float)newColor.G * num);
			int b = (int)((float)newColor.B * num);
			int num2 = (int)newColor.A - this.alpha;
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num2 > 255)
			{
				num2 = 255;
			}
			if (this.type >= 198 && this.type <= 203)
			{
				return Color.White;
			}
			return new Color(r, g, b, num2);
		}
		public Color GetColor(Color newColor)
		{
			int num = (int)(this.color.R - (255 - newColor.R));
			int num2 = (int)(this.color.G - (255 - newColor.G));
			int num3 = (int)(this.color.B - (255 - newColor.B));
			int num4 = (int)(this.color.A - (255 - newColor.A));
			if (num < 0)
			{
				num = 0;
			}
			if (num > 255)
			{
				num = 255;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num2 > 255)
			{
				num2 = 255;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			if (num3 > 255)
			{
				num3 = 255;
			}
			if (num4 < 0)
			{
				num4 = 0;
			}
			if (num4 > 255)
			{
				num4 = 255;
			}
			return new Color(num, num2, num3, num4);
		}
		public static bool MechSpawn(float x, float y, int type)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < 200; i++)
			{
				if (Main.item[i].active && Main.item[i].type == type)
				{
					num++;
					Vector2 vector = new Vector2(x, y);
					float num4 = Main.item[i].position.X - vector.X;
					float num5 = Main.item[i].position.Y - vector.Y;
					float num6 = (float)Math.Sqrt((double)(num4 * num4 + num5 * num5));
					if (num6 < 300f)
					{
						num2++;
					}
					if (num6 < 800f)
					{
						num3++;
					}
				}
			}
			return num2 < 3 && num3 < 6 && num < 10;
		}
		public static int buyPrice(int platinum = 0, int gold = 0, int silver = 0, int copper = 0)
		{
			int num = copper + silver * 100;
			num += gold * 100 * 100;
			return num + platinum * 100 * 100 * 100;
		}
		public static int sellPrice(int platinum = 0, int gold = 0, int silver = 0, int copper = 0)
		{
			int num = copper + silver * 100;
			num += gold * 100 * 100;
			num += platinum * 100 * 100 * 100;
			return num * 5;
		}
		public void UpdateItem(int i)
		{
			if (this.active)
			{
				if (Main.netMode == 0)
				{
					this.owner = Main.myPlayer;
				}
				float num = 0.1f;
				float num2 = 7f;
				if (Main.netMode == 1)
				{
					int num3 = (int)(this.position.X + (float)(this.width / 2)) / 16;
					int num4 = (int)(this.position.Y + (float)(this.height / 2)) / 16;
					if (num3 >= 0 && num4 >= 0 && num3 < Main.maxTilesX && num4 < Main.maxTilesY && Main.tile[num3, num4] == null)
					{
						num = 0f;
						this.velocity.X = 0f;
						this.velocity.Y = 0f;
					}
				}
				if (this.honeyWet)
				{
					num = 0.05f;
					num2 = 3f;
				}
				else
				{
					if (this.wet)
					{
						num2 = 5f;
						num = 0.08f;
					}
				}
				Vector2 value = this.velocity * 0.5f;
				if (this.ownTime > 0)
				{
					this.ownTime--;
				}
				else
				{
					this.ownIgnore = -1;
				}
				if (this.keepTime > 0)
				{
					this.keepTime--;
				}
				if (!this.beingGrabbed)
				{
					if (this.owner == Main.myPlayer && (this.createTile >= 0 || this.createWall > 0 || (this.ammo > 0 && !this.notAmmo) || this.consumable || (this.type >= 71 && this.type <= 74)) && this.stack < this.maxStack)
					{
						for (int j = i + 1; j < 400; j++)
						{
							if (Main.item[j].active && Main.item[j].type == this.type && Main.item[j].stack > 0 && Main.item[j].owner == this.owner)
							{
								float num5 = Math.Abs(this.position.X + (float)(this.width / 2) - (Main.item[j].position.X + (float)(Main.item[j].width / 2))) + Math.Abs(this.position.Y + (float)(this.height / 2) - (Main.item[j].position.Y + (float)(Main.item[j].height / 2)));
								if (num5 < 30f)
								{
									this.position = (this.position + Main.item[j].position) / 2f;
									this.velocity = (this.velocity + Main.item[j].velocity) / 2f;
									int num6 = Main.item[j].stack;
									if (num6 > this.maxStack - this.stack)
									{
										num6 = this.maxStack - this.stack;
									}
									Main.item[j].stack -= num6;
									this.stack += num6;
									if (Main.item[j].stack <= 0)
									{
										Main.item[j].SetDefaults(0, false);
										Main.item[j].active = false;
									}
									if (Main.netMode != 0)
									{
										NetMessage.SendData(21, -1, -1, "", i, 0f, 0f, 0f, 0);
										NetMessage.SendData(21, -1, -1, "", j, 0f, 0f, 0f, 0);
									}
								}
							}
						}
					}
					if (this.type == 520 || this.type == 521 || this.type == 547 || this.type == 548 || this.type == 549 || this.type == 575)
					{
						this.velocity.X = this.velocity.X * 0.95f;
						if ((double)this.velocity.X < 0.1 && (double)this.velocity.X > -0.1)
						{
							this.velocity.X = 0f;
						}
						this.velocity.Y = this.velocity.Y * 0.95f;
						if ((double)this.velocity.Y < 0.1 && (double)this.velocity.Y > -0.1)
						{
							this.velocity.Y = 0f;
						}
					}
					else
					{
						this.velocity.Y = this.velocity.Y + num;
						if (this.velocity.Y > num2)
						{
							this.velocity.Y = num2;
						}
						this.velocity.X = this.velocity.X * 0.95f;
						if ((double)this.velocity.X < 0.1 && (double)this.velocity.X > -0.1)
						{
							this.velocity.X = 0f;
						}
					}
					bool flag = Collision.LavaCollision(this.position, this.width, this.height);
					if (flag)
					{
						this.lavaWet = true;
					}
					bool flag2 = Collision.WetCollision(this.position, this.width, this.height);
					if (Collision.honey)
					{
						this.honeyWet = true;
					}
					if (flag2)
					{
						if (!this.wet)
						{
							if (this.wetCount == 0)
							{
								this.wetCount = 20;
								if (!flag)
								{
									if (this.honeyWet)
									{
										for (int k = 0; k < 5; k++)
										{
											int num7 = Dust.NewDust(new Vector2(this.position.X - 6f, this.position.Y + (float)(this.height / 2) - 8f), this.width + 12, 24, 152, 0f, 0f, 0, default(Color), 1f);
											Dust expr_62C_cp_0 = Main.dust[num7];
											expr_62C_cp_0.velocity.Y = expr_62C_cp_0.velocity.Y - 1f;
											Dust expr_64A_cp_0 = Main.dust[num7];
											expr_64A_cp_0.velocity.X = expr_64A_cp_0.velocity.X * 2.5f;
											Main.dust[num7].scale = 1.3f;
											Main.dust[num7].alpha = 100;
											Main.dust[num7].noGravity = true;
										}
										Main.PlaySound(19, (int)this.position.X, (int)this.position.Y, 1);
									}
									else
									{
										for (int l = 0; l < 10; l++)
										{
											int num8 = Dust.NewDust(new Vector2(this.position.X - 6f, this.position.Y + (float)(this.height / 2) - 8f), this.width + 12, 24, Dust.dustWater(), 0f, 0f, 0, default(Color), 1f);
											Dust expr_734_cp_0 = Main.dust[num8];
											expr_734_cp_0.velocity.Y = expr_734_cp_0.velocity.Y - 4f;
											Dust expr_752_cp_0 = Main.dust[num8];
											expr_752_cp_0.velocity.X = expr_752_cp_0.velocity.X * 2.5f;
											Main.dust[num8].scale *= 0.8f;
											Main.dust[num8].alpha = 100;
											Main.dust[num8].noGravity = true;
										}
										Main.PlaySound(19, (int)this.position.X, (int)this.position.Y, 1);
									}
								}
								else
								{
									for (int m = 0; m < 5; m++)
									{
										int num9 = Dust.NewDust(new Vector2(this.position.X - 6f, this.position.Y + (float)(this.height / 2) - 8f), this.width + 12, 24, 35, 0f, 0f, 0, default(Color), 1f);
										Dust expr_841_cp_0 = Main.dust[num9];
										expr_841_cp_0.velocity.Y = expr_841_cp_0.velocity.Y - 1.5f;
										Dust expr_85F_cp_0 = Main.dust[num9];
										expr_85F_cp_0.velocity.X = expr_85F_cp_0.velocity.X * 2.5f;
										Main.dust[num9].scale = 1.3f;
										Main.dust[num9].alpha = 100;
										Main.dust[num9].noGravity = true;
									}
									Main.PlaySound(19, (int)this.position.X, (int)this.position.Y, 1);
								}
							}
							this.wet = true;
						}
					}
					else
					{
						if (this.wet)
						{
							this.wet = false;
						}
					}
					if (!this.wet)
					{
						this.lavaWet = false;
						this.honeyWet = false;
					}
					if (this.wetCount > 0)
					{
						this.wetCount -= 1;
					}
					if (this.wet)
					{
						if (this.wet)
						{
							Vector2 vector = this.velocity;
							this.velocity = Collision.TileCollision(this.position, this.velocity, this.width, this.height, false, false);
							if (this.velocity.X != vector.X)
							{
								value.X = this.velocity.X;
							}
							if (this.velocity.Y != vector.Y)
							{
								value.Y = this.velocity.Y;
							}
						}
					}
					else
					{
						this.velocity = Collision.TileCollision(this.position, this.velocity, this.width, this.height, false, false);
					}
					Vector4 vector2 = Collision.SlopeCollision(this.position, this.velocity, this.width, this.height, num);
					this.position.X = vector2.X;
					this.position.Y = vector2.Y;
					this.velocity.X = vector2.Z;
					this.velocity.Y = vector2.W;
					if (this.lavaWet)
					{
						if (this.type == 267)
						{
							if (Main.netMode != 1)
							{
								this.active = false;
								this.type = 0;
								this.name = "";
								this.stack = 0;
								for (int n = 0; n < 200; n++)
								{
									if (Main.npc[n].active && Main.npc[n].type == 22)
									{
										if (Main.netMode == 2)
										{
											NetMessage.SendData(28, -1, -1, "", n, 9999f, 10f, (float)(-(float)Main.npc[n].direction), 0);
										}
										Main.npc[n].StrikeNPC(9999, 10f, -Main.npc[n].direction, false, false);
										NPC.SpawnWOF(this.position);
									}
								}
								NetMessage.SendData(21, -1, -1, "", i, 0f, 0f, 0f, 0);
							}
						}
						else
						{
							if (this.owner == Main.myPlayer && this.type != 312 && this.type != 318 && this.type != 173 && this.type != 174 && this.type != 175 && this.rare == 0)
							{
								this.active = false;
								this.type = 0;
								this.name = "";
								this.stack = 0;
								if (Main.netMode != 0)
								{
									NetMessage.SendData(21, -1, -1, "", i, 0f, 0f, 0f, 0);
								}
							}
						}
					}
					if (this.type == 520)
					{
						float num10 = (float)Main.rand.Next(90, 111) * 0.01f;
						num10 *= Main.essScale;
						Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.5f * num10, 0.1f * num10, 0.25f * num10);
					}
					else
					{
						if (this.type == 521)
						{
							float num11 = (float)Main.rand.Next(90, 111) * 0.01f;
							num11 *= Main.essScale;
							Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.25f * num11, 0.1f * num11, 0.5f * num11);
						}
						else
						{
							if (this.type == 547)
							{
								float num12 = (float)Main.rand.Next(90, 111) * 0.01f;
								num12 *= Main.essScale;
								Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.5f * num12, 0.3f * num12, 0.05f * num12);
							}
							else
							{
								if (this.type == 548)
								{
									float num13 = (float)Main.rand.Next(90, 111) * 0.01f;
									num13 *= Main.essScale;
									Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.1f * num13, 0.1f * num13, 0.6f * num13);
								}
								else
								{
									if (this.type == 575)
									{
										float num14 = (float)Main.rand.Next(90, 111) * 0.01f;
										num14 *= Main.essScale;
										Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.1f * num14, 0.3f * num14, 0.5f * num14);
									}
									else
									{
										if (this.type == 549)
										{
											float num15 = (float)Main.rand.Next(90, 111) * 0.01f;
											num15 *= Main.essScale;
											Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.1f * num15, 0.5f * num15, 0.2f * num15);
										}
										else
										{
											if (this.type == 58)
											{
												float num16 = (float)Main.rand.Next(90, 111) * 0.01f;
												num16 *= Main.essScale * 0.5f;
												Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.5f * num16, 0.1f * num16, 0.1f * num16);
											}
											else
											{
												if (this.type == 184)
												{
													float num17 = (float)Main.rand.Next(90, 111) * 0.01f;
													num17 *= Main.essScale * 0.5f;
													Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.1f * num17, 0.1f * num17, 0.5f * num17);
												}
												else
												{
													if (this.type == 522)
													{
														float num18 = (float)Main.rand.Next(90, 111) * 0.01f;
														num18 *= Main.essScale * 0.2f;
														Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.5f * num18, 1f * num18, 0.1f * num18);
													}
													else
													{
														if (this.type == 1332)
														{
															float num19 = (float)Main.rand.Next(90, 111) * 0.01f;
															num19 *= Main.essScale * 0.2f;
															Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 1f * num19, 1f * num19, 0.1f * num19);
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
					if (this.type == 75 && Main.dayTime)
					{
						for (int num20 = 0; num20 < 10; num20++)
						{
							Dust.NewDust(this.position, this.width, this.height, 15, this.velocity.X, this.velocity.Y, 150, default(Color), 1.2f);
						}
						for (int num21 = 0; num21 < 3; num21++)
						{
							Gore.NewGore(this.position, new Vector2(this.velocity.X, this.velocity.Y), Main.rand.Next(16, 18), 1f);
						}
						this.active = false;
						this.type = 0;
						this.stack = 0;
						if (Main.netMode == 2)
						{
							NetMessage.SendData(21, -1, -1, "", i, 0f, 0f, 0f, 0);
						}
					}
				}
				else
				{
					this.beingGrabbed = false;
				}
				if (this.type == 501)
				{
					if (Main.rand.Next(6) == 0)
					{
						int num22 = Dust.NewDust(this.position, this.width, this.height, 55, 0f, 0f, 200, this.color, 1f);
						Main.dust[num22].velocity *= 0.3f;
						Main.dust[num22].scale *= 0.5f;
					}
				}
				else
				{
					if (this.type == 8 || this.type == 105)
					{
						if (!this.wet)
						{
							Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 1f, 0.95f, 0.8f);
						}
					}
					else
					{
						if (this.type == 523)
						{
							Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.85f, 1f, 0.7f);
						}
						else
						{
							if (this.type == 1333)
							{
								Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 1.25f, 1.25f, 0.8f);
							}
							else
							{
								if (this.type >= 427 && this.type <= 432)
								{
									if (!this.wet)
									{
										float r = 0f;
										float g = 0f;
										float b = 0f;
										int num23 = this.type - 426;
										if (num23 == 1)
										{
											r = 0.1f;
											g = 0.2f;
											b = 1.1f;
										}
										if (num23 == 2)
										{
											r = 1f;
											g = 0.1f;
											b = 0.1f;
										}
										if (num23 == 3)
										{
											r = 0f;
											g = 1f;
											b = 0.1f;
										}
										if (num23 == 4)
										{
											r = 0.9f;
											g = 0f;
											b = 0.9f;
										}
										if (num23 == 5)
										{
											r = 1.3f;
											g = 1.3f;
											b = 1.3f;
										}
										if (num23 == 6)
										{
											r = 0.9f;
											g = 0.9f;
											b = 0f;
										}
										Lighting.addLight((int)((this.position.X + (float)(this.width / 2)) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), r, g, b);
									}
								}
								else
								{
									if (this.type == 41)
									{
										if (!this.wet)
										{
											Lighting.addLight((int)((this.position.X + (float)this.width) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 1f, 0.75f, 0.55f);
										}
									}
									else
									{
										if (this.type == 988)
										{
											if (!this.wet)
											{
												Lighting.addLight((int)((this.position.X + (float)this.width) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.35f, 0.65f, 1f);
											}
										}
										else
										{
											if (this.type == 282)
											{
												Lighting.addLight((int)((this.position.X + (float)this.width) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.7f, 1f, 0.8f);
											}
											else
											{
												if (this.type == 286)
												{
													Lighting.addLight((int)((this.position.X + (float)this.width) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.7f, 0.8f, 1f);
												}
												else
												{
													if (this.type == 331)
													{
														Lighting.addLight((int)((this.position.X + (float)this.width) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.55f, 0.75f, 0.6f);
													}
													else
													{
														if (this.type == 183)
														{
															Lighting.addLight((int)((this.position.X + (float)this.width) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.15f, 0.45f, 0.9f);
														}
														else
														{
															if (this.type == 75)
															{
																Lighting.addLight((int)((this.position.X + (float)this.width) / 16f), (int)((this.position.Y + (float)(this.height / 2)) / 16f), 0.8f, 0.7f, 0.1f);
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
				if (this.type == 75)
				{
					if (Main.rand.Next(25) == 0)
					{
						Dust.NewDust(this.position, this.width, this.height, 58, this.velocity.X * 0.5f, this.velocity.Y * 0.5f, 150, default(Color), 1.2f);
					}
					if (Main.rand.Next(50) == 0)
					{
						Gore.NewGore(this.position, new Vector2(this.velocity.X * 0.2f, this.velocity.Y * 0.2f), Main.rand.Next(16, 18), 1f);
					}
				}
				if (this.spawnTime < 2147483646)
				{
					this.spawnTime++;
				}
				if (Main.netMode == 2 && this.owner != Main.myPlayer)
				{
					this.release++;
					if (this.release >= 300)
					{
						this.release = 0;
						NetMessage.SendData(39, this.owner, -1, "", i, 0f, 0f, 0f, 0);
					}
				}
				if (this.wet)
				{
					this.position += value;
				}
				else
				{
					this.position += this.velocity;
				}
				if (this.noGrabDelay > 0)
				{
					this.noGrabDelay--;
				}
			}
		}
		public static int NewItem(int X, int Y, int Width, int Height, int Type, int Stack = 1, bool noBroadcast = false, int pfix = 0, bool noGrabDelay = false)
		{
			if (Main.rand == null)
			{
				Main.rand = new Random();
			}
			if (WorldGen.gen)
			{
				return 0;
			}
			int num = 400;
			Main.item[400] = new Item();
			if (Main.netMode != 1)
			{
				for (int i = 0; i < 400; i++)
				{
					if (!Main.item[i].active)
					{
						num = i;
						break;
					}
				}
			}
			if (num == 400 && Main.netMode != 1)
			{
				int num2 = 0;
				for (int j = 0; j < 400; j++)
				{
					if (Main.item[j].spawnTime > num2)
					{
						num2 = Main.item[j].spawnTime;
						num = j;
					}
				}
			}
			Main.item[num] = new Item();
			Main.item[num].SetDefaults(Type, false);
			Main.item[num].Prefix(pfix);
			Main.item[num].position.X = (float)(X + Width / 2 - Main.item[num].width / 2);
			Main.item[num].position.Y = (float)(Y + Height / 2 - Main.item[num].height / 2);
			Main.item[num].wet = Collision.WetCollision(Main.item[num].position, Main.item[num].width, Main.item[num].height);
			Main.item[num].velocity.X = (float)Main.rand.Next(-30, 31) * 0.1f;
			Main.item[num].velocity.Y = (float)Main.rand.Next(-40, -15) * 0.1f;
			if (Type == 859)
			{
				Main.item[num].velocity *= 0f;
			}
			if (Type == 520 || Type == 521)
			{
				Main.item[num].velocity.X = (float)Main.rand.Next(-30, 31) * 0.1f;
				Main.item[num].velocity.Y = (float)Main.rand.Next(-30, 31) * 0.1f;
			}
			Main.item[num].active = true;
			Main.item[num].spawnTime = 0;
			Main.item[num].stack = Stack;
			if (Main.netMode == 2 && !noBroadcast)
			{
				int num3 = 0;
				if (noGrabDelay)
				{
					num3 = 1;
				}
				NetMessage.SendData(21, -1, -1, "", num, (float)num3, 0f, 0f, 0);
				Main.item[num].FindOwner(num);
			}
			else
			{
				if (Main.netMode == 0)
				{
					Main.item[num].owner = Main.myPlayer;
				}
			}
			return num;
		}
		public void FindOwner(int whoAmI)
		{
			if (this.keepTime > 0)
			{
				return;
			}
			int num = this.owner;
			this.owner = 255;
			float num2 = -1f;
			for (int i = 0; i < 255; i++)
			{
				if (this.ownIgnore != i && Main.player[i].active && Main.player[i].ItemSpace(Main.item[whoAmI]))
				{
					float num3 = Math.Abs(Main.player[i].position.X + (float)(Main.player[i].width / 2) - this.position.X - (float)(this.width / 2)) + Math.Abs(Main.player[i].position.Y + (float)(Main.player[i].height / 2) - this.position.Y - (float)this.height);
					if (num3 < (float)NPC.sWidth && (num2 == -1f || num3 < num2))
					{
						num2 = num3;
						this.owner = i;
					}
				}
			}
			if (this.owner != num && ((num == Main.myPlayer && Main.netMode == 1) || (num == 255 && Main.netMode == 2) || !Main.player[num].active))
			{
				NetMessage.SendData(21, -1, -1, "", whoAmI, 0f, 0f, 0f, 0);
				if (this.active)
				{
					NetMessage.SendData(22, -1, -1, "", whoAmI, 0f, 0f, 0f, 0);
				}
			}
		}
		public object Clone()
		{
			return base.MemberwiseClone();
		}
		public bool IsTheSameAs(Item compareItem)
		{
			return this.netID == compareItem.netID && this.type == compareItem.type;
		}
		public bool IsNotTheSameAs(Item compareItem)
		{
			return this.netID != compareItem.netID || this.stack != compareItem.stack || this.prefix != compareItem.prefix;
		}
	}
}
