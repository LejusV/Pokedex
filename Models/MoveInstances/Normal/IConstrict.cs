using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IConstrict : MoveInstance
	{
		public IConstrict() : base( MoveConstrict.Instance ) {}
	}
}