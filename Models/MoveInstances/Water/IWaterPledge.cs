using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IWaterPledge : MoveInstance
	{
		public IWaterPledge() : base( MoveWaterPledge.Instance ) {}
	}
}