using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IWaterPulse : MoveInstance
	{
		public IWaterPulse() : base( MoveWaterPulse.Instance ) {}
	}
}