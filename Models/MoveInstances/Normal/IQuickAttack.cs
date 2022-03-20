using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IQuickAttack : MoveInstance
	{
		public IQuickAttack() : base( MoveQuickAttack.Instance ) {}
	}
}