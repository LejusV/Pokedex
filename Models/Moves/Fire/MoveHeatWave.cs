using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to burn the target.
	public class MoveHeatWave : Move
	{
#nullable enable
		private static MoveHeatWave? _instance = null;
#nullable restore
        public static MoveHeatWave Instance => _instance ?? (_instance = new MoveHeatWave());

		public MoveHeatWave() : base(
			"Heat-Wave",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 95,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}