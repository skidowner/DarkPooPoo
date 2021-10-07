using System;
using System.Windows.Forms;
using Client.SDK;

namespace Client
{
	// Token: 0x02000005 RID: 5
	public class MoveUtils
	{
		// Token: 0x0600000E RID: 14 RVA: 0x0000248C File Offset: 0x0000068C
		public static bool CanMove(string x, string y, string z)
		{
			if (Imports.GetAsyncKeyState(Keys.W) < 0 || Imports.GetAsyncKeyState(Keys.A) < 0 || Imports.GetAsyncKeyState(Keys.S) < 0 || Imports.GetAsyncKeyState(Keys.D) < 0)
			{
				float num = Form1.m.ReadFloat(x, "", true);
				Form1.m.ReadFloat(y, "", true);
				float num2 = Form1.m.ReadFloat(z, "", true);
				if (num > 0f && num2 > 0f)
				{
					MoveUtils.returnValue = true;
				}
				else
				{
					MoveUtils.returnValue = false;
				}
			}
			return MoveUtils.returnValue;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002518 File Offset: 0x00000718
		public static void TPY(float yValue)
		{
			Entity.LocalPlayer.posY += yValue;
		}

		// Token: 0x04000007 RID: 7
		public static bool returnValue;
	}
}
