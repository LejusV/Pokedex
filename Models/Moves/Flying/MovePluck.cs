using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//If target has a berry, inflicts double damage and uses the berry.
	public class MovePluck : Move
	{
		public MovePluck() : base(
			"Pluck",
			Flying.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}