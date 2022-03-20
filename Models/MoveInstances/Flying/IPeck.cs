using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPeck : MoveInstance
	{
		public IPeck() : base( MovePeck.Instance ) {}
	}
}