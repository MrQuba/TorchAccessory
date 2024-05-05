using Terraria;
using Terraria.ModLoader;

namespace TorchAccessory.Content
{
	public class LightPlayer : ModPlayer
	{
		public bool hasTorchAccessory = false;

		public override void ResetEffects()
		{
			hasTorchAccessory = false;
		}
	}
};