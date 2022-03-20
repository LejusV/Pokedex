using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPsystrike : MoveInstance
	{
		public IPsystrike() : base( MovePsystrike.Instance ) {}
	}
}