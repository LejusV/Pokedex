using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHeartSwap : MoveInstance
	{
		public IHeartSwap() : base( MoveHeartSwap.Instance ) {}
	}
}