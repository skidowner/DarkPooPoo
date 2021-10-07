using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Client
{
	// Token: 0x02000004 RID: 4
	public class Imports
	{
		// Token: 0x0600000B RID: 11
		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(Keys vKey);

		// Token: 0x0600000C RID: 12
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
	}
}
