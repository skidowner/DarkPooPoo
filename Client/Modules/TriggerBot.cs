using System;
using System.Threading;
using System.Windows.Forms;
using Client.SDK;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x0200001B RID: 27
	public class TriggerBot : Module
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00004041 File Offset: 0x00002241
		public TriggerBot() : base("TriggerBot", Keys.None, "Combat")
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004054 File Offset: 0x00002254
		public override void onDisable()
		{
			base.onDisable();
			Imports.mouse_event(4, 0, 0, 0, 0);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004066 File Offset: 0x00002266
		public override void onTick()
		{
			base.onTick();
			if (Level.MultiPlayer.lookingActor != 0)
			{
				Imports.mouse_event(4, 0, 0, 0, 0);
				Thread.Sleep(30);
				Imports.mouse_event(2, 0, 0, 0, 0);
			}
		}

		// Token: 0x04000044 RID: 68
		private const int LEFTUP = 4;

		// Token: 0x04000045 RID: 69
		private const int LEFTDOWN = 2;

		// Token: 0x04000046 RID: 70
		public const int interval = 20;
	}
}
