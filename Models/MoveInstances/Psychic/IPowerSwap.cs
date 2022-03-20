using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPowerSwap : MoveInstance
	{
		public IPowerSwap() : base( MovePowerSwap.Instance ) {}
	}
}