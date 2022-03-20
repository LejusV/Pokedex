using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHoldHands : MoveInstance
	{
		public IHoldHands() : base( MoveHoldHands.Instance ) {}
	}
}