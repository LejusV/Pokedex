using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPetalBlizzard : MoveInstance
	{
		public IPetalBlizzard() : base( MovePetalBlizzard.Instance ) {}
	}
}