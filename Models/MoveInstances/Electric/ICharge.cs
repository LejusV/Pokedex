using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ICharge : MoveInstance
	{
		public ICharge() : base( MoveCharge.Instance ) {}
	}
}