using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchAccessory.Content.Items
{
	public class TorchAccessory : ModItem
	{
		public readonly int LifeRegenIncrease = 4;
		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;
			Item.maxStack = 1;
			Item.value = Item.sellPrice(copper: 50);
			Item.accessory = true;
			Item.vanity = true;
		}
		public override void UpdateVanity(Player player)
		{
			EmitLight(player);
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			hideVisual = true;
			EmitLight(player);
		}
		private void EmitLight(Player player)
		{
			player.AddBuff(BuffID.Shine, 1);
			player.GetModPlayer<LightPlayer>().hasTorchAccessory = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Torch, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}