using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHeadCharge : MoveInstance
	{
		public IHeadCharge() : base( MoveHeadCharge.Instance ) {}
	}
}