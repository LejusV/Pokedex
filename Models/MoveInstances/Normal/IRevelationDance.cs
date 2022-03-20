using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRevelationDance : MoveInstance
	{
		public IRevelationDance() : base( MoveRevelationDance.Instance ) {}
	}
}