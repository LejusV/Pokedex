using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IFocusEnergy : MoveInstance
	{
		public IFocusEnergy() : base( MoveFocusEnergy.Instance ) {}
	}
}