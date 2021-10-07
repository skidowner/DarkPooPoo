using System;

namespace Client
{
	// Token: 0x02000006 RID: 6
	public class TimeUtil
	{
		// Token: 0x06000011 RID: 17 RVA: 0x0000252E File Offset: 0x0000072E
		public static void Reset()
		{
			TimeUtil.currentTick = 0;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002536 File Offset: 0x00000736
		public static void Tick()
		{
			TimeUtil.currentTick++;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002544 File Offset: 0x00000744
		public static bool timerHasReached(int value, bool reset)
		{
			if (TimeUtil.currentTick >= value)
			{
				if (reset)
				{
					TimeUtil.Reset();
				}
				return true;
			}
			TimeUtil.Tick();
			return false;
		}

		// Token: 0x04000008 RID: 8
		public static int currentTick;
	}
}
