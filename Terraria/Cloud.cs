using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
namespace Terraria
{
	public class Cloud
	{
		public Vector2 position;
		public float scale;
		public float rotation;
		public float rSpeed;
		public float sSpeed;
		public bool active;
		public SpriteEffects spriteDir;
		public int type;
		public int width;
		public int height;
		public float Alpha;
		public bool kill;
		private static Random rand = new Random();
		public static void resetClouds()
		{
			if (Main.dedServ)
			{
				return;
			}
			if (Main.cloudLimit < 10)
			{
				return;
			}
			Main.windSpeed = Main.windSpeedSet;
			for (int i = 0; i < 200; i++)
			{
				Main.cloud[i].active = false;
			}
			for (int j = 0; j < Main.numClouds; j++)
			{
				Cloud.addCloud();
				Main.cloud[j].Alpha = 1f;
			}
			for (int k = 0; k < 200; k++)
			{
				Main.cloud[k].Alpha = 1f;
			}
		}
		public static void addCloud()
		{
			if (Main.netMode == 2)
			{
				return;
			}
			int num = -1;
			for (int i = 0; i < 200; i++)
			{
				if (!Main.cloud[i].active)
				{
					num = i;
					break;
				}
			}
			if (num >= 0)
			{
				Main.cloud[num].kill = false;
				Main.cloud[num].rSpeed = 0f;
				Main.cloud[num].sSpeed = 0f;
				Main.cloud[num].scale = (float)Cloud.rand.Next(70, 131) * 0.01f;
				Main.cloud[num].rotation = (float)Cloud.rand.Next(-10, 11) * 0.01f;
				Main.cloud[num].width = (int)((float)Main.cloudTexture[Main.cloud[num].type].Width * Main.cloud[num].scale);
				Main.cloud[num].height = (int)((float)Main.cloudTexture[Main.cloud[num].type].Height * Main.cloud[num].scale);
				Main.cloud[num].Alpha = 0f;
				Main.cloud[num].spriteDir = SpriteEffects.None;
				if (Cloud.rand.Next(2) == 0)
				{
					Main.cloud[num].spriteDir = SpriteEffects.FlipHorizontally;
				}
				float num2 = Main.windSpeed;
				if (!Main.gameMenu)
				{
					num2 = Main.windSpeed - Main.player[Main.myPlayer].velocity.X * 0.1f;
				}
				int num3 = 0;
				int num4 = 0;
				if (num2 > 0f)
				{
					num3 -= 200;
				}
				if (num2 < 0f)
				{
					num4 += 200;
				}
				int num5 = 300;
				float x = (float)WorldGen.genRand.Next(num3 - num5, Main.screenWidth + num4 + num5);
				Main.cloud[num].Alpha = 0f;
				Main.cloud[num].position.Y = (float)Cloud.rand.Next((int)((float)(-(float)Main.screenHeight) * 0.25f), (int)((float)Main.screenHeight * 0.25f));
				Cloud expr_211_cp_0 = Main.cloud[num];
				expr_211_cp_0.position.Y = expr_211_cp_0.position.Y - (float)Cloud.rand.Next((int)((float)Main.screenHeight * 0.15f));
				Cloud expr_241_cp_0 = Main.cloud[num];
				expr_241_cp_0.position.Y = expr_241_cp_0.position.Y - (float)Cloud.rand.Next((int)((float)Main.screenHeight * 0.15f));
				Main.cloud[num].type = Cloud.rand.Next(4);
				if (Main.rand == null)
				{
					Main.rand = new Random();
				}
				if ((Main.cloudAlpha > 0f && Cloud.rand.Next(4) != 0) || (Main.cloudBGActive >= 1f && Main.rand.Next(2) == 0))
				{
					Main.cloud[num].type = Cloud.rand.Next(18, 22);
					if ((double)Main.cloud[num].scale >= 1.15)
					{
						Cloud expr_303_cp_0 = Main.cloud[num];
						expr_303_cp_0.position.Y = expr_303_cp_0.position.Y - 150f;
					}
					if (Main.cloud[num].scale >= 1f)
					{
						Cloud expr_336_cp_0 = Main.cloud[num];
						expr_336_cp_0.position.Y = expr_336_cp_0.position.Y - 150f;
					}
				}
				else
				{
					if (((Main.cloudBGActive <= 0f && Main.cloudAlpha == 0f && Main.cloud[num].scale < 1f && Main.cloud[num].position.Y < (float)(-(float)Main.screenHeight) * 0.2f) || Main.cloud[num].position.Y < (float)(-(float)Main.screenHeight) * 0.2f) && (double)Main.numClouds < 50.0)
					{
						Main.cloud[num].type = Cloud.rand.Next(9, 14);
					}
					else
					{
						if ((((double)Main.cloud[num].scale < 1.15 && Main.cloud[num].position.Y < (float)(-(float)Main.screenHeight) * 0.3f) || ((double)Main.cloud[num].scale < 0.85 && Main.cloud[num].position.Y < (float)Main.screenHeight * 0.15f)) && ((double)Main.numClouds > 70.0 || Main.cloudBGActive >= 1f))
						{
							Main.cloud[num].type = Cloud.rand.Next(4, 9);
						}
						else
						{
							if (Main.cloud[num].position.Y > (float)(-(float)Main.screenHeight) * 0.15f && Cloud.rand.Next(2) == 0 && (double)Main.numClouds > 20.0)
							{
								Main.cloud[num].type = Cloud.rand.Next(14, 18);
							}
						}
					}
				}
				if ((double)Main.cloud[num].scale > 1.2)
				{
					Cloud expr_50A_cp_0 = Main.cloud[num];
					expr_50A_cp_0.position.Y = expr_50A_cp_0.position.Y + 100f;
				}
				if ((double)Main.cloud[num].scale > 1.3)
				{
					Main.cloud[num].scale = 1.3f;
				}
				if ((double)Main.cloud[num].scale < 0.7)
				{
					Main.cloud[num].scale = 0.7f;
				}
				Main.cloud[num].active = true;
				Main.cloud[num].position.X = x;
				if (Main.cloud[num].position.X > (float)(Main.screenWidth + 100))
				{
					Main.cloud[num].Alpha = 1f;
				}
				if (Main.cloud[num].position.X + (float)Main.cloudTexture[Main.cloud[num].type].Width * Main.cloud[num].scale < -100f)
				{
					Main.cloud[num].Alpha = 1f;
				}
				Rectangle rectangle = new Rectangle((int)Main.cloud[num].position.X, (int)Main.cloud[num].position.Y, Main.cloud[num].width, Main.cloud[num].height);
				for (int j = 0; j < 200; j++)
				{
					if (num != j && Main.cloud[j].active)
					{
						Rectangle value = new Rectangle((int)Main.cloud[j].position.X, (int)Main.cloud[j].position.Y, Main.cloud[j].width, Main.cloud[j].height);
						if (rectangle.Intersects(value))
						{
							Main.cloud[num].active = false;
						}
					}
				}
			}
		}
		public Color cloudColor(Color bgColor)
		{
			float num = this.scale * this.Alpha;
			if (num > 1f)
			{
				num = 1f;
			}
			float num2 = (float)((int)((float)bgColor.R * num));
			float num3 = (float)((int)((float)bgColor.G * num));
			float num4 = (float)((int)((float)bgColor.B * num));
			float num5 = (float)((int)((float)bgColor.A * num));
			return new Color((int)((byte)num2), (int)((byte)num3), (int)((byte)num4), (int)((byte)num5));
		}
		public object Clone()
		{
			return base.MemberwiseClone();
		}
		public static void UpdateClouds()
		{
			if (Main.netMode == 2)
			{
				return;
			}
			int num = 0;
			for (int i = 0; i < 200; i++)
			{
				if (Main.cloud[i].active)
				{
					Main.cloud[i].Update();
					if (!Main.cloud[i].kill)
					{
						num++;
					}
				}
			}
			for (int j = 0; j < 200; j++)
			{
				if (Main.cloud[j].active)
				{
					if (j > 1 && (!Main.cloud[j - 1].active || (double)Main.cloud[j - 1].scale > (double)Main.cloud[j].scale + 0.02))
					{
						Cloud cloud = (Cloud)Main.cloud[j - 1].Clone();
						Main.cloud[j - 1] = (Cloud)Main.cloud[j].Clone();
						Main.cloud[j] = cloud;
					}
					if (j < 199 && (!Main.cloud[j].active || (double)Main.cloud[j + 1].scale < (double)Main.cloud[j].scale - 0.02))
					{
						Cloud cloud2 = (Cloud)Main.cloud[j + 1].Clone();
						Main.cloud[j + 1] = (Cloud)Main.cloud[j].Clone();
						Main.cloud[j] = cloud2;
					}
				}
			}
			if (num < Main.numClouds)
			{
				Cloud.addCloud();
				return;
			}
			if (num > Main.numClouds)
			{
				int num2 = Main.rand.Next(num);
				int num3 = 0;
				while (Main.cloud[num2].kill && num3 < 100)
				{
					num3++;
					num2 = Main.rand.Next(num);
				}
				Main.cloud[num2].kill = true;
			}
		}
		public void Update()
		{
			if (Main.gameMenu)
			{
				this.position.X = this.position.X + Main.windSpeed * this.scale * 3f;
			}
			else
			{
				if (this.scale == 1f)
				{
					this.scale -= 0.0001f;
				}
				if ((double)this.scale == 1.15)
				{
					this.scale -= 0.0001f;
				}
				float num;
				if (this.scale < 1f)
				{
					num = 0.07f;
					float num2 = this.scale + 0.15f;
					num2 = (num2 + 1f) / 2f;
					num2 *= num2;
					num *= num2;
				}
				else
				{
					if ((double)this.scale <= 1.15)
					{
						num = 0.17f;
						float num3 = this.scale - 0.075f;
						num3 *= num3;
						num *= num3;
					}
					else
					{
						num = 0.23f;
						float num4 = this.scale - 0.15f - 0.075f;
						num4 *= num4;
						num *= num4;
					}
				}
				this.position.X = this.position.X + Main.windSpeed * num * 5f * (float)Main.dayRate;
				float num5 = Main.screenPosition.X - Main.screenLastPosition.X;
				this.position.X = this.position.X - num5 * num;
			}
			float num6 = 600f;
			if (!this.kill)
			{
				if (this.Alpha < 1f)
				{
					this.Alpha += 0.001f * (float)Main.dayRate;
					if (this.Alpha > 1f)
					{
						this.Alpha = 1f;
					}
				}
			}
			else
			{
				this.Alpha -= 0.001f * (float)Main.dayRate;
				if (this.Alpha <= 0f)
				{
					this.active = false;
				}
			}
			if (this.position.X + (float)Main.cloudTexture[this.type].Width * this.scale < -num6 || this.position.X > (float)Main.screenWidth + num6)
			{
				this.active = false;
			}
			this.rSpeed += (float)Cloud.rand.Next(-10, 11) * 2E-05f;
			if ((double)this.rSpeed > 0.0002)
			{
				this.rSpeed = 0.0002f;
			}
			if ((double)this.rSpeed < -0.0002)
			{
				this.rSpeed = -0.0002f;
			}
			if ((double)this.rotation > 0.02)
			{
				this.rotation = 0.02f;
			}
			if ((double)this.rotation < -0.02)
			{
				this.rotation = -0.02f;
			}
			this.rotation += this.rSpeed;
			this.width = (int)((float)Main.cloudTexture[this.type].Width * this.scale);
			this.height = (int)((float)Main.cloudTexture[this.type].Height * this.scale);
			if (this.type >= 9 && this.type <= 13 && (Main.cloudAlpha > 0f || Main.cloudBGActive >= 1f))
			{
				this.kill = true;
			}
		}
	}
}
