using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Hits twice in one turn.
	public class MoveGearGrind : Move
	{
		public MoveGearGrind() : base(
			"Gear-Grind",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 50,// PP & Pow
			85, 0 // Acc & Priority
		) {}
	}
}