using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITrickOrTreat : MoveInstance
	{
		public ITrickOrTreat() : base( MoveTrickOrTreat.Instance ) {}
	}
}