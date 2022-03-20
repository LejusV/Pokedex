using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPoisonFang : MoveInstance
	{
		public IPoisonFang() : base( MovePoisonFang.Instance ) {}
	}
}