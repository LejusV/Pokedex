using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITakeDown : MoveInstance
	{
		public ITakeDown() : base( MoveTakeDown.Instance ) {}
	}
}