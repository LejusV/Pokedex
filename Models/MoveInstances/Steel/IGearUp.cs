using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IGearUp : MoveInstance
	{
		public IGearUp() : base( MoveGearUp.Instance ) {}
	}
}