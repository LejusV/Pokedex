using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Discards the user's stat changes and copies the target's.
	public class MovePsychUp : Move
	{
		public MovePsychUp() : base(
			"Psych-Up",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}