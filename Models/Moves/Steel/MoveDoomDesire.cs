using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Hits the target two turns later.
	public class MoveDoomDesire : Move
	{
		public MoveDoomDesire() : base(
			"Doom-Desire",
			Steel.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 140,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}