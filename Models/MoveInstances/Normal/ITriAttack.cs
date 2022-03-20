using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITriAttack : MoveInstance
	{
		public ITriAttack() : base( MoveTriAttack.Instance ) {}
	}
}