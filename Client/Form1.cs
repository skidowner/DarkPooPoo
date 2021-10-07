using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Client.Modules;
using Client.UI;
using K4os.Compression.LZ4.Internal;

namespace Client
{
    // Token: 0x02000002 RID: 2
    public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002056 File Offset: 0x00000256
		private void Form1_Load(object sender, EventArgs e)
		{
			this.addModules();
			OpenProcess("Minecraft.Windows.exe");
		}

        private void OpenProcess(string v)
        {
            throw new NotImplementedException();
        }

        // Token: 0x06000003 RID: 3 RVA: 0x00002070 File Offset: 0x00000270
        public void addModules()
		{
			Form1.modules.Add(new AirJump());
			Form1.modules.Add(new AirWalk());
			Form1.modules.Add(new BHop());
			Form1.modules.Add(new BounceGlide());
			Form1.modules.Add(new CCFly());
			Form1.modules.Add(new Flight());
			Form1.modules.Add(new Glide());
			Form1.modules.Add(new Step());
			Form1.modules.Add(new TriggerBot());
			Form1.modules.Add(new ClickGuiModule());
			Form1.modules.Add(new FullBright());
			Form1.modules.Add(new Jesus());
			Form1.modules.Add(new HiveFly());
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002140 File Offset: 0x00000340
		private void timer1_Tick(object sender, EventArgs e)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.toggeld)
				{
					module.onTick();
				}
				if (Imports.GetAsyncKeyState(module.key) < 0)
				{
					if (!module.isPressed)
					{
						module.toggle();
						module.isPressed = true;
					}
				}
				else
				{
					module.isPressed = false;
				}
			}
			this.onLoop();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		public void onLoop()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021D0 File Offset: 0x000003D0
		public static Module getModuleByName(string name)
		{
			foreach (Module module in Form1.modules)
			{
				if (module.name == name)
				{
					return module;
				}
			}
			return null;
		}

		// Token: 0x04000001 RID: 1
		public static Mem m = new Mem();

		// Token: 0x04000002 RID: 2
		public static List<Module> modules = new List<Module>();

		// Token: 0x04000003 RID: 3
		public static SolidBrush primary = new SolidBrush(Color.FromArgb(255, 255, 255));
	}
}
