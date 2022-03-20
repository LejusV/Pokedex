using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRollout : MoveInstance
	{
		public IRollout() : base( MoveRollout.Instance ) {}
	}
}