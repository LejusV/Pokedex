using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMaxGuard : MoveInstance
	{
		public IMaxGuard() : base( MoveMaxGuard.Instance ) {}
	}
}