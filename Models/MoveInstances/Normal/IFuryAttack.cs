using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFuryAttack : MoveInstance
	{
		public IFuryAttack() : base( MoveFuryAttack.Instance ) {}
	}
}