using Microsoft.Xna.Framework;
using System;
using System.Diagnostics;
namespace Terraria
{
	public class Lighting
	{
		public static int maxRenderCount = 4;
		public static int dirX;
		public static int dirY;
		public static float brightness = 1f;
		public static float defBrightness = 1f;
		public static int lightMode = 0;
		public static bool RGB = true;
		public static float oldSkyColor = 0f;
		public static float skyColor = 0f;
		private static float lightColor = 0f;
		private static float lightColorG = 0f;
		private static float lightColorB = 0f;
		public static int lightCounter = 0;
		public static int offScreenTiles = 45;
		public static int offScreenTiles2 = 35;
		private static int firstTileX;
		private static int lastTileX;
		private static int firstTileY;
		private static int lastTileY;
		public static float[,] color = new float[Main.screenWidth + Lighting.offScreenTiles * 2 + 10, Main.screenHeight + Lighting.offScreenTiles * 2 + 10];
		public static float[,] colorG = new float[Main.screenWidth + Lighting.offScreenTiles * 2 + 10, Main.screenHeight + Lighting.offScreenTiles * 2 + 10];
		public static float[,] colorB = new float[Main.screenWidth + Lighting.offScreenTiles * 2 + 10, Main.screenHeight + Lighting.offScreenTiles * 2 + 10];
		public static float[,] color2 = new float[Main.screenWidth + Lighting.offScreenTiles * 2 + 10, Main.screenHeight + Lighting.offScreenTiles * 2 + 10];
		public static float[,] colorG2 = new float[Main.screenWidth + Lighting.offScreenTiles * 2 + 10, Main.screenHeight + Lighting.offScreenTiles * 2 + 10];
		public static float[,] colorB2 = new float[Main.screenWidth + Lighting.offScreenTiles * 2 + 10, Main.screenHeight + Lighting.offScreenTiles * 2 + 10];
		public static bool[,] stopLight = new bool[Main.screenWidth + Lighting.offScreenTiles * 2 + 10, Main.screenHeight + Lighting.offScreenTiles * 2 + 10];
		public static bool[,] wetLight = new bool[Main.screenWidth + Lighting.offScreenTiles * 2 + 10, Main.screenHeight + Lighting.offScreenTiles * 2 + 10];
		public static bool[,] honeyLight = new bool[Main.screenWidth + Lighting.offScreenTiles * 2 + 10, Main.screenHeight + Lighting.offScreenTiles * 2 + 10];
		public static int scrX;
		public static int scrY;
		public static int minX;
		public static int maxX;
		public static int minY;
		public static int maxY;
		private static int maxTempLights = 2000;
		private static int[] tempLightX = new int[Lighting.maxTempLights];
		private static int[] tempLightY = new int[Lighting.maxTempLights];
		private static float[] tempLight = new float[Lighting.maxTempLights];
		private static float[] tempLightG = new float[Lighting.maxTempLights];
		private static float[] tempLightB = new float[Lighting.maxTempLights];
		public static int tempLightCount;
		private static int firstToLightX;
		private static int firstToLightY;
		private static int lastToLightX;
		private static int lastToLightY;
		public static bool resize = false;
		private static float negLight = 0.04f;
		private static float negLight2 = 0.16f;
		private static float wetLightR = 0.16f;
		private static float wetLightG = 0.16f;
		private static float wetLightB = 0.16f;
		private static float honeyLightR = 0.16f;
		private static float honeyLightG = 0.16f;
		private static float honeyLightB = 0.16f;
		private static float blueWave = 1f;
		private static int blueDir = 1;
		private static int minX7;
		private static int maxX7;
		private static int minY7;
		private static int maxY7;
		private static int firstTileX7;
		private static int lastTileX7;
		private static int lastTileY7;
		private static int firstTileY7;
		private static int firstToLightX7;
		private static int lastToLightX7;
		private static int firstToLightY7;
		private static int lastToLightY7;
		private static int firstToLightX27;
		private static int lastToLightX27;
		private static int firstToLightY27;
		private static int lastToLightY27;
		public static void LightTiles(int firstX, int lastX, int firstY, int lastY)
		{
			Main.render = true;
			Lighting.oldSkyColor = Lighting.skyColor;
			Lighting.skyColor = (float)((Main.tileColor.R + Main.tileColor.G + Main.tileColor.B) / 3) / 255f;
			if (Lighting.lightMode < 2)
			{
				Lighting.brightness = 1.2f;
				Lighting.offScreenTiles2 = 34;
				Lighting.offScreenTiles = 40;
			}
			else
			{
				Lighting.brightness = 1f;
				Lighting.offScreenTiles2 = 18;
				Lighting.offScreenTiles = 23;
			}
			if (Main.player[Main.myPlayer].blind)
			{
				Lighting.brightness = 1f;
			}
			Lighting.defBrightness = Lighting.brightness;
			Lighting.firstTileX = firstX;
			Lighting.lastTileX = lastX;
			Lighting.firstTileY = firstY;
			Lighting.lastTileY = lastY;
			Lighting.firstToLightX = Lighting.firstTileX - Lighting.offScreenTiles;
			Lighting.firstToLightY = Lighting.firstTileY - Lighting.offScreenTiles;
			Lighting.lastToLightX = Lighting.lastTileX + Lighting.offScreenTiles;
			Lighting.lastToLightY = Lighting.lastTileY + Lighting.offScreenTiles;
			if (Lighting.firstToLightX < 0)
			{
				Lighting.firstToLightX = 0;
			}
			if (Lighting.lastToLightX >= Main.maxTilesX)
			{
				Lighting.lastToLightX = Main.maxTilesX - 1;
			}
			if (Lighting.firstToLightY < 0)
			{
				Lighting.firstToLightY = 0;
			}
			if (Lighting.lastToLightY >= Main.maxTilesY)
			{
				Lighting.lastToLightY = Main.maxTilesY - 1;
			}
			int num = Lighting.firstTileX - Lighting.offScreenTiles2;
			int num2 = Lighting.firstTileY - Lighting.offScreenTiles2;
			int num3 = Lighting.lastTileX + Lighting.offScreenTiles2;
			int num4 = Lighting.lastTileY + Lighting.offScreenTiles2;
			if (num < 0)
			{
				num = 0;
			}
			if (num3 >= Main.maxTilesX)
			{
				num3 = Main.maxTilesX - 1;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num4 >= Main.maxTilesY)
			{
				num4 = Main.maxTilesY - 1;
			}
			Lighting.lightCounter++;
			Main.renderCount++;
			int num5 = Main.screenWidth / 16 + Lighting.offScreenTiles * 2;
			int num6 = Main.screenHeight / 16 + Lighting.offScreenTiles * 2;
			Vector2 vector = Main.screenLastPosition;
			Lighting.doColors();
			if (Main.renderCount == 2)
			{
				vector = Main.screenPosition;
				int num7 = (int)(Main.screenPosition.X / 16f) - Lighting.scrX;
				int num8 = (int)(Main.screenPosition.Y / 16f) - Lighting.scrY;
				if (num7 > 16)
				{
					num7 = 0;
				}
				if (num8 > 16)
				{
					num8 = 0;
				}
				if (Lighting.RGB)
				{
					for (int i = 0; i < num5; i++)
					{
						if (i + num7 >= 0)
						{
							for (int j = 0; j < num6; j++)
							{
								if (j + num8 >= 0)
								{
									Lighting.color[i, j] = Lighting.color2[i + num7, j + num8];
									Lighting.colorG[i, j] = Lighting.colorG2[i + num7, j + num8];
									Lighting.colorB[i, j] = Lighting.colorB2[i + num7, j + num8];
								}
							}
						}
					}
				}
				else
				{
					for (int k = 0; k < num5; k++)
					{
						if (k + num7 >= 0)
						{
							for (int l = 0; l < num6; l++)
							{
								if (l + num8 >= 0)
								{
									Lighting.color[k, l] = Lighting.color2[k + num7, l + num8];
									Lighting.colorG[k, l] = Lighting.color2[k + num7, l + num8];
									Lighting.colorB[k, l] = Lighting.color2[k + num7, l + num8];
								}
							}
						}
					}
				}
			}
			if (Main.renderCount != 2 && !Lighting.resize && !Main.renderNow)
			{
				if (Math.Abs(Main.screenPosition.X / 16f - vector.X / 16f) < 5f)
				{
					while ((int)(Main.screenPosition.X / 16f) < (int)(vector.X / 16f))
					{
						vector.X -= 16f;
						for (int m = num5 - 1; m > 1; m--)
						{
							for (int n = 0; n < num6; n++)
							{
								Lighting.color[m, n] = Lighting.color[m - 1, n];
								Lighting.colorG[m, n] = Lighting.colorG[m - 1, n];
								Lighting.colorB[m, n] = Lighting.colorB[m - 1, n];
							}
						}
					}
					while ((int)(Main.screenPosition.X / 16f) > (int)(vector.X / 16f))
					{
						vector.X += 16f;
						for (int num9 = 0; num9 < num5 - 1; num9++)
						{
							for (int num10 = 0; num10 < num6; num10++)
							{
								Lighting.color[num9, num10] = Lighting.color[num9 + 1, num10];
								Lighting.colorG[num9, num10] = Lighting.colorG[num9 + 1, num10];
								Lighting.colorB[num9, num10] = Lighting.colorB[num9 + 1, num10];
							}
						}
					}
				}
				if (Math.Abs(Main.screenPosition.Y / 16f - vector.Y / 16f) < 5f)
				{
					while ((int)(Main.screenPosition.Y / 16f) < (int)(vector.Y / 16f))
					{
						vector.Y -= 16f;
						for (int num11 = num6 - 1; num11 > 1; num11--)
						{
							for (int num12 = 0; num12 < num5; num12++)
							{
								Lighting.color[num12, num11] = Lighting.color[num12, num11 - 1];
								Lighting.colorG[num12, num11] = Lighting.colorG[num12, num11 - 1];
								Lighting.colorB[num12, num11] = Lighting.colorB[num12, num11 - 1];
							}
						}
					}
					while ((int)(Main.screenPosition.Y / 16f) > (int)(vector.Y / 16f))
					{
						vector.Y += 16f;
						for (int num13 = 0; num13 < num6 - 1; num13++)
						{
							for (int num14 = 0; num14 < num5 - 1; num14++)
							{
								Lighting.color[num14, num13] = Lighting.color[num14, num13 + 1];
								Lighting.colorG[num14, num13] = Lighting.colorG[num14, num13 + 1];
								Lighting.colorB[num14, num13] = Lighting.colorB[num14, num13 + 1];
							}
						}
					}
				}
				if (Netplay.clientSock.statusMax > 0)
				{
					Main.mapTime = 1;
				}
				if (Main.mapTime == 0 && Main.mapEnabled && Main.renderCount == 3)
				{
					try
					{
						Main.mapTime = Main.mapTimeMax;
						Main.updateMap = true;
						Main.mapMinX = Lighting.firstToLightX + Lighting.offScreenTiles;
						Main.mapMaxX = Lighting.lastToLightX - Lighting.offScreenTiles;
						Main.mapMinY = Lighting.firstToLightY + Lighting.offScreenTiles;
						Main.mapMaxY = Lighting.lastToLightY - Lighting.offScreenTiles;
						for (int num15 = Main.mapMinX; num15 < Main.mapMaxX; num15++)
						{
							for (int num16 = Main.mapMinY; num16 < Main.mapMaxY; num16++)
							{
								float num17 = 0f;
								int num18 = num15 - Lighting.firstTileX + Lighting.offScreenTiles;
								int num19 = num16 - Lighting.firstTileY + Lighting.offScreenTiles;
								if (Lighting.color[num18, num19] * 255f > num17)
								{
									num17 = Lighting.color[num18, num19] * 255f;
								}
								if (Lighting.colorG[num18, num19] * 255f > num17)
								{
									num17 = Lighting.colorG[num18, num19] * 255f;
								}
								if (Lighting.colorB[num18, num19] * 255f > num17)
								{
									num17 = Lighting.colorB[num18, num19] * 255f;
								}
								if (Lighting.lightMode < 2)
								{
									num17 *= 1.5f;
								}
								if (num17 > 255f)
								{
									num17 = 255f;
								}
								if ((double)num16 < Main.worldSurface && !Main.tile[num15, num16].active() && Main.tile[num15, num16].wall == 0 && Main.tile[num15, num16].liquid == 0)
								{
									num17 = 22f;
								}
								if (num17 > 18f || (Main.map[num15, num16] != null && Main.map[num15, num16].light > 0))
								{
									if (num17 < 22f)
									{
										num17 = 22f;
									}
									if (Main.map[num15, num16] == null)
									{
										Main.map[num15, num16] = new Map();
									}
									Main.map[num15, num16].setTile(num15, num16, (byte)num17);
								}
							}
						}
					}
					catch
					{
					}
				}
				if (Lighting.oldSkyColor != Lighting.skyColor)
				{
					for (int num20 = Lighting.firstToLightX; num20 < Lighting.lastToLightX; num20++)
					{
						for (int num21 = Lighting.firstToLightY; num21 < Lighting.lastToLightY; num21++)
						{
							if (Main.tile[num20, num21] == null)
							{
								Main.tile[num20, num21] = new Tile();
							}
							if ((!Main.tile[num20, num21].active() || !Main.tileNoSunLight[(int)Main.tile[num20, num21].type]) && Lighting.color[num20 - Lighting.firstToLightX, num21 - Lighting.firstToLightY] < Lighting.skyColor && (double)num21 < Main.worldSurface && Main.tile[num20, num21].liquid < 200 && (Main.wallLight[(int)Main.tile[num20, num21].wall] || Main.tile[num20, num21].wall == 73))
							{
								if (Lighting.color[num20 - Lighting.firstToLightX, num21 - Lighting.firstToLightY] < Lighting.skyColor)
								{
									Lighting.color[num20 - Lighting.firstToLightX, num21 - Lighting.firstToLightY] = (float)Main.tileColor.R / 255f;
								}
								if (Lighting.colorG[num20 - Lighting.firstToLightX, num21 - Lighting.firstToLightY] < Lighting.skyColor)
								{
									Lighting.colorG[num20 - Lighting.firstToLightX, num21 - Lighting.firstToLightY] = (float)Main.tileColor.G / 255f;
								}
								if (Lighting.colorB[num20 - Lighting.firstToLightX, num21 - Lighting.firstToLightY] < Lighting.skyColor)
								{
									Lighting.colorB[num20 - Lighting.firstToLightX, num21 - Lighting.firstToLightY] = (float)Main.tileColor.B / 255f;
								}
							}
						}
					}
				}
			}
			else
			{
				Lighting.lightCounter = 0;
			}
			if (Main.renderCount <= Lighting.maxRenderCount)
			{
				return;
			}
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			long arg_B7E_0 = stopwatch.ElapsedMilliseconds;
			Lighting.resize = false;
			Main.drawScene = true;
			Lighting.ResetRange();
			if (Lighting.lightMode == 0 || Lighting.lightMode == 3)
			{
				Lighting.RGB = true;
			}
			else
			{
				Lighting.RGB = false;
			}
			int num22 = 0;
			int num23 = Main.screenWidth / 16 + Lighting.offScreenTiles * 2 + 10;
			int num24 = 0;
			int num25 = Main.screenHeight / 16 + Lighting.offScreenTiles * 2 + 10;
			for (int num26 = num22; num26 < num23; num26++)
			{
				for (int num27 = num24; num27 < num25; num27++)
				{
					Lighting.color2[num26, num27] = 0f;
					Lighting.colorG2[num26, num27] = 0f;
					Lighting.colorB2[num26, num27] = 0f;
					Lighting.stopLight[num26, num27] = false;
					Lighting.wetLight[num26, num27] = false;
					Lighting.honeyLight[num26, num27] = false;
				}
			}
			for (int num28 = 0; num28 < Lighting.tempLightCount; num28++)
			{
				if (Lighting.tempLightX[num28] - Lighting.firstTileX + Lighting.offScreenTiles >= 0 && Lighting.tempLightX[num28] - Lighting.firstTileX + Lighting.offScreenTiles < Main.screenWidth / 16 + Lighting.offScreenTiles * 2 + 10 && Lighting.tempLightY[num28] - Lighting.firstTileY + Lighting.offScreenTiles >= 0 && Lighting.tempLightY[num28] - Lighting.firstTileY + Lighting.offScreenTiles < Main.screenHeight / 16 + Lighting.offScreenTiles * 2 + 10)
				{
					int num29 = Lighting.tempLightX[num28] - Lighting.firstTileX + Lighting.offScreenTiles;
					int num30 = Lighting.tempLightY[num28] - Lighting.firstTileY + Lighting.offScreenTiles;
					if (Lighting.color2[num29, num30] < Lighting.tempLight[num28])
					{
						Lighting.color2[num29, num30] = Lighting.tempLight[num28];
					}
					if (Lighting.colorG2[num29, num30] < Lighting.tempLightG[num28])
					{
						Lighting.colorG2[num29, num30] = Lighting.tempLightG[num28];
					}
					if (Lighting.colorB2[num29, num30] < Lighting.tempLightB[num28])
					{
						Lighting.colorB2[num29, num30] = Lighting.tempLightB[num28];
					}
				}
			}
			if (Main.wof >= 0 && Main.player[Main.myPlayer].gross)
			{
				try
				{
					int num31 = (int)Main.screenPosition.Y / 16 - 10;
					int num32 = (int)(Main.screenPosition.Y + (float)Main.screenHeight) / 16 + 10;
					int num33 = (int)Main.npc[Main.wof].position.X / 16;
					if (Main.npc[Main.wof].direction > 0)
					{
						num33 -= 3;
					}
					else
					{
						num33 += 2;
					}
					int num34 = num33 + 8;
					float num35 = 0.5f * Main.demonTorch + 1f * (1f - Main.demonTorch);
					float num36 = 0.3f;
					float num37 = 1f * Main.demonTorch + 0.5f * (1f - Main.demonTorch);
					num35 *= 0.2f;
					num36 *= 0.1f;
					num37 *= 0.3f;
					for (int num38 = num33; num38 <= num34; num38++)
					{
						for (int num39 = num31; num39 <= num32; num39++)
						{
							if (Lighting.color2[num38 - Lighting.firstToLightX, num39 - Lighting.firstToLightY] < num35)
							{
								Lighting.color2[num38 - Lighting.firstToLightX, num39 - Lighting.firstToLightY] = num35;
							}
							if (Lighting.colorG2[num38 - Lighting.firstToLightX, num39 - Lighting.firstToLightY] < num36)
							{
								Lighting.colorG2[num38 - Lighting.firstToLightX, num39 - Lighting.firstToLightY] = num36;
							}
							if (Lighting.colorB2[num38 - Lighting.firstToLightX, num39 - Lighting.firstToLightY] < num37)
							{
								Lighting.colorB2[num38 - Lighting.firstToLightX, num39 - Lighting.firstToLightY] = num37;
							}
						}
					}
				}
				catch
				{
				}
			}
			if (!Main.renderNow)
			{
				Main.oldTempLightCount = Lighting.tempLightCount;
				Lighting.tempLightCount = 0;
			}
			if (Main.gamePaused)
			{
				Lighting.tempLightCount = Main.oldTempLightCount;
			}
			Main.sandTiles = 0;
			Main.evilTiles = 0;
			Main.bloodTiles = 0;
			Main.shroomTiles = 0;
			Main.snowTiles = 0;
			Main.holyTiles = 0;
			Main.meteorTiles = 0;
			Main.jungleTiles = 0;
			Main.dungeonTiles = 0;
			Main.campfire = false;
			Main.musicBox = -1;
			Main.waterCandles = 0;
			num22 = Lighting.firstToLightX;
			num23 = Lighting.lastToLightX;
			num24 = Lighting.firstToLightY;
			num25 = Lighting.lastToLightY;
			for (int num40 = num22; num40 < num23; num40++)
			{
				for (int num41 = num24; num41 < num25; num41++)
				{
					if (Main.tile[num40, num41] == null)
					{
						Main.tile[num40, num41] = new Tile();
					}
					if ((!Main.tile[num40, num41].active() || !Main.tileNoSunLight[(int)Main.tile[num40, num41].type]) && Lighting.color2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] < Lighting.skyColor && (Main.wallLight[(int)Main.tile[num40, num41].wall] || Main.tile[num40, num41].wall == 73) && (double)num41 < Main.worldSurface)
					{
						if (Main.tile[num40, num41].halfBrick())
						{
							if (Main.tile[num40, num41].liquid < 200 && Main.tile[num40, num41 - 1].liquid < 200)
							{
								if (Lighting.color2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] < Lighting.skyColor)
								{
									Lighting.color2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] = (float)Main.tileColor.R / 255f;
								}
								if (Lighting.colorG2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] < Lighting.skyColor)
								{
									Lighting.colorG2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] = (float)Main.tileColor.G / 255f;
								}
								if (Lighting.colorB2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] < Lighting.skyColor)
								{
									Lighting.colorB2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] = (float)Main.tileColor.B / 255f;
								}
							}
						}
						else
						{
							if (Main.tile[num40, num41].liquid < 200)
							{
								if (Lighting.color2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] < Lighting.skyColor)
								{
									Lighting.color2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] = (float)Main.tileColor.R / 255f;
								}
								if (Lighting.colorG2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] < Lighting.skyColor)
								{
									Lighting.colorG2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] = (float)Main.tileColor.G / 255f;
								}
								if (Lighting.colorB2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] < Lighting.skyColor)
								{
									Lighting.colorB2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] = (float)Main.tileColor.B / 255f;
								}
							}
						}
					}
					if ((!Main.tile[num40, num41].active() || Main.tile[num40, num41].halfBrick() || !Main.tileNoSunLight[(int)Main.tile[num40, num41].type]) && Main.tile[num40, num41].wall >= 88 && Main.tile[num40, num41].wall <= 93 && (double)num41 < Main.worldSurface && Main.tile[num40, num41].liquid < 255)
					{
						float num42 = (float)Main.tileColor.R / 255f;
						float num43 = (float)Main.tileColor.G / 255f;
						float num44 = (float)Main.tileColor.B / 255f;
						int num45 = (int)(Main.tile[num40, num41].wall - 88);
						if (num45 == 0)
						{
							num42 *= 0.9f;
							num43 *= 0.15f;
							num44 *= 0.9f;
						}
						else
						{
							if (num45 == 1)
							{
								num42 *= 0.9f;
								num43 *= 0.9f;
								num44 *= 0.15f;
							}
							else
							{
								if (num45 == 2)
								{
									num42 *= 0.15f;
									num43 *= 0.15f;
									num44 *= 0.9f;
								}
								else
								{
									if (num45 == 3)
									{
										num42 *= 0.15f;
										num43 *= 0.9f;
										num44 *= 0.15f;
									}
									else
									{
										if (num45 == 4)
										{
											num42 *= 0.9f;
											num43 *= 0.15f;
											num44 *= 0.15f;
										}
										else
										{
											if (num45 == 5)
											{
												float num46 = 0.2f;
												float num47 = 0.7f - num46;
												num42 *= num47 + (float)Main.DiscoR / 255f * num46;
												num43 *= num47 + (float)Main.DiscoG / 255f * num46;
												num44 *= num47 + (float)Main.DiscoB / 255f * num46;
											}
										}
									}
								}
							}
						}
						if (Lighting.color2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] < num42)
						{
							Lighting.color2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] = num42;
						}
						if (Lighting.colorG2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] < num43)
						{
							Lighting.colorG2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] = num43;
						}
						if (Lighting.colorB2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] < num44)
						{
							Lighting.colorB2[num40 - Lighting.firstToLightX, num41 - Lighting.firstToLightY] = num44;
						}
					}
				}
			}
			Main.fountainColor = -1;
			for (int num48 = num22; num48 < num23; num48++)
			{
				for (int num49 = num24; num49 < num25; num49++)
				{
					int num50 = num48 - Lighting.firstToLightX;
					int num51 = num49 - Lighting.firstToLightY;
					int zoneX = Main.zoneX;
					int zoneY = Main.zoneY;
					int num52 = (num23 - num22 - zoneX) / 2;
					int num53 = (num25 - num24 - zoneY) / 2;
					byte b = Main.tile[num48, num49].wall;
					if (b != 33)
					{
						if (b == 44)
						{
							if (!Main.tile[num48, num49].active() || !Main.tileBlockLight[(int)Main.tile[num48, num49].type])
							{
								if (Lighting.RGB)
								{
									float num54 = (float)Main.DiscoR / 255f;
									float num55 = (float)Main.DiscoG / 255f;
									float num56 = (float)Main.DiscoB / 255f;
									num54 *= 0.15f;
									num55 *= 0.15f;
									num56 *= 0.15f;
									if (Lighting.color2[num50, num51] < num54)
									{
										Lighting.color2[num50, num51] = num54;
									}
									if (Lighting.colorG2[num50, num51] < num55)
									{
										Lighting.colorG2[num50, num51] = num55;
									}
									if (Lighting.colorB2[num50, num51] < num56)
									{
										Lighting.colorB2[num50, num51] = num56;
									}
								}
								else
								{
									if (Lighting.color2[num50, num51] < 0.15f)
									{
										Lighting.color2[num50, num51] = 0.15f;
									}
								}
							}
						}
					}
					else
					{
						if (!Main.tile[num48, num49].active() || !Main.tileBlockLight[(int)Main.tile[num48, num49].type])
						{
							if ((double)Lighting.color2[num50, num51] < 0.12)
							{
								Lighting.color2[num50, num51] = 0.0899999961f;
							}
							if ((double)Lighting.colorG2[num50, num51] < 0.07)
							{
								Lighting.colorG2[num50, num51] = 0.0525000021f;
							}
							if ((double)Lighting.colorB2[num50, num51] < 0.32)
							{
								Lighting.colorB2[num50, num51] = 0.24f;
							}
						}
					}
					if (Main.tile[num48, num49].active())
					{
						if (num48 > num22 + num52 && num48 < num23 - num52 && num49 > num24 + num53 && num49 < num25 - num53)
						{
							b = Main.tile[num48, num49].type;
							if (b <= 72)
							{
								if (b <= 44)
								{
									if (b <= 32)
									{
										switch (b)
										{
										case 23:
										case 24:
										case 25:
											break;
										case 26:
											goto IL_1B95;
										case 27:
											Main.evilTiles -= 5;
											goto IL_1B95;
										default:
											if (b != 32)
											{
												goto IL_1B95;
											}
											break;
										}
										Main.evilTiles++;
										goto IL_1B95;
									}
									if (b == 37)
									{
										Main.meteorTiles++;
										goto IL_1B95;
									}
									switch (b)
									{
									case 41:
									case 43:
									case 44:
										Main.dungeonTiles++;
										goto IL_1B95;
									case 42:
										goto IL_1B95;
									default:
										goto IL_1B95;
									}
								}
								else
								{
									if (b <= 53)
									{
										if (b == 49)
										{
											Main.waterCandles++;
											goto IL_1B95;
										}
										if (b != 53)
										{
											goto IL_1B95;
										}
										Main.sandTiles++;
										goto IL_1B95;
									}
									else
									{
										switch (b)
										{
										case 60:
										case 61:
										case 62:
											break;
										default:
											switch (b)
											{
											case 70:
											case 71:
											case 72:
												Main.shroomTiles++;
												goto IL_1B95;
											default:
												goto IL_1B95;
											}
											break;
										}
									}
								}
							}
							else
							{
								if (b <= 164)
								{
									if (b > 117)
									{
										switch (b)
										{
										case 147:
										case 148:
											break;
										default:
											switch (b)
											{
											case 161:
											case 162:
												break;
											case 163:
												Main.snowTiles++;
												Main.evilTiles++;
												goto IL_1B95;
											case 164:
												Main.holyTiles++;
												Main.snowTiles++;
												goto IL_1B95;
											default:
												goto IL_1B95;
											}
											break;
										}
										Main.snowTiles++;
										goto IL_1B95;
									}
									if (b != 84)
									{
										switch (b)
										{
										case 109:
										case 110:
										case 113:
										case 117:
											Main.holyTiles++;
											goto IL_1B95;
										case 111:
										case 114:
										case 115:
											goto IL_1B95;
										case 112:
											Main.sandTiles++;
											Main.evilTiles++;
											goto IL_1B95;
										case 116:
											Main.sandTiles++;
											Main.holyTiles++;
											goto IL_1B95;
										default:
											goto IL_1B95;
										}
									}
								}
								else
								{
									if (b <= 215)
									{
										switch (b)
										{
										case 199:
										case 200:
										case 203:
											Main.bloodTiles++;
											goto IL_1B95;
										case 201:
										case 202:
											goto IL_1B95;
										default:
											if (b != 215)
											{
												goto IL_1B95;
											}
											Main.campfire = true;
											goto IL_1B95;
										}
									}
									else
									{
										if (b != 226)
										{
											if (b != 234)
											{
												goto IL_1B95;
											}
											Main.bloodTiles++;
											Main.sandTiles++;
											goto IL_1B95;
										}
									}
								}
							}
							Main.jungleTiles++;
						}
						IL_1B95:
						b = Main.tile[num48, num49].type;
						if (b != 139)
						{
							if (b == 207)
							{
								if (Main.tile[num48, num49].frameY >= 72)
								{
									int num57 = 0;
									for (int num58 = (int)(Main.tile[num48, num49].frameX / 18); num58 >= 2; num58 -= 2)
									{
										num57++;
									}
									if (num57 == 0)
									{
										Main.fountainColor = 0;
									}
									if (num57 == 1)
									{
										Main.fountainColor = 6;
									}
									if (num57 == 2)
									{
										Main.fountainColor = 3;
									}
									if (num57 == 3)
									{
										Main.fountainColor = 5;
									}
									if (num57 == 4)
									{
										Main.fountainColor = 2;
									}
									if (num57 == 5)
									{
										Main.fountainColor = 10;
									}
									if (num57 == 6)
									{
										Main.fountainColor = 4;
									}
									if (num57 == 7)
									{
										Main.fountainColor = 9;
									}
								}
							}
						}
						else
						{
							if (Main.tile[num48, num49].frameX >= 36)
							{
								int num59 = 0;
								for (int num60 = (int)(Main.tile[num48, num49].frameY / 18); num60 >= 2; num60 -= 2)
								{
									num59++;
								}
								Main.musicBox = num59;
							}
						}
						if (Main.tileBlockLight[(int)Main.tile[num48, num49].type] && Main.tile[num48, num49].type != 131 && !Main.tile[num48, num49].inActive() && Main.tile[num48, num49].slope() == 0)
						{
							Lighting.stopLight[num50, num51] = true;
						}
						if (Main.tileLighted[(int)Main.tile[num48, num49].type])
						{
							if (Lighting.RGB)
							{
								b = Main.tile[num48, num49].type;
								if (b <= 84)
								{
									if (b <= 42)
									{
										if (b <= 17)
										{
											if (b != 4)
											{
												if (b != 17)
												{
													goto IL_42F9;
												}
												goto IL_2B4F;
											}
											else
											{
												float num61 = 1f;
												float num62 = 0.95f;
												float num63 = 0.8f;
												if (Main.tile[num48, num49].frameX >= 66)
												{
													goto IL_42F9;
												}
												int num64 = (int)(Main.tile[num48, num49].frameY / 22);
												if (num64 == 1)
												{
													num61 = 0f;
													num62 = 0.1f;
													num63 = 1.3f;
												}
												else
												{
													if (num64 == 2)
													{
														num61 = 1f;
														num62 = 0.1f;
														num63 = 0.1f;
													}
													else
													{
														if (num64 == 3)
														{
															num61 = 0f;
															num62 = 1f;
															num63 = 0.1f;
														}
														else
														{
															if (num64 == 4)
															{
																num61 = 0.9f;
																num62 = 0f;
																num63 = 0.9f;
															}
															else
															{
																if (num64 == 5)
																{
																	num61 = 1.3f;
																	num62 = 1.3f;
																	num63 = 1.3f;
																}
																else
																{
																	if (num64 == 6)
																	{
																		num61 = 0.9f;
																		num62 = 0.9f;
																		num63 = 0f;
																	}
																	else
																	{
																		if (num64 == 7)
																		{
																			num61 = 0.5f * Main.demonTorch + 1f * (1f - Main.demonTorch);
																			num62 = 0.3f;
																			num63 = 1f * Main.demonTorch + 0.5f * (1f - Main.demonTorch);
																		}
																		else
																		{
																			if (num64 == 8)
																			{
																				num63 = 0.7f;
																				num61 = 0.85f;
																				num62 = 1f;
																			}
																			else
																			{
																				if (num64 == 9)
																				{
																					num63 = 1f;
																					num61 = 0.7f;
																					num62 = 0.85f;
																				}
																				else
																				{
																					if (num64 == 10)
																					{
																						num61 = 1f;
																						num62 = 0.5f;
																						num63 = 0f;
																					}
																					else
																					{
																						if (num64 == 11)
																						{
																							num61 = 1.25f;
																							num62 = 1.25f;
																							num63 = 0.8f;
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
												if (Lighting.color2[num50, num51] < num61)
												{
													Lighting.color2[num50, num51] = num61;
												}
												if (Lighting.colorG2[num50, num51] < num62)
												{
													Lighting.colorG2[num50, num51] = num62;
												}
												if (Lighting.colorB2[num50, num51] < num63)
												{
													Lighting.colorB2[num50, num51] = num63;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
										}
										else
										{
											if (b == 22)
											{
												goto IL_2CDE;
											}
											switch (b)
											{
											case 26:
											case 31:
												if ((Main.tile[num48, num49].type == 31 && Main.tile[num48, num49].frameX >= 36) || (Main.tile[num48, num49].type == 26 && Main.tile[num48, num49].frameX >= 54))
												{
													float num65 = (float)Main.rand.Next(-5, 6) * 0.0025f;
													if (Lighting.color2[num50, num51] < 0.5f + num65 * 2f)
													{
														Lighting.color2[num50, num51] = 0.5f + num65 * 2f;
													}
													if (Lighting.colorG2[num50, num51] < 0.2f + num65)
													{
														Lighting.colorG2[num50, num51] = 0.2f + num65;
													}
													if (Lighting.colorB2[num50, num51] < 0.1f)
													{
														Lighting.colorB2[num50, num51] = 0.1f;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
												else
												{
													float num66 = (float)Main.rand.Next(-5, 6) * 0.0025f;
													if (Lighting.color2[num50, num51] < 0.31f + num66)
													{
														Lighting.color2[num50, num51] = 0.31f + num66;
													}
													if (Lighting.colorG2[num50, num51] < 0.1f + num66)
													{
														Lighting.colorG2[num50, num51] = 0.1f;
													}
													if (Lighting.colorB2[num50, num51] < 0.44f + num66 * 2f)
													{
														Lighting.colorB2[num50, num51] = 0.44f + num66 * 2f;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
												break;
											case 27:
											case 28:
											case 29:
											case 30:
											case 32:
												goto IL_42F9;
											case 33:
												if (Main.tile[num48, num49].frameX != 0)
												{
													goto IL_42F9;
												}
												if (Main.tile[num48, num49].frameY == 0)
												{
													if (Lighting.color2[num50, num51] < 1f)
													{
														Lighting.color2[num50, num51] = 1f;
													}
													if ((double)Lighting.colorG2[num50, num51] < 0.95)
													{
														Lighting.colorG2[num50, num51] = 0.95f;
													}
													if ((double)Lighting.colorB2[num50, num51] < 0.65)
													{
														Lighting.colorB2[num50, num51] = 0.65f;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
												else
												{
													if (Main.tile[num48, num49].frameY == 22)
													{
														if (Lighting.color2[num50, num51] < 0.55f)
														{
															Lighting.color2[num50, num51] = 0.55f;
														}
														if ((double)Lighting.colorG2[num50, num51] < 0.85)
														{
															Lighting.colorG2[num50, num51] = 0.85f;
														}
														if ((double)Lighting.colorB2[num50, num51] < 0.35)
														{
															Lighting.colorB2[num50, num51] = 0.35f;
															goto IL_42F9;
														}
														goto IL_42F9;
													}
													else
													{
														if (Main.tile[num48, num49].frameY == 44)
														{
															if ((double)Lighting.color2[num50, num51] < 0.65)
															{
																Lighting.color2[num50, num51] = 0.65f;
															}
															if ((double)Lighting.colorG2[num50, num51] < 0.95)
															{
																Lighting.colorG2[num50, num51] = 0.95f;
															}
															if ((double)Lighting.colorB2[num50, num51] < 0.5)
															{
																Lighting.colorB2[num50, num51] = 0.5f;
																goto IL_42F9;
															}
															goto IL_42F9;
														}
														else
														{
															if (Main.tile[num48, num49].frameY != 66)
															{
																goto IL_42F9;
															}
															if ((double)Lighting.color2[num50, num51] < 0.2)
															{
																Lighting.color2[num50, num51] = 0.2f;
															}
															if ((double)Lighting.colorG2[num50, num51] < 0.75)
															{
																Lighting.colorG2[num50, num51] = 0.75f;
															}
															if (Lighting.colorB2[num50, num51] < 1f)
															{
																Lighting.colorB2[num50, num51] = 1f;
																goto IL_42F9;
															}
															goto IL_42F9;
														}
													}
												}
												break;
											case 34:
											case 35:
												goto IL_2A07;
											case 36:
												break;
											case 37:
												if ((double)Lighting.color2[num50, num51] < 0.56)
												{
													Lighting.color2[num50, num51] = 0.56f;
												}
												if ((double)Lighting.colorG2[num50, num51] < 0.43)
												{
													Lighting.colorG2[num50, num51] = 0.43f;
												}
												if ((double)Lighting.colorB2[num50, num51] < 0.15)
												{
													Lighting.colorB2[num50, num51] = 0.15f;
													goto IL_42F9;
												}
												goto IL_42F9;
											default:
											{
												if (b != 42)
												{
													goto IL_42F9;
												}
												if (Main.tile[num48, num49].frameX != 0)
												{
													goto IL_42F9;
												}
												int num67 = (int)(Main.tile[num48, num49].frameY / 36);
												float num68 = 1f;
												float num69 = 1f;
												float num70 = 1f;
												if (num67 == 0)
												{
													num68 = 0.7f;
													num69 = 0.65f;
													num70 = 0.55f;
												}
												else
												{
													if (num67 == 1)
													{
														num68 = 0.9f;
														num69 = 0.75f;
														num70 = 0.6f;
													}
													else
													{
														if (num67 == 2)
														{
															num68 = 0.8f;
															num69 = 0.6f;
															num70 = 0.6f;
														}
														else
														{
															if (num67 == 3)
															{
																num68 = 0.65f;
																num69 = 0.5f;
																num70 = 0.2f;
															}
															else
															{
																if (num67 == 4)
																{
																	num68 = 0.5f;
																	num69 = 0.7f;
																	num70 = 0.4f;
																}
																else
																{
																	if (num67 == 5)
																	{
																		num68 = 0.9f;
																		num69 = 0.4f;
																		num70 = 0.2f;
																	}
																	else
																	{
																		if (num67 == 6)
																		{
																			num68 = 0.7f;
																			num69 = 0.75f;
																			num70 = 0.3f;
																		}
																		else
																		{
																			if (num67 == 7)
																			{
																				num68 = 0.9f;
																				num69 = 0.9f;
																				num70 = 0.7f;
																				num70 += Main.demonTorch * 0.2f;
																				num68 -= Main.demonTorch * 0.2f;
																				num69 -= Main.demonTorch * 0.2f;
																			}
																		}
																	}
																}
															}
														}
													}
												}
												if (Lighting.color2[num50, num51] < num68)
												{
													Lighting.color2[num50, num51] = num68;
												}
												if (Lighting.colorG2[num50, num51] < num69)
												{
													Lighting.colorG2[num50, num51] = num69;
												}
												if (Lighting.colorB2[num50, num51] < num70)
												{
													Lighting.colorB2[num50, num51] = num70;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
											}
										}
									}
									else
									{
										if (b <= 61)
										{
											if (b != 49)
											{
												if (b != 61)
												{
													goto IL_42F9;
												}
												if (Main.tile[num48, num49].frameX != 144)
												{
													goto IL_42F9;
												}
												float num71 = 1f + (float)(270 - (int)Main.mouseTextColor) / 400f;
												float num72 = 0.8f - (float)(270 - (int)Main.mouseTextColor) / 400f;
												if (Lighting.color2[num50, num51] < 0.42f * num71)
												{
													Lighting.color2[num50, num51] = 0.42f * num72;
												}
												if (Lighting.colorG2[num50, num51] < 0.81f * num71)
												{
													Lighting.colorG2[num50, num51] = 0.81f * num71;
												}
												if (Lighting.colorB2[num50, num51] < 0.52f * num71)
												{
													Lighting.colorB2[num50, num51] = 0.52f * num72;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
											else
											{
												if (Lighting.color2[num50, num51] < 0f)
												{
													Lighting.color2[num50, num51] = 0f;
												}
												if (Lighting.colorG2[num50, num51] < 0.35f)
												{
													Lighting.colorG2[num50, num51] = 0.35f;
												}
												if (Lighting.colorB2[num50, num51] < 0.8f)
												{
													Lighting.colorB2[num50, num51] = 0.8f;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
										}
										else
										{
											switch (b)
											{
											case 70:
											case 71:
											case 72:
												goto IL_2FF1;
											default:
												if (b != 77)
												{
													switch (b)
													{
													case 83:
														if (Main.tile[num48, num49].frameX != 18 || Main.dayTime)
														{
															goto IL_42F9;
														}
														if ((double)Lighting.color2[num50, num51] < 0.1)
														{
															Lighting.color2[num50, num51] = 0.1f;
														}
														if ((double)Lighting.colorG2[num50, num51] < 0.4)
														{
															Lighting.colorG2[num50, num51] = 0.4f;
														}
														if ((double)Lighting.colorB2[num50, num51] < 0.6)
														{
															Lighting.colorB2[num50, num51] = 0.6f;
															goto IL_42F9;
														}
														goto IL_42F9;
													case 84:
													{
														int num73 = (int)(Main.tile[num48, num49].frameX / 18);
														if (num73 == 2)
														{
															float num74 = (float)(270 - (int)Main.mouseTextColor);
															num74 /= 800f;
															if (num74 > 1f)
															{
																num74 = 1f;
															}
															if (num74 < 0f)
															{
																num74 = 0f;
															}
															float num75 = num74;
															if (Lighting.color2[num50, num51] < num75 * 0.7f)
															{
																Lighting.color2[num50, num51] = num75 * 0.7f;
															}
															if (Lighting.colorG2[num50, num51] < num75)
															{
																Lighting.colorG2[num50, num51] = num75;
															}
															if (Lighting.colorB2[num50, num51] < num75 * 0.1f)
															{
																Lighting.colorB2[num50, num51] = num75 * 0.1f;
																goto IL_42F9;
															}
															goto IL_42F9;
														}
														else
														{
															if (num73 != 5)
															{
																goto IL_42F9;
															}
															float num75 = 0.9f;
															if (Lighting.color2[num50, num51] < num75)
															{
																Lighting.color2[num50, num51] = num75;
															}
															if (Lighting.colorG2[num50, num51] < num75 * 0.8f)
															{
																Lighting.colorG2[num50, num51] = num75 * 0.8f;
															}
															if (Lighting.colorB2[num50, num51] < num75 * 0.2f)
															{
																Lighting.colorB2[num50, num51] = num75 * 0.2f;
																goto IL_42F9;
															}
															goto IL_42F9;
														}
														break;
													}
													default:
														goto IL_42F9;
													}
												}
												else
												{
													if (Lighting.color2[num50, num51] < 0.75f)
													{
														Lighting.color2[num50, num51] = 0.75f;
													}
													if (Lighting.colorG2[num50, num51] < 0.45f)
													{
														Lighting.colorG2[num50, num51] = 0.45f;
													}
													if (Lighting.colorB2[num50, num51] < 0.25f)
													{
														Lighting.colorB2[num50, num51] = 0.25f;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
												break;
											}
										}
									}
								}
								else
								{
									if (b <= 149)
									{
										if (b <= 129)
										{
											switch (b)
											{
											case 92:
												if (Main.tile[num48, num49].frameY > 18 || Main.tile[num48, num49].frameX != 0)
												{
													goto IL_42F9;
												}
												if (Lighting.color2[num50, num51] < 1f)
												{
													Lighting.color2[num50, num51] = 1f;
												}
												if (Lighting.colorG2[num50, num51] < 1f)
												{
													Lighting.colorG2[num50, num51] = 1f;
												}
												if (Lighting.colorB2[num50, num51] < 1f)
												{
													Lighting.colorB2[num50, num51] = 1f;
													goto IL_42F9;
												}
												goto IL_42F9;
											case 93:
												if (Main.tile[num48, num49].frameY != 0 || Main.tile[num48, num49].frameX != 0)
												{
													goto IL_42F9;
												}
												if (Lighting.color2[num50, num51] < 1f)
												{
													Lighting.color2[num50, num51] = 1f;
												}
												if ((double)Lighting.colorG2[num50, num51] < 0.97)
												{
													Lighting.colorG2[num50, num51] = 0.97f;
												}
												if ((double)Lighting.colorB2[num50, num51] < 0.85)
												{
													Lighting.colorB2[num50, num51] = 0.85f;
													goto IL_42F9;
												}
												goto IL_42F9;
											case 94:
											case 96:
											case 97:
											case 99:
												goto IL_42F9;
											case 95:
												if (Main.tile[num48, num49].frameX >= 36)
												{
													goto IL_42F9;
												}
												if (Lighting.color2[num50, num51] < 1f)
												{
													Lighting.color2[num50, num51] = 1f;
												}
												if ((double)Lighting.colorG2[num50, num51] < 0.95)
												{
													Lighting.colorG2[num50, num51] = 0.95f;
												}
												if ((double)Lighting.colorB2[num50, num51] < 0.8)
												{
													Lighting.colorB2[num50, num51] = 0.8f;
													goto IL_42F9;
												}
												goto IL_42F9;
											case 98:
												if (Main.tile[num48, num49].frameY != 0)
												{
													goto IL_42F9;
												}
												if (Lighting.color2[num50, num51] < 1f)
												{
													Lighting.color2[num50, num51] = 1f;
												}
												if ((double)Lighting.colorG2[num50, num51] < 0.97)
												{
													Lighting.colorG2[num50, num51] = 0.97f;
												}
												if ((double)Lighting.colorB2[num50, num51] < 0.85)
												{
													Lighting.colorB2[num50, num51] = 0.85f;
													goto IL_42F9;
												}
												goto IL_42F9;
											case 100:
												break;
											default:
												switch (b)
												{
												case 125:
												{
													float num76 = (float)Main.rand.Next(28, 42) * 0.01f;
													num76 += (float)(270 - (int)Main.mouseTextColor) / 800f;
													if ((double)Lighting.colorG2[num50, num51] < 0.1 * (double)num76)
													{
														Lighting.colorG2[num50, num51] = 0.3f * num76;
													}
													if ((double)Lighting.colorB2[num50, num51] < 0.3 * (double)num76)
													{
														Lighting.colorB2[num50, num51] = 0.6f * num76;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
												case 126:
													if (Main.tile[num48, num49].frameX >= 36)
													{
														goto IL_42F9;
													}
													if (Lighting.color2[num50, num51] < (float)Main.DiscoR / 255f)
													{
														Lighting.color2[num50, num51] = (float)Main.DiscoR / 255f;
													}
													if (Lighting.colorG2[num50, num51] < (float)Main.DiscoG / 255f)
													{
														Lighting.colorG2[num50, num51] = (float)Main.DiscoG / 255f;
													}
													if (Lighting.colorB2[num50, num51] < (float)Main.DiscoB / 255f)
													{
														Lighting.colorB2[num50, num51] = (float)Main.DiscoB / 255f;
														goto IL_42F9;
													}
													goto IL_42F9;
												case 127:
												case 128:
													goto IL_42F9;
												case 129:
												{
													float num61;
													float num62;
													float num63;
													if (Main.tile[num48, num49].frameX == 0 || Main.tile[num48, num49].frameX == 54 || Main.tile[num48, num49].frameX == 108)
													{
														num62 = 0.05f;
														num63 = 0.25f;
														num61 = 0f;
													}
													else
													{
														if (Main.tile[num48, num49].frameX == 18 || Main.tile[num48, num49].frameX == 72 || Main.tile[num48, num49].frameX == 126)
														{
															num61 = 0.2f;
															num63 = 0.15f;
															num62 = 0f;
														}
														else
														{
															num63 = 0.2f;
															num61 = 0.1f;
															num62 = 0f;
														}
													}
													if (Lighting.color2[num50, num51] < num61)
													{
														Lighting.color2[num50, num51] = num61 * (float)Main.rand.Next(970, 1031) * 0.001f;
													}
													if (Lighting.colorG2[num50, num51] < num62)
													{
														Lighting.colorG2[num50, num51] = num62 * (float)Main.rand.Next(970, 1031) * 0.001f;
													}
													if (Lighting.colorB2[num50, num51] < num63)
													{
														Lighting.colorB2[num50, num51] = num63 * (float)Main.rand.Next(970, 1031) * 0.001f;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
												default:
													goto IL_42F9;
												}
												break;
											}
										}
										else
										{
											if (b == 133)
											{
												goto IL_2B4F;
											}
											if (b == 140)
											{
												goto IL_2CDE;
											}
											if (b != 149)
											{
												goto IL_42F9;
											}
											float num61;
											float num62;
											float num63;
											if (Main.tile[num48, num49].frameX == 0)
											{
												num62 = 0.2f;
												num63 = 0.5f;
												num61 = 0.1f;
											}
											else
											{
												if (Main.tile[num48, num49].frameX == 18)
												{
													num61 = 0.5f;
													num63 = 0.1f;
													num62 = 0.1f;
												}
												else
												{
													num63 = 0.1f;
													num61 = 0.2f;
													num62 = 0.5f;
												}
											}
											if (Main.tile[num48, num49].frameX > 36)
											{
												goto IL_42F9;
											}
											if (Lighting.color2[num50, num51] < num61)
											{
												Lighting.color2[num50, num51] = num61 * (float)Main.rand.Next(970, 1031) * 0.001f;
											}
											if (Lighting.colorG2[num50, num51] < num62)
											{
												Lighting.colorG2[num50, num51] = num62 * (float)Main.rand.Next(970, 1031) * 0.001f;
											}
											if (Lighting.colorB2[num50, num51] < num63)
											{
												Lighting.colorB2[num50, num51] = num63 * (float)Main.rand.Next(970, 1031) * 0.001f;
												goto IL_42F9;
											}
											goto IL_42F9;
										}
									}
									else
									{
										if (b <= 190)
										{
											if (b != 160)
											{
												switch (b)
												{
												case 170:
												case 171:
													goto IL_2A07;
												case 172:
													goto IL_28BF;
												case 173:
													break;
												case 174:
													if (Main.tile[num48, num49].frameX != 0)
													{
														goto IL_42F9;
													}
													if (Lighting.color2[num50, num51] < 1f)
													{
														Lighting.color2[num50, num51] = 1f;
													}
													if ((double)Lighting.colorG2[num50, num51] < 0.95)
													{
														Lighting.colorG2[num50, num51] = 0.95f;
													}
													if ((double)Lighting.colorB2[num50, num51] < 0.65)
													{
														Lighting.colorB2[num50, num51] = 0.65f;
														goto IL_42F9;
													}
													goto IL_42F9;
												default:
													if (b != 190)
													{
														goto IL_42F9;
													}
													goto IL_2FF1;
												}
											}
											else
											{
												float num77 = (float)Main.DiscoR / 255f;
												float num78 = (float)Main.DiscoG / 255f;
												float num79 = (float)Main.DiscoB / 255f;
												num77 *= 0.25f;
												num78 *= 0.25f;
												num79 *= 0.25f;
												if (Lighting.color2[num50, num51] < num77)
												{
													Lighting.color2[num50, num51] = num77;
												}
												if (Lighting.colorG2[num50, num51] < num78)
												{
													Lighting.colorG2[num50, num51] = num78;
												}
												if (Lighting.colorB2[num50, num51] < num79)
												{
													Lighting.colorB2[num50, num51] = num79;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
										}
										else
										{
											if (b != 204)
											{
												if (b != 215)
												{
													switch (b)
													{
													case 235:
														if ((double)Lighting.color2[num50, num51] < 0.6)
														{
															Lighting.color2[num50, num51] = 0.6f;
														}
														if ((double)Lighting.colorG2[num50, num51] < 0.6)
														{
															Lighting.colorG2[num50, num51] = 0.6f;
															goto IL_42F9;
														}
														goto IL_42F9;
													case 236:
														goto IL_42F9;
													case 237:
														if ((double)Lighting.color2[num50, num51] < 0.1)
														{
															Lighting.color2[num50, num51] = 0.1f;
														}
														if ((double)Lighting.colorG2[num50, num51] < 0.1)
														{
															Lighting.colorG2[num50, num51] = 0.1f;
															goto IL_42F9;
														}
														goto IL_42F9;
													case 238:
														if ((double)Lighting.color2[num50, num51] < 0.5)
														{
															Lighting.color2[num50, num51] = 0.5f;
														}
														if ((double)Lighting.colorB2[num50, num51] < 0.5)
														{
															Lighting.colorB2[num50, num51] = 0.5f;
															goto IL_42F9;
														}
														goto IL_42F9;
													default:
														goto IL_42F9;
													}
												}
												else
												{
													float num80 = (float)Main.rand.Next(28, 42) * 0.005f;
													num80 += (float)(270 - (int)Main.mouseTextColor) / 700f;
													if ((double)Lighting.color2[num50, num51] < 0.9 + (double)num80)
													{
														Lighting.color2[num50, num51] = 0.9f + num80;
													}
													if ((double)Lighting.colorG2[num50, num51] < 0.3 + (double)num80)
													{
														Lighting.colorG2[num50, num51] = 0.3f + num80;
													}
													if ((double)Lighting.colorB2[num50, num51] < 0.1 + (double)num80)
													{
														Lighting.colorB2[num50, num51] = 0.1f + num80;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
											}
											else
											{
												if ((double)Lighting.color2[num50, num51] < 0.35)
												{
													Lighting.color2[num50, num51] = 0.35f;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
										}
									}
									if (Main.tile[num48, num49].frameX >= 36)
									{
										goto IL_42F9;
									}
									if (Lighting.color2[num50, num51] < 1f)
									{
										Lighting.color2[num50, num51] = 1f;
									}
									if ((double)Lighting.colorG2[num50, num51] < 0.95)
									{
										Lighting.colorG2[num50, num51] = 0.95f;
									}
									if ((double)Lighting.colorB2[num50, num51] < 0.65)
									{
										Lighting.colorB2[num50, num51] = 0.65f;
										goto IL_42F9;
									}
									goto IL_42F9;
								}
								IL_28BF:
								if (Main.tile[num48, num49].frameX >= 54)
								{
									goto IL_42F9;
								}
								if (Lighting.color2[num50, num51] < 1f)
								{
									Lighting.color2[num50, num51] = 1f;
								}
								if ((double)Lighting.colorG2[num50, num51] < 0.95)
								{
									Lighting.colorG2[num50, num51] = 0.95f;
								}
								if ((double)Lighting.colorB2[num50, num51] < 0.65)
								{
									Lighting.colorB2[num50, num51] = 0.65f;
									goto IL_42F9;
								}
								goto IL_42F9;
								IL_2A07:
								if (Main.tile[num48, num49].frameX >= 54)
								{
									goto IL_42F9;
								}
								if (Lighting.color2[num50, num51] < 1f)
								{
									Lighting.color2[num50, num51] = 1f;
								}
								if ((double)Lighting.colorG2[num50, num51] < 0.95)
								{
									Lighting.colorG2[num50, num51] = 0.95f;
								}
								if ((double)Lighting.colorB2[num50, num51] < 0.8)
								{
									Lighting.colorB2[num50, num51] = 0.8f;
									goto IL_42F9;
								}
								goto IL_42F9;
								IL_2B4F:
								if (Lighting.color2[num50, num51] < 0.83f)
								{
									Lighting.color2[num50, num51] = 0.83f;
								}
								if (Lighting.colorG2[num50, num51] < 0.6f)
								{
									Lighting.colorG2[num50, num51] = 0.6f;
								}
								if (Lighting.colorB2[num50, num51] < 0.5f)
								{
									Lighting.colorB2[num50, num51] = 0.5f;
									goto IL_42F9;
								}
								goto IL_42F9;
								IL_2CDE:
								if ((double)Lighting.color2[num50, num51] < 0.12)
								{
									Lighting.color2[num50, num51] = 0.12f;
								}
								if ((double)Lighting.colorG2[num50, num51] < 0.07)
								{
									Lighting.colorG2[num50, num51] = 0.07f;
								}
								if ((double)Lighting.colorB2[num50, num51] < 0.32)
								{
									Lighting.colorB2[num50, num51] = 0.32f;
									goto IL_42F9;
								}
								goto IL_42F9;
								IL_2FF1:
								float num81 = (float)Main.rand.Next(28, 42) * 0.005f;
								num81 += (float)(270 - (int)Main.mouseTextColor) / 1000f;
								if (Lighting.color2[num50, num51] < 0.1f)
								{
									Lighting.color2[num50, num51] = 0.1f;
								}
								if (Lighting.colorG2[num50, num51] < 0.2f + num81 / 2f)
								{
									Lighting.colorG2[num50, num51] = 0.2f + num81 / 2f;
								}
								if (Lighting.colorB2[num50, num51] < 0.7f + num81)
								{
									Lighting.colorB2[num50, num51] = 0.7f + num81;
								}
							}
							else
							{
								b = Main.tile[num48, num49].type;
								if (b <= 84)
								{
									if (b <= 42)
									{
										if (b <= 17)
										{
											if (b != 4)
											{
												if (b != 17)
												{
													goto IL_42F9;
												}
												goto IL_3E61;
											}
											else
											{
												if (Main.tile[num48, num49].frameX < 66)
												{
													Lighting.color2[num50, num51] = 1f;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
										}
										else
										{
											if (b != 22)
											{
												switch (b)
												{
												case 26:
												case 31:
												{
													float num82 = (float)Main.rand.Next(-5, 6) * 0.01f;
													if (Lighting.color2[num50, num51] < 0.4f + num82)
													{
														Lighting.color2[num50, num51] = 0.4f + num82;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
												case 27:
												case 28:
												case 29:
												case 30:
												case 32:
													goto IL_42F9;
												case 33:
													if (Main.tile[num48, num49].frameX == 0)
													{
														Lighting.color2[num50, num51] = 1f;
														goto IL_42F9;
													}
													goto IL_42F9;
												case 34:
												case 35:
												case 36:
													break;
												case 37:
													if (Lighting.color2[num50, num51] < 0.5f)
													{
														Lighting.color2[num50, num51] = 0.5f;
														goto IL_42F9;
													}
													goto IL_42F9;
												default:
													if (b != 42)
													{
														goto IL_42F9;
													}
													if (Main.tile[num48, num49].frameX == 0)
													{
														Lighting.color2[num50, num51] = 0.75f;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
											}
											else
											{
												if (Lighting.color2[num50, num51] < 0.2f)
												{
													Lighting.color2[num50, num51] = 0.2f;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
										}
									}
									else
									{
										if (b <= 61)
										{
											if (b != 49)
											{
												if (b != 61)
												{
													goto IL_42F9;
												}
												if (Main.tile[num48, num49].frameX == 144 && Lighting.color2[num50, num51] < 0.75f)
												{
													Lighting.color2[num50, num51] = 0.75f;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
											else
											{
												if (Lighting.color2[num50, num51] < 0.1f)
												{
													Lighting.color2[num50, num51] = 0.7f;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
										}
										else
										{
											switch (b)
											{
											case 70:
											case 71:
											case 72:
												goto IL_4000;
											default:
												if (b != 77)
												{
													if (b != 84)
													{
														goto IL_42F9;
													}
													int num83 = (int)(Main.tile[num48, num49].frameX / 18);
													float num84 = 0f;
													if (num83 == 2)
													{
														float num85 = (float)(270 - (int)Main.mouseTextColor);
														num85 /= 500f;
														if (num85 > 1f)
														{
															num85 = 1f;
														}
														if (num85 < 0f)
														{
															num85 = 0f;
														}
														num84 = num85;
													}
													else
													{
														if (num83 == 5)
														{
															num84 = 0.7f;
														}
													}
													if (Lighting.color2[num50, num51] < num84)
													{
														Lighting.color2[num50, num51] = num84;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
												else
												{
													if (Lighting.color2[num50, num51] < 0.6f)
													{
														Lighting.color2[num50, num51] = 0.6f;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
												break;
											}
										}
									}
								}
								else
								{
									if (b <= 160)
									{
										if (b <= 129)
										{
											switch (b)
											{
											case 92:
												if (Main.tile[num48, num49].frameY <= 18 && Main.tile[num48, num49].frameX == 0)
												{
													Lighting.color2[num50, num51] = 1f;
													goto IL_42F9;
												}
												goto IL_42F9;
											case 93:
												if (Main.tile[num48, num49].frameY == 0 && Main.tile[num48, num49].frameX == 0)
												{
													Lighting.color2[num50, num51] = 1f;
													goto IL_42F9;
												}
												goto IL_42F9;
											case 94:
											case 96:
											case 97:
											case 99:
												goto IL_42F9;
											case 95:
												if (Main.tile[num48, num49].frameX < 36 && Lighting.color2[num50, num51] < 0.85f)
												{
													Lighting.color2[num50, num51] = 0.9f;
													goto IL_42F9;
												}
												goto IL_42F9;
											case 98:
												if (Main.tile[num48, num49].frameY == 0)
												{
													Lighting.color2[num50, num51] = 1f;
													goto IL_42F9;
												}
												goto IL_42F9;
											case 100:
												if (Main.tile[num48, num49].frameX < 36)
												{
													Lighting.color2[num50, num51] = 1f;
													goto IL_42F9;
												}
												goto IL_42F9;
											default:
												switch (b)
												{
												case 125:
												{
													float num86 = (float)Main.rand.Next(28, 42) * 0.007f;
													num86 += (float)(270 - (int)Main.mouseTextColor) / 900f;
													if ((double)Lighting.color2[num50, num51] < 0.5 * (double)num86)
													{
														Lighting.color2[num50, num51] = 0.3f * num86;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
												case 126:
													if (Main.tile[num48, num49].frameX < 36 && Lighting.color2[num50, num51] < 0.3f)
													{
														Lighting.color2[num50, num51] = 0.3f;
														goto IL_42F9;
													}
													goto IL_42F9;
												case 127:
												case 128:
													goto IL_42F9;
												case 129:
												{
													float num87 = 0.08f;
													if (Lighting.color2[num50, num51] < num87)
													{
														Lighting.color2[num50, num51] = num87 * (float)Main.rand.Next(970, 1031) * 0.001f;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
												default:
													goto IL_42F9;
												}
												break;
											}
										}
										else
										{
											if (b == 133)
											{
												goto IL_3E61;
											}
											if (b != 149)
											{
												if (b != 160)
												{
													goto IL_42F9;
												}
												if (Lighting.color2[num50, num51] < 15f)
												{
													Lighting.color2[num50, num51] = 0.1f;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
											else
											{
												if (Main.tile[num48, num49].frameX > 36)
												{
													goto IL_42F9;
												}
												float num87 = 0.4f;
												if (Lighting.color2[num50, num51] < num87)
												{
													Lighting.color2[num50, num51] = num87 * (float)Main.rand.Next(970, 1031) * 0.001f;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
										}
									}
									else
									{
										if (b <= 190)
										{
											switch (b)
											{
											case 170:
											case 171:
											case 172:
												break;
											default:
												if (b != 190)
												{
													goto IL_42F9;
												}
												goto IL_4000;
											}
										}
										else
										{
											if (b != 204)
											{
												if (b != 215)
												{
													if (b == 237 && (double)Lighting.color2[num50, num51] < 0.1)
													{
														Lighting.color2[num50, num51] = 0.1f;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
												else
												{
													float num88 = (float)Main.rand.Next(28, 42) * 0.005f;
													num88 += (float)(270 - (int)Main.mouseTextColor) / 700f;
													if ((double)Lighting.color2[num50, num51] < 0.9 + (double)num88)
													{
														Lighting.color2[num50, num51] = 0.9f + num88;
														goto IL_42F9;
													}
													goto IL_42F9;
												}
											}
											else
											{
												if ((double)Lighting.color2[num50, num51] < 0.2)
												{
													Lighting.color2[num50, num51] = 0.2f;
													goto IL_42F9;
												}
												goto IL_42F9;
											}
										}
									}
								}
								if (Main.tile[num48, num49].frameX < 54)
								{
									Lighting.color2[num50, num51] = 1f;
									goto IL_42F9;
								}
								goto IL_42F9;
								IL_3E61:
								if (Lighting.color2[num50, num51] < 0.75f)
								{
									Lighting.color2[num50, num51] = 0.75f;
									goto IL_42F9;
								}
								goto IL_42F9;
								IL_4000:
								float num89 = (float)Main.rand.Next(38, 43) * 0.01f;
								if (Lighting.color2[num50, num51] < num89)
								{
									Lighting.color2[num50, num51] = num89;
								}
							}
						}
					}
					IL_42F9:
					if (Main.tile[num48, num49].lava() && Main.tile[num48, num49].liquid > 0)
					{
						if (Lighting.RGB)
						{
							float num90 = (float)(Main.tile[num48, num49].liquid / 255) * 0.41f + 0.14f;
							num90 = 0.55f;
							num90 += (float)(270 - (int)Main.mouseTextColor) / 900f;
							if (Lighting.color2[num50, num51] < num90)
							{
								Lighting.color2[num50, num51] = num90;
							}
							if (Lighting.colorG2[num50, num51] < num90)
							{
								Lighting.colorG2[num50, num51] = num90 * 0.6f;
							}
							if (Lighting.colorB2[num50, num51] < num90)
							{
								Lighting.colorB2[num50, num51] = num90 * 0.2f;
							}
						}
						else
						{
							float num91 = (float)(Main.tile[num48, num49].liquid / 255) * 0.38f + 0.08f;
							num91 += (float)(270 - (int)Main.mouseTextColor) / 2000f;
							if (Lighting.color2[num50, num51] < num91)
							{
								Lighting.color2[num50, num51] = num91;
							}
						}
					}
					else
					{
						if (Main.tile[num48, num49].liquid > 128)
						{
							Lighting.wetLight[num50, num51] = true;
							if (Main.tile[num48, num49].honey())
							{
								Lighting.honeyLight[num50, num51] = true;
							}
						}
					}
					if (Lighting.RGB)
					{
						if (Lighting.color2[num50, num51] > 0f || Lighting.colorG2[num50, num51] > 0f || Lighting.colorB2[num50, num51] > 0f)
						{
							if (Lighting.minX > num50)
							{
								Lighting.minX = num50;
							}
							if (Lighting.maxX < num50 + 1)
							{
								Lighting.maxX = num50 + 1;
							}
							if (Lighting.minY > num51)
							{
								Lighting.minY = num51;
							}
							if (Lighting.maxY < num51 + 1)
							{
								Lighting.maxY = num51 + 1;
							}
						}
					}
					else
					{
						if (Lighting.color2[num50, num51] > 0f)
						{
							if (Lighting.minX > num50)
							{
								Lighting.minX = num50;
							}
							if (Lighting.maxX < num50 + 1)
							{
								Lighting.maxX = num50 + 1;
							}
							if (Lighting.minY > num51)
							{
								Lighting.minY = num51;
							}
							if (Lighting.maxY < num51 + 1)
							{
								Lighting.maxY = num51 + 1;
							}
						}
					}
				}
			}
			if (Main.holyTiles < 0)
			{
				Main.holyTiles = 0;
			}
			if (Main.evilTiles < 0)
			{
				Main.evilTiles = 0;
			}
			int holyTiles = Main.holyTiles;
			Main.holyTiles -= Main.evilTiles;
			Main.evilTiles -= holyTiles;
			if (Main.holyTiles < 0)
			{
				Main.holyTiles = 0;
			}
			if (Main.evilTiles < 0)
			{
				Main.evilTiles = 0;
			}
			Lighting.minX += Lighting.firstToLightX;
			Lighting.maxX += Lighting.firstToLightX;
			Lighting.minY += Lighting.firstToLightY;
			Lighting.maxY += Lighting.firstToLightY;
			Lighting.minX7 = Lighting.minX;
			Lighting.maxX7 = Lighting.maxX;
			Lighting.minY7 = Lighting.minY;
			Lighting.maxY7 = Lighting.maxY;
			Lighting.firstTileX7 = Lighting.firstTileX;
			Lighting.lastTileX7 = Lighting.lastTileX;
			Lighting.lastTileY7 = Lighting.lastTileY;
			Lighting.firstTileY7 = Lighting.firstTileY;
			Lighting.firstToLightX7 = Lighting.firstToLightX;
			Lighting.lastToLightX7 = Lighting.lastToLightX;
			Lighting.firstToLightY7 = Lighting.firstToLightY;
			Lighting.lastToLightY7 = Lighting.lastToLightY;
			Lighting.firstToLightX27 = num;
			Lighting.lastToLightX27 = num3;
			Lighting.firstToLightY27 = num2;
			Lighting.lastToLightY27 = num4;
			Lighting.scrX = (int)Main.screenPosition.X / 16;
			Lighting.scrY = (int)Main.screenPosition.Y / 16;
			Main.renderCount = 0;
			Main.lightTimer[0] = (float)stopwatch.ElapsedMilliseconds;
			Lighting.doColors();
		}
		public static void doColors()
		{
			Stopwatch stopwatch = new Stopwatch();
			if (Lighting.lightMode < 2)
			{
				Lighting.blueWave += (float)Lighting.blueDir * 0.0001f;
				if (Lighting.blueWave > 1f)
				{
					Lighting.blueWave = 1f;
					Lighting.blueDir = -1;
				}
				else
				{
					if (Lighting.blueWave < 0.97f)
					{
						Lighting.blueWave = 0.97f;
						Lighting.blueDir = 1;
					}
				}
				if (Lighting.RGB)
				{
					Lighting.negLight = 0.91f;
					Lighting.negLight2 = 0.56f;
					Lighting.honeyLightG = 0.7f * Lighting.negLight * Lighting.blueWave;
					Lighting.honeyLightR = 0.75f * Lighting.negLight * Lighting.blueWave;
					Lighting.honeyLightB = 0.6f * Lighting.negLight * Lighting.blueWave;
					Lighting.wetLightG = 0.96f * Lighting.negLight * Lighting.blueWave;
					Lighting.wetLightR = 0.88f * Lighting.negLight * Lighting.blueWave;
					Lighting.wetLightB = 1.015f * Lighting.negLight * Lighting.blueWave;
					if (Main.waterStyle == 2)
					{
						Lighting.wetLightG = 0.85f * Lighting.negLight * Lighting.blueWave;
						Lighting.wetLightR = 0.94f * Lighting.negLight * Lighting.blueWave;
						Lighting.wetLightB = 1.01f * Lighting.negLight * Lighting.blueWave;
					}
					else
					{
						if (Main.waterStyle == 3)
						{
							Lighting.wetLightG = 0.95f * Lighting.negLight * Lighting.blueWave;
							Lighting.wetLightR = 0.84f * Lighting.negLight * Lighting.blueWave;
							Lighting.wetLightB = 1.015f * Lighting.negLight * Lighting.blueWave;
						}
						else
						{
							if (Main.waterStyle == 4)
							{
								Lighting.wetLightG = 0.86f * Lighting.negLight * Lighting.blueWave;
								Lighting.wetLightR = 0.9f * Lighting.negLight * Lighting.blueWave;
								Lighting.wetLightB = 1.01f * Lighting.negLight * Lighting.blueWave;
							}
							else
							{
								if (Main.waterStyle == 5)
								{
									Lighting.wetLightG = 0.99f * Lighting.negLight * Lighting.blueWave;
									Lighting.wetLightR = 0.84f * Lighting.negLight * Lighting.blueWave;
									Lighting.wetLightB = 1.01f * Lighting.negLight * Lighting.blueWave;
								}
								else
								{
									if (Main.waterStyle == 6)
									{
										Lighting.wetLightG = 0.98f * Lighting.negLight * Lighting.blueWave;
										Lighting.wetLightR = 0.95f * Lighting.negLight * Lighting.blueWave;
										Lighting.wetLightB = 0.85f * Lighting.negLight * Lighting.blueWave;
									}
									else
									{
										if (Main.waterStyle == 9)
										{
											Lighting.wetLightG = 0.88f * Lighting.negLight * Lighting.blueWave;
											Lighting.wetLightR = 1f * Lighting.negLight * Lighting.blueWave;
											Lighting.wetLightB = 0.84f * Lighting.negLight * Lighting.blueWave;
										}
										else
										{
											if (Main.waterStyle == 10)
											{
												Lighting.wetLightG = 1f * Lighting.negLight * Lighting.blueWave;
												Lighting.wetLightR = 0.83f * Lighting.negLight * Lighting.blueWave;
												Lighting.wetLightB = 1f * Lighting.negLight * Lighting.blueWave;
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
					Lighting.negLight = 0.9f;
					Lighting.negLight2 = 0.54f;
					Lighting.wetLightR = 0.95f * Lighting.negLight * Lighting.blueWave;
				}
				if (Main.player[Main.myPlayer].nightVision)
				{
					Lighting.negLight *= 1.03f;
					Lighting.negLight2 *= 1.03f;
				}
				if (Main.player[Main.myPlayer].blind)
				{
					Lighting.negLight *= 0.95f;
					Lighting.negLight2 *= 0.95f;
				}
				if (Main.player[Main.myPlayer].blackout)
				{
					Lighting.negLight *= 0.85f;
					Lighting.negLight2 *= 0.85f;
				}
				if (Lighting.RGB)
				{
					if (Main.renderCount == 0)
					{
						stopwatch.Restart();
						for (int i = Lighting.minX7; i < Lighting.maxX7; i++)
						{
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = 1;
							for (int j = Lighting.minY7; j < Lighting.lastToLightY27 + Lighting.maxRenderCount; j++)
							{
								Lighting.LightColor(i, j);
								Lighting.LightColorG(i, j);
								Lighting.LightColorB(i, j);
							}
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = -1;
							for (int k = Lighting.maxY7; k >= Lighting.firstTileY7 - Lighting.maxRenderCount; k--)
							{
								Lighting.LightColor(i, k);
								Lighting.LightColorG(i, k);
								Lighting.LightColorB(i, k);
							}
						}
						Main.lightTimer[1] = (float)stopwatch.ElapsedMilliseconds;
					}
					if (Main.renderCount == 1)
					{
						stopwatch.Restart();
						for (int l = Lighting.firstToLightY7; l < Lighting.lastToLightY7; l++)
						{
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = 1;
							Lighting.dirY = 0;
							for (int m = Lighting.minX7; m < Lighting.lastTileX7 + Lighting.maxRenderCount; m++)
							{
								Lighting.LightColor(m, l);
								Lighting.LightColorG(m, l);
								Lighting.LightColorB(m, l);
							}
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = -1;
							Lighting.dirY = 0;
							for (int n = Lighting.maxX7; n >= Lighting.firstTileX7 - Lighting.maxRenderCount; n--)
							{
								Lighting.LightColor(n, l);
								Lighting.LightColorG(n, l);
								Lighting.LightColorB(n, l);
							}
						}
						Main.lightTimer[2] = (float)stopwatch.ElapsedMilliseconds;
					}
					if (Main.renderCount == 1)
					{
						stopwatch.Restart();
						for (int num = Lighting.firstToLightX27; num < Lighting.lastToLightX27; num++)
						{
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = 1;
							for (int num2 = Lighting.firstToLightY27; num2 < Lighting.lastTileY7 + Lighting.maxRenderCount; num2++)
							{
								Lighting.LightColor(num, num2);
								Lighting.LightColorG(num, num2);
								Lighting.LightColorB(num, num2);
							}
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = -1;
							for (int num3 = Lighting.lastToLightY27; num3 >= Lighting.firstTileY7 - Lighting.maxRenderCount; num3--)
							{
								Lighting.LightColor(num, num3);
								Lighting.LightColorG(num, num3);
								Lighting.LightColorB(num, num3);
							}
						}
						Main.lightTimer[3] = (float)stopwatch.ElapsedMilliseconds;
					}
					if (Main.renderCount == 2)
					{
						stopwatch.Restart();
						for (int num4 = Lighting.firstToLightY27; num4 < Lighting.lastToLightY27; num4++)
						{
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = 1;
							Lighting.dirY = 0;
							for (int num5 = Lighting.firstToLightX27; num5 < Lighting.lastTileX7 + Lighting.maxRenderCount; num5++)
							{
								Lighting.LightColor(num5, num4);
								Lighting.LightColorG(num5, num4);
								Lighting.LightColorB(num5, num4);
							}
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = -1;
							Lighting.dirY = 0;
							for (int num6 = Lighting.lastToLightX27; num6 >= Lighting.firstTileX7 - Lighting.maxRenderCount; num6--)
							{
								Lighting.LightColor(num6, num4);
								Lighting.LightColorG(num6, num4);
								Lighting.LightColorB(num6, num4);
							}
						}
						Main.lightTimer[4] = (float)stopwatch.ElapsedMilliseconds;
						return;
					}
				}
				else
				{
					if (Main.renderCount == 0)
					{
						stopwatch.Restart();
						for (int num7 = Lighting.minX7; num7 < Lighting.maxX7; num7++)
						{
							Lighting.lightColor = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = 1;
							for (int num8 = Lighting.minY7; num8 < Lighting.lastToLightY27 + Lighting.maxRenderCount; num8++)
							{
								Lighting.LightColor(num7, num8);
							}
							Lighting.lightColor = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = -1;
							for (int num9 = Lighting.maxY7; num9 >= Lighting.firstTileY7 - Lighting.maxRenderCount; num9--)
							{
								Lighting.LightColor(num7, num9);
							}
						}
						Main.lightTimer[1] = (float)stopwatch.ElapsedMilliseconds;
					}
					if (Main.renderCount == 1)
					{
						stopwatch.Restart();
						for (int num10 = Lighting.firstToLightY7; num10 < Lighting.lastToLightY7; num10++)
						{
							Lighting.lightColor = 0f;
							Lighting.dirX = 1;
							Lighting.dirY = 0;
							for (int num11 = Lighting.minX7; num11 < Lighting.lastTileX7 + Lighting.maxRenderCount; num11++)
							{
								Lighting.LightColor(num11, num10);
							}
							Lighting.lightColor = 0f;
							Lighting.dirX = -1;
							Lighting.dirY = 0;
							for (int num12 = Lighting.maxX7; num12 >= Lighting.firstTileX7 - Lighting.maxRenderCount; num12--)
							{
								Lighting.LightColor(num12, num10);
							}
						}
						Main.lightTimer[2] = (float)stopwatch.ElapsedMilliseconds;
					}
					if (Main.renderCount == 1)
					{
						stopwatch.Restart();
						for (int num13 = Lighting.firstToLightX27; num13 < Lighting.lastToLightX27; num13++)
						{
							Lighting.lightColor = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = 1;
							for (int num14 = Lighting.firstToLightY27; num14 < Lighting.lastTileY7 + Lighting.maxRenderCount; num14++)
							{
								Lighting.LightColor(num13, num14);
							}
							Lighting.lightColor = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = -1;
							for (int num15 = Lighting.lastToLightY27; num15 >= Lighting.firstTileY7 - Lighting.maxRenderCount; num15--)
							{
								Lighting.LightColor(num13, num15);
							}
						}
						Main.lightTimer[3] = (float)stopwatch.ElapsedMilliseconds;
					}
					if (Main.renderCount == 2)
					{
						stopwatch.Restart();
						for (int num16 = Lighting.firstToLightY27; num16 < Lighting.lastToLightY27; num16++)
						{
							Lighting.lightColor = 0f;
							Lighting.dirX = 1;
							Lighting.dirY = 0;
							for (int num17 = Lighting.firstToLightX27; num17 < Lighting.lastTileX7 + Lighting.maxRenderCount; num17++)
							{
								Lighting.LightColor(num17, num16);
							}
							Lighting.lightColor = 0f;
							Lighting.dirX = -1;
							Lighting.dirY = 0;
							for (int num18 = Lighting.lastToLightX27; num18 >= Lighting.firstTileX7 - Lighting.maxRenderCount; num18--)
							{
								Lighting.LightColor(num18, num16);
							}
						}
						Main.lightTimer[4] = (float)stopwatch.ElapsedMilliseconds;
						return;
					}
				}
			}
			else
			{
				Lighting.negLight = 0.04f;
				Lighting.negLight2 = 0.16f;
				if (Main.player[Main.myPlayer].nightVision)
				{
					Lighting.negLight -= 0.013f;
					Lighting.negLight2 -= 0.04f;
				}
				if (Main.player[Main.myPlayer].blind)
				{
					Lighting.negLight += 0.03f;
					Lighting.negLight2 += 0.06f;
				}
				if (Main.player[Main.myPlayer].blackout)
				{
					Lighting.negLight += 0.09f;
					Lighting.negLight2 += 0.18f;
				}
				Lighting.wetLightR = Lighting.negLight * 1.2f;
				Lighting.wetLightG = Lighting.negLight * 1.1f;
				if (Lighting.RGB)
				{
					if (Main.renderCount == 0)
					{
						stopwatch.Restart();
						for (int num19 = Lighting.minX7; num19 < Lighting.maxX7; num19++)
						{
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = 1;
							for (int num20 = Lighting.minY7; num20 < Lighting.lastToLightY27 + Lighting.maxRenderCount; num20++)
							{
								Lighting.LightColor2(num19, num20);
								Lighting.LightColorG2(num19, num20);
								Lighting.LightColorB2(num19, num20);
							}
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = -1;
							for (int num21 = Lighting.maxY7; num21 >= Lighting.firstTileY7 - Lighting.maxRenderCount; num21--)
							{
								Lighting.LightColor2(num19, num21);
								Lighting.LightColorG2(num19, num21);
								Lighting.LightColorB2(num19, num21);
							}
						}
						Main.lightTimer[1] = (float)stopwatch.ElapsedMilliseconds;
					}
					if (Main.renderCount == 1)
					{
						stopwatch.Restart();
						for (int num22 = Lighting.firstToLightY7; num22 < Lighting.lastToLightY7; num22++)
						{
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = 1;
							Lighting.dirY = 0;
							for (int num23 = Lighting.minX7; num23 < Lighting.lastTileX7 + Lighting.maxRenderCount; num23++)
							{
								Lighting.LightColor2(num23, num22);
								Lighting.LightColorG2(num23, num22);
								Lighting.LightColorB2(num23, num22);
							}
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = -1;
							Lighting.dirY = 0;
							for (int num24 = Lighting.maxX7; num24 >= Lighting.firstTileX7 - Lighting.maxRenderCount; num24--)
							{
								Lighting.LightColor2(num24, num22);
								Lighting.LightColorG2(num24, num22);
								Lighting.LightColorB2(num24, num22);
							}
						}
						Main.lightTimer[2] = (float)stopwatch.ElapsedMilliseconds;
					}
					if (Main.renderCount == 1)
					{
						stopwatch.Restart();
						for (int num25 = Lighting.firstToLightX27; num25 < Lighting.lastToLightX27; num25++)
						{
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = 1;
							for (int num26 = Lighting.firstToLightY27; num26 < Lighting.lastTileY7 + Lighting.maxRenderCount; num26++)
							{
								Lighting.LightColor2(num25, num26);
								Lighting.LightColorG2(num25, num26);
								Lighting.LightColorB2(num25, num26);
							}
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = -1;
							for (int num27 = Lighting.lastToLightY27; num27 >= Lighting.firstTileY7 - Lighting.maxRenderCount; num27--)
							{
								Lighting.LightColor2(num25, num27);
								Lighting.LightColorG2(num25, num27);
								Lighting.LightColorB2(num25, num27);
							}
						}
						Main.lightTimer[3] = (float)stopwatch.ElapsedMilliseconds;
					}
					if (Main.renderCount == 2)
					{
						stopwatch.Restart();
						for (int num28 = Lighting.firstToLightY27; num28 < Lighting.lastToLightY27; num28++)
						{
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = 1;
							Lighting.dirY = 0;
							for (int num29 = Lighting.firstToLightX27; num29 < Lighting.lastTileX7 + Lighting.maxRenderCount; num29++)
							{
								Lighting.LightColor2(num29, num28);
								Lighting.LightColorG2(num29, num28);
								Lighting.LightColorB2(num29, num28);
							}
							Lighting.lightColor = 0f;
							Lighting.lightColorG = 0f;
							Lighting.lightColorB = 0f;
							Lighting.dirX = -1;
							Lighting.dirY = 0;
							for (int num30 = Lighting.lastToLightX27; num30 >= Lighting.firstTileX7 - Lighting.maxRenderCount; num30--)
							{
								Lighting.LightColor2(num30, num28);
								Lighting.LightColorG2(num30, num28);
								Lighting.LightColorB2(num30, num28);
							}
						}
						Main.lightTimer[4] = (float)stopwatch.ElapsedMilliseconds;
						return;
					}
				}
				else
				{
					if (Main.renderCount == 0)
					{
						stopwatch.Restart();
						for (int num31 = Lighting.minX7; num31 < Lighting.maxX7; num31++)
						{
							Lighting.lightColor = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = 1;
							for (int num32 = Lighting.minY7; num32 < Lighting.lastToLightY27 + Lighting.maxRenderCount; num32++)
							{
								Lighting.LightColor2(num31, num32);
							}
							Lighting.lightColor = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = -1;
							for (int num33 = Lighting.maxY7; num33 >= Lighting.firstTileY7 - Lighting.maxRenderCount; num33--)
							{
								Lighting.LightColor2(num31, num33);
							}
						}
						Main.lightTimer[1] = (float)stopwatch.ElapsedMilliseconds;
					}
					if (Main.renderCount == 1)
					{
						stopwatch.Restart();
						for (int num34 = Lighting.firstToLightY7; num34 < Lighting.lastToLightY7; num34++)
						{
							Lighting.lightColor = 0f;
							Lighting.dirX = 1;
							Lighting.dirY = 0;
							for (int num35 = Lighting.minX7; num35 < Lighting.lastTileX7 + Lighting.maxRenderCount; num35++)
							{
								Lighting.LightColor2(num35, num34);
							}
							Lighting.lightColor = 0f;
							Lighting.dirX = -1;
							Lighting.dirY = 0;
							for (int num36 = Lighting.maxX7; num36 >= Lighting.firstTileX7 - Lighting.maxRenderCount; num36--)
							{
								Lighting.LightColor2(num36, num34);
							}
						}
						Main.lightTimer[2] = (float)stopwatch.ElapsedMilliseconds;
					}
					if (Main.renderCount == 1)
					{
						stopwatch.Restart();
						for (int num37 = Lighting.firstToLightX27; num37 < Lighting.lastToLightX27; num37++)
						{
							Lighting.lightColor = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = 1;
							for (int num38 = Lighting.firstToLightY27; num38 < Lighting.lastTileY7 + Lighting.maxRenderCount; num38++)
							{
								Lighting.LightColor2(num37, num38);
							}
							Lighting.lightColor = 0f;
							Lighting.dirX = 0;
							Lighting.dirY = -1;
							for (int num39 = Lighting.lastToLightY27; num39 >= Lighting.firstTileY7 - Lighting.maxRenderCount; num39--)
							{
								Lighting.LightColor2(num37, num39);
							}
						}
						Main.lightTimer[3] = (float)stopwatch.ElapsedMilliseconds;
					}
					if (Main.renderCount == 2)
					{
						stopwatch.Restart();
						for (int num40 = Lighting.firstToLightY27; num40 < Lighting.lastToLightY27; num40++)
						{
							Lighting.lightColor = 0f;
							Lighting.dirX = 1;
							Lighting.dirY = 0;
							for (int num41 = Lighting.firstToLightX27; num41 < Lighting.lastTileX7 + Lighting.maxRenderCount; num41++)
							{
								Lighting.LightColor2(num41, num40);
							}
							Lighting.lightColor = 0f;
							Lighting.dirX = -1;
							Lighting.dirY = 0;
							for (int num42 = Lighting.lastToLightX27; num42 >= Lighting.firstTileX7 - Lighting.maxRenderCount; num42--)
							{
								Lighting.LightColor2(num42, num40);
							}
						}
						Main.lightTimer[4] = (float)stopwatch.ElapsedMilliseconds;
					}
				}
			}
		}
		public static void addLight(int i, int j, float Lightness)
		{
			if (Main.netMode == 2)
			{
				return;
			}
			if (i - Lighting.firstTileX + Lighting.offScreenTiles >= 0 && i - Lighting.firstTileX + Lighting.offScreenTiles < Main.screenWidth / 16 + Lighting.offScreenTiles * 2 + 10 && j - Lighting.firstTileY + Lighting.offScreenTiles >= 0 && j - Lighting.firstTileY + Lighting.offScreenTiles < Main.screenHeight / 16 + Lighting.offScreenTiles * 2 + 10)
			{
				if (Lighting.tempLightCount == Lighting.maxTempLights)
				{
					return;
				}
				if (!Lighting.RGB)
				{
					for (int k = 0; k < Lighting.tempLightCount; k++)
					{
						if (Lighting.tempLightX[k] == i && Lighting.tempLightY[k] == j && Lightness <= Lighting.tempLight[k])
						{
							return;
						}
					}
					Lighting.tempLightX[Lighting.tempLightCount] = i;
					Lighting.tempLightY[Lighting.tempLightCount] = j;
					Lighting.tempLight[Lighting.tempLightCount] = Lightness;
					Lighting.tempLightG[Lighting.tempLightCount] = Lightness;
					Lighting.tempLightB[Lighting.tempLightCount] = Lightness;
					Lighting.tempLightCount++;
					return;
				}
				Lighting.tempLight[Lighting.tempLightCount] = Lightness;
				Lighting.tempLightG[Lighting.tempLightCount] = Lightness;
				Lighting.tempLightB[Lighting.tempLightCount] = Lightness;
				Lighting.tempLightX[Lighting.tempLightCount] = i;
				Lighting.tempLightY[Lighting.tempLightCount] = j;
				Lighting.tempLightCount++;
			}
		}
		public static void addLight(int i, int j, float R, float G, float B)
		{
			if (Main.netMode == 2)
			{
				return;
			}
			if (!Lighting.RGB)
			{
				Lighting.addLight(i, j, (R + G + B) / 3f);
			}
			if (i - Lighting.firstTileX + Lighting.offScreenTiles >= 0 && i - Lighting.firstTileX + Lighting.offScreenTiles < Main.screenWidth / 16 + Lighting.offScreenTiles * 2 + 10 && j - Lighting.firstTileY + Lighting.offScreenTiles >= 0 && j - Lighting.firstTileY + Lighting.offScreenTiles < Main.screenHeight / 16 + Lighting.offScreenTiles * 2 + 10)
			{
				if (Lighting.tempLightCount == Lighting.maxTempLights)
				{
					return;
				}
				for (int k = 0; k < Lighting.tempLightCount; k++)
				{
					if (Lighting.tempLightX[k] == i && Lighting.tempLightY[k] == j)
					{
						if (Lighting.tempLight[k] < R)
						{
							Lighting.tempLight[k] = R;
						}
						if (Lighting.tempLightG[k] < G)
						{
							Lighting.tempLightG[k] = G;
						}
						if (Lighting.tempLightB[k] < B)
						{
							Lighting.tempLightB[k] = B;
						}
						return;
					}
				}
				Lighting.tempLight[Lighting.tempLightCount] = R;
				Lighting.tempLightG[Lighting.tempLightCount] = G;
				Lighting.tempLightB[Lighting.tempLightCount] = B;
				Lighting.tempLightX[Lighting.tempLightCount] = i;
				Lighting.tempLightY[Lighting.tempLightCount] = j;
				Lighting.tempLightCount++;
			}
		}
		public static void BlackOut()
		{
			int num = Main.screenWidth / 16 + Lighting.offScreenTiles * 2;
			int num2 = Main.screenHeight / 16 + Lighting.offScreenTiles * 2;
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num2; j++)
				{
					Lighting.color[i, j] = 0f;
					Lighting.colorG[i, j] = 0f;
					Lighting.colorB[i, j] = 0f;
				}
			}
		}
		private static void ResetRange()
		{
			Lighting.minX = Main.screenWidth + Lighting.offScreenTiles * 2 + 10;
			Lighting.maxX = 0;
			Lighting.minY = Main.screenHeight + Lighting.offScreenTiles * 2 + 10;
			Lighting.maxY = 0;
		}
		private static void LightColor(int i, int j)
		{
			int num = i - Lighting.firstToLightX7;
			int num2 = j - Lighting.firstToLightY7;
			if (Lighting.color2[num, num2] > Lighting.lightColor)
			{
				Lighting.lightColor = Lighting.color2[num, num2];
			}
			else
			{
				if ((double)Lighting.lightColor <= 0.0185)
				{
					return;
				}
				if (Lighting.color2[num, num2] < Lighting.lightColor)
				{
					Lighting.color2[num, num2] = Lighting.lightColor;
				}
			}
			if (Lighting.color2[num + Lighting.dirX, num2 + Lighting.dirY] > Lighting.lightColor)
			{
				return;
			}
			if (Lighting.stopLight[num, num2])
			{
				Lighting.lightColor *= Lighting.negLight2;
				return;
			}
			if (!Lighting.wetLight[num, num2])
			{
				Lighting.lightColor *= Lighting.negLight;
				return;
			}
			if (Lighting.honeyLight[num, num2])
			{
				Lighting.lightColor *= Lighting.honeyLightR * (float)Main.rand.Next(98, 100) * 0.01f;
				return;
			}
			Lighting.lightColor *= Lighting.wetLightR * (float)Main.rand.Next(98, 100) * 0.01f;
		}
		private static void LightColorG(int i, int j)
		{
			int num = i - Lighting.firstToLightX7;
			int num2 = j - Lighting.firstToLightY7;
			if (Lighting.colorG2[num, num2] > Lighting.lightColorG)
			{
				Lighting.lightColorG = Lighting.colorG2[num, num2];
			}
			else
			{
				if ((double)Lighting.lightColorG <= 0.0185)
				{
					return;
				}
				Lighting.colorG2[num, num2] = Lighting.lightColorG;
			}
			if (Lighting.colorG2[num + Lighting.dirX, num2 + Lighting.dirY] > Lighting.lightColorG)
			{
				return;
			}
			if (Lighting.stopLight[num, num2])
			{
				Lighting.lightColorG *= Lighting.negLight2;
				return;
			}
			if (!Lighting.wetLight[num, num2])
			{
				Lighting.lightColorG *= Lighting.negLight;
				return;
			}
			if (Lighting.honeyLight[num, num2])
			{
				Lighting.lightColorG *= Lighting.honeyLightG * (float)Main.rand.Next(97, 100) * 0.01f;
				return;
			}
			Lighting.lightColorG *= Lighting.wetLightG * (float)Main.rand.Next(97, 100) * 0.01f;
		}
		private static void LightColorB(int i, int j)
		{
			int num = i - Lighting.firstToLightX7;
			int num2 = j - Lighting.firstToLightY7;
			if (Lighting.colorB2[num, num2] > Lighting.lightColorB)
			{
				Lighting.lightColorB = Lighting.colorB2[num, num2];
			}
			else
			{
				if ((double)Lighting.lightColorB <= 0.0185)
				{
					return;
				}
				Lighting.colorB2[num, num2] = Lighting.lightColorB;
			}
			if (Lighting.colorB2[num + Lighting.dirX, num2 + Lighting.dirY] >= Lighting.lightColorB)
			{
				return;
			}
			if (Lighting.stopLight[num, num2])
			{
				Lighting.lightColorB *= Lighting.negLight2;
				return;
			}
			if (!Lighting.wetLight[num, num2])
			{
				Lighting.lightColorB *= Lighting.negLight;
				return;
			}
			if (Lighting.honeyLight[num, num2])
			{
				Lighting.lightColorB *= Lighting.honeyLightB * (float)Main.rand.Next(97, 100) * 0.01f;
				return;
			}
			Lighting.lightColorB *= Lighting.wetLightB * (float)Main.rand.Next(97, 100) * 0.01f;
		}
		private static void LightColor2(int i, int j)
		{
			int num = i - Lighting.firstToLightX7;
			int num2 = j - Lighting.firstToLightY7;
			try
			{
				if (Lighting.color2[num, num2] > Lighting.lightColor)
				{
					Lighting.lightColor = Lighting.color2[num, num2];
				}
				else
				{
					if (Lighting.lightColor <= 0f)
					{
						return;
					}
					Lighting.color2[num, num2] = Lighting.lightColor;
				}
				if (Main.tile[i, j].active() && Main.tileBlockLight[(int)Main.tile[i, j].type])
				{
					Lighting.lightColor -= Lighting.negLight2;
				}
				else
				{
					if (Lighting.wetLight[num, num2])
					{
						Lighting.lightColor -= Lighting.wetLightR;
					}
					else
					{
						Lighting.lightColor -= Lighting.negLight;
					}
				}
			}
			catch
			{
			}
		}
		private static void LightColorG2(int i, int j)
		{
			int num = i - Lighting.firstToLightX7;
			int num2 = j - Lighting.firstToLightY7;
			try
			{
				if (Lighting.colorG2[num, num2] > Lighting.lightColorG)
				{
					Lighting.lightColorG = Lighting.colorG2[num, num2];
				}
				else
				{
					if (Lighting.lightColorG <= 0f)
					{
						return;
					}
					Lighting.colorG2[num, num2] = Lighting.lightColorG;
				}
				if (Main.tile[i, j].active() && Main.tileBlockLight[(int)Main.tile[i, j].type])
				{
					Lighting.lightColorG -= Lighting.negLight2;
				}
				else
				{
					if (Lighting.wetLight[num, num2])
					{
						Lighting.lightColorG -= Lighting.wetLightG;
					}
					else
					{
						Lighting.lightColorG -= Lighting.negLight;
					}
				}
			}
			catch
			{
			}
		}
		private static void LightColorB2(int i, int j)
		{
			int num = i - Lighting.firstToLightX7;
			int num2 = j - Lighting.firstToLightY7;
			try
			{
				if (Lighting.colorB2[num, num2] > Lighting.lightColorB)
				{
					Lighting.lightColorB = Lighting.colorB2[num, num2];
				}
				else
				{
					if (Lighting.lightColorB <= 0f)
					{
						return;
					}
					Lighting.colorB2[num, num2] = Lighting.lightColorB;
				}
				if (Main.tile[i, j].active() && Main.tileBlockLight[(int)Main.tile[i, j].type])
				{
					Lighting.lightColorB -= Lighting.negLight2;
				}
				else
				{
					Lighting.lightColorB -= Lighting.negLight;
				}
			}
			catch
			{
			}
		}
		public static int LightingX(int lightX)
		{
			if (lightX < 0)
			{
				return 0;
			}
			if (lightX >= Main.screenWidth / 16 + Lighting.offScreenTiles * 2 + 10)
			{
				return Main.screenWidth / 16 + Lighting.offScreenTiles * 2 + 10 - 1;
			}
			return lightX;
		}
		public static int LightingY(int lightY)
		{
			if (lightY < 0)
			{
				return 0;
			}
			if (lightY >= Main.screenHeight / 16 + Lighting.offScreenTiles * 2 + 10)
			{
				return Main.screenHeight / 16 + Lighting.offScreenTiles * 2 + 10 - 1;
			}
			return lightY;
		}
		public static Color GetColor(int x, int y, Color oldColor)
		{
			int num = x - Lighting.firstTileX + Lighting.offScreenTiles;
			int num2 = y - Lighting.firstTileY + Lighting.offScreenTiles;
			if (Main.gameMenu)
			{
				return oldColor;
			}
			if (num < 0 || num2 < 0 || num >= Main.screenWidth / 16 + Lighting.offScreenTiles * 2 + 10 || num2 >= Main.screenHeight / 16 + Lighting.offScreenTiles * 2 + 10)
			{
				return Color.Black;
			}
			Color white = Color.White;
			int num3 = (int)((float)oldColor.R * Lighting.color[num, num2] * Lighting.brightness);
			int num4 = (int)((float)oldColor.G * Lighting.colorG[num, num2] * Lighting.brightness);
			int num5 = (int)((float)oldColor.B * Lighting.colorB[num, num2] * Lighting.brightness);
			if (num3 > 255)
			{
				num3 = 255;
			}
			if (num4 > 255)
			{
				num4 = 255;
			}
			if (num5 > 255)
			{
				num5 = 255;
			}
			white.R = (byte)num3;
			white.G = (byte)num4;
			white.B = (byte)num5;
			return white;
		}
		public static Color GetColor(int x, int y)
		{
			int num = x - Lighting.firstTileX + Lighting.offScreenTiles;
			int num2 = y - Lighting.firstTileY + Lighting.offScreenTiles;
			if (num < 0 || num2 < 0 || num >= Main.screenWidth / 16 + Lighting.offScreenTiles * 2 + 10 || num2 >= Main.screenHeight / 16 + Lighting.offScreenTiles * 2)
			{
				return Color.Black;
			}
			int num3 = (int)(255f * Lighting.color[num, num2] * Lighting.brightness);
			int num4 = (int)(255f * Lighting.colorG[num, num2] * Lighting.brightness);
			int num5 = (int)(255f * Lighting.colorB[num, num2] * Lighting.brightness);
			if (num3 > 255)
			{
				num3 = 255;
			}
			if (num4 > 255)
			{
				num4 = 255;
			}
			if (num5 > 255)
			{
				num5 = 255;
			}
			Color result = new Color((int)((byte)num3), (int)((byte)num4), (int)((byte)num5), 255);
			return result;
		}
		public static Color GetBlackness(int x, int y)
		{
			int num = x - Lighting.firstTileX + Lighting.offScreenTiles;
			int num2 = y - Lighting.firstTileY + Lighting.offScreenTiles;
			if (num < 0 || num2 < 0 || num >= Main.screenWidth / 16 + Lighting.offScreenTiles * 2 + 10 || num2 >= Main.screenHeight / 16 + Lighting.offScreenTiles * 2 + 10)
			{
				return Color.Black;
			}
			Color result = new Color(0, 0, 0, (int)((byte)(255f - 255f * Lighting.color[num, num2])));
			return result;
		}
		public static float Brightness(int x, int y)
		{
			int num = x - Lighting.firstTileX + Lighting.offScreenTiles;
			int num2 = y - Lighting.firstTileY + Lighting.offScreenTiles;
			if (num < 0 || num2 < 0 || num >= Main.screenWidth / 16 + Lighting.offScreenTiles * 2 + 10 || num2 >= Main.screenHeight / 16 + Lighting.offScreenTiles * 2 + 10)
			{
				return 0f;
			}
			return (Lighting.color[num, num2] + Lighting.colorG[num, num2] + Lighting.colorB[num, num2]) / 3f;
		}
		public static bool Brighter(int x, int y, int x2, int y2)
		{
			int num = x - Lighting.firstTileX + Lighting.offScreenTiles;
			int num2 = y - Lighting.firstTileY + Lighting.offScreenTiles;
			int num3 = x2 - Lighting.firstTileX + Lighting.offScreenTiles;
			int num4 = y2 - Lighting.firstTileY + Lighting.offScreenTiles;
			bool result;
			try
			{
				if (Lighting.color[num, num2] + Lighting.colorG[num, num2] + Lighting.colorB[num, num2] >= Lighting.color[num3, num4] + Lighting.colorG[num3, num4] + Lighting.colorB[num3, num4])
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}
	}
}
