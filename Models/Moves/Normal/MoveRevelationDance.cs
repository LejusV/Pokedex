using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has the same type as the user.
	public class MoveRevelationDance : Move
	{
#nullable enable
		private static MoveRevelationDance? _instance = null;
#nullable restore
        public static MoveRevelationDance Instance => _instance ?? (_instance = new MoveRevelationDance());

		public MoveRevelationDance() : base(
			"Revelation-Dance",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			15, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}