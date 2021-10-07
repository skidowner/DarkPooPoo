using System;
using System.Windows.Forms;
using Client.SDK;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x02000019 RID: 25
	public class Jesus : Module
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00003FBD File Offset: 0x000021BD
		public Jesus() : base("Jesus", Keys.NumPad5, "Player")
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003FD1 File Offset: 0x000021D1
		public override void onTick()
		{
			base.onTick();
			if (Entity.LocalPlayer.exists && (Entity.LocalPlayer.isInWater | Entity.LocalPlayer.isInLava))
			{
				Entity.LocalPlayer.MotionY = 0.2f;
			}
		}
	}
}
