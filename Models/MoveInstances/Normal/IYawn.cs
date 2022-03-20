using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IYawn : MoveInstance
	{
		public IYawn() : base( MoveYawn.Instance ) {}
	}
}