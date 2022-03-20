using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IEggBomb : MoveInstance
	{
		public IEggBomb() : base( MoveEggBomb.Instance ) {}
	}
}