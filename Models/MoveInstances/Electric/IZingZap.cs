using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IZingZap : MoveInstance
	{
		public IZingZap() : base( MoveZingZap.Instance ) {}
	}
}