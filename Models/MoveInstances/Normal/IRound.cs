using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRound : MoveInstance
	{
		public IRound() : base( MoveRound.Instance ) {}
	}
}