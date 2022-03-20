using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHealingWish : MoveInstance
	{
		public IHealingWish() : base( MoveHealingWish.Instance ) {}
	}
}