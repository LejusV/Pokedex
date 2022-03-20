using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFeint : MoveInstance
	{
		public IFeint() : base( MoveFeint.Instance ) {}
	}
}