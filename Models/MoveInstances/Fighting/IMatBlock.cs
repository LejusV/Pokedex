using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMatBlock : MoveInstance
	{
		public IMatBlock() : base( MoveMatBlock.Instance ) {}
	}
}