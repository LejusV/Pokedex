using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IShiftGear : MoveInstance
	{
		public IShiftGear() : base( MoveShiftGear.Instance ) {}
	}
}