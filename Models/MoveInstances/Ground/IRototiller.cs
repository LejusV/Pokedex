using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRototiller : MoveInstance
	{
		public IRototiller() : base( MoveRototiller.Instance ) {}
	}
}