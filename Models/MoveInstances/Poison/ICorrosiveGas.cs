using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ICorrosiveGas : MoveInstance
	{
		public ICorrosiveGas() : base( MoveCorrosiveGas.Instance ) {}
	}
}