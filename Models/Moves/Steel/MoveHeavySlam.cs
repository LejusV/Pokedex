using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Power is higher when the user weighs more than the target, up to a maximum of 120.
	public class MoveHeavySlam : Move
	{
#nullable enable
		private static MoveHeavySlam? _instance = null;
#nullable restore
        public static MoveHeavySlam Instance => _instance ?? (_instance = new MoveHeavySlam());

		public MoveHeavySlam() : base(
			"Heavy-Slam",
			Steel.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			10, null,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}