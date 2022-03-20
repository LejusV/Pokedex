using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPluck : MoveInstance
	{
		public IPluck() : base( MovePluck.Instance ) {}
	}
}