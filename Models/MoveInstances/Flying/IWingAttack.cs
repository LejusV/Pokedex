using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IWingAttack : MoveInstance
	{
		public IWingAttack() : base( MoveWingAttack.Instance ) {}
	}
}