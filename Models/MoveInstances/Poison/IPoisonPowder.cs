using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPoisonPowder : MoveInstance
	{
		public IPoisonPowder() : base( MovePoisonPowder.Instance ) {}
	}
}