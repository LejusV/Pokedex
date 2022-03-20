using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IWonderRoom : MoveInstance
	{
		public IWonderRoom() : base( MoveWonderRoom.Instance ) {}
	}
}