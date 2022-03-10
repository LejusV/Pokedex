using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveRockThrow : Move
	{
		public MoveRockThrow() : base(
			"Rock-Throw",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 50,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}