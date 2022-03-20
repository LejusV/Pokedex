using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 50% chance to raise the user's Special Attack by one stage.
	public class MoveFieryDance : Move
	{
#nullable enable
		private static MoveFieryDance? _instance = null;
#nullable restore
        public static MoveFieryDance Instance => _instance ?? (_instance = new MoveFieryDance());

		public MoveFieryDance() : base(
			"Fiery-Dance",
			Fire.Instance, // Move Type
			MoveCategory.Special, // Move Category
			10, 80,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}