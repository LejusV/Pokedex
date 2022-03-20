using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IWaterfall : MoveInstance
	{
		public IWaterfall() : base( MoveWaterfall.Instance ) {}
	}
}