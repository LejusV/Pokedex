using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Doubles prize money.
	public class MoveHappyHour : Move
	{
#nullable enable
		private static MoveHappyHour? _instance = null;
#nullable restore
        public static MoveHappyHour Instance => _instance ?? (_instance = new MoveHappyHour());

		public MoveHappyHour() : base(
			"Happy-Hour",
			Normal.Instance, // Move Type
			MoveCategory.Status, // Move Category
			30, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}