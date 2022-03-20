using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISafeguard : MoveInstance
	{
		public ISafeguard() : base( MoveSafeguard.Instance ) {}
	}
}