using Microsoft.Xna.Framework;
using System;
namespace Terraria
{
	public class ItemText
	{
		public Vector2 position;
		public Vector2 velocity;
		public float alpha;
		public int alphaDir = 1;
		public string name;
		public int stack;
		public float scale = 1f;
		public float rotation;
		public Color color;
		public bool active;
		public int lifeTime;
		public static int activeTime = 60;
		public static int numActive;
		public static void NewText(Item newItem, int stack)
		{
			if (!Main.showItemText)
			{
				return;
			}
			if (newItem.name == null || !newItem.active)
			{
				return;
			}
			if (Main.netMode == 2)
			{
				return;
			}
			for (int i = 0; i < 20; i++)
			{
				if (Main.itemText[i].active && Main.itemText[i].name == newItem.name)
				{
					string text = string.Concat(new object[]
					{
						newItem.name,
						" (",
						Main.itemText[i].stack + stack,
						")"
					});
					string text2 = newItem.name;
					if (Main.itemText[i].stack > 1)
					{
						object obj = text2;
						text2 = string.Concat(new object[]
						{
							obj,
							" (",
							Main.itemText[i].stack,
							")"
						});
					}
					Vector2 vector = Main.fontMouseText.MeasureString(text2);
					vector = Main.fontMouseText.MeasureString(text);
					if (Main.itemText[i].lifeTime < 0)
					{
						Main.itemText[i].scale = 1f;
					}
					Main.itemText[i].lifeTime = 60;
					Main.itemText[i].stack += stack;
					Main.itemText[i].scale = 0f;
					Main.itemText[i].rotation = 0f;
					Main.itemText[i].position.X = newItem.position.X + (float)newItem.width * 0.5f - vector.X * 0.5f;
					Main.itemText[i].position.Y = newItem.position.Y + (float)newItem.height * 0.25f - vector.Y * 0.5f;
					Main.itemText[i].velocity.Y = -7f;
					return;
				}
			}
			int num = -1;
			for (int j = 0; j < 20; j++)
			{
				if (!Main.itemText[j].active)
				{
					num = j;
					break;
				}
			}
			if (num == -1)
			{
				double num2 = (double)Main.bottomWorld;
				for (int k = 0; k < 20; k++)
				{
					if (num2 > (double)Main.itemText[k].position.Y)
					{
						num = k;
						num2 = (double)Main.itemText[k].position.Y;
					}
				}
			}
			if (num >= 0)
			{
				string text3 = newItem.AffixName();
				if (stack > 1)
				{
					object obj2 = text3;
					text3 = string.Concat(new object[]
					{
						obj2,
						" (",
						stack,
						")"
					});
				}
				Vector2 vector2 = Main.fontMouseText.MeasureString(text3);
				Main.itemText[num].alpha = 1f;
				Main.itemText[num].alphaDir = -1;
				Main.itemText[num].active = true;
				Main.itemText[num].scale = 0f;
				Main.itemText[num].rotation = 0f;
				Main.itemText[num].position.X = newItem.position.X + (float)newItem.width * 0.5f - vector2.X * 0.5f;
				Main.itemText[num].position.Y = newItem.position.Y + (float)newItem.height * 0.25f - vector2.Y * 0.5f;
				Main.itemText[num].color = Color.White;
				if (newItem.rare == 1)
				{
					Main.itemText[num].color = new Color(150, 150, 255);
				}
				else
				{
					if (newItem.rare == 2)
					{
						Main.itemText[num].color = new Color(150, 255, 150);
					}
					else
					{
						if (newItem.rare == 3)
						{
							Main.itemText[num].color = new Color(255, 200, 150);
						}
						else
						{
							if (newItem.rare == 4)
							{
								Main.itemText[num].color = new Color(255, 150, 150);
							}
							else
							{
								if (newItem.rare == 5)
								{
									Main.itemText[num].color = new Color(255, 150, 255);
								}
								else
								{
									if (newItem.rare == -1)
									{
										Main.itemText[num].color = new Color(130, 130, 130);
									}
									else
									{
										if (newItem.rare == 6)
										{
											Main.itemText[num].color = new Color(210, 160, 255);
										}
										else
										{
											if (newItem.rare == 7)
											{
												Main.itemText[num].color = new Color(150, 255, 10);
											}
											else
											{
												if (newItem.rare == 8)
												{
													Main.itemText[num].color = new Color(255, 255, 10);
												}
												else
												{
													if (newItem.rare >= 9)
													{
														Main.itemText[num].color = new Color(5, 200, 255);
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
				Main.itemText[num].name = newItem.AffixName();
				Main.itemText[num].stack = stack;
				Main.itemText[num].velocity.Y = -7f;
				Main.itemText[num].lifeTime = 60;
			}
		}
		public void Update(int whoAmI)
		{
			if (this.active)
			{
				this.alpha += (float)this.alphaDir * 0.01f;
				if ((double)this.alpha <= 0.7)
				{
					this.alpha = 0.7f;
					this.alphaDir = 1;
				}
				if (this.alpha >= 1f)
				{
					this.alpha = 1f;
					this.alphaDir = -1;
				}
				bool flag = false;
				string text = this.name;
				if (this.stack > 1)
				{
					object obj = text;
					text = string.Concat(new object[]
					{
						obj,
						" (",
						this.stack,
						")"
					});
				}
				Vector2 value = Main.fontMouseText.MeasureString(text);
				value *= this.scale;
				value.Y *= 0.8f;
				Rectangle rectangle = new Rectangle((int)(this.position.X - value.X / 2f), (int)(this.position.Y - value.Y / 2f), (int)value.X, (int)value.Y);
				for (int i = 0; i < 20; i++)
				{
					if (Main.itemText[i].active && i != whoAmI)
					{
						string text2 = Main.itemText[i].name;
						if (Main.itemText[i].stack > 1)
						{
							object obj2 = text2;
							text2 = string.Concat(new object[]
							{
								obj2,
								" (",
								Main.itemText[i].stack,
								")"
							});
						}
						Vector2 value2 = Main.fontMouseText.MeasureString(text2);
						value2 *= Main.itemText[i].scale;
						value2.Y *= 0.8f;
						Rectangle value3 = new Rectangle((int)(Main.itemText[i].position.X - value2.X / 2f), (int)(Main.itemText[i].position.Y - value2.Y / 2f), (int)value2.X, (int)value2.Y);
						if (rectangle.Intersects(value3) && (this.position.Y < Main.itemText[i].position.Y || (this.position.Y == Main.itemText[i].position.Y && whoAmI < i)))
						{
							flag = true;
							int num = ItemText.numActive;
							if (num > 3)
							{
								num = 3;
							}
							Main.itemText[i].lifeTime = ItemText.activeTime + 15 * num;
							this.lifeTime = ItemText.activeTime + 15 * num;
						}
					}
				}
				if (!flag)
				{
					this.velocity.Y = this.velocity.Y * 0.86f;
					if (this.scale == 1f)
					{
						this.velocity.Y = this.velocity.Y * 0.4f;
					}
				}
				else
				{
					if (this.velocity.Y > -6f)
					{
						this.velocity.Y = this.velocity.Y - 0.2f;
					}
					else
					{
						this.velocity.Y = this.velocity.Y * 0.86f;
					}
				}
				this.velocity.X = this.velocity.X * 0.93f;
				this.position += this.velocity;
				this.lifeTime--;
				if (this.lifeTime <= 0)
				{
					this.scale -= 0.03f;
					if ((double)this.scale < 0.1)
					{
						this.active = false;
					}
					this.lifeTime = 0;
					return;
				}
				if (this.scale < 1f)
				{
					this.scale += 0.1f;
				}
				if (this.scale > 1f)
				{
					this.scale = 1f;
				}
			}
		}
		public static void UpdateItemText()
		{
			int num = 0;
			for (int i = 0; i < 20; i++)
			{
				if (Main.itemText[i].active)
				{
					num++;
					Main.itemText[i].Update(i);
				}
			}
			ItemText.numActive = num;
		}
	}
}
