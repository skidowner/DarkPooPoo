using System;
using System.Windows.Forms;
using Client.SDK;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x02000017 RID: 23
	public class Flight : Module
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00003F04 File Offset: 0x00002104
		public Flight() : base("Flight", Keys.F, "Movement")
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003F18 File Offset: 0x00002118
		public override void onEnable()
		{
			base.onEnable();
			Entity.LocalPlayer.isFlying = true;
			Entity.LocalPlayer.canFly = true;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003F2C File Offset: 0x0000212C
		public override void onDisable()
		{
			base.onDisable();
			Entity.LocalPlayer.isFlying = false;
			Entity.LocalPlayer.canFly = false;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003F40 File Offset: 0x00002140
		public override void onTick()
		{
			base.onTick();
			Entity.LocalPlayer.isFlying = true;
			Entity.LocalPlayer.canFly = true;
		}
	}
}
