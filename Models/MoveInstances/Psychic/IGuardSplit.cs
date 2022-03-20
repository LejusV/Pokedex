using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IGuardSplit : MoveInstance
	{
		public IGuardSplit() : base( MoveGuardSplit.Instance ) {}
	}
}