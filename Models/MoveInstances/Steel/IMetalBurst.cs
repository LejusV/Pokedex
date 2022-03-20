using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMetalBurst : MoveInstance
	{
		public IMetalBurst() : base( MoveMetalBurst.Instance ) {}
	}
}