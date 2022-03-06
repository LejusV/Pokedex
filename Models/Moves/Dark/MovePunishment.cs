using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power increases against targets with more raised stats, up to a maximum of 200.
	public class MovePunishment : Move
	{
		public MovePunishment() : base(
			"Punishment",
			Dark.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}