using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IAgility : MoveInstance
	{
		public IAgility() : base( MoveAgility.Instance ) {}
	}
}