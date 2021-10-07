using System;

namespace Client.SDK
{
	// Token: 0x0200000E RID: 14
	public class Entity
	{
		// Token: 0x0400002D RID: 45
		public static string Player = "Minecraft.Windows.exe+03F88808,10,1F0,0,130,";

		// Token: 0x0400002E RID: 46
		public static string Player2 = "Minecraft.Windows.exe+03F88808,10,1F0,0,130";

		// Token: 0x0400002F RID: 47
		private static string yaw = Entity.Player + "144";

		// Token: 0x04000030 RID: 48
		private static string pitch = Entity.Player + "140";

		// Token: 0x04000031 RID: 49
		private static string FallDistance = Entity.Player + "1DC";

		// Token: 0x04000032 RID: 50
		private static string IsInWater = Entity.Player + "264";

		// Token: 0x04000033 RID: 51
		private static string IsInLava = Entity.Player + "2D0";

		// Token: 0x04000034 RID: 52
		private static string OnGround = Entity.Player + "1E0";

		// Token: 0x04000035 RID: 53
		private static string StepHeight = Entity.Player + "240";

		// Token: 0x04000036 RID: 54
		private static string airAccelaration = Entity.Player + "7B8";

		// Token: 0x04000037 RID: 55
		private static string IsFlying = Entity.Player + "9C0";

		// Token: 0x04000038 RID: 56
		private static string CanFly = Entity.Player + "9CC";

		// Token: 0x04000039 RID: 57
		private static string FlySpeed = Entity.Player + "9F0";

		// Token: 0x0400003A RID: 58
		private static string VelocityX = Entity.Player + "50C";

		// Token: 0x0400003B RID: 59
		private static string VelocityY = Entity.Player + "510";

		// Token: 0x0400003C RID: 60
		private static string VelocityZ = Entity.Player + "514";

		// Token: 0x0400003D RID: 61
		private static string PosX = Entity.Player + "4D0";

		// Token: 0x0400003E RID: 62
		private static string PosY = Entity.Player + "4D4";

		// Token: 0x0400003F RID: 63
		private static string PosZ = Entity.Player + "4D8";

		// Token: 0x04000040 RID: 64
		private static string PosX2 = Entity.Player + "4DC";

		// Token: 0x04000041 RID: 65
		private static string PosY2 = Entity.Player + "4E0";

		// Token: 0x04000042 RID: 66
		private static string PosZ2 = Entity.Player + "4E4";

