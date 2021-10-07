using System;
using System.Windows.Forms;
using Client.SDK;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x02000015 RID: 21
	public class AirJump : Module
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00003EBC File Offset: 0x000020BC
		public AirJump() : base("Airjump", Keys.G, "Movement")
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003ED0 File Offset: 0x000020D0
		public override void onTick()
		{
			base.onTick();
			Entity.LocalPlayer.onGround = true;
		}
	}
}
