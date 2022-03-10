using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveAccelerock : Move
	{
		public MoveAccelerock() : base(
			"Accelerock",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 40,// PP & Pow
			100, 1 // Acc & Priority
		) {}
	}
}