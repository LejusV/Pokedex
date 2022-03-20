using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IScratch : MoveInstance
	{
		public IScratch() : base( MoveScratch.Instance ) {}
	}
}