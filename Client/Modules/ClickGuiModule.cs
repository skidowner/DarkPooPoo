using System;
using System.Windows.Forms;
using Client.UI;

namespace Client.Modules
{
	// Token: 0x02000012 RID: 18
	public class ClickGuiModule : Module
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00003E0E File Offset: 0x0000200E
		public ClickGuiModule() : base("ClickGui", Keys.Insert, "Visual")
		{
			this.ClickGui.Activate();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003E38 File Offset: 0x00002038
		public override void onEnable()
		{
			base.onEnable();
			this.ClickGui.Show();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003E4B File Offset: 0x0000204B
		public override void onDisable()
		{
			base.onDisable();
			this.ClickGui.Hide();
		}

		// Token: 0x04000043 RID: 67
		public ClickGui ClickGui = new ClickGui();
	}
}
