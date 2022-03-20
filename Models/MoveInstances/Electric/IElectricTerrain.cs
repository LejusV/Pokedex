using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IElectricTerrain : MoveInstance
	{
		public IElectricTerrain() : base( MoveElectricTerrain.Instance ) {}
	}
}