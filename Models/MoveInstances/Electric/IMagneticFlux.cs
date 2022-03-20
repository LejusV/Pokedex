using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMagneticFlux : MoveInstance
	{
		public IMagneticFlux() : base( MoveMagneticFlux.Instance ) {}
	}
}