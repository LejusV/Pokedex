using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHiddenPower : MoveInstance
	{
		public IHiddenPower() : base( MoveHiddenPower.Instance ) {}
	}
}