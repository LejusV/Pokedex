using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Inflicts damage based on the target's Defense, not Special Defense.
	public class MovePsystrike : Move
	{
		public MovePsystrike() : base(
			"Psystrike",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 100,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}