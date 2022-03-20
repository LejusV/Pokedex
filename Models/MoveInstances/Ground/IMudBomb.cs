using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMudBomb : MoveInstance
	{
		public IMudBomb() : base( MoveMudBomb.Instance ) {}
	}
}