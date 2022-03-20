using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Halves all Fire-type damage.
	public class MoveWaterSport : Move
	{
#nullable enable
		private static MoveWaterSport? _instance = null;
#nullable restore
        public static MoveWaterSport Instance => _instance ?? (_instance = new MoveWaterSport());

		public MoveWaterSport() : base(
			"Water-Sport",
			Water.Instance, // Move Type
			MoveCategory.Status, // Move Category
			15, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}