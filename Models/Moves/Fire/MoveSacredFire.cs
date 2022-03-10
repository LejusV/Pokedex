using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to burn the target.  Lets frozen Pokémon thaw themselves.
	public class MoveSacredFire : Move
	{
		public MoveSacredFire() : base(
			"Sacred-Fire",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 100,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}