using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has an increased chance for a critical hit.
	public class MovePsychoCut : Move
	{
		public MovePsychoCut() : base(
			"Psycho-Cut",
			Psychic.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 70,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}