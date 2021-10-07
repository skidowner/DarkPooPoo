using System;

namespace Client.SDK
{
	// Token: 0x0200000D RID: 13
	public class Level
	{
		// Token: 0x0400002B RID: 43
		private static string MultiPlayerLvl = Entity.Player + "378,";

		// Token: 0x0400002C RID: 44
		private static string LookingActor = Level.MultiPlayerLvl + "99C";

		// Token: 0x0200001E RID: 30
		public struct MultiPlayer
		{
			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600005B RID: 91 RVA: 0x00004090 File Offset: 0x00002290
			// (set) Token: 0x0600005C RID: 92 RVA: 0x000040A6 File Offset: 0x000022A6
			public static int lookingActor
			{
				get
				{
					return Form1.m.ReadByte(Level.LookingActor, "");
				}
				set
				{
					Form1.m.WriteMemory(Level.LookingActor, "byte", value.ToString(), "", null);
				}
			}
		}
	}
}
