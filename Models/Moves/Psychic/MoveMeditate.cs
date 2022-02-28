using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//Raises the user's Attack by one stage.
	public class MoveMeditate : Move
	{
		public MoveMeditate() : base(
			"Meditate",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			40, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}