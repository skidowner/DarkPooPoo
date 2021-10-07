using System;
using System.Windows.Forms;
using Client.SDK;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x02000010 RID: 16
	public class BounceGlide : Module
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00003D99 File Offset: 0x00001F99
		public BounceGlide() : base("BounceGlide", Keys.H, "Movement")
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003DAD File Offset: 0x00001FAD
		public override void onTick()
		{
			base.onTick();
			if (TimeUtil.timerHasReached(40, true))
			{
				Entity.LocalPlayer.Jump();
			}
		}
	}
}
