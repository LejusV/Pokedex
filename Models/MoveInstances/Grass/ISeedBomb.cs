using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISeedBomb : MoveInstance
	{
		public ISeedBomb() : base( MoveSeedBomb.Instance ) {}
	}
}