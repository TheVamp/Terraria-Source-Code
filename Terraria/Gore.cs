using Microsoft.Xna.Framework;
using System;
namespace Terraria
{
	public class Gore
	{
		public static int goreTime = 600;
		public Vector2 position;
		public Vector2 velocity;
		public float rotation;
		public float scale;
		public int alpha;
		public int type;
		public float light;
		public bool active;
		public bool sticky = true;
		public int timeLeft = Gore.goreTime;
		public void Update()
		{
			if (Main.netMode == 2)
			{
				return;
			}
			if (this.active)
			{
				if (this.type >= 276 && this.type <= 282)
				{
					this.velocity.X = this.velocity.X * 0.98f;
					this.velocity.Y = this.velocity.Y * 0.98f;
					if (this.velocity.Y < this.scale)
					{
						this.velocity.Y = this.velocity.Y + 0.05f;
					}
					if ((double)this.velocity.Y > 0.1)
					{
						if (this.velocity.X > 0f)
						{
							this.rotation += 0.01f;
						}
						else
						{
							this.rotation -= 0.01f;
						}
					}
				}
				else
				{
					if (this.type == 11 || this.type == 12 || this.type == 13 || this.type == 61 || this.type == 62 || this.type == 63 || this.type == 99 || this.type == 220 || this.type == 221 || this.type == 222 || (this.type >= 375 && this.type <= 377) || (this.type >= 435 && this.type <= 437))
					{
						this.velocity.Y = this.velocity.Y * 0.98f;
						this.velocity.X = this.velocity.X * 0.98f;
						this.scale -= 0.007f;
						if ((double)this.scale < 0.1)
						{
							this.scale = 0.1f;
							this.alpha = 255;
						}
					}
					else
					{
						if (this.type == 16 || this.type == 17)
						{
							this.velocity.Y = this.velocity.Y * 0.98f;
							this.velocity.X = this.velocity.X * 0.98f;
							this.scale -= 0.01f;
							if ((double)this.scale < 0.1)
							{
								this.scale = 0.1f;
								this.alpha = 255;
							}
						}
						else
						{
							if (this.type == 331)
							{
								this.alpha += 5;
								this.velocity.Y = this.velocity.Y * 0.95f;
								this.velocity.X = this.velocity.X * 0.95f;
								this.rotation = this.velocity.X * 0.1f;
							}
							else
							{
								if (this.type < 411 || this.type > 430)
								{
									this.velocity.Y = this.velocity.Y + 0.2f;
								}
							}
						}
					}
				}
				this.rotation += this.velocity.X * 0.1f;
				if (this.type >= 411 && this.type <= 430)
				{
					this.alpha = 50;
					this.velocity.X = (this.velocity.X * 50f + Main.windSpeed * 2f + (float)Main.rand.Next(-10, 11) * 0.1f) / 51f;
					this.velocity.Y = (this.velocity.Y * 50f + -0.25f + (float)Main.rand.Next(-10, 11) * 0.2f) / 51f;
					this.rotation = this.velocity.X * 0.3f;
					if (Main.goreLoaded[this.type])
					{
						Rectangle rectangle = new Rectangle((int)this.position.X, (int)this.position.Y, (int)((float)Main.goreTexture[this.type].Width * this.scale), (int)((float)Main.goreTexture[this.type].Height * this.scale));
						for (int i = 0; i < 255; i++)
						{
							if (Main.player[i].active && !Main.player[i].dead)
							{
								Rectangle value = new Rectangle((int)Main.player[i].position.X, (int)Main.player[i].position.Y, Main.player[i].width, Main.player[i].height);
								if (rectangle.Intersects(value))
								{
									this.timeLeft = 0;
								}
							}
						}
						if (Collision.SolidCollision(this.position, (int)((float)Main.goreTexture[this.type].Width * this.scale), (int)((float)Main.goreTexture[this.type].Height * this.scale)))
						{
							this.timeLeft = 0;
						}
					}
					if (this.timeLeft > 0)
					{
						if (Main.rand.Next(2) == 0)
						{
							this.timeLeft--;
						}
						if (Main.rand.Next(50) == 0)
						{
							this.timeLeft -= 5;
						}
						if (Main.rand.Next(100) == 0)
						{
							this.timeLeft -= 10;
						}
					}
					else
					{
						this.alpha = 255;
						if (Main.goreLoaded[this.type])
						{
							float num = (float)Main.goreTexture[this.type].Width * this.scale * 0.8f;
							float x = this.position.X;
							float y = this.position.Y;
							float num2 = (float)Main.goreTexture[this.type].Width * this.scale;
							float num3 = (float)Main.goreTexture[this.type].Height * this.scale;
							int num4 = 176;
							if (this.type >= 416 && this.type <= 420)
							{
								num4 = 177;
							}
							if (this.type >= 421 && this.type <= 425)
							{
								num4 = 178;
							}
							if (this.type >= 426 && this.type <= 430)
							{
								num4 = 179;
							}
							int num5 = 0;
							while ((float)num5 < num)
							{
								int num6 = Dust.NewDust(new Vector2(x, y), (int)num2, (int)num3, num4, 0f, 0f, 0, default(Color), 1f);
								Main.dust[num6].noGravity = true;
								Main.dust[num6].alpha = 100;
								Main.dust[num6].scale = this.scale;
								num5++;
							}
						}
					}
				}
				else
				{
					if (this.sticky)
					{
						int num7 = 32;
						if (Main.goreLoaded[this.type])
						{
							num7 = Main.goreTexture[this.type].Width;
							if (Main.goreTexture[this.type].Height < num7)
							{
								num7 = Main.goreTexture[this.type].Height;
							}
						}
						num7 = (int)((float)num7 * 0.9f);
						this.velocity = Collision.TileCollision(this.position, this.velocity, (int)((float)num7 * this.scale), (int)((float)num7 * this.scale), false, false);
						if (this.velocity.Y == 0f)
						{
							this.velocity.X = this.velocity.X * 0.97f;
							if ((double)this.velocity.X > -0.01 && (double)this.velocity.X < 0.01)
							{
								this.velocity.X = 0f;
							}
						}
						if (this.timeLeft > 0)
						{
							this.timeLeft--;
						}
						else
						{
							this.alpha++;
						}
					}
					else
					{
						this.alpha += 2;
					}
				}
				this.position += this.velocity;
				if (this.alpha >= 255)
				{
					this.active = false;
				}
				if (this.light > 0f)
				{
					float num8 = this.light * this.scale;
					float num9 = this.light * this.scale;
					float num10 = this.light * this.scale;
					if (this.type == 16)
					{
						num10 *= 0.3f;
						num9 *= 0.8f;
					}
					else
					{
						if (this.type == 17)
						{
							num9 *= 0.6f;
							num8 *= 0.3f;
						}
					}
					if (Main.goreLoaded[this.type])
					{
						Lighting.addLight((int)((this.position.X + (float)Main.goreTexture[this.type].Width * this.scale / 2f) / 16f), (int)((this.position.Y + (float)Main.goreTexture[this.type].Height * this.scale / 2f) / 16f), num8, num9, num10);
						return;
					}
					Lighting.addLight((int)((this.position.X + 32f * this.scale / 2f) / 16f), (int)((this.position.Y + 32f * this.scale / 2f) / 16f), num8, num9, num10);
				}
			}
		}
		public static int NewGore(Vector2 Position, Vector2 Velocity, int Type, float Scale = 1f)
		{
			if (Main.rand == null)
			{
				Main.rand = new Random();
			}
			if (Main.netMode == 2)
			{
				return 0;
			}
			int num = 500;
			for (int i = 0; i < 500; i++)
			{
				if (!Main.gore[i].active)
				{
					num = i;
					break;
				}
			}
			if (num == 500)
			{
				return num;
			}
			Main.gore[num].light = 0f;
			Main.gore[num].position = Position;
			Main.gore[num].velocity = Velocity;
			Gore expr_84_cp_0 = Main.gore[num];
			expr_84_cp_0.velocity.Y = expr_84_cp_0.velocity.Y - (float)Main.rand.Next(10, 31) * 0.1f;
			Gore expr_B1_cp_0 = Main.gore[num];
			expr_B1_cp_0.velocity.X = expr_B1_cp_0.velocity.X + (float)Main.rand.Next(-20, 21) * 0.1f;
			Main.gore[num].type = Type;
			Main.gore[num].active = true;
			Main.gore[num].alpha = 0;
			Main.gore[num].rotation = 0f;
			Main.gore[num].scale = Scale;
			if (Gore.goreTime == 0 || Type == 11 || Type == 12 || Type == 13 || Type == 16 || Type == 17 || Type == 61 || Type == 62 || Type == 63 || Type == 99 || Type == 220 || Type == 221 || Type == 222 || Type == 435 || Type == 436 || Type == 437)
			{
				Main.gore[num].sticky = false;
			}
			else
			{
				if (Type >= 375 && Type <= 377)
				{
					Main.gore[num].sticky = false;
					Main.gore[num].alpha = 100;
				}
				else
				{
					Main.gore[num].sticky = true;
					Main.gore[num].timeLeft = Gore.goreTime;
				}
			}
			if (Type == 16 || Type == 17)
			{
				Main.gore[num].alpha = 100;
				Main.gore[num].scale = 0.7f;
				Main.gore[num].light = 1f;
			}
			if (Type >= 411 && Type <= 430 && Main.goreLoaded[Type])
			{
				Main.gore[num].position.X = Position.X - (float)(Main.goreTexture[Type].Width / 2) * Scale;
				Main.gore[num].position.Y = Position.Y - (float)Main.goreTexture[Type].Height * Scale;
				Gore expr_28F_cp_0 = Main.gore[num];
				expr_28F_cp_0.velocity.Y = expr_28F_cp_0.velocity.Y * ((float)Main.rand.Next(90, 150) * 0.01f);
				Gore expr_2BF_cp_0 = Main.gore[num];
				expr_2BF_cp_0.velocity.X = expr_2BF_cp_0.velocity.X * ((float)Main.rand.Next(40, 90) * 0.01f);
				int num2 = Main.rand.Next(4) * 5;
				Main.gore[num].type += num2;
				Main.gore[num].timeLeft = Main.rand.Next(Gore.goreTime / 2, Gore.goreTime * 2);
			}
			return num;
		}
		public Color GetAlpha(Color newColor)
		{
			float num = (float)(255 - this.alpha) / 255f;
			int r;
			int g;
			int b;
			if (this.type == 16 || this.type == 17)
			{
				r = (int)newColor.R;
				g = (int)newColor.G;
				b = (int)newColor.B;
			}
			else
			{
				if (this.type == 331)
				{
					return new Color(255, 255, 255, 50);
				}
				r = (int)((float)newColor.R * num);
				g = (int)((float)newColor.G * num);
				b = (int)((float)newColor.B * num);
			}
			int num2 = (int)newColor.A - this.alpha;
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num2 > 255)
			{
				num2 = 255;
			}
			return new Color(r, g, b, num2);
		}
	}
}
