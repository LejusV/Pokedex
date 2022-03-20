using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISteamroller : MoveInstance
	{
		public ISteamroller() : base( MoveSteamroller.Instance ) {}
	}
}