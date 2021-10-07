using System;

namespace Client
{
	// Token: 0x02000007 RID: 7
	internal class Vecters
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002568 File Offset: 0x00000768
		public static Vecters.Vec3f directionalVector(float yaw, float pitch)
		{
			Vecters.Vec3f result = default(Vecters.Vec3f);
			Vecters.Vec2f vec2f = default(Vecters.Vec2f);
			vec2f.x = (float)((double)yaw * -0.017453292519943295);
			vec2f.y = (float)((double)(pitch + 90f) * 0.017453292519943295);
			result.x = (float)Math.Cos((double)vec2f.x) * (float)Math.Cos((double)vec2f.y);
			result.y = (float)Math.Sin((double)vec2f.y);
			result.z = (float)Math.Sin((double)vec2f.y) * (float)Math.Cos((double)vec2f.x);
			return result;
		}

		// Token: 0x0200001C RID: 28
		public struct Vec3f
		{
			// Token: 0x04000047 RID: 71
			public float x;

			// Token: 0x04000048 RID: 72
			public float y;

			// Token: 0x04000049 RID: 73
			public float z;
		}

		// Token: 0x0200001D RID: 29
		public struct Vec2f
		{
			// Token: 0x0400004A RID: 74
			public float x;

			// Token: 0x0400004B RID: 75
			public float y;
		}
	}
}
