using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Moves have 100% accuracy against the target for three turns.
	public class MoveTelekinesis : Move
	{
		public MoveTelekinesis() : base(
			"Telekinesis",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
			
		) {}
	}
}