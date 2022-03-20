using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISwitcheroo : MoveInstance
	{
		public ISwitcheroo() : base( MoveSwitcheroo.Instance ) {}
	}
}