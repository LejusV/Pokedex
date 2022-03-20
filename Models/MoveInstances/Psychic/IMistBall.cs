using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IMistBall : MoveInstance
	{
		public IMistBall() : base( MoveMistBall.Instance ) {}
	}
}