using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRockBlast : MoveInstance
	{
		public IRockBlast() : base( MoveRockBlast.Instance ) {}
	}
}