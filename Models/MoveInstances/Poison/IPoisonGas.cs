using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPoisonGas : MoveInstance
	{
		public IPoisonGas() : base( MovePoisonGas.Instance ) {}
	}
}