using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ILeafStorm : MoveInstance
	{
		public ILeafStorm() : base( MoveLeafStorm.Instance ) {}
	}
}