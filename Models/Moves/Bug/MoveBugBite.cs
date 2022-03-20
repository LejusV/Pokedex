using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//If target has a berry, inflicts double damage and uses the berry.
	public class MoveBugBite : Move
	{
#nullable enable
		private static MoveBugBite? _instance = null;
#nullable restore
        public static MoveBugBite Instance => _instance ?? (_instance = new MoveBugBite());

		public MoveBugBite() : base(
			"Bug-Bite",
			Bug.Instance, // Move Type
			MoveCategory.Physical, // Move Category
			20, 60,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}