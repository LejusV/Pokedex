using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves
{
	//For five turns, slower Pokémon will act before faster Pokémon.
	public class MoveTrickRoom : Move
	{
		public MoveTrickRoom() : base(
			"Trick-Room",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			5, null,// PP & Pow
			null, -7 // Acc & Priority
		) {}
	}
}