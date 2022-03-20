using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISeedFlare : MoveInstance
	{
		public ISeedFlare() : base( MoveSeedFlare.Instance ) {}
	}
}