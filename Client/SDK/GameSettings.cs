using System;

namespace Client.SDK
{
	// Token: 0x0200000C RID: 12
	public class GameSettings
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00003B24 File Offset: 0x00001D24
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00003B3B File Offset: 0x00001D3B
		public static float Brightness
        {
            get => Form1.m.ReadFloat(GameSettings.brightness, "", true);
            set
            {
                Form1.m.WriteMemory(GameSettings.brightness, "float", value.ToString(), "", null);
            }
        }

        // Token: 0x0400002A RID: 42
        private static string brightness = "Minecraft.Windows.exe+03F58BA8,10,98,8,C8,170,140,18";
	}
}
