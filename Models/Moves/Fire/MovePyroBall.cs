using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target.
	public class MovePyroBall : Move
	{
		public MovePyroBall() : base(
			"Pyro-Ball",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 120,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}