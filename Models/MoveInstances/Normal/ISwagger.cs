using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISwagger : MoveInstance
	{
		public ISwagger() : base( MoveSwagger.Instance ) {}
	}
}