using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IVacuumWave : MoveInstance
	{
		public IVacuumWave() : base( MoveVacuumWave.Instance ) {}
	}
}