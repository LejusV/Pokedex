using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHornAttack : MoveInstance
	{
		public IHornAttack() : base( MoveHornAttack.Instance ) {}
	}
}