using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IReversal : MoveInstance
	{
		public IReversal() : base( MoveReversal.Instance ) {}
	}
}