using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts damage between 50% and 150% of the user's level.
	public class MovePsywave : Move
	{
		public MovePsywave() : base(
			"Psywave",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, null,// PP & Pow
			100, 0 // Acc & Priority
			
		) {}
	}
}