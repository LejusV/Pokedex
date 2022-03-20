using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power is higher when the user weighs more than the target, up to a maximum of 120.
	public class MoveHeatCrash : Move
	{
#nullable enable
		private static MoveHeatCrash? _instance = null;
#nullable restore
        public static MoveHeatCrash Instance => _instance ?? (_instance = new MoveHeatCrash());

		public MoveHeatCrash() : base(
			"Heat-Crash",
			Fire.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}