using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPsybeam : MoveInstance
	{
		public IPsybeam() : base( MovePsybeam.Instance ) {}
	}
}