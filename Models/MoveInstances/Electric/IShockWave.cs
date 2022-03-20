using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IShockWave : MoveInstance
	{
		public IShockWave() : base( MoveShockWave.Instance ) {}
	}
}