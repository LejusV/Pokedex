using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRainDance : MoveInstance
	{
		public IRainDance() : base( MoveRainDance.Instance ) {}
	}
}