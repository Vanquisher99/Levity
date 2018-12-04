using Terraria.ID;
using Terraria.ModLoader;

namespace Levity.Items
{
	public class Stick : ModItem 
	{ 
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("RazorCut"); 
			Tooltip.SetDefault("This sword may have herpes."); 
		}
		public override void SetDefaults() 
		{ 
			item.damage = 500; 
			item.ranged = true; 
			item.melee = true; 
			item.width = 40; 
			item.height = 40; 
			item.useTime = 5; 
			item.useAnimation = 5; 
			item.useStyle = 1; 
			item.knockBack = 6; 
			item.value = 10000; 
			item.rare = 2; 
			item.UseSound = SoundID.Item1;
			item.autoReuse = true; 
			item.shoot = 227; 
			item.shootSpeed = 16f; 
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