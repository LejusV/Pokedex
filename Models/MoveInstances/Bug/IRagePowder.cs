using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRagePowder : MoveInstance
	{
		public IRagePowder() : base( MoveRagePowder.Instance ) {}
	}
}