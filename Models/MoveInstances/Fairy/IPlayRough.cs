using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPlayRough : MoveInstance
	{
		public IPlayRough() : base( MovePlayRough.Instance ) {}
	}
}