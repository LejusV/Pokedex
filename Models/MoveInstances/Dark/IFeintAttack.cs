using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFeintAttack : MoveInstance
	{
		public IFeintAttack() : base( MoveFeintAttack.Instance ) {}
	}
}