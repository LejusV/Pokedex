using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IDefendOrder : MoveInstance
	{
		public IDefendOrder() : base( MoveDefendOrder.Instance ) {}
	}
}