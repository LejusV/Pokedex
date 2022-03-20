using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHyperBeam : MoveInstance
	{
		public IHyperBeam() : base( MoveHyperBeam.Instance ) {}
	}
}