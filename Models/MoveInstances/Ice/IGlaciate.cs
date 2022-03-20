using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IGlaciate : MoveInstance
	{
		public IGlaciate() : base( MoveGlaciate.Instance ) {}
	}
}