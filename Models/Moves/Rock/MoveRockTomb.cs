using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 100% chance to lower the target's Speed by one stage.
	public class MoveRockTomb : Move
	{
#nullable enable
		private static MoveRockTomb? _instance = null;
#nullable restore
        public static MoveRockTomb Instance => _instance ?? (_instance = new MoveRockTomb());

		public MoveRockTomb() : base(
			"Rock-Tomb",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			15, 60,// PP & Pow
			95, 0 // Acc & Priority
		) {}
	}
}