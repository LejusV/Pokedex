using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMaxStarfall : MoveInstance
	{
		public IMaxStarfall() : base( MoveMaxStarfall.Instance ) {}
	}
}