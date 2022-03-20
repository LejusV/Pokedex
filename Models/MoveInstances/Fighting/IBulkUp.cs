using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBulkUp : MoveInstance
	{
		public IBulkUp() : base( MoveBulkUp.Instance ) {}
	}
}