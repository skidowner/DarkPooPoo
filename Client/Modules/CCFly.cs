using System;
using System.Windows.Forms;
using Client.SDK;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x02000011 RID: 17
	public class CCFly : Module
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00003DC4 File Offset: 0x00001FC4
		public CCFly() : base("CCFly", Keys.V, "Movement")
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003DD8 File Offset: 0x00001FD8
		public override void onTick()
		{
			base.onTick();
			Entity.LocalPlayer.MotionY = 0f;
			if (TimeUtil.timerHasReached(50, true))
			{
				Entity.LocalPlayer.Telport(Entity.LocalPlayer.posX, Entity.LocalPlayer.posY + 0.5f, Entity.LocalPlayer.posZ);
			}
		}
	}
}
