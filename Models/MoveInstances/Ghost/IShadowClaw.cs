using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IShadowClaw : MoveInstance
	{
		public IShadowClaw() : base( MoveShadowClaw.Instance ) {}
	}
}