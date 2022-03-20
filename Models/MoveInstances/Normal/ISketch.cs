using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISketch : MoveInstance
	{
		public ISketch() : base( MoveSketch.Instance ) {}
	}
}