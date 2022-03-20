using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRockSmash : MoveInstance
	{
		public IRockSmash() : base( MoveRockSmash.Instance ) {}
	}
}