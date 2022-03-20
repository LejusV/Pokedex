using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class ISignalBeam : MoveInstance
	{
		public ISignalBeam() : base( MoveSignalBeam.Instance ) {}
	}
}