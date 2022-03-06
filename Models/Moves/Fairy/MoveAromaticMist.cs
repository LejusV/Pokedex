using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Raises a selected ally's Special Defense by one stage.
	public class MoveAromaticMist : Move
	{
		public MoveAromaticMist() : base(
			"Aromatic-Mist",
			Fairy.Instance, // Move Type
			MoveCategory.Status, // Move Category
			20, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}