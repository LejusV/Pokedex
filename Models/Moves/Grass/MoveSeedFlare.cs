using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 40% chance to lower the target's Special Defense by two stages.
	public class MoveSeedFlare : Move
	{
		public MoveSeedFlare() : base(
			"Seed-Flare",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 120,// PP & Pow
			85, 0 // Acc & Priority
			
		) {}
	}
}