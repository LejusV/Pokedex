using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IGuardianOfAlola : MoveInstance
	{
		public IGuardianOfAlola() : base( MoveGuardianOfAlola.Instance ) {}
	}
}