using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User vanishes, dodging all attacks, and hits next turn.  Hits through Protect and Detect.
	public class MoveShadowForce : Move
	{
		public MoveShadowForce() : base(
			"Shadow-Force",
			Ghost.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}