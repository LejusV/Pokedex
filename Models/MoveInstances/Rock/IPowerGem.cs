using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPowerGem : MoveInstance
	{
		public IPowerGem() : base( MovePowerGem.Instance ) {}
	}
}