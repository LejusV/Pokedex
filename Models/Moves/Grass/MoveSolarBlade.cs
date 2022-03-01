using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Requires a turn to charge before attacking.
	public class MoveSolarBlade : Move
	{
		public MoveSolarBlade() : base(
			"Solar-Blade",
			Grass.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 125,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}