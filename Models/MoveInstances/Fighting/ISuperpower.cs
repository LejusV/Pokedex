using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISuperpower : MoveInstance
	{
		public ISuperpower() : base( MoveSuperpower.Instance ) {}
	}
}