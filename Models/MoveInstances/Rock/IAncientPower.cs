using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IAncientPower : MoveInstance
	{
		public IAncientPower() : base( MoveAncientPower.Instance ) {}
	}
}