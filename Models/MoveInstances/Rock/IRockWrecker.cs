using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRockWrecker : MoveInstance
	{
		public IRockWrecker() : base( MoveRockWrecker.Instance ) {}
	}
}