using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to confuse the target.
	public class MovePsybeam : Move
	{
		public MovePsybeam() : base(
			"Psybeam",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 65,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}