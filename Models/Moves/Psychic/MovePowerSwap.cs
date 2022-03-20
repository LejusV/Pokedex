using Pokedex.Enums;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Moves
{
	//User swaps Attack and Special Attack changes with the target.
	public class MovePowerSwap : Move
	{
#nullable enable
		private static MovePowerSwap? _instance = null;
#nullable restore
        public static MovePowerSwap Instance => _instance ?? (_instance = new MovePowerSwap());

		public MovePowerSwap() : base(
			"Power-Swap",
			Psychic.Instance, // Move Type
			MoveCategory.Status, // Move Category
			10, null,// PP & Pow
			null, 0 // Acc & Priority
		) {}
	}
}