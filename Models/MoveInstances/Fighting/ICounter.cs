using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ICounter : MoveInstance
	{
		public ICounter() : base( MoveCounter.Instance ) {}
	}
}