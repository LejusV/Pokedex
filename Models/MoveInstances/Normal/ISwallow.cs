using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISwallow : MoveInstance
	{
		public ISwallow() : base( MoveSwallow.Instance ) {}
	}
}