using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Puts the target to sleep.
	public class MoveHypnosis : Move
	{
		public MoveHypnosis() : base(
			"Hypnosis",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			60, 0 // Acc & Priority
		) {}
	}
}