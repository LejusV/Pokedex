using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IGrassyTerrain : MoveInstance
	{
		public IGrassyTerrain() : base( MoveGrassyTerrain.Instance ) {}
	}
}