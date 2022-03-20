using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISludge : MoveInstance
	{
		public ISludge() : base( MoveSludge.Instance ) {}
	}
}