using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Never misses.
	public class MoveVitalThrow : Move
	{
		public MoveVitalThrow() : base(
			"Vital-Throw",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 70,// PP & Pow
			null, -1 // Acc & Priority
		) {}
	}
}