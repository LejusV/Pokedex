using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPsychicFangs : MoveInstance
	{
		public IPsychicFangs() : base( MovePsychicFangs.Instance ) {}
	}
}