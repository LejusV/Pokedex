using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISweetScent : MoveInstance
	{
		public ISweetScent() : base( MoveSweetScent.Instance ) {}
	}
}