using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IBind : MoveInstance
	{
		public IBind() : base( MoveBind.Instance ) {}
	}
}