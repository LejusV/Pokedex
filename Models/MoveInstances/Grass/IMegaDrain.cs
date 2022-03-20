using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMegaDrain : MoveInstance
	{
		public IMegaDrain() : base( MoveMegaDrain.Instance ) {}
	}
}