using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPsyshock : MoveInstance
	{
		public IPsyshock() : base( MovePsyshock.Instance ) {}
	}
}