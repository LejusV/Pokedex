using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IDischarge : MoveInstance
	{
		public IDischarge() : base( MoveDischarge.Instance ) {}
	}
}