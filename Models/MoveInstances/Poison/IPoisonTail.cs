using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPoisonTail : MoveInstance
	{
		public IPoisonTail() : base( MovePoisonTail.Instance ) {}
	}
}