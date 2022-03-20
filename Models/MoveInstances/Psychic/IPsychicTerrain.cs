using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IPsychicTerrain : MoveInstance
	{
		public IPsychicTerrain() : base( MovePsychicTerrain.Instance ) {}
	}
}