using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IVoltSwitch : MoveInstance
	{
		public IVoltSwitch() : base( MoveVoltSwitch.Instance ) {}
	}
}