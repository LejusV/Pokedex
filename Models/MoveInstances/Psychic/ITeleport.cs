using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITeleport : MoveInstance
	{
		public ITeleport() : base( MoveTeleport.Instance ) {}
	}
}