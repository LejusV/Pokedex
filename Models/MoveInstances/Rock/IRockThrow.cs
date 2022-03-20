using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRockThrow : MoveInstance
	{
		public IRockThrow() : base( MoveRockThrow.Instance ) {}
	}
}