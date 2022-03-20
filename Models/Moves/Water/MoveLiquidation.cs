using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to lower the target's Defense by one stage.
	public class MoveLiquidation : Move
	{
#nullable enable
		private static MoveLiquidation? _instance = null;
#nullable restore
        public static MoveLiquidation Instance => _instance ?? (_instance = new MoveLiquidation());

		public MoveLiquidation() : base(
			"Liquidation",
			Water.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, 85,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}