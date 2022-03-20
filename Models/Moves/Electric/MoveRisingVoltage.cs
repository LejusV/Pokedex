using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Inflicts regular damage with no additional effect.
	public class MoveRisingVoltage : Move
	{
#nullable enable
		private static MoveRisingVoltage? _instance = null;
#nullable restore
        public static MoveRisingVoltage Instance => _instance ?? (_instance = new MoveRisingVoltage());

		public MoveRisingVoltage() : base(
			"Rising-Voltage",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}