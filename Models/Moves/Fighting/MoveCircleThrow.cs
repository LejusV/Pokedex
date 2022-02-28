using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Ends wild battles.  Forces trainers to switch Pokémon.
	public class MoveCircleThrow : Move
	{
		public MoveCircleThrow() : base(
			"Circle-Throw",
			Fighting.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 60,// PP & Pow
			90, -6 // Acc & Priority
		) {}
	}
}