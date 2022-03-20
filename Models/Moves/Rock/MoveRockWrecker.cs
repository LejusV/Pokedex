using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User foregoes its next turn to recharge.
	public class MoveRockWrecker : Move
	{
#nullable enable
		private static MoveRockWrecker? _instance = null;
#nullable restore
        public static MoveRockWrecker Instance => _instance ?? (_instance = new MoveRockWrecker());

		public MoveRockWrecker() : base(
			"Rock-Wrecker",
			Rock.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			5, 150,// PP & Pow
			90, 0 // Acc & Priority
		) {}
	}
}