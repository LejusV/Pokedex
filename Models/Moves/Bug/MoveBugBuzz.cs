using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 10% chance to lower the target's Special Defense by one stage.
	public class MoveBugBuzz : Move
	{
#nullable enable
		private static MoveBugBuzz? _instance = null;
#nullable restore
        public static MoveBugBuzz Instance => _instance ?? (_instance = new MoveBugBuzz());

		public MoveBugBuzz() : base(
			"Bug-Buzz",
			Bug.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 90,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}