using Pokedex.Enums;
using Pokedex.Models.PokeTypes;

namespace Pokedex.Models.Moves
{
	//Requires a turn to charge before attacking.
	public class MoveSolarBeam : Move
	{
		public MoveSolarBeam() : base(
			"Solar-Beam",
			Grass.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 120,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}