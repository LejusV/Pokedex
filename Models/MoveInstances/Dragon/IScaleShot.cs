using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IScaleShot : MoveInstance
	{
		public IScaleShot() : base( MoveScaleShot.Instance ) {}
	}
}