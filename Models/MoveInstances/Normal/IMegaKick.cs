using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMegaKick : MoveInstance
	{
		public IMegaKick() : base( MoveMegaKick.Instance ) {}
	}
}