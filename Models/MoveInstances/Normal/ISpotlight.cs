using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISpotlight : MoveInstance
	{
		public ISpotlight() : base( MoveSpotlight.Instance ) {}
	}
}