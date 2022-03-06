using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User faints, and its replacement is fully healed.
	public class MoveLunarDance : Move
	{
		public MoveLunarDance() : base(
			"Lunar-Dance",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}