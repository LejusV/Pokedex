using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IGuardSwap : MoveInstance
	{
		public IGuardSwap() : base( MoveGuardSwap.Instance ) {}
	}
}