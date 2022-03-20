using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISteelRoller : MoveInstance
	{
		public ISteelRoller() : base( MoveSteelRoller.Instance ) {}
	}
}