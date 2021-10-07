using System;
using System.Windows.Forms;
using Client.SDK;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x02000018 RID: 24
	public class HiveFly : Module
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00003F54 File Offset: 0x00002154
		public HiveFly() : base("Airjump", Keys.Z, "Movement")
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003F68 File Offset: 0x00002168
		public override void onTick()
		{
			base.onTick();
			Entity.LocalPlayer.MotionY = -0.07f;
			if (TimeUtil.timerHasReached(47, true))
			{
				Entity.LocalPlayer.Telport(Entity.LocalPlayer.posX, Entity.LocalPlayer.posY + 0.35f, Entity.LocalPlayer.posZ);
				Entity.LocalPlayer.MotionY = -0.07f;
				Entity.LocalPlayer.AirAccelaration = 0.3f;
			}
		}
	}
}
