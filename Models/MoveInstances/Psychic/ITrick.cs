using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITrick : MoveInstance
	{
		public ITrick() : base( MoveTrick.Instance ) {}
	}
}