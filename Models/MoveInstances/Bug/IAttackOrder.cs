using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IAttackOrder : MoveInstance
	{
		public IAttackOrder() : base( MoveAttackOrder.Instance ) {}
	}
}