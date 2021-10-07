using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Client.UI
{
	// Token: 0x0200000A RID: 10
	public partial class ClickGui : Form
	{
		// Token: 0x0600001E RID: 30 RVA: 0x0000267C File Offset: 0x0000087C
		public ClickGui()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000268C File Offset: 0x0000088C
		private void ClickGui_Load(object sender, EventArgs e)
		{
			this.TriggerBot.BackColor = Color.Black;
			this.AirJump.BackColor = Color.Black;
			this.AirWalk.BackColor = Color.Black;
			this.Speed.BackColor = Color.Black;
			this.BounceGlide.BackColor = Color.Black;
			this.CCFly.BackColor = Color.Black;
			this.Flight.BackColor = Color.Black;
			this.Glide.BackColor = Color.Black;
			this.Step.BackColor = Color.Black;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000272C File Offset: 0x0000092C
		private void TriggerBot_Click(object sender, EventArgs e)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.name == this.TriggerBot.Name)
				{
					module.toggle();
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002798 File Offset: 0x00000998
		private void AirJump_Click(object sender, EventArgs e)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.name == this.AirJump.Name)
				{
					module.toggle();
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002804 File Offset: 0x00000A04
		private void AirWalk_Click(object sender, EventArgs e)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.name == this.AirWalk.Name)
				{
					module.toggle();
				}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002870 File Offset: 0x00000A70
		private void Speed_Click(object sender, EventArgs e)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.name == "Speed")
				{
					module.toggle();
				}
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000028D4 File Offset: 0x00000AD4
		private void BounceGlide_Click(object sender, EventArgs e)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.name == "BounceGlide")
				{
					module.toggle();
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002938 File Offset: 0x00000B38
		private void CCFly_Click(object sender, EventArgs e)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.name == "CCFly")
				{
					module.toggle();
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000299C File Offset: 0x00000B9C
		private void Flight_Click(object sender, EventArgs e)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.name == "Flight")
				{
					module.toggle();
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002A00 File Offset: 0x00000C00
		private void button1_Click(object sender, EventArgs e)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.name == "Glide")
				{
					module.toggle();
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002A64 File Offset: 0x00000C64
		private void Step_Click(object sender, EventArgs e)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.name == "Step")
				{
					module.toggle();
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002AC8 File Offset: 0x00000CC8
		private void FullBright_Click(object sender, EventArgs e)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.name == "FullBright")
				{
					module.toggle();
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002B2C File Offset: 0x00000D2C
		private void button1_Click_1(object sender, EventArgs e)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.name == "Jesus")
				{
					module.toggle();
				}
			}
		}
	}
}
