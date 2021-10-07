using System;
using System.Windows.Forms;
using Client.SDK;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x0200001A RID: 26
	public class Step : Module
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00003FF7 File Offset: 0x000021F7
		public Step() : base("Step", Keys.NumPad1, "Player")
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000400B File Offset: 0x0000220B
		public override void onEnable()
		{
			base.onEnable();
			Entity.LocalPlayer.stepHeight = 2f;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000401D File Offset: 0x0000221D
		public override void onDisable()
		{
			base.onDisable();
			Entity.LocalPlayer.stepHeight = 0.56f;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000402F File Offset: 0x0000222F
		public override void onTick()
		{
			base.onTick();
			Entity.LocalPlayer.stepHeight = 2f;
		}
	}
}
