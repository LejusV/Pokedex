using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Immediately ends wild battles.  Forces trainers to switch Pokémon.
	public class MoveWhirlwind : Move
	{
		public MoveWhirlwind() : base(
			"Whirlwind",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, -6 // Acc & Priority
		) {}
	}
}