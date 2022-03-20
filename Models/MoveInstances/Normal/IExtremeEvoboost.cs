using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IExtremeEvoboost : MoveInstance
	{
		public IExtremeEvoboost() : base( MoveExtremeEvoboost.Instance ) {}
	}
}