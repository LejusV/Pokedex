using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to badly poison the target.
	public class MovePoisonFang : Move
	{
		public MovePoisonFang() : base(
			"Poison-Fang",
			Poison.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 50,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}