		// Token: 0x0200001F RID: 31
		public struct LocalPlayer
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600005D RID: 93 RVA: 0x000040CA File Offset: 0x000022CA
			public static bool exists
			{
				get
				{
					return Form1.m.ReadInt(Entity.Player2, "") > 0;
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600005E RID: 94 RVA: 0x000040E6 File Offset: 0x000022E6
			// (set) Token: 0x0600005F RID: 95 RVA: 0x000040FD File Offset: 0x000022FD
			public static float AirAccelaration
			{
				get
				{
					return Form1.m.ReadFloat(Entity.airAccelaration, "", true);
				}
				set
				{
					Form1.m.WriteMemory(Entity.airAccelaration, "float", value.ToString(), "", null);
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000060 RID: 96 RVA: 0x00004121 File Offset: 0x00002321
			public static float Yaw
			{
				get
				{
					return Form1.m.ReadFloat(Entity.yaw, "", true);
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000061 RID: 97 RVA: 0x00004138 File Offset: 0x00002338
			public static float Pitch
			{
				get
				{
					return Form1.m.ReadFloat(Entity.pitch, "", true);
				}
			}

			// Token: 0x06000062 RID: 98 RVA: 0x0000414F File Offset: 0x0000234F
			public static void Jump()
			{
				Form1.m.WriteMemory(Entity.VelocityY, "float", "0.5", "", null);
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000063 RID: 99 RVA: 0x00004171 File Offset: 0x00002371
			// (set) Token: 0x06000064 RID: 100 RVA: 0x00004188 File Offset: 0x00002388
			public static float posX
			{
				get
				{
					return Form1.m.ReadFloat(Entity.PosX, "", true);
				}
				set
				{
					Form1.m.WriteMemory(Entity.PosX, "float", value.ToString(), "", null);
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000065 RID: 101 RVA: 0x000041AC File Offset: 0x000023AC
			// (set) Token: 0x06000066 RID: 102 RVA: 0x000041C3 File Offset: 0x000023C3
			public static float posY
			{
				get
				{
					return Form1.m.ReadFloat(Entity.PosY, "", true);
				}
				set
				{
					Form1.m.WriteMemory(Entity.PosY, "float", value.ToString(), "", null);
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000067 RID: 103 RVA: 0x000041E7 File Offset: 0x000023E7
			// (set) Token: 0x06000068 RID: 104 RVA: 0x000041FE File Offset: 0x000023FE
			public static float posZ
			{
				get
				{
					return Form1.m.ReadFloat(Entity.PosZ, "", true);
				}
				set
				{
					Form1.m.WriteMemory(Entity.PosZ, "float", value.ToString(), "", null);
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000069 RID: 105 RVA: 0x00004222 File Offset: 0x00002422
			// (set) Token: 0x0600006A RID: 106 RVA: 0x00004239 File Offset: 0x00002439
			public static float posX2
			{
				get
				{
					return Form1.m.ReadFloat(Entity.PosX2, "", true);
				}
				set
				{
					Form1.m.WriteMemory(Entity.PosX2, "float", value.ToString(), "", null);
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x0600006B RID: 107 RVA: 0x0000425D File Offset: 0x0000245D
			// (set) Token: 0x0600006C RID: 108 RVA: 0x00004274 File Offset: 0x00002474
			public static float posY2
			{
				get
				{
					return Form1.m.ReadFloat(Entity.PosY2, "", true);
				}
				set
				{
					Form1.m.WriteMemory(Entity.PosY2, "float", value.ToString(), "", null);
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600006D RID: 109 RVA: 0x00004298 File Offset: 0x00002498
			// (set) Token: 0x0600006E RID: 110 RVA: 0x000042AF File Offset: 0x000024AF
			public static float posZ2
			{
				get
				{
					return Form1.m.ReadFloat(Entity.PosZ2, "", true);
				}
				set
				{
					Form1.m.WriteMemory(Entity.PosZ2, "float", value.ToString(), "", null);
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600006F RID: 111 RVA: 0x000042D3 File Offset: 0x000024D3
			// (set) Token: 0x06000070 RID: 112 RVA: 0x000042EA File Offset: 0x000024EA
			public static float MotionX
			{
				get
				{
					return Form1.m.ReadFloat(Entity.VelocityX, "", true);
				}
				set
				{
					Form1.m.WriteMemory(Entity.VelocityX, "float", value.ToString(), "", null);
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000071 RID: 113 RVA: 0x0000430E File Offset: 0x0000250E
			// (set) Token: 0x06000072 RID: 114 RVA: 0x00004325 File Offset: 0x00002525
			public static float MotionY
			{
				get
				{
					return Form1.m.ReadFloat(Entity.VelocityY, "", true);
				}
				set
				{
					Form1.m.WriteMemory(Entity.VelocityY, "float", value.ToString(), "", null);
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000073 RID: 115 RVA: 0x00004349 File Offset: 0x00002549
			// (set) Token: 0x06000074 RID: 116 RVA: 0x00004360 File Offset: 0x00002560
			public static float MotionZ
			{
				get
				{
					return Form1.m.ReadFloat(Entity.VelocityZ, "", true);
				}
				set
				{
					Form1.m.WriteMemory(Entity.VelocityZ, "float", value.ToString(), "", null);
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000075 RID: 117 RVA: 0x00004384 File Offset: 0x00002584
			// (set) Token: 0x06000076 RID: 118 RVA: 0x000043A0 File Offset: 0x000025A0
			public static bool onGround
			{
				get
				{
					return Form1.m.ReadByte(Entity.OnGround, "") >= 1;
				}
				set
				{
					if (value)
					{
						Form1.m.WriteMemory(Entity.OnGround, "byte", "1", "", null);
						return;
					}
					Form1.m.WriteMemory(Entity.OnGround, "byte", "0", "", null);
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000077 RID: 119 RVA: 0x000043F1 File Offset: 0x000025F1
			// (set) Token: 0x06000078 RID: 120 RVA: 0x00004410 File Offset: 0x00002610
			public static bool canFly
			{
				get
				{
					return Form1.m.ReadByte(Entity.CanFly, "") >= 1;
				}
				set
				{
					if (value)
					{
						Form1.m.WriteMemory(Entity.CanFly, "byte", "1", "", null);
						return;
					}
					Form1.m.WriteMemory(Entity.CanFly, "byte", "0", "", null);
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000079 RID: 121 RVA: 0x00004461 File Offset: 0x00002661
			// (set) Token: 0x0600007A RID: 122 RVA: 0x00004480 File Offset: 0x00002680
			public static bool isFlying
			{
				get
				{
					return Form1.m.ReadByte(Entity.IsFlying, "") >= 1;
				}
				set
				{
					if (value)
					{
						Form1.m.WriteMemory(Entity.IsFlying, "byte", "1", "", null);
						return;
					}
					Form1.m.WriteMemory(Entity.IsFlying, "byte", "0", "", null);
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600007B RID: 123 RVA: 0x000044D1 File Offset: 0x000026D1
			// (set) Token: 0x0600007C RID: 124 RVA: 0x000044E8 File Offset: 0x000026E8
			public static float flySpeed
			{
				get
				{
					return Form1.m.ReadFloat(Entity.FlySpeed, "", true);
				}
				set
				{
					Form1.m.WriteMemory(Entity.FlySpeed, "float", value.ToString(), "", null);
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600007D RID: 125 RVA: 0x0000450C File Offset: 0x0000270C
			// (set) Token: 0x0600007E RID: 126 RVA: 0x00004528 File Offset: 0x00002728
			public static bool isInWater
			{
				get
				{
					return Form1.m.ReadInt(Entity.IsInWater, "") >= 1;
				}
				set
				{
					if (value)
					{
						Form1.m.WriteMemory(Entity.IsInWater, "int", "1", "", null);
						return;
					}
					Form1.m.WriteMemory(Entity.IsInWater, "int", "0", "", null);
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600007F RID: 127 RVA: 0x00004579 File Offset: 0x00002779
			// (set) Token: 0x06000080 RID: 128 RVA: 0x00004598 File Offset: 0x00002798
			public static bool isInLava
			{
				get
				{
					return Form1.m.ReadInt(Entity.IsInLava, "") >= 1;
				}
				set
				{
					if (value)
					{
						Form1.m.WriteMemory(Entity.IsInLava, "int", "1", "", null);
						return;
					}
					Form1.m.WriteMemory(Entity.IsInLava, "int", "0", "", null);
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000081 RID: 129 RVA: 0x000045E9 File Offset: 0x000027E9
			// (set) Token: 0x06000082 RID: 130 RVA: 0x00004600 File Offset: 0x00002800
			public static float stepHeight
			{
				get
				{
					return Form1.m.ReadFloat(Entity.StepHeight, "", true);
				}
				set
				{
					Form1.m.WriteMemory(Entity.StepHeight, "float", value.ToString(), "", null);
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000083 RID: 131 RVA: 0x00004624 File Offset: 0x00002824
			public static float fallDistance
			{
				get
				{
					return Form1.m.ReadFloat(Entity.FallDistance, "", true);
				}
			}

			// Token: 0x06000084 RID: 132 RVA: 0x0000463B File Offset: 0x0000283B
			public static void Telport(float x, float y, float z)
			{
				Entity.LocalPlayer.posX = x;
				Entity.LocalPlayer.posY = y;
				Entity.LocalPlayer.posZ = z;
				Entity.LocalPlayer.posX2 = x + 0.6f;
				Entity.LocalPlayer.posY2 = y + 1.8f;
				Entity.LocalPlayer.posZ2 = z + 0.6f;
			}

			// Token: 0x06000085 RID: 133 RVA: 0x00004674 File Offset: 0x00002874
			public double distanceTo(float x, float y, float z)
			{
				float num = Entity.LocalPlayer.posX - x;
				float num2 = Entity.LocalPlayer.posY - y;
				float num3 = Entity.LocalPlayer.posZ - z;
				return Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3));
			}
		}
	}
}
