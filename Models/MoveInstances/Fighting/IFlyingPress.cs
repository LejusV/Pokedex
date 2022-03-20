using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFlyingPress : MoveInstance
	{
		public IFlyingPress() : base( MoveFlyingPress.Instance ) {}
	}
}