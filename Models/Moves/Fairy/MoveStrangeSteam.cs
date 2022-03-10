using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to confuse the target.
	public class MoveStrangeSteam : Move
	{
		public MoveStrangeSteam() : base(
			"Strange-Steam",
			Fairy.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}