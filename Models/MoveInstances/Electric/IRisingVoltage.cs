using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	// The specific Move Instance Class
	public class IRisingVoltage : MoveInstance
	{
		public IRisingVoltage() : base( MoveRisingVoltage.Instance ) {}
	}
}