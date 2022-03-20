using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IHeatWave : MoveInstance
	{
		public IHeatWave() : base( MoveHeatWave.Instance ) {}
	}
}