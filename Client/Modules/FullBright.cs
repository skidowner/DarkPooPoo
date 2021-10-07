using System;
using System.Windows.Forms;
using Client.SDK;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x02000013 RID: 19
	public class FullBright : Module
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00003E5E File Offset: 0x0000205E
		public FullBright() : base("FullBright", Keys.NumPad0, "Visual")
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003E72 File Offset: 0x00002072
		public override void onTick()
		{
			base.onTick();
			GameSettings.Brightness = 1000f;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003E84 File Offset: 0x00002084
		public override void onDisable()
		{
			base.onDisable();
			GameSettings.Brightness = 1f;
		}
	}
}
