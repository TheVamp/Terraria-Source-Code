using Microsoft.Xna.Framework;
using System;
namespace Terraria
{
	public class Rain
	{
		public Vector2 position;
		public Vector2 velocity;
		public float scale;
		public int alpha;
		public bool active;
		public byte type;
		public static void MakeRain()
		{
			if ((double)Main.screenPosition.Y > Main.worldSurface * 16.0)
			{
				return;
			}
			if (Main.gameMenu)
			{
				return;
			}
			float num = (float)Main.screenWidth / 1920f;
			num *= 25f;
			num *= 0.25f + 1f * Main.cloudAlpha;
			int num2 = 0;
			while ((float)num2 < num)
			{
				int num3 = 600;
				if (Main.player[Main.myPlayer].velocity.Y < 0f)
				{
					num3 += (int)(Math.Abs(Main.player[Main.myPlayer].velocity.Y) * 30f);
				}
				Vector2 vector;
				vector.X = (float)Main.rand.Next((int)Main.screenPosition.X - num3, (int)Main.screenPosition.X + Main.screenWidth + num3);
				vector.Y = Main.screenPosition.Y - (float)Main.rand.Next(20, 100);
				vector.X -= Main.windSpeed * 15f * 40f;
				vector.X += Main.player[Main.myPlayer].velocity.X * 40f;
				if (vector.X < 0f)
				{
					vector.X = 0f;
				}
				if (vector.X > (float)((Main.maxTilesX - 1) * 16))
				{
					vector.X = (float)((Main.maxTilesX - 1) * 16);
				}
				int num4 = (int)vector.X / 16;
				int num5 = (int)vector.Y / 16;
				if (num4 < 0)
				{
					num4 = 0;
				}
				if (num4 > Main.maxTilesX - 1)
				{
					num4 = Main.maxTilesX - 1;
				}
				if (Main.gameMenu || (!WorldGen.SolidTile(num4, num5) && Main.tile[num4, num5].wall <= 0))
				{
					Vector2 vector2 = new Vector2(Main.windSpeed * 12f, 14f);
					Rain.NewRain(vector, vector2);
				}
				num2++;
			}
		}
		public void Update()
		{
			this.position += this.velocity;
			if (Collision.SolidCollision(this.position, 2, 2) || this.position.Y > Main.screenPosition.Y + (float)Main.screenHeight + 100f || Collision.WetCollision(this.position, 2, 2))
			{
				this.active = false;
				if ((float)Main.rand.Next(100) < Main.gfxQuality * 100f)
				{
					int num = Dust.NewDust(this.position - this.velocity, 2, 2, 154, 0f, 0f, 0, default(Color), 1f);
					Dust expr_C3_cp_0 = Main.dust[num];
					expr_C3_cp_0.position.X = expr_C3_cp_0.position.X - 2f;
					Main.dust[num].alpha = 38;
					Main.dust[num].velocity *= 0.1f;
					Main.dust[num].velocity += -this.velocity * 0.025f;
					Main.dust[num].scale = 0.75f;
				}
			}
		}
		public static int NewRain(Vector2 Position, Vector2 Velocity)
		{
			int num = -1;
			int num2 = (int)((float)Main.maxRain * Main.cloudAlpha);
			if (num2 > Main.maxRain)
			{
				num2 = Main.maxRain;
			}
			float num3 = (1f + Main.gfxQuality) / 2f;
			if ((double)num3 < 0.9)
			{
				num2 = (int)((float)num2 * num3);
			}
			float num4 = (float)(800 - Main.snowTiles);
			if (num4 < 0f)
			{
				num4 = 0f;
			}
			num4 /= 800f;
			num2 = (int)((float)num2 * num4);
			for (int i = 0; i < num2; i++)
			{
				if (!Main.rain[i].active)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return Main.maxRain;
			}
			Main.rain[num].active = true;
			Main.rain[num].position = Position;
			Main.rain[num].scale = 1f + (float)Main.rand.Next(-20, 21) * 0.01f;
			Main.rain[num].velocity = Velocity * Main.rain[num].scale;
			Main.rain[num].type = (byte)Main.rand.Next(3);
			return num;
		}
	}
}
