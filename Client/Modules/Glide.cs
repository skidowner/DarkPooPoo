using System;
using System.Windows.Forms;
using Client.SDK;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x02000014 RID: 20
	public class Glide : Module
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00003E96 File Offset: 0x00002096
		public Glide() : base("Glide", Keys.NumPad2, "Movement")
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003EAA File Offset: 0x000020AA
		public override void onTick()
		{
			base.onTick();
			Entity.LocalPlayer.MotionY = -0.04f;
		}
	}
}
