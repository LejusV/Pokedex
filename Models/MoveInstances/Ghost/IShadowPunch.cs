using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IShadowPunch : MoveInstance
	{
		public IShadowPunch() : base( MoveShadowPunch.Instance ) {}
	}
}