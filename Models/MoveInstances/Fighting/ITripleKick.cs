using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ITripleKick : MoveInstance
	{
		public ITripleKick() : base( MoveTripleKick.Instance ) {}
	}
}