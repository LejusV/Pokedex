using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPowder : MoveInstance
	{
		public IPowder() : base( MovePowder.Instance ) {}
	}
}