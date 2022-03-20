using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//Has a 20% chance to make the target flinch.
	public class MoveTwister : Move
	{
#nullable enable
		private static MoveTwister? _instance = null;
#nullable restore
        public static MoveTwister Instance => _instance ?? (_instance = new MoveTwister());

		public MoveTwister() : base(
			"Twister",
			Dragon.Instance, // Move Type
			MoveCategory.Special, // Move Category
			20, 40,// PP & Pow
			100, 0 // Acc & Priority
		) {}
	}
}