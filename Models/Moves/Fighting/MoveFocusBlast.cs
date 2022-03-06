using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Special Defense by one stage.
	public class MoveFocusBlast : Move
	{
		public MoveFocusBlast() : base(
			"Focus-Blast",
			Fighting.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 120,// PP & Pow
			70, 0 // Acc & Priority
		) {}
	}
}