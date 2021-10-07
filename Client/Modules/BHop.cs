using System;
using System.Windows.Forms;
using Client.SDK;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x0200000F RID: 15
	public class BHop : Module
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00003D61 File Offset: 0x00001F61
		public BHop() : base("Speed", Keys.X, "Player")
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003D75 File Offset: 0x00001F75
		public override void onTick()
		{
			base.onTick();
			if (Entity.LocalPlayer.onGround)
			{
				Entity.LocalPlayer.MotionY = 0.4f;
				return;
			}
			Entity.LocalPlayer.AirAccelaration = 0.06f;
		}
	}
}
