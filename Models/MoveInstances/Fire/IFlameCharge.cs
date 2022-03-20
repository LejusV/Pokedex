using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFlameCharge : MoveInstance
	{
		public IFlameCharge() : base( MoveFlameCharge.Instance ) {}
	}
}