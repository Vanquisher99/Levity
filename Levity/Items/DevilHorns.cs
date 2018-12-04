using Terraria.ID;
using Terraria.ModLoader;

namespace Levity.Items
{
	public class DevilHorns : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Holding this might make you insane.");
		}

		public override void SetDefaults()
		{
			item.damage = 10000;
			item.magic = true;
			item.mana = 50;
			item.width = 40;
			item.height = 40;
			item.useTime = 150;
			item.useAnimation = 150;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item15;
			item.autoReuse = true;
			item.shoot = 700;
			item.shootSpeed = 50f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10); 
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}