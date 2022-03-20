using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHealOrder : MoveInstance
	{
		public IHealOrder() : base( MoveHealOrder.Instance ) {}
	}
}