using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IJumpKick : MoveInstance
	{
		public IJumpKick() : base( MoveJumpKick.Instance ) {}
	}
}