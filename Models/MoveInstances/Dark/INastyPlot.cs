using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class INastyPlot : MoveInstance
	{
		public INastyPlot() : base( MoveNastyPlot.Instance ) {}
	}
}