using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBlock : MoveInstance
	{
		public IBlock() : base( MoveBlock.Instance ) {}
	}
}