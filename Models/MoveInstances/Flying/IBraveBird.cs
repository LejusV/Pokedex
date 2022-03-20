using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBraveBird : MoveInstance
	{
		public IBraveBird() : base( MoveBraveBird.Instance ) {}
	}
}