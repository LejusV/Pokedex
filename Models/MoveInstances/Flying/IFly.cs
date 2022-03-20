using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFly : MoveInstance
	{
		public IFly() : base( MoveFly.Instance ) {}
	}
}