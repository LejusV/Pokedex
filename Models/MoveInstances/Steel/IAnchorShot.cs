using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IAnchorShot : MoveInstance
	{
		public IAnchorShot() : base( MoveAnchorShot.Instance ) {}
	}
}