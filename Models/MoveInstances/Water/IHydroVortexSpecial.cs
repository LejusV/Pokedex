using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHydroVortexSpecial : MoveInstance
	{
		public IHydroVortexSpecial() : base( MoveHydroVortexSpecial.Instance ) {}
	}
}