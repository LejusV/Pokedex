using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPainSplit : MoveInstance
	{
		public IPainSplit() : base( MovePainSplit.Instance ) {}
	}
}