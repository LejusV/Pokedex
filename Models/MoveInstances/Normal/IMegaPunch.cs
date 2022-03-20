using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMegaPunch : MoveInstance
	{
		public IMegaPunch() : base( MoveMegaPunch.Instance ) {}
	}
}