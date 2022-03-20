using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISelfDestruct : MoveInstance
	{
		public ISelfDestruct() : base( MoveSelfDestruct.Instance ) {}
	}
}