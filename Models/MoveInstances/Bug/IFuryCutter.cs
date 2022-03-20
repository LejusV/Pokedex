using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFuryCutter : MoveInstance
	{
		public IFuryCutter() : base( MoveFuryCutter.Instance ) {}
	}
}