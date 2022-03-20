using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISpeedSwap : MoveInstance
	{
		public ISpeedSwap() : base( MoveSpeedSwap.Instance ) {}
	}
}