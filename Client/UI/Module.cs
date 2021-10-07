using System;
using System.Windows.Forms;

namespace Client.UI
{
	// Token: 0x0200000B RID: 11
	public class Module
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00003ADB File Offset: 0x00001CDB
		public Module(string name, Keys key, string category)
		{
			this.name = name;
			this.key = key;
			this.category = category;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003AF8 File Offset: 0x00001CF8
		public void toggle()
		{
			this.toggeld = !this.toggeld;
			if (this.toggeld)
			{
				this.onEnable();
				return;
			}
			this.onDisable();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003B1E File Offset: 0x00001D1E
		public virtual void onEnable()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003B20 File Offset: 0x00001D20
		public virtual void onDisable()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003B22 File Offset: 0x00001D22
		public virtual void onTick()
		{
		}

		// Token: 0x04000025 RID: 37
		public string name;

		// Token: 0x04000026 RID: 38
		public Keys key;

		// Token: 0x04000027 RID: 39
		public string category;

		// Token: 0x04000028 RID: 40
		public bool toggeld;

		// Token: 0x04000029 RID: 41
		public bool isPressed;
	}
}
