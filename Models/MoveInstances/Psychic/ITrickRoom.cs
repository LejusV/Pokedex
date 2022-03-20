using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITrickRoom : MoveInstance
	{
		public ITrickRoom() : base( MoveTrickRoom.Instance ) {}
	}
}