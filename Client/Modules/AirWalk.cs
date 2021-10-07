using System;
using System.Windows.Forms;
using Client.SDK;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x02000016 RID: 22
	public class AirWalk : Module
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00003EDE File Offset: 0x000020DE
		public AirWalk() : base("Airwalk", Keys.C, "Movement")
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003EF2 File Offset: 0x000020F2
		public override void onTick()
		{
			base.onTick();
			Entity.LocalPlayer.MotionY = 0f;
		}
	}
}
