using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ILeafTornado : MoveInstance
	{
		public ILeafTornado() : base( MoveLeafTornado.Instance ) {}
	}
}