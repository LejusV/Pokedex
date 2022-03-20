using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPsywave : MoveInstance
	{
		public IPsywave() : base( MovePsywave.Instance ) {}
	}
}