using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRetaliate : MoveInstance
	{
		public IRetaliate() : base( MoveRetaliate.Instance ) {}
	}
}