using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to raise all of the user's stats by one stage.
	public class MoveSilverWind : Move
	{
#nullable enable
		private static MoveSilverWind? _instance = null;
#nullable restore
        public static MoveSilverWind Instance => _instance ?? (_instance = new MoveSilverWind());

		public MoveSilverWind() : base(
			"Silver-Wind",
			Bug.Instance, // Move Type
			MoveCategory.Special, // Move Category
			5, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}