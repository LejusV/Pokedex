using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPursuit : MoveInstance
	{
		public IPursuit() : base( MovePursuit.Instance ) {}
	}
}