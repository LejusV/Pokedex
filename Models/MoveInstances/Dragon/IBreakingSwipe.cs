using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBreakingSwipe : MoveInstance
	{
		public IBreakingSwipe() : base( MoveBreakingSwipe.Instance ) {}
	}
}