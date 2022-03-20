using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPoisonSting : MoveInstance
	{
		public IPoisonSting() : base( MovePoisonSting.Instance ) {}
	}
}