using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISimpleBeam : MoveInstance
	{
		public ISimpleBeam() : base( MoveSimpleBeam.Instance ) {}
	}
}