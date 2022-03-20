using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMudSlap : MoveInstance
	{
		public IMudSlap() : base( MoveMudSlap.Instance ) {}
	}
}