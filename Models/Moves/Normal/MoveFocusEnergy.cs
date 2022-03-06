using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Increases the user's chance to score a critical hit.
	public class MoveFocusEnergy : Move
	{
		public MoveFocusEnergy() : base(
			"Focus-Energy",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}