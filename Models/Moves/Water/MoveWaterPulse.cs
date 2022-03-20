using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to confuse the target.
	public class MoveWaterPulse : Move
	{
#nullable enable
		private static MoveWaterPulse? _instance = null;
#nullable restore
        public static MoveWaterPulse Instance => _instance ?? (_instance = new MoveWaterPulse());

		public MoveWaterPulse() : base(
			"Water-Pulse",
			Water.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}