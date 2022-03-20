using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IZapCannon : MoveInstance
	{
		public IZapCannon() : base( MoveZapCannon.Instance ) {}
	}
}