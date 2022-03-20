using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IStormThrow : MoveInstance
	{
		public IStormThrow() : base( MoveStormThrow.Instance ) {}
	}
}