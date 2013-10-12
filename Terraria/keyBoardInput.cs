using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Terraria
{
	public class keyBoardInput
	{
		public class inKey : IMessageFilter
		{
			public bool PreFilterMessage(ref Message m)
			{
				if (m.Msg == 258)
				{
					char c = (char)((int)m.WParam);
					Console.WriteLine(c);
					if (keyBoardInput.newKeyEvent != null)
					{
						keyBoardInput.newKeyEvent(c);
					}
				}
				else
				{
					if (m.Msg == 256)
					{
						IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(m));
						Marshal.StructureToPtr(m, intPtr, true);
						keyBoardInput.TranslateMessage(intPtr);
					}
				}
				return false;
			}
		}
		public static event Action<char> newKeyEvent;
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern bool TranslateMessage(IntPtr message);
		static keyBoardInput()
		{
			Application.AddMessageFilter(new keyBoardInput.inKey());
		}
	}
}
