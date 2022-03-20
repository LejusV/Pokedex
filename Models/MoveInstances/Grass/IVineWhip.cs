using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IVineWhip : MoveInstance
	{
		public IVineWhip() : base( MoveVineWhip.Instance ) {}
	}
}