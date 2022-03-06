using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Cannot be disrupted by abilities.
	public class MoveSunsteelStrike : Move
	{
		public MoveSunsteelStrike() : base(
			"Sunsteel-Strike",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}