using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Heals the target for ½ its max HP, or ⅔ on Grassy Terrain.
	public class MoveFloralHealing : Move
	{
		public MoveFloralHealing() : base(
			"Floral-Healing",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}