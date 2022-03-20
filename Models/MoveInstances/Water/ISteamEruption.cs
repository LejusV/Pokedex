using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISteamEruption : MoveInstance
	{
		public ISteamEruption() : base( MoveSteamEruption.Instance ) {}
	}
}