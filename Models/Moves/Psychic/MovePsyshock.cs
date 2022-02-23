using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts damage based on the target's Defense, not Special Defense.
	public class MovePsyshock : Move
	{
		public MovePsyshock() : base(
			"Psyshock",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}