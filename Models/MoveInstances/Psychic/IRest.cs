using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRest : MoveInstance
	{
		public IRest() : base( MoveRest.Instance ) {}
	}
}