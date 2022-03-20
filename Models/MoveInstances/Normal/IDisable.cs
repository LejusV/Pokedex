using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IDisable : MoveInstance
	{
		public IDisable() : base( MoveDisable.Instance ) {}
	}
}