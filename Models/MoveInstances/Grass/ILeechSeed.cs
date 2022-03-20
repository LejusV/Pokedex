using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ILeechSeed : MoveInstance
	{
		public ILeechSeed() : base( MoveLeechSeed.Instance ) {}
	}
}