using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts 20 points of damage.
	public class MoveSonicBoom : Move
	{
		public MoveSonicBoom() : base(
			"Sonic-Boom",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, null,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}