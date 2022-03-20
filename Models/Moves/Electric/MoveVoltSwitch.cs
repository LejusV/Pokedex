using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User must switch out after attacking.
	public class MoveVoltSwitch : Move
	{
#nullable enable
		private static MoveVoltSwitch? _instance = null;
#nullable restore
        public static MoveVoltSwitch Instance => _instance ?? (_instance = new MoveVoltSwitch());

		public MoveVoltSwitch() : base(
			"Volt-Switch",
			Electric.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 70,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}