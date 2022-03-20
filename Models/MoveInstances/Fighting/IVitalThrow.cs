using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IVitalThrow : MoveInstance
	{
		public IVitalThrow() : base( MoveVitalThrow.Instance ) {}
	}
}