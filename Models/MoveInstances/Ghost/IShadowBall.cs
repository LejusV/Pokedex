using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IShadowBall : MoveInstance
	{
		public IShadowBall() : base( MoveShadowBall.Instance ) {}
	}
}