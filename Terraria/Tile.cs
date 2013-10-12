using Microsoft.Xna.Framework;
using System;
namespace Terraria
{
	public class Tile
	{
		public byte type;
		public byte wall;
		public byte liquid;
		public byte tileHeader;
		public byte tileHeader2;
		public byte tileHeader3;
		public byte tileHeader4;
		public byte tileHeader5;
		public short frameX;
		public short frameY;
		public object Clone()
		{
			return base.MemberwiseClone();
		}
		public bool isTheSameAs(Tile compTile)
		{
			if (compTile == null)
			{
				return false;
			}
			if (this.active() != compTile.active())
			{
				return false;
			}
			if (this.active())
			{
				if (this.type != compTile.type)
				{
					return false;
				}
				if (Main.tileFrameImportant[(int)this.type])
				{
					if (this.frameX != compTile.frameX)
					{
						return false;
					}
					if (this.frameY != compTile.frameY)
					{
						return false;
					}
				}
			}
			return this.wall == compTile.wall && this.liquid == compTile.liquid && this.lava() == compTile.lava() && this.honey() == compTile.honey() && this.wire() == compTile.wire() && this.wire2() == compTile.wire2() && this.wire3() == compTile.wire3() && this.halfBrick() == compTile.halfBrick() && this.actuator() == compTile.actuator() && this.inActive() == compTile.inActive() && this.wallColor() == compTile.wallColor() && this.color() == compTile.color() && this.slope() == compTile.slope();
		}
		public byte wallFrameX()
		{
			byte b = 0;
			if ((this.tileHeader4 & 16) == 16)
			{
				b += 1;
			}
			if ((this.tileHeader4 & 32) == 32)
			{
				b += 2;
			}
			if ((this.tileHeader4 & 64) == 64)
			{
				b += 4;
			}
			if ((this.tileHeader4 & 128) == 128)
			{
				b += 8;
			}
			return (byte)(b * 18);
		}
		public void wallFrameX(int wallFrameX)
		{
			int num = wallFrameX / 18;
			if ((num & 1) == 1)
			{
				this.tileHeader4 |= 16;
			}
			else
			{
				this.tileHeader4 = (byte)((int)this.tileHeader4 & -17);
			}
			if ((num & 2) == 2)
			{
				this.tileHeader4 |= 32;
			}
			else
			{
				this.tileHeader4 = (byte)((int)this.tileHeader4 & -33);
			}
			if ((num & 4) == 4)
			{
				this.tileHeader4 |= 64;
			}
			else
			{
				this.tileHeader4 = (byte)((int)this.tileHeader4 & -65);
			}
			if ((num & 8) == 8)
			{
				this.tileHeader4 |= 128;
				return;
			}
			this.tileHeader4 = (byte)((int)this.tileHeader4 & -129);
		}
		public byte wallFrameY()
		{
			byte b = 0;
			if ((this.tileHeader5 & 1) == 1)
			{
				b += 1;
			}
			if ((this.tileHeader5 & 2) == 2)
			{
				b += 2;
			}
			if ((this.tileHeader5 & 4) == 4)
			{
				b += 4;
			}
			return (byte)(b * 18);
		}
		public void wallFrameY(int wallFrameX)
		{
			int num = wallFrameX / 18;
			if ((num & 1) == 1)
			{
				this.tileHeader5 |= 1;
			}
			else
			{
				this.tileHeader5 = (byte)((int)this.tileHeader5 & -2);
			}
			if ((num & 2) == 2)
			{
				this.tileHeader5 |= 2;
			}
			else
			{
				this.tileHeader5 = (byte)((int)this.tileHeader5 & -3);
			}
			if ((num & 4) == 4)
			{
				this.tileHeader5 |= 4;
				return;
			}
			this.tileHeader5 = (byte)((int)this.tileHeader5 & -5);
		}
		public byte frameNumber()
		{
			byte b = 0;
			if ((this.tileHeader4 & 1) == 1)
			{
				b += 1;
			}
			if ((this.tileHeader4 & 2) == 2)
			{
				b += 2;
			}
			return b;
		}
		public void frameNumber(byte frameNumber)
		{
			if ((frameNumber & 1) == 1)
			{
				this.tileHeader4 |= 1;
			}
			else
			{
				this.tileHeader4 = (byte)((int)this.tileHeader4 & -2);
			}
			if ((frameNumber & 2) == 2)
			{
				this.tileHeader4 |= 2;
				return;
			}
			this.tileHeader4 = (byte)((int)this.tileHeader4 & -3);
		}
		public byte wallFrameNumber()
		{
			byte b = 0;
			if ((this.tileHeader4 & 4) == 4)
			{
				b += 1;
			}
			if ((this.tileHeader4 & 8) == 8)
			{
				b += 2;
			}
			return b;
		}
		public void wallFrameNumber(byte wallFrameNumber)
		{
			if ((wallFrameNumber & 4) == 4)
			{
				this.tileHeader4 |= 4;
			}
			else
			{
				this.tileHeader4 = (byte)((int)this.tileHeader4 & -5);
			}
			if ((wallFrameNumber & 8) == 8)
			{
				this.tileHeader4 |= 8;
				return;
			}
			this.tileHeader4 = (byte)((int)this.tileHeader4 & -9);
		}
		public byte slope()
		{
			byte b = 0;
			if ((this.tileHeader3 & 16) == 16)
			{
				b += 1;
			}
			if ((this.tileHeader3 & 32) == 32)
			{
				b += 2;
			}
			return b;
		}
		public void slope(byte slope)
		{
			if ((slope & 1) == 1)
			{
				this.tileHeader3 |= 16;
			}
			else
			{
				this.tileHeader3 = (byte)((int)this.tileHeader3 & -17);
			}
			if ((slope & 2) == 2)
			{
				this.tileHeader3 |= 32;
				return;
			}
			this.tileHeader3 = (byte)((int)this.tileHeader3 & -33);
		}
		public byte color()
		{
			byte b = 0;
			if ((this.tileHeader2 & 4) == 4)
			{
				b += 1;
			}
			if ((this.tileHeader2 & 8) == 8)
			{
				b += 2;
			}
			if ((this.tileHeader2 & 16) == 16)
			{
				b += 4;
			}
			if ((this.tileHeader2 & 32) == 32)
			{
				b += 8;
			}
			if ((this.tileHeader2 & 64) == 64)
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
				this.tileHeader2 |= 4;
			}
			else
			{
				this.tileHeader2 = (byte)((int)this.tileHeader2 & -5);
			}
			if ((color & 2) == 2)
			{
				this.tileHeader2 |= 8;
			}
			else
			{
				this.tileHeader2 = (byte)((int)this.tileHeader2 & -9);
			}
			if ((color & 4) == 4)
			{
				this.tileHeader2 |= 16;
			}
			else
			{
				this.tileHeader2 = (byte)((int)this.tileHeader2 & -17);
			}
			if ((color & 8) == 8)
			{
				this.tileHeader2 |= 32;
			}
			else
			{
				this.tileHeader2 = (byte)((int)this.tileHeader2 & -33);
			}
			if ((color & 16) == 16)
			{
				this.tileHeader2 |= 64;
				return;
			}
			this.tileHeader2 = (byte)((int)this.tileHeader2 & -65);
		}
		public byte wallColor()
		{
			byte b = 0;
			if ((this.tileHeader2 & 128) == 128)
			{
				b += 1;
			}
			if ((this.tileHeader3 & 1) == 1)
			{
				b += 2;
			}
			if ((this.tileHeader3 & 2) == 2)
			{
				b += 4;
			}
			if ((this.tileHeader3 & 4) == 4)
			{
				b += 8;
			}
			if ((this.tileHeader3 & 8) == 8)
			{
				b += 16;
			}
			return b;
		}
		public void wallColor(byte wallColor)
		{
			if (wallColor > 27)
			{
				wallColor = 27;
			}
			if ((wallColor & 1) == 1)
			{
				this.tileHeader2 |= 128;
			}
			else
			{
				this.tileHeader2 = (byte)((int)this.tileHeader2 & -129);
			}
			if ((wallColor & 2) == 2)
			{
				this.tileHeader3 |= 1;
			}
			else
			{
				this.tileHeader3 = (byte)((int)this.tileHeader3 & -2);
			}
			if ((wallColor & 4) == 4)
			{
				this.tileHeader3 |= 2;
			}
			else
			{
				this.tileHeader3 = (byte)((int)this.tileHeader3 & -3);
			}
			if ((wallColor & 8) == 8)
			{
				this.tileHeader3 |= 4;
			}
			else
			{
				this.tileHeader3 = (byte)((int)this.tileHeader3 & -5);
			}
			if ((wallColor & 16) == 16)
			{
				this.tileHeader3 |= 8;
				return;
			}
			this.tileHeader3 = (byte)((int)this.tileHeader3 & -9);
		}
		public bool lava()
		{
			return (this.tileHeader & 8) == 8;
		}
		public void lava(bool lava)
		{
			if (lava)
			{
				this.tileHeader |= 8;
				this.tileHeader3 = (byte)((int)this.tileHeader3 & -65);
				return;
			}
			this.tileHeader = (byte)((int)this.tileHeader & -9);
		}
		public bool honey()
		{
			return (this.tileHeader3 & 64) == 64;
		}
		public void honey(bool honey)
		{
			if (honey)
			{
				this.tileHeader3 |= 64;
				this.tileHeader = (byte)((int)this.tileHeader & -9);
				return;
			}
			this.tileHeader3 = (byte)((int)this.tileHeader3 & -65);
		}
		public void liquidType(int liquidType)
		{
			if (liquidType == 0)
			{
				this.honey(false);
				this.lava(false);
			}
			if (liquidType == 1)
			{
				this.honey(false);
				this.lava(true);
			}
			if (liquidType == 2)
			{
				this.honey(true);
				this.lava(false);
			}
		}
		public byte liquidType()
		{
			if (this.honey())
			{
				return 2;
			}
			if (this.lava())
			{
				return 1;
			}
			return 0;
		}
		public bool checkingLiquid()
		{
			return (this.tileHeader & 2) == 2;
		}
		public void checkingLiquid(bool checkingLiquid)
		{
			if (checkingLiquid)
			{
				this.tileHeader |= 2;
				return;
			}
			this.tileHeader = (byte)((int)this.tileHeader & -3);
		}
		public bool skipLiquid()
		{
			return (this.tileHeader & 4) == 4;
		}
		public void skipLiquid(bool skipLiquid)
		{
			if (skipLiquid)
			{
				this.tileHeader |= 4;
				return;
			}
			this.tileHeader = (byte)((int)this.tileHeader & -5);
		}
		public bool wire()
		{
			return (this.tileHeader & 16) == 16;
		}
		public void wire(bool wire)
		{
			if (wire)
			{
				this.tileHeader |= 16;
				return;
			}
			this.tileHeader = (byte)((int)this.tileHeader & -17);
		}
		public bool halfBrick()
		{
			return (this.tileHeader & 32) == 32;
		}
		public void halfBrick(bool halfBrick)
		{
			if (halfBrick)
			{
				this.tileHeader |= 32;
				return;
			}
			this.tileHeader = (byte)((int)this.tileHeader & -33);
		}
		public bool actuator()
		{
			return (this.tileHeader & 64) == 64;
		}
		public void actuator(bool actuator)
		{
			if (actuator)
			{
				this.tileHeader |= 64;
				return;
			}
			this.tileHeader = (byte)((int)this.tileHeader & -65);
		}
		public bool nactive()
		{
			return ((this.tileHeader & 1) != 1 || (this.tileHeader & 128) != 128) && (this.tileHeader & 1) == 1;
		}
		public bool inActive()
		{
			return (this.tileHeader & 128) == 128;
		}
		public void inActive(bool inActive)
		{
			if (inActive)
			{
				this.tileHeader |= 128;
				return;
			}
			this.tileHeader = (byte)((int)this.tileHeader & -129);
		}
		public bool active()
		{
			return (this.tileHeader & 1) == 1;
		}
		public void active(bool active)
		{
			if (active)
			{
				this.tileHeader |= 1;
				return;
			}
			this.tileHeader = (byte)((int)this.tileHeader & -2);
		}
		public bool wire2()
		{
			return (this.tileHeader2 & 1) == 1;
		}
		public void wire2(bool wire2)
		{
			if (wire2)
			{
				this.tileHeader2 |= 1;
				return;
			}
			this.tileHeader2 = (byte)((int)this.tileHeader2 & -2);
		}
		public bool wire3()
		{
			return (this.tileHeader2 & 2) == 2;
		}
		public void wire3(bool wire3)
		{
			if (wire3)
			{
				this.tileHeader2 |= 2;
				return;
			}
			this.tileHeader2 = (byte)((int)this.tileHeader2 & -3);
		}
		public Color actColor(Color oldColor)
		{
			if (this.inActive())
			{
				float num = 0.4f;
				int r = (int)((byte)(num * (float)oldColor.R));
				int g = (int)((byte)(num * (float)oldColor.G));
				int b = (int)((byte)(num * (float)oldColor.B));
				return new Color(r, g, b, (int)oldColor.A);
			}
			return oldColor;
		}
	}
}
