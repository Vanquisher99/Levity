using Terraria.ID;
using Terraria.ModLoader;

namespace Levity.Items
{
	public class HorrorShow : ModItem 
	{ 
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Horror Show"); 
			Tooltip.SetDefault("This sword may have herpes."); 
		}
		public override void SetDefaults() 
		{ 
			item.damage = 500; 
			item.ranged = true; 
			item.melee = true; 
			item.width = 395; 
			item.height = 394; 
			item.useTime = 20; 
			item.useAnimation = 20; 
			item.useStyle = 1; 
			item.knockBack = 6; 
			item.value = 10000; 
			item.rare = 2; 
			item.UseSound = SoundID.Item1;
			item.autoReuse = true; 
			item.shoot = mod.ProjectileType("HorrorShowProjectile");
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


