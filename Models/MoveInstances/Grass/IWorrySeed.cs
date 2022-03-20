using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IWorrySeed : MoveInstance
	{
		public IWorrySeed() : base( MoveWorrySeed.Instance ) {}
	}
}