using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IEarthquake : MoveInstance
	{
		public IEarthquake() : base( MoveEarthquake.Instance ) {}
	}
}