using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to raise all of the user's stats by one stage.
	public class MoveOminousWind : Move
	{
#nullable enable
		private static MoveOminousWind? _instance = null;
#nullable restore
        public static MoveOminousWind Instance => _instance ?? (_instance = new MoveOminousWind());

		public MoveOminousWind() : base(
			"Ominous-Wind",
			Ghost.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}