using Microsoft.Xna.Framework;
using System;
using System.Diagnostics;
using System.IO;
namespace Terraria
{
	public class Map
	{
		public static int maxUpdateTile = 1000;
		public static int numUpdateTile = 0;
		public static short[] updateTileX = new short[Map.maxUpdateTile];
		public static short[] updateTileY = new short[Map.maxUpdateTile];
		public static bool saveLock = false;
		private static object padlock = new object();
		public byte type;
		public byte light;
		public byte misc;
		public byte misc2;
		public bool isTheSameAs(Map newMap, int j, int c)
		{
			if (this.light == newMap.light && this.color() == 0 && newMap.color() == 0)
			{
				if (this.active())
				{
					if (newMap.active() && this.type == newMap.type && this.option() == newMap.option())
					{
						return true;
					}
				}
				else
				{
					if (this.lava())
					{
						if (newMap.lava())
						{
							return true;
						}
					}
					else
					{
						if (this.water())
						{
							if (newMap.water())
							{
								return true;
							}
						}
						else
						{
							if (this.honey())
							{
								if (newMap.honey())
								{
									return true;
								}
							}
							else
							{
								if (this.wall())
								{
									if (newMap.wall() && this.type == newMap.type && this.type != 27)
									{
										return true;
									}
								}
								else
								{
									if (!this.active() && !newMap.active() && !newMap.lava() && !newMap.water() && !newMap.wall())
									{
										if ((double)j > Main.worldSurface)
										{
											if ((double)j < Main.rockLayer)
											{
												if ((double)c > Main.worldSurface && (double)c < Main.rockLayer && this.type == newMap.type)
												{
													return true;
												}
											}
											else
											{
												if (j < Main.maxTilesY - 200)
												{
													if ((double)c >= Main.rockLayer && c < Main.maxTilesY - 200 && this.type == newMap.type)
													{
														return true;
													}
												}
												else
												{
													if (c >= Main.maxTilesY - 200)
													{
														return true;
													}
												}
											}
										}
										else
										{
											if (j == c)
											{
												return true;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return false;
		}
		public bool active()
		{
			return (this.misc & 1) == 1;
		}
		public void active(bool active)
		{
			if (active)
			{
				this.misc |= 1;
				return;
			}
			this.misc = (byte)((int)this.misc & -2);
		}
		public bool water()
		{
			return (this.misc & 2) == 2;
		}
		public void water(bool water)
		{
			if (water)
			{
				this.misc |= 2;
				return;
			}
			this.misc = (byte)((int)this.misc & -3);
		}
		public bool lava()
		{
			return (this.misc & 4) == 4;
		}
		public void lava(bool lava)
		{
			if (lava)
			{
				this.misc |= 4;
				return;
			}
			this.misc = (byte)((int)this.misc & -5);
		}
		public bool honey()
		{
			return (this.misc2 & 64) == 64;
		}
		public void honey(bool honey)
		{
			if (honey)
			{
				this.misc2 |= 64;
				return;
			}
			this.misc2 = (byte)((int)this.misc2 & -65);
		}
		public bool changed()
		{
			return (this.misc & 8) == 8;
		}
		public void changed(bool changed)
		{
			if (changed)
			{
				this.misc |= 8;
				return;
			}
			this.misc = (byte)((int)this.misc & -9);
		}
		public bool wall()
		{
			return (this.misc & 16) == 16;
		}
		public void wall(bool wall)
		{
			if (wall)
			{
				this.misc |= 16;
				return;
			}
			this.misc = (byte)((int)this.misc & -17);
		}
		public byte option()
		{
			byte b = 0;
			if ((this.misc & 32) == 32)
			{
				b += 1;
			}
			if ((this.misc & 64) == 64)
			{
				b += 2;
			}
			if ((this.misc & 128) == 128)
			{
				b += 4;
			}
			if ((this.misc2 & 1) == 1)
			{
				b += 8;
			}
			return b;
		}
		public void option(byte option)
		{
			if ((option & 1) == 1)
			{
				this.misc |= 32;
			}
			else
			{
				this.misc = (byte)((int)this.misc & -33);
			}
			if ((option & 2) == 2)
			{
				this.misc |= 64;
			}
			else
			{
				this.misc = (byte)((int)this.misc & -65);
			}
			if ((option & 4) == 4)
			{
				this.misc |= 128;
			}
			else
			{
				this.misc = (byte)((int)this.misc & -129);
			}
			if ((option & 8) == 8)
			{
				this.misc2 |= 1;
				return;
			}
			this.misc2 = (byte)((int)this.misc2 & -2);
		}
		public byte color()
		{
			byte b = 0;
			if ((this.misc2 & 2) == 2)
			{
				b += 1;
			}
			if ((this.misc2 & 4) == 4)
			{
				b += 2;
			}
			if ((this.misc2 & 8) == 8)
			{
				b += 4;
			}
			if ((this.misc2 & 16) == 16)
			{
				b += 8;
			}
			if ((this.misc2 & 32) == 32)
			{
				b += 16;
			}
			return b;
		}
		public void color(byte color)
		{
			if (color > 27)
			{
				color = 27;
			}
			if ((color & 1) == 1)
			{
				this.misc2 |= 2;
			}
			else
			{
				this.misc2 = (byte)((int)this.misc2 & -3);
			}
			if ((color & 2) == 2)
			{
				this.misc2 |= 4;
			}
			else
			{
				this.misc2 = (byte)((int)this.misc2 & -5);
			}
			if ((color & 4) == 4)
			{
				this.misc2 |= 8;
			}
			else
			{
				this.misc2 = (byte)((int)this.misc2 & -9);
			}
			if ((color & 8) == 8)
			{
				this.misc2 |= 16;
			}
			else
			{
				this.misc2 = (byte)((int)this.misc2 & -17);
			}
			if ((color & 16) == 16)
			{
				this.misc2 |= 32;
				return;
			}
			this.misc2 = (byte)((int)this.misc2 & -33);
		}
		public object Clone()
		{
			return base.MemberwiseClone();
		}
		public static void clearMap()
		{
			try
			{
				for (int i = 0; i < Main.maxTilesX; i++)
				{
					float num = (float)i / (float)Main.maxTilesX;
					Main.statusText = string.Concat(new object[]
					{
						Lang.gen[65],
						" ",
						(int)(num * 100f + 1f),
						"%"
					});
					for (int j = 0; j < Main.maxTilesY; j++)
					{
						if (Main.map[i, j] != null)
						{
							Main.map[i, j] = null;
						}
					}
				}
			}
			catch
			{
			}
		}
		public static void loadMap()
		{
			Map.saveLock = false;
			if (!Main.mapEnabled)
			{
				return;
			}
			string text = Main.playerPathName.Substring(0, Main.playerPathName.Length - 4);
			string path = string.Concat(new object[]
			{
				text,
				Path.DirectorySeparatorChar,
				Main.worldID,
				".map"
			});
			if (!File.Exists(path))
			{
				return;
			}
			using (FileStream fileStream = new FileStream(path, FileMode.Open))
			{
				using (BinaryReader binaryReader = new BinaryReader(fileStream))
				{
					try
					{
						int num = binaryReader.ReadInt32();
						if (num > Main.curRelease)
						{
							try
							{
								binaryReader.Close();
								fileStream.Close();
							}
							catch
							{
							}
						}
						else
						{
							Main.worldName = binaryReader.ReadString();
							Main.worldID = binaryReader.ReadInt32();
							Main.maxTilesY = binaryReader.ReadInt32();
							Main.maxTilesX = binaryReader.ReadInt32();
							for (int i = 0; i < Main.maxTilesX; i++)
							{
								float num2 = (float)i / (float)Main.maxTilesX;
								Main.statusText = string.Concat(new object[]
								{
									Lang.gen[67],
									" ",
									(int)(num2 * 100f + 1f),
									"%"
								});
								for (int j = 0; j < Main.maxTilesY; j++)
								{
									bool flag = binaryReader.ReadBoolean();
									Main.map[i, j] = new Map();
									if (flag)
									{
										Main.map[i, j].type = binaryReader.ReadByte();
										Main.map[i, j].light = binaryReader.ReadByte();
										Main.map[i, j].misc = binaryReader.ReadByte();
										if (num >= 50)
										{
											Main.map[i, j].misc2 = binaryReader.ReadByte();
										}
										else
										{
											Main.map[i, j].misc2 = 0;
										}
										Main.map[i, j].changed(true);
										int num3 = (int)binaryReader.ReadInt16();
										if (Main.map[i, j].light == 255)
										{
											if (num3 > 0)
											{
												for (int k = j + 1; k < j + num3 + 1; k++)
												{
													Main.map[i, k] = new Map();
													Main.map[i, k].type = Main.map[i, j].type;
													Main.map[i, k].misc = Main.map[i, j].misc;
													Main.map[i, k].misc2 = Main.map[i, j].misc2;
													Main.map[i, k].light = Main.map[i, j].light;
													Main.map[i, k].changed(true);
												}
												j += num3;
											}
										}
										else
										{
											if (num3 > 0)
											{
												for (int l = j + 1; l < j + num3 + 1; l++)
												{
													byte b = binaryReader.ReadByte();
													if (b > 18)
													{
														Main.map[i, l] = new Map();
														Main.map[i, l].type = Main.map[i, j].type;
														Main.map[i, l].misc = Main.map[i, j].misc;
														Main.map[i, l].misc2 = Main.map[i, j].misc2;
														Main.map[i, l].light = b;
														Main.map[i, l].changed(true);
													}
												}
												j += num3;
											}
										}
									}
									else
									{
										int num4 = (int)binaryReader.ReadInt16();
										if (num4 > 0)
										{
											j += num4;
											if (Main.map[i, j] != null)
											{
												Main.map[i, j] = new Map();
											}
										}
									}
								}
							}
							binaryReader.Close();
							fileStream.Close();
							Main.clearMap = true;
							Main.loadMap = true;
							Main.loadMapLock = true;
							Main.refreshMap = false;
						}
					}
					catch
					{
						Map.clearMap();
					}
				}
			}
		}
		public static void saveMap()
		{
			if (!Main.mapEnabled)
			{
				return;
			}
			if (Map.saveLock)
			{
				return;
			}
			string text = Main.playerPathName.Substring(0, Main.playerPathName.Length - 4);
			lock (Map.padlock)
			{
				try
				{
					Map.saveLock = true;
					try
					{
						Directory.CreateDirectory(text);
					}
					catch
					{
					}
					text = string.Concat(new object[]
					{
						text,
						Path.DirectorySeparatorChar,
						Main.worldID,
						".map"
					});
					Stopwatch stopwatch = new Stopwatch();
					stopwatch.Start();
					string text2 = text + ".sav";
					bool flag2 = false;
					if (!Main.gameMenu)
					{
						flag2 = true;
					}
					using (FileStream fileStream = new FileStream(text2, FileMode.Create))
					{
						using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
						{
							binaryWriter.Write(Main.curRelease);
							binaryWriter.Write(Main.worldName);
							binaryWriter.Write(Main.worldID);
							binaryWriter.Write(Main.maxTilesY);
							binaryWriter.Write(Main.maxTilesX);
							for (int i = 0; i < Main.maxTilesX; i++)
							{
								if (!flag2)
								{
									float num = (float)i / (float)Main.maxTilesX;
									Main.statusText = string.Concat(new object[]
									{
										Lang.gen[66],
										" ",
										(int)(num * 100f + 1f),
										"%"
									});
								}
								for (int j = 0; j < Main.maxTilesY; j++)
								{
									bool value = false;
									if (Main.map[i, j] != null && Main.map[i, j].light > 18)
									{
										value = true;
										binaryWriter.Write(value);
										binaryWriter.Write(Main.map[i, j].type);
										binaryWriter.Write(Main.map[i, j].light);
										binaryWriter.Write(Main.map[i, j].misc);
										binaryWriter.Write(Main.map[i, j].misc2);
										int num2 = 1;
										if (Main.map[i, j].light == 255)
										{
											while (j + num2 < Main.maxTilesY && Main.map[i, j + num2] != null && Main.map[i, j].type == Main.map[i, j + num2].type && Main.map[i, j].misc == Main.map[i, j + num2].misc && Main.map[i, j].misc2 == Main.map[i, j + num2].misc2 && Main.map[i, j + num2].light == 255)
											{
												num2++;
											}
											num2--;
											binaryWriter.Write((short)num2);
											j += num2;
										}
										else
										{
											while (j + num2 < Main.maxTilesY && Main.map[i, j + num2] != null && Main.map[i, j + num2].light > 18 && Main.map[i, j].type == Main.map[i, j + num2].type && Main.map[i, j].misc == Main.map[i, j + num2].misc && Main.map[i, j].misc2 == Main.map[i, j + num2].misc2)
											{
												num2++;
											}
											num2--;
											binaryWriter.Write((short)num2);
											if (num2 > 0)
											{
												for (int k = j + 1; k < j + num2 + 1; k++)
												{
													binaryWriter.Write(Main.map[i, k].light);
												}
											}
											j += num2;
										}
									}
									else
									{
										binaryWriter.Write(value);
										int num3 = 1;
										while (j + num3 < Main.maxTilesY && (Main.map[i, j + num3] == null || Main.map[i, j + num3].light == 0))
										{
											num3++;
										}
										num3--;
										binaryWriter.Write((short)num3);
										j += num3;
									}
								}
							}
							binaryWriter.Close();
							fileStream.Close();
							File.Copy(text2, text, true);
							File.Delete(text2);
						}
					}
				}
				catch
				{
				}
				Map.saveLock = false;
			}
		}
		public Color mapColor(Color oldColor)
		{
			Color color = WorldGen.paintColor((int)this.color());
			float num = (float)oldColor.R / 255f;
			float num2 = (float)oldColor.G / 255f;
			float num3 = (float)oldColor.B / 255f;
			if (num2 > num)
			{
				num = num2;
			}
			if (num3 > num)
			{
				num = num3;
			}
			float num4 = num;
			byte r = (byte)((float)color.R * num4);
			byte g = (byte)((float)color.G * num4);
			byte b = (byte)((float)color.B * num4);
			return new Color((int)r, (int)g, (int)b, (int)oldColor.A);
		}
		public Color tileColor(int j)
		{
			if (this.active())
			{
				switch (this.type)
				{
				case 0:
				case 5:
				case 30:
				case 191:
					return new Color(151, 107, 75);
				case 1:
				case 38:
				case 48:
				case 130:
				case 138:
					return new Color(128, 128, 128);
				case 2:
					return new Color(28, 216, 94);
				case 3:
				case 192:
					return new Color(26, 196, 84);
				case 4:
					if (this.option() == 0)
					{
						return new Color(169, 125, 93);
					}
					return new Color(253, 221, 3);
				case 6:
					return new Color(140, 101, 80);
				case 7:
				case 47:
					return new Color(150, 67, 22);
				case 8:
				case 45:
					return new Color(185, 164, 23);
				case 9:
				case 46:
					return new Color(185, 194, 195);
				case 10:
				case 11:
					return new Color(119, 105, 79);
				case 12:
					return new Color(174, 24, 69);
				case 13:
					return new Color(133, 213, 247);
				case 14:
				case 15:
				case 18:
				case 19:
				case 55:
				case 79:
				case 86:
				case 87:
				case 88:
				case 89:
				case 94:
				case 101:
				case 104:
				case 106:
				case 114:
				case 128:
				case 139:
				case 216:
					return new Color(191, 142, 111);
				case 16:
					return new Color(140, 130, 116);
				case 17:
				case 90:
				case 96:
				case 97:
				case 99:
				case 132:
				case 142:
				case 143:
				case 144:
				case 207:
				case 209:
				case 212:
				case 217:
				case 218:
				case 219:
				case 220:
				case 228:
					return new Color(144, 148, 144);
				case 20:
					return new Color(163, 116, 81);
				case 21:
					if (this.option() == 0)
					{
						return new Color(174, 129, 92);
					}
					if (this.option() == 1)
					{
						return new Color(233, 207, 94);
					}
					if (this.option() == 2)
					{
						return new Color(137, 128, 200);
					}
					if (this.option() == 3)
					{
						return new Color(160, 160, 160);
					}
					return new Color(106, 210, 255);
				case 22:
				case 140:
					return new Color(98, 95, 167);
				case 23:
					return new Color(141, 137, 223);
				case 24:
					return new Color(122, 116, 218);
				case 25:
					return new Color(109, 90, 128);
				case 26:
					if (this.option() == 1)
					{
						return new Color(214, 127, 133);
					}
					return new Color(119, 101, 125);
				case 27:
					if (this.option() == 1)
					{
						return new Color(226, 196, 49);
					}
					return new Color(54, 154, 54);
				case 28:
					if (this.option() == 0)
					{
						return new Color(151, 79, 80);
					}
					if (this.option() == 1)
					{
						return new Color(90, 139, 140);
					}
					if (this.option() == 2)
					{
						return new Color(192, 136, 70);
					}
					if (this.option() == 3)
					{
						return new Color(203, 185, 151);
					}
					if (this.option() == 4)
					{
						return new Color(73, 56, 41);
					}
					if (this.option() == 5)
					{
						return new Color(148, 159, 67);
					}
					if (this.option() == 6)
					{
						return new Color(138, 172, 67);
					}
					if (this.option() == 8)
					{
						return new Color(198, 87, 93);
					}
					return new Color(226, 122, 47);
				case 29:
					return new Color(175, 105, 128);
				case 31:
					if (this.option() == 1)
					{
						return new Color(212, 105, 105);
					}
					return new Color(141, 120, 168);
				case 32:
					return new Color(151, 135, 183);
				case 33:
				case 93:
				case 98:
				case 100:
				case 173:
				case 174:
					return new Color(253, 221, 3);
				case 34:
					return new Color(235, 166, 135);
				case 35:
					return new Color(197, 216, 219);
				case 36:
				case 102:
					return new Color(229, 212, 73);
				case 37:
					return new Color(104, 86, 84);
				case 39:
					return new Color(181, 62, 59);
				case 40:
					return new Color(146, 81, 68);
				case 41:
					return new Color(66, 84, 109);
				case 42:
					return new Color(251, 235, 127);
				case 43:
					return new Color(84, 100, 63);
				case 44:
					return new Color(107, 68, 99);
				case 49:
					return new Color(89, 201, 255);
				case 50:
					return new Color(170, 48, 114);
				case 51:
					return new Color(192, 202, 203);
				case 52:
					return new Color(23, 177, 76);
				case 53:
					return new Color(186, 168, 84);
				case 54:
					return new Color(200, 246, 254);
				case 56:
					return new Color(43, 40, 84);
				case 57:
					return new Color(68, 68, 76);
				case 58:
				case 76:
					return new Color(142, 66, 66);
				case 59:
				case 120:
					return new Color(92, 68, 73);
				case 60:
					return new Color(143, 215, 29);
				case 61:
					return new Color(135, 196, 26);
				case 62:
					return new Color(121, 176, 24);
				case 63:
					return new Color(110, 140, 182);
				case 64:
					return new Color(196, 96, 114);
				case 65:
					return new Color(56, 150, 97);
				case 66:
					return new Color(160, 118, 58);
				case 67:
					return new Color(140, 58, 166);
				case 68:
					return new Color(125, 191, 197);
				case 69:
					return new Color(190, 150, 92);
				case 70:
					return new Color(93, 127, 255);
				case 71:
				case 72:
				case 190:
					return new Color(182, 175, 130);
				case 73:
					return new Color(27, 197, 109);
				case 74:
					return new Color(96, 197, 27);
				case 75:
					return new Color(26, 26, 26);
				case 77:
					return new Color(238, 85, 70);
				case 78:
					return new Color(121, 110, 97);
				case 80:
				case 188:
					return new Color(73, 120, 17);
				case 81:
					return new Color(245, 133, 191);
				case 82:
				case 83:
				case 84:
					if (this.option() == 0)
					{
						return new Color(246, 197, 26);
					}
					if (this.option() == 1)
					{
						return new Color(76, 150, 216);
					}
					if (this.option() == 2)
					{
						return new Color(185, 214, 42);
					}
					if (this.option() == 3)
					{
						return new Color(167, 203, 37);
					}
					if (this.option() == 4)
					{
						return new Color(72, 145, 125);
					}
					return new Color(177, 69, 49);
				case 85:
					return new Color(192, 192, 192);
				case 91:
					return new Color(13, 88, 130);
				case 92:
					return new Color(213, 229, 237);
				case 95:
					return new Color(255, 162, 31);
				case 103:
					return new Color(141, 98, 77);
				case 105:
					if (this.option() == 1)
					{
						return new Color(177, 92, 31);
					}
					if (this.option() == 2)
					{
						return new Color(201, 188, 170);
					}
					return new Color(144, 148, 144);
				case 107:
				case 121:
					return new Color(11, 80, 143);
				case 108:
				case 122:
					return new Color(91, 169, 169);
				case 109:
					return new Color(78, 193, 227);
				case 110:
					return new Color(48, 186, 135);
				case 111:
				case 150:
					return new Color(128, 26, 52);
				case 112:
					return new Color(103, 98, 122);
				case 113:
					return new Color(48, 208, 234);
				case 115:
					return new Color(33, 171, 207);
				case 116:
				case 118:
					return new Color(238, 225, 218);
				case 117:
					return new Color(181, 172, 190);
				case 119:
					return new Color(107, 92, 108);
				case 123:
					return new Color(106, 107, 118);
				case 124:
					return new Color(73, 51, 36);
				case 125:
					return new Color(141, 175, 255);
				case 126:
					return new Color(159, 209, 229);
				case 129:
					return new Color(255, 117, 224);
				case 131:
					return new Color(52, 52, 52);
				case 133:
					if (this.option() == 0)
					{
						return new Color(231, 53, 56);
					}
					return new Color(192, 189, 221);
				case 134:
					if (this.option() == 0)
					{
						return new Color(166, 187, 153);
					}
					return new Color(241, 129, 249);
				case 136:
					return new Color(213, 203, 204);
				case 137:
					if (this.option() == 0)
					{
						return new Color(144, 148, 144);
					}
					return new Color(141, 56, 0);
				case 141:
					return new Color(192, 59, 59);
				case 145:
					return new Color(192, 30, 30);
				case 146:
					return new Color(43, 192, 30);
				case 147:
				case 148:
					return new Color(211, 236, 241);
				case 149:
					if (j % 3 == 0)
					{
						return new Color(220, 50, 50);
					}
					if (j % 3 == 1)
					{
						return new Color(0, 220, 50);
					}
					return new Color(50, 50, 220);
				case 151:
				case 154:
					return new Color(190, 171, 94);
				case 152:
					return new Color(128, 133, 184);
				case 153:
					return new Color(239, 141, 126);
				case 155:
					return new Color(131, 162, 161);
				case 156:
					return new Color(170, 171, 157);
				case 157:
					return new Color(104, 100, 126);
				case 158:
				case 232:
					return new Color(145, 81, 85);
				case 159:
					return new Color(148, 133, 98);
				case 160:
					if (j % 3 == 0)
					{
						return new Color(200, 0, 0);
					}
					if (j % 3 == 1)
					{
						return new Color(0, 200, 0);
					}
					return new Color(0, 0, 200);
				case 161:
					return new Color(144, 195, 232);
				case 162:
					return new Color(184, 219, 240);
				case 163:
					return new Color(174, 145, 214);
				case 164:
					return new Color(218, 182, 204);
				case 165:
					if (this.option() == 0)
					{
						return new Color(115, 173, 229);
					}
					if (this.option() == 1)
					{
						return new Color(100, 100, 100);
					}
					if (this.option() == 2)
					{
						return new Color(152, 152, 152);
					}
					return new Color(227, 125, 22);
				case 166:
				case 175:
					return new Color(129, 125, 93);
				case 167:
					return new Color(62, 82, 114);
				case 168:
				case 176:
					return new Color(132, 157, 127);
				case 169:
				case 177:
					return new Color(152, 171, 198);
				case 170:
					return new Color(228, 219, 162);
				case 171:
					return new Color(177, 192, 176);
				case 172:
					return new Color(181, 194, 217);
				case 178:
					if (this.option() == 0)
					{
						return new Color(208, 94, 201);
					}
					if (this.option() == 1)
					{
						return new Color(233, 146, 69);
					}
					if (this.option() == 2)
					{
						return new Color(71, 146, 251);
					}
					if (this.option() == 3)
					{
						return new Color(60, 226, 133);
					}
					if (this.option() == 4)
					{
						return new Color(250, 30, 71);
					}
					if (this.option() == 6)
					{
						return new Color(255, 217, 120);
					}
					return new Color(166, 176, 204);
				case 179:
					return new Color(49, 134, 114);
				case 180:
					return new Color(126, 134, 49);
				case 181:
					return new Color(134, 59, 49);
				case 182:
					return new Color(43, 86, 140);
				case 183:
					return new Color(121, 49, 134);
				case 184:
					if (this.option() == 0)
					{
						return new Color(29, 106, 88);
					}
					if (this.option() == 1)
					{
						return new Color(94, 100, 36);
					}
					if (this.option() == 2)
					{
						return new Color(96, 44, 40);
					}
					if (this.option() == 3)
					{
						return new Color(34, 63, 102);
					}
					return new Color(79, 35, 95);
				case 185:
				case 186:
				case 187:
					if (this.option() == 0)
					{
						return new Color(99, 99, 99);
					}
					if (this.option() == 1)
					{
						return new Color(114, 81, 56);
					}
					if (this.option() == 2)
					{
						return new Color(133, 133, 101);
					}
					if (this.option() == 3)
					{
						return new Color(151, 200, 211);
					}
					if (this.option() == 4)
					{
						return new Color(177, 183, 161);
					}
					if (this.option() == 5)
					{
						return new Color(134, 114, 38);
					}
					if (this.option() == 6)
					{
						return new Color(82, 62, 66);
					}
					if (this.option() == 7)
					{
						return new Color(143, 117, 121);
					}
					if (this.option() == 8)
					{
						return new Color(177, 92, 31);
					}
					return new Color(85, 73, 87);
				case 189:
					return new Color(223, 255, 255);
				case 193:
					return new Color(56, 121, 255);
				case 194:
					return new Color(157, 157, 107);
				case 195:
					return new Color(134, 22, 34);
				case 196:
					return new Color(147, 144, 178);
				case 197:
					return new Color(97, 200, 225);
				case 198:
					return new Color(62, 61, 52);
				case 199:
					return new Color(208, 80, 80);
				case 200:
					return new Color(216, 152, 144);
				case 201:
					return new Color(203, 61, 64);
				case 202:
					return new Color(213, 178, 28);
				case 203:
					return new Color(128, 44, 45);
				case 204:
					return new Color(125, 55, 65);
				case 205:
					return new Color(186, 50, 52);
				case 206:
					return new Color(124, 175, 201);
				case 208:
					return new Color(88, 105, 118);
				case 211:
					return new Color(191, 233, 115);
				case 213:
					return new Color(137, 120, 67);
				case 214:
					return new Color(103, 103, 103);
				case 215:
					return new Color(254, 121, 2);
				case 221:
					return new Color(239, 90, 50);
				case 222:
					return new Color(231, 96, 228);
				case 223:
					return new Color(57, 85, 101);
				case 224:
					return new Color(107, 132, 139);
				case 225:
					return new Color(227, 125, 22);
				case 226:
					return new Color(141, 56, 0);
				case 227:
					if (this.option() == 0)
					{
						return new Color(74, 197, 155);
					}
					if (this.option() == 1)
					{
						return new Color(54, 153, 88);
					}
					if (this.option() == 2)
					{
						return new Color(63, 126, 207);
					}
					if (this.option() == 3)
					{
						return new Color(240, 180, 4);
					}
					if (this.option() == 4)
					{
						return new Color(45, 68, 168);
					}
					if (this.option() == 5)
					{
						return new Color(61, 92, 0);
					}
					if (this.option() == 6)
					{
						return new Color(216, 112, 152);
					}
					return new Color(200, 40, 24);
				case 229:
					return new Color(255, 156, 12);
				case 230:
					return new Color(131, 79, 13);
				case 231:
					return new Color(224, 194, 101);
				case 233:
					return new Color(107, 182, 29);
				case 234:
					return new Color(53, 44, 41);
				case 235:
					return new Color(214, 184, 46);
				case 236:
					return new Color(149, 232, 87);
				case 237:
					return new Color(255, 241, 51);
				case 238:
					return new Color(225, 128, 206);
				case 239:
					return new Color(224, 194, 101);
				case 240:
					if (this.option() == 1)
					{
						return new Color(99, 50, 30);
					}
					if (this.option() == 2)
					{
						return new Color(153, 153, 117);
					}
					return new Color(120, 85, 60);
				case 241:
					return new Color(77, 74, 72);
				case 242:
				case 245:
				case 246:
					return new Color(99, 50, 30);
				case 244:
					return new Color(200, 245, 253);
				case 247:
					return new Color(140, 150, 150);
				}
			}
			if (this.lava())
			{
				return new Color(253, 32, 3);
			}
			if (this.water())
			{
				return new Color(9, 61, 191);
			}
			if (this.honey())
			{
				return new Color(254, 194, 20);
			}
			if (this.wall())
			{
				switch (this.type)
				{
				case 1:
				case 5:
				case 44:
				case 48:
				case 49:
				case 50:
				case 51:
				case 52:
				case 53:
					return new Color(52, 52, 52);
				case 2:
				case 16:
				case 59:
					return new Color(88, 61, 46);
				case 3:
					return new Color(61, 58, 78);
				case 4:
					return new Color(73, 51, 36);
				case 6:
					return new Color(91, 30, 30);
				case 7:
				case 17:
					return new Color(27, 31, 42);
				case 8:
				case 18:
					return new Color(31, 39, 26);
				case 9:
				case 19:
					return new Color(41, 28, 36);
				case 10:
					return new Color(74, 62, 12);
				case 11:
					return new Color(46, 56, 59);
				case 12:
					return new Color(75, 32, 11);
				case 13:
					return new Color(67, 37, 37);
				case 14:
				case 20:
					return new Color(15, 15, 15);
				case 15:
					return new Color(52, 43, 45);
				case 22:
					return new Color(113, 99, 99);
				case 23:
					return new Color(38, 38, 43);
				case 24:
					return new Color(53, 39, 41);
				case 25:
					return new Color(11, 35, 62);
				case 26:
					return new Color(21, 63, 70);
				case 27:
					if (j % 2 == 0)
					{
						return new Color(88, 61, 46);
					}
					return new Color(52, 52, 52);
				case 28:
					return new Color(81, 84, 101);
				case 29:
					return new Color(88, 23, 23);
				case 30:
					return new Color(28, 88, 23);
				case 31:
					return new Color(78, 87, 99);
				case 32:
					return new Color(86, 17, 40);
				case 33:
					return new Color(49, 47, 83);
				case 34:
				case 37:
					return new Color(69, 67, 41);
				case 35:
					return new Color(51, 51, 70);
				case 36:
					return new Color(87, 59, 55);
				case 38:
					return new Color(49, 57, 49);
				case 39:
					return new Color(78, 79, 73);
				case 40:
					return new Color(85, 102, 103);
				case 41:
					return new Color(52, 50, 62);
				case 42:
					return new Color(71, 42, 44);
				case 43:
					return new Color(73, 66, 50);
				case 45:
					return new Color(60, 59, 51);
				case 46:
					return new Color(48, 57, 47);
				case 47:
					return new Color(71, 77, 85);
				case 54:
					return new Color(40, 56, 50);
				case 55:
					return new Color(49, 48, 36);
				case 56:
					return new Color(43, 33, 32);
				case 57:
					return new Color(31, 40, 49);
				case 58:
					return new Color(48, 35, 52);
				case 60:
					return new Color(1, 52, 20);
				case 61:
					return new Color(55, 39, 26);
				case 62:
					return new Color(39, 33, 26);
				case 63:
				case 65:
				case 66:
				case 68:
					return new Color(30, 80, 48);
				case 64:
				case 67:
					return new Color(53, 80, 30);
				case 69:
					return new Color(43, 42, 68);
				case 70:
					return new Color(30, 70, 80);
				case 71:
					return new Color(78, 105, 135);
				case 72:
					return new Color(52, 84, 12);
				case 73:
					return new Color(190, 204, 223);
				case 74:
				case 80:
					return new Color(64, 62, 80);
				case 75:
					return new Color(65, 65, 35);
				case 76:
					return new Color(20, 46, 104);
				case 77:
					return new Color(61, 13, 16);
				case 78:
					return new Color(63, 39, 26);
				case 79:
					return new Color(51, 47, 96);
				case 81:
					return new Color(101, 51, 51);
				case 82:
					return new Color(77, 64, 34);
				case 83:
					return new Color(62, 38, 41);
				case 84:
					return new Color(48, 78, 93);
				case 85:
					return new Color(54, 63, 69);
				case 86:
				case 108:
					return new Color(138, 73, 38);
				case 87:
					return new Color(50, 15, 8);
				case 94:
				case 100:
					return new Color(32, 40, 45);
				case 95:
				case 101:
					return new Color(44, 41, 50);
				case 96:
				case 102:
					return new Color(72, 50, 77);
				case 97:
				case 103:
					return new Color(78, 50, 69);
				case 98:
				case 104:
					return new Color(36, 45, 44);
				case 99:
				case 105:
					return new Color(38, 49, 50);
				}
			}
			if ((double)j < Main.worldSurface)
			{
				float num = (float)j / (float)Main.worldSurface;
				float num2 = 1f - num;
				Color color = new Color((int)((byte)(num2 * 50f)), (int)((byte)(num2 * 40f)), (int)((byte)(num2 * 255f)));
				Color color2 = new Color((int)((byte)(num * 145f)), (int)((byte)(num * 185f)), (int)((byte)(num * 255f)));
				Color result = new Color((int)(color.R + color2.R), (int)(color.G + color2.G), (int)(color.B + color2.B));
				float num3 = 1f;
				result = new Color((int)((byte)((float)result.R * num3)), (int)((byte)((float)result.G * num3)), (int)((byte)((float)result.B * num3)), (int)((byte)(255f * num3)));
				return result;
			}
			if ((double)j < Main.rockLayer)
			{
				Color color3 = new Color(88, 61, 46);
				Color color4 = new Color(37, 78, 123);
				float num4 = (float)this.type / 255f;
				float num5 = 1f - num4;
				return new Color((int)((byte)((float)color3.R * num5 + (float)color4.R * num4)), (int)((byte)((float)color3.G * num5 + (float)color4.G * num4)), (int)((byte)((float)color3.B * num5 + (float)color4.B * num4)));
			}
			if (j < Main.maxTilesY - 200)
			{
				Color color5 = new Color(74, 67, 60);
				Color color6 = new Color(53, 70, 97);
				float num6 = (float)this.type / 255f;
				float num7 = 1f - num6;
				return new Color((int)((byte)((float)color5.R * num7 + (float)color6.R * num6)), (int)((byte)((float)color5.G * num7 + (float)color6.G * num6)), (int)((byte)((float)color5.B * num7 + (float)color6.B * num6)));
			}
			return new Color(50, 44, 38);
		}
		public Color getColor(int j)
		{
			Color oldColor = this.tileColor(j);
			if (this.color() > 0)
			{
				oldColor = this.mapColor(oldColor);
			}
			float num = (float)this.light / 255f;
			return new Color((int)((byte)((float)oldColor.R * num)), (int)((byte)((float)oldColor.G * num)), (int)((byte)((float)oldColor.B * num)), 255);
		}
		public void setTile(int i, int j, byte Light)
		{
			if (Main.tile[i, j] == null)
			{
				return;
			}
			bool flag = false;
			if (this.light < Light)
			{
				this.light = Light;
				this.changed(true);
			}
			if (Main.tile[i, j] != null && Main.tile[i, j].active() && Main.tile[i, j].type != 135 && Main.tile[i, j].type != 127 && Main.tile[i, j].type != 210 && (Main.tile[i, j].type != 51 || (i + j) % 2 != 0))
			{
				if (!this.active())
				{
					this.changed(true);
				}
				this.active(true);
				if (this.type != Main.tile[i, j].type)
				{
					this.changed(true);
				}
				this.type = Main.tile[i, j].type;
				if (this.type == 160)
				{
					if (this.color() != 0)
					{
						this.changed(true);
					}
					this.color(0);
				}
				else
				{
					if (this.color() != Main.tile[i, j].color())
					{
						this.changed(true);
					}
					this.color(Main.tile[i, j].color());
				}
				this.lava(false);
				this.water(false);
				this.honey(false);
				flag = true;
				if (Main.tile[i, j].type == 4)
				{
					if (Main.tile[i, j].frameX < 66)
					{
						this.option(1);
					}
					else
					{
						this.option(0);
					}
				}
				else
				{
					if (Main.tile[i, j].type == 21)
					{
						int num = (int)(Main.tile[i, j].frameX / 36);
						if (num == 1 || num == 2 || num == 10 || num == 13 || num == 15)
						{
							this.option(1);
						}
						else
						{
							if (num == 3 || num == 4)
							{
								this.option(2);
							}
							else
							{
								if (num == 6)
								{
									this.option(3);
								}
								else
								{
									if (num == 11 || num == 17)
									{
										this.option(4);
									}
									else
									{
										this.option(0);
									}
								}
							}
						}
					}
					else
					{
						if (Main.tile[i, j].type == 28)
						{
							if (Main.tile[i, j].frameY < 144)
							{
								this.option(0);
							}
							else
							{
								if (Main.tile[i, j].frameY < 252)
								{
									this.option(1);
								}
								else
								{
									if (Main.tile[i, j].frameY < 360 || (Main.tile[i, j].frameY > 900 && Main.tile[i, j].frameY < 1008))
									{
										this.option(2);
									}
									else
									{
										if (Main.tile[i, j].frameY < 468)
										{
											this.option(3);
										}
										else
										{
											if (Main.tile[i, j].frameY < 576)
											{
												this.option(4);
											}
											else
											{
												if (Main.tile[i, j].frameY < 684)
												{
													this.option(5);
												}
												else
												{
													if (Main.tile[i, j].frameY < 792)
													{
														this.option(6);
													}
													else
													{
														if (Main.tile[i, j].frameY < 898)
														{
															this.option(8);
														}
														else
														{
															this.option(7);
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
							if (Main.tile[i, j].type == 27)
							{
								if (Main.tile[i, j].frameY < 34)
								{
									this.option(1);
								}
								else
								{
									this.option(0);
								}
							}
							else
							{
								if (Main.tile[i, j].type == 31)
								{
									if (Main.tile[i, j].frameX > 36)
									{
										this.option(1);
									}
									else
									{
										this.option(0);
									}
								}
								else
								{
									if (Main.tile[i, j].type == 26)
									{
										if (Main.tile[i, j].frameX >= 54)
										{
											this.option(1);
										}
										else
										{
											this.option(0);
										}
									}
									else
									{
										if (Main.tile[i, j].type == 137)
										{
											if (Main.tile[i, j].frameY == 0)
											{
												this.option(0);
											}
											else
											{
												this.option(1);
											}
										}
										else
										{
											if (Main.tile[i, j].type == 82 || Main.tile[i, j].type == 83 || Main.tile[i, j].type == 84)
											{
												if (Main.tile[i, j].frameX < 18)
												{
													this.option(0);
												}
												else
												{
													if (Main.tile[i, j].frameX < 36)
													{
														this.option(1);
													}
													else
													{
														if (Main.tile[i, j].frameX < 54)
														{
															this.option(2);
														}
														else
														{
															if (Main.tile[i, j].frameX < 72)
															{
																this.option(3);
															}
															else
															{
																if (Main.tile[i, j].frameX < 90)
																{
																	this.option(4);
																}
																else
																{
																	this.option(6);
																}
															}
														}
													}
												}
											}
											else
											{
												if (Main.tile[i, j].type == 105)
												{
													if (Main.tile[i, j].frameX >= 1548 && Main.tile[i, j].frameX <= 1654)
													{
														this.option(1);
													}
													if (Main.tile[i, j].frameX >= 1656 && Main.tile[i, j].frameX <= 1798)
													{
														this.option(2);
													}
													else
													{
														this.option(0);
													}
												}
												else
												{
													if (Main.tile[i, j].type == 133)
													{
														if (Main.tile[i, j].frameX < 52)
														{
															this.option(0);
														}
														else
														{
															this.option(1);
														}
													}
													else
													{
														if (Main.tile[i, j].type == 134)
														{
															if (Main.tile[i, j].frameX < 28)
															{
																this.option(0);
															}
															else
															{
																this.option(1);
															}
														}
														else
														{
															if (Main.tile[i, j].type == 165)
															{
																if (Main.tile[i, j].frameX < 54)
																{
																	this.option(0);
																}
																else
																{
																	if (Main.tile[i, j].frameX < 106)
																	{
																		this.option(1);
																	}
																	else
																	{
																		if (Main.tile[i, j].frameX < 162)
																		{
																			this.option(2);
																		}
																		else
																		{
																			this.option(3);
																		}
																	}
																}
															}
															else
															{
																if (Main.tile[i, j].type == 178)
																{
																	if (Main.tile[i, j].frameX < 18)
																	{
																		this.option(0);
																	}
																	else
																	{
																		if (Main.tile[i, j].frameX < 36)
																		{
																			this.option(1);
																		}
																		else
																		{
																			if (Main.tile[i, j].frameX < 54)
																			{
																				this.option(2);
																			}
																			else
																			{
																				if (Main.tile[i, j].frameX < 72)
																				{
																					this.option(3);
																				}
																				else
																				{
																					if (Main.tile[i, j].frameX < 90)
																					{
																						this.option(4);
																					}
																					else
																					{
																						if (Main.tile[i, j].frameX < 108)
																						{
																							this.option(5);
																						}
																						else
																						{
																							this.option(6);
																						}
																					}
																				}
																			}
																		}
																	}
																}
																else
																{
																	if (Main.tile[i, j].type == 184)
																	{
																		if (Main.tile[i, j].frameX < 22)
																		{
																			this.option(0);
																		}
																		else
																		{
																			if (Main.tile[i, j].frameX < 44)
																			{
																				this.option(1);
																			}
																			else
																			{
																				if (Main.tile[i, j].frameX < 66)
																				{
																					this.option(2);
																				}
																				else
																				{
																					if (Main.tile[i, j].frameX < 88)
																					{
																						this.option(3);
																					}
																					else
																					{
																						this.option(4);
																					}
																				}
																			}
																		}
																	}
																	else
																	{
																		if (Main.tile[i, j].type == 185)
																		{
																			if (Main.tile[i, j].frameY < 18)
																			{
																				int num2 = (int)(Main.tile[i, j].frameX / 18);
																				if (num2 < 6 || num2 == 28 || num2 == 29 || num2 == 30 || num2 == 31 || num2 == 32)
																				{
																					this.option(0);
																				}
																				else
																				{
																					if (num2 < 12 || num2 == 33 || num2 == 34 || num2 == 35)
																					{
																						this.option(1);
																					}
																					else
																					{
																						if (num2 < 28)
																						{
																							this.option(2);
																						}
																						else
																						{
																							if (num2 < 48)
																							{
																								this.option(3);
																							}
																							else
																							{
																								if (num2 < 54)
																								{
																									this.option(4);
																								}
																							}
																						}
																					}
																				}
																			}
																			else
																			{
																				int num3 = (int)(Main.tile[i, j].frameX / 36);
																				if (num3 < 6 || num3 == 19 || num3 == 20 || num3 == 21 || num3 == 22 || num3 == 23 || num3 == 24 || num3 == 33 || num3 == 38 || num3 == 39 || num3 == 40)
																				{
																					this.option(0);
																				}
																				else
																				{
																					if (num3 < 16)
																					{
																						this.option(2);
																					}
																					else
																					{
																						if (num3 < 19 || num3 == 31 || num3 == 32)
																						{
																							this.option(1);
																						}
																						else
																						{
																							if (num3 < 31)
																							{
																								this.option(3);
																							}
																							else
																							{
																								if (num3 < 38)
																								{
																									this.option(4);
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																		else
																		{
																			if (Main.tile[i, j].type == 186)
																			{
																				int num4 = (int)(Main.tile[i, j].frameX / 54);
																				if (num4 < 7)
																				{
																					this.option(2);
																				}
																				else
																				{
																					if (num4 < 22 || num4 == 33 || num4 == 34 || num4 == 35)
																					{
																						this.option(0);
																					}
																					else
																					{
																						if (num4 < 25)
																						{
																							this.option(1);
																						}
																						else
																						{
																							if (num4 == 25)
																							{
																								this.option(5);
																							}
																							else
																							{
																								if (num4 < 32)
																								{
																									this.option(3);
																								}
																							}
																						}
																					}
																				}
																			}
																			else
																			{
																				if (Main.tile[i, j].type == 187)
																				{
																					int num5 = (int)(Main.tile[i, j].frameX / 54);
																					if (num5 < 3 || num5 == 14 || num5 == 15 || num5 == 16)
																					{
																						this.option(0);
																					}
																					else
																					{
																						if (num5 < 6)
																						{
																							this.option(6);
																						}
																						else
																						{
																							if (num5 < 9)
																							{
																								this.option(7);
																							}
																							else
																							{
																								if (num5 < 14)
																								{
																									this.option(4);
																								}
																								else
																								{
																									if (num5 < 18)
																									{
																										this.option(4);
																									}
																									else
																									{
																										if (num5 < 23)
																										{
																											this.option(8);
																										}
																										else
																										{
																											if (num5 < 25)
																											{
																												this.option(0);
																											}
																											else
																											{
																												if (num5 < 29)
																												{
																													this.option(1);
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
																					if (Main.tile[i, j].type == 227)
																					{
																						int num6 = (int)(Main.tile[i, j].frameX / 34);
																						this.option((byte)num6);
																					}
																					else
																					{
																						if (Main.tile[i, j].type == 240)
																						{
																							int num7 = (int)(Main.tile[i, j].frameX / 54);
																							if (num7 >= 0 && num7 <= 11)
																							{
																								this.option(0);
																							}
																							else
																							{
																								if (num7 >= 12 && num7 <= 15)
																								{
																									this.option(1);
																								}
																								else
																								{
																									if (num7 == 16 || num7 == 17)
																									{
																										this.option(2);
																									}
																									else
																									{
																										if (num7 >= 18 && num7 <= 35)
																										{
																											this.option(1);
																										}
																									}
																								}
																							}
																						}
																						else
																						{
																							if (Main.tile[i, j].type == 241)
																							{
																								short arg_CCB_0 = (short)(Main.tile[i, j].frameY / 54);
																								this.option(0);
																							}
																							else
																							{
																								this.option(0);
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
			if (!flag)
			{
				if (this.active())
				{
					this.changed(true);
				}
				this.active(false);
				if (Main.tile[i, j] != null && Main.tile[i, j].liquid > 32)
				{
					if (this.color() != 0)
					{
						this.changed(true);
					}
					this.color(0);
					if (this.wall())
					{
						this.changed(true);
					}
					if (Main.tile[i, j].lava())
					{
						if (!this.lava())
						{
							this.changed(true);
						}
						this.lava(true);
						this.water(false);
						this.honey(false);
						return;
					}
					if (Main.tile[i, j].honey())
					{
						if (!this.honey())
						{
							this.changed(true);
						}
						this.honey(true);
						this.lava(false);
						this.water(false);
						return;
					}
					if (!this.water())
					{
						this.changed(true);
					}
					this.water(true);
					this.lava(false);
					this.honey(false);
					return;
				}
				else
				{
					if (this.lava() || this.water() || this.honey())
					{
						this.changed(true);
					}
					this.lava(false);
					this.water(false);
					this.honey(false);
					if (Main.tile[i, j] != null && Main.tile[i, j].wall > 0)
					{
						if (!this.wall())
						{
							this.changed(true);
						}
						this.wall(true);
						if (Main.tile[i, j].wall != this.type)
						{
							this.changed(true);
						}
						this.type = Main.tile[i, j].wall;
						if (this.type != 21)
						{
							if (this.color() != Main.tile[i, j].wallColor())
							{
								this.changed(true);
							}
							this.color(Main.tile[i, j].wallColor());
							return;
						}
						if (this.color() != 0)
						{
							this.changed(true);
						}
						this.color(0);
						if ((double)j < Main.worldSurface)
						{
							if (this.light < 255)
							{
								this.changed(true);
							}
							this.light = 255;
							return;
						}
					}
					else
					{
						if ((double)j < Main.worldSurface)
						{
							if (this.color() != 0)
							{
								this.changed(true);
							}
							this.color(0);
							if (this.wall())
							{
								this.changed(true);
							}
							this.wall(false);
							if (this.water() || this.lava() || this.honey())
							{
								this.changed(true);
							}
							this.water(false);
							this.lava(false);
							this.honey(false);
							if (this.light < 255)
							{
								this.light = 255;
								this.changed(true);
								return;
							}
						}
						else
						{
							if (j < Main.maxTilesY - 200)
							{
								if (this.color() != 0)
								{
									this.changed(true);
								}
								this.color(0);
								if (this.wall())
								{
									this.changed(true);
								}
								this.wall(false);
								if (this.water() || this.lava() || this.honey())
								{
									this.changed(true);
								}
								this.water(false);
								this.lava(false);
								this.honey(false);
								float num8 = Main.screenPosition.X / 16f - 5f;
								float num9 = (Main.screenPosition.X + (float)Main.screenWidth) / 16f + 5f;
								float num10 = Main.screenPosition.Y / 16f - 5f;
								float num11 = (Main.screenPosition.Y + (float)Main.screenHeight) / 16f + 5f;
								if (((float)i < num8 || (float)i > num9 || (float)j < num10 || (float)j > num11) && i > 40 && i < Main.maxTilesX - 40 && j > 40 && j < Main.maxTilesY - 40)
								{
									if (this.changed())
									{
										byte b = 0;
										for (int k = i - 36; k <= i + 30; k += 10)
										{
											for (int l = j - 36; l <= j + 30; l += 10)
											{
												if (Main.map[k, l] != null && Main.map[k, l].active())
												{
													int num12 = (int)Main.map[k, l].type;
													if (num12 == 147 || num12 == 161 || num12 == 162 || num12 == 163 || num12 == 164 || num12 == 200)
													{
														b = 255;
														break;
													}
												}
											}
											if (b != 0)
											{
												break;
											}
										}
										if (this.type != b)
										{
											this.changed(true);
										}
										this.type = b;
										return;
									}
								}
								else
								{
									float num13 = (float)Main.snowTiles / 1000f;
									num13 *= 255f;
									if (num13 > 255f)
									{
										num13 = 255f;
									}
									if ((float)this.type != num13)
									{
										this.changed(true);
										this.type = (byte)num13;
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
