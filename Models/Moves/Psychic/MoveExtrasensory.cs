using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to make the target flinch.
	public class MoveExtrasensory : Move
	{
		public MoveExtrasensory() : base(
			"Extrasensory",
			Psychic.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 80,// PP & Pow
			1.0, 0 // Acc & Priority
		) {}
	}
}