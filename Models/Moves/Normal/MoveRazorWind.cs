using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Requires a turn to charge before attacking.
	public class MoveRazorWind : Move
	{
#nullable enable
		private static MoveRazorWind? _instance = null;
#nullable restore
        public static MoveRazorWind Instance => _instance ?? (_instance = new MoveRazorWind());

		public MoveRazorWind() : base(
			"Razor-Wind",
			Normal.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}