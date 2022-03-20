using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IQuickGuard : MoveInstance
	{
		public IQuickGuard() : base( MoveQuickGuard.Instance ) {}
	}
}