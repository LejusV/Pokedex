using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMaxPhantasm : MoveInstance
	{
		public IMaxPhantasm() : base( MoveMaxPhantasm.Instance ) {}
	}
